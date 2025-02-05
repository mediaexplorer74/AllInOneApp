﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// Copied from https://raw.githubusercontent.com/dotnet/corefx/master/src/System.Net.Http/src/System/Net/Http/SocketsHttpHandler/HttpEnvironmentProxy.cs

#nullable disable

using System;
using System.Net;
using System.Collections.Generic;

namespace Azure.Core.Pipeline
{
    internal sealed partial class HttpEnvironmentProxy : IWebProxy
    {
        private const string EnvAllProxyUC = "ALL_PROXY";
        private const string EnvAllProxyLC = "all_proxy";
        private const string EnvHttpProxyLC = "http_proxy";
        private const string EnvHttpProxyUC = "HTTP_PROXY";
        private const string EnvHttpsProxyLC = "https_proxy";
        private const string EnvHttpsProxyUC = "HTTPS_PROXY";
        private const string EnvNoProxyLC = "no_proxy";
        private const string EnvNoProxyUC = "NO_PROXY";
        private const string EnvCGI = "GATEWAY_INTERFACE"; // Running in a CGI environment.

        private readonly Uri _httpProxyUri;      // String URI for HTTP requests
        private readonly Uri _httpsProxyUri;     // String URI for HTTPS requests
        private readonly string[] _bypass;// list of domains not to proxy
        private readonly ICredentials _credentials;

        public static bool TryCreate(out IWebProxy proxy)
        {
            // Get environment variables. Protocol specific take precedence over
            // general all_*, lower case variable has precedence over upper case.
            // Note that curl uses HTTPS_PROXY but not HTTP_PROXY.

            Uri httpProxy = GetUriFromString(Environment.GetEnvironmentVariable(EnvHttpProxyLC));
            if (httpProxy == null && Environment.GetEnvironmentVariable(EnvCGI) == null)
            {
                httpProxy = GetUriFromString(Environment.GetEnvironmentVariable(EnvHttpProxyUC));
            }

            Uri httpsProxy = GetUriFromString(Environment.GetEnvironmentVariable(EnvHttpsProxyLC)) ??
                             GetUriFromString(Environment.GetEnvironmentVariable(EnvHttpsProxyUC));

            if (httpProxy == null || httpsProxy == null)
            {
                Uri allProxy = GetUriFromString(Environment.GetEnvironmentVariable(EnvAllProxyLC)) ??
                               GetUriFromString(Environment.GetEnvironmentVariable(EnvAllProxyUC));

                if (httpProxy == null)
                {
                    httpProxy = allProxy;
                }

                if (httpsProxy == null)
                {
                    httpsProxy = allProxy;
                }
            }

            // Do not instantiate if nothing is set.
            // Caller may pick some other proxy type.
            if (httpProxy == null && httpsProxy == null)
            {
                proxy = null;
                return false;
            }

            string noProxy = Environment.GetEnvironmentVariable(EnvNoProxyLC) ??
                             Environment.GetEnvironmentVariable(EnvNoProxyUC);
            proxy = new HttpEnvironmentProxy(httpProxy, httpsProxy, noProxy);

            return true;
        }

        private HttpEnvironmentProxy(Uri httpProxy, Uri httpsProxy, string bypassList)
        {
            _httpProxyUri = httpProxy;
            _httpsProxyUri = httpsProxy;

            _credentials = HttpEnvironmentProxyCredentials.TryCreate(httpProxy, httpsProxy);

            if (!string.IsNullOrWhiteSpace(bypassList))
            {
                string[] list = bypassList.Split(',');
                List<string> tmpList = new List<string>(list.Length);

                foreach (string value in list)
                {
                    string tmp = value.Trim();
                    if (tmp.Length > 0)
                    {
                        tmpList.Add(tmp);
                    }
                }
                if (tmpList.Count > 0)
                {
                    _bypass = tmpList.ToArray();
                }
            }
        }

        /// <summary>
        /// This function will evaluate given string and it will try to convert
        /// it to Uri object. The string could contain URI fragment, IP address and  port
        /// tuple or just IP address or name. It will return null if parsing fails.
        /// </summary>
        private static Uri GetUriFromString(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return null;
            }
            if (value.StartsWith("http://", StringComparison.OrdinalIgnoreCase))
            {
                value = value.Substring(7);
            }

            string user = null;
            string password = null;
            ushort port = 80;

            // Check if there is authentication part with user and possibly password.
            // Curl accepts raw text and that may break URI parser.
            int separatorIndex = value.LastIndexOf('@');
            if (separatorIndex != -1)
            {
                string auth = value.Substring(0, separatorIndex);

                // The User and password may or may not be URL encoded.
                // Curl seems to accept both. To match that,
                // we do opportunistic decode and we use original string if it fails.
                try
                {
                    auth = Uri.UnescapeDataString(auth);
                }
                catch { };

                value = value.Substring(separatorIndex + 1);
                separatorIndex = auth.IndexOfOrdinal(':');
                if (separatorIndex == -1)
                {
                    user = auth;
                }
                else
                {
                    user = auth.Substring(0, separatorIndex);
                    password = auth.Substring(separatorIndex + 1);
                }
            }

            int ipV6AddressEnd = value.IndexOfOrdinal(']');
            separatorIndex = value.LastIndexOf(':');
            string host;
            // No ':' or it is part of IPv6 address.
            if (separatorIndex == -1 || (ipV6AddressEnd != -1 && separatorIndex < ipV6AddressEnd))
            {
                host = value;
            }
            else
            {
                host = value.Substring(0, separatorIndex);
                int endIndex = separatorIndex + 1;
                // Strip any trailing characters after port number.
                while (endIndex < value.Length)
                {
                    if (!char.IsDigit(value[endIndex]))
                    {
                        break;
                    }
                    endIndex += 1;
                }

                if (!ushort.TryParse(value.Substring(separatorIndex + 1, endIndex - separatorIndex - 1), out port))
                {
                    return null;
                }
            }

            try
            {
                UriBuilder ub = new UriBuilder("http", host, port);
                if (user != null)
                {
                    ub.UserName = Uri.EscapeDataString(user);
                }

                if (password != null)
                {
                    ub.Password = Uri.EscapeDataString(password);
                }

                return ub.Uri;
            }
            catch { };
            return null;
        }

        /// <summary>
        /// This function returns true if given Host match bypass list.
        /// Note, that the list is common for http and https.
        /// </summary>
        private bool IsMatchInBypassList(Uri input)
        {
            if (_bypass != null)
            {
                foreach (string s in _bypass)
                {
                    if (s[0] == '.')
                    {
                        // This should match either domain it self or any subdomain or host
                        // .foo.com will match foo.com it self or *.foo.com
                        if ((s.Length - 1) == input.Host.Length &&
                            string.Compare(s, 1, input.Host, 0, input.Host.Length, StringComparison.OrdinalIgnoreCase) == 0)
                        {
                            return true;
                        }
                        else if (input.Host.EndsWith(s, StringComparison.OrdinalIgnoreCase))
                        {
                            return true;
                        }
                    }
                    else
                    {
                        if (string.Equals(s, input.Host, StringComparison.OrdinalIgnoreCase))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Gets the proxy URI. (iWebProxy interface).
        /// </summary>
        public Uri GetProxy(Uri uri)
        {
            return uri.Scheme == /*Uri.UriSchemeHttp*/ "http" ? _httpProxyUri : _httpsProxyUri;
        }

        /// <summary>
        /// Checks if URI is subject to proxy or not.
        /// </summary>
        public bool IsBypassed(Uri uri)
        {
            return GetProxy(uri) == null ? true : IsMatchInBypassList(uri);
        }

        public ICredentials Credentials
        {
            get
            {
                return _credentials;
            }
            set { throw new NotSupportedException(); }
        }
    }
}
