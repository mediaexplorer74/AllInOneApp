// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph
{
    using System;
    using System.Net.Http;

    /// <summary>
    /// Extension methods for <see cref="BaseRequest"/>
    /// </summary>
    public static class BaseRequestExtensions
    {

        /// <summary>
        /// Sets the default authentication provider to the default Authentication Middleware Handler for this request.
        /// This only works with the default authentication handler.
        /// If you use a custom authentication handler, you have to handle it's retrieval in your implementation.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="baseRequest">The <see cref="BaseRequest"/> for the request.</param>
        /// <returns></returns>
        internal static T WithDefaultAuthProvider<T>(this T baseRequest) where T : IBaseRequest
        {
            string authOptionKey = nameof(AuthenticationHandlerOption);
            if (baseRequest.MiddlewareOptions.ContainsKey(authOptionKey))
            {
                (baseRequest.MiddlewareOptions[authOptionKey] as AuthenticationHandlerOption).AuthenticationProvider = baseRequest.Client.AuthenticationProvider;
            }
            else
            {
                baseRequest.MiddlewareOptions.Add(authOptionKey, new AuthenticationHandlerOption { AuthenticationProvider = baseRequest.Client.AuthenticationProvider });
            }
            return baseRequest;
        }

        /// <summary>
        /// Sets the PerRequestAuthProvider delegate handler to the default Authentication Middleware Handler to authenticate a single request.
        /// The PerRequestAuthProvider delegate handler must be set to the GraphServiceClient instance before using this extension method otherwise, it defaults to the default authentication provider.
        /// This only works with the default authentication handler.
        /// If you use a custom authentication handler, you have to handle it's retrieval in your implementation.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="baseRequest">The <see cref="BaseRequest"/> for the request.</param>
        /// <returns></returns>
        public static T WithPerRequestAuthProvider<T>(this T baseRequest) where T : IBaseRequest
        {
            if (baseRequest.Client.PerRequestAuthProvider != null)
            {
                string authOptionKey = nameof(AuthenticationHandlerOption);
                if (baseRequest.MiddlewareOptions.ContainsKey(authOptionKey))
                {
                    (baseRequest.MiddlewareOptions[authOptionKey] as AuthenticationHandlerOption).AuthenticationProvider = baseRequest.Client.PerRequestAuthProvider();
                }
                else
                {
                    baseRequest.MiddlewareOptions.Add(authOptionKey, new AuthenticationHandlerOption { AuthenticationProvider = baseRequest.Client.PerRequestAuthProvider() });
                }
            }
            return baseRequest;
        }

        /// <summary>
        /// Sets a ShouldRetry delegate to the default Retry Middleware Handler for this request.
        /// This only works with the default Retry Middleware Handler.
        /// If you use a custom Retry Middleware Handler, you have to handle it's retrieval in your implementation.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="baseRequest">The <see cref="BaseRequest"/> for the request.</param>
        /// <param name="shouldRetry">A <see cref="Func{Int32, Int32, HttpResponseMessage, Boolean}"/> for the request.</param>
        /// <returns></returns>
        public static T WithShouldRetry<T>(this T baseRequest, Func<int, int, HttpResponseMessage, bool> shouldRetry) where T : IBaseRequest
        {
            string retryOptionKey = nameof(RetryHandlerOption);
            if (baseRequest.MiddlewareOptions.ContainsKey(retryOptionKey))
            {
                (baseRequest.MiddlewareOptions[retryOptionKey] as RetryHandlerOption).ShouldRetry = shouldRetry;
            }
            else
            {
                baseRequest.MiddlewareOptions.Add(retryOptionKey, new RetryHandlerOption { ShouldRetry = shouldRetry });
            }
            return baseRequest;
        }

        /// <summary>
        /// Sets the maximum number of retries to the default Retry Middleware Handler for this request.
        /// This only works with the default Retry Middleware Handler.
        /// If you use a custom Retry Middleware Handler, you have to handle it's retrieval in your implementation.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="baseRequest">The <see cref="BaseRequest"/> for the request.</param>
        /// <param name="maxRetry">The maxRetry for the request.</param>
        /// <returns></returns>
        public static T WithMaxRetry<T>(this T baseRequest, int maxRetry) where T : IBaseRequest
        {
            string retryOptionKey = nameof(RetryHandlerOption);
            if (baseRequest.MiddlewareOptions.ContainsKey(retryOptionKey))
            {
                (baseRequest.MiddlewareOptions[retryOptionKey] as RetryHandlerOption).MaxRetry = maxRetry;
            }
            else
            {
                baseRequest.MiddlewareOptions.Add(retryOptionKey, new RetryHandlerOption { MaxRetry = maxRetry });
            }
            return baseRequest;
        }

        /// <summary>
        /// Sets the maximum time for request retries to the default Retry Middleware Handler for this request.
        /// This only works with the default Retry Middleware Handler.
        /// If you use a custom Retry Middleware Handler, you have to handle it's retrieval in your implementation.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="baseRequest">The <see cref="BaseRequest"/> for the request.</param>
        /// <param name="retriesTimeLimit">The retriestimelimit for the request in seconds.</param>
        /// <returns></returns>
        public static T WithMaxRetry<T>(this T baseRequest, TimeSpan retriesTimeLimit) where T : IBaseRequest
        {
            string retryOptionKey = nameof(RetryHandlerOption);
            if (baseRequest.MiddlewareOptions.ContainsKey(retryOptionKey))
            {
                (baseRequest.MiddlewareOptions[retryOptionKey] as RetryHandlerOption).RetriesTimeLimit = retriesTimeLimit;
            }
            else
            {
                baseRequest.MiddlewareOptions.Add(retryOptionKey, new RetryHandlerOption { RetriesTimeLimit = retriesTimeLimit });
            }
            return baseRequest;
        }

        /// <summary>
        /// Sets the maximum number of redirects to the default Redirect Middleware Handler for this request.
        /// This only works with the default Redirect Middleware Handler.
        /// If you use a custom Redirect Middleware Handler, you have to handle it's retrieval in your implementation.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="baseRequest">The <see cref="BaseRequest"/> for the request.</param>
        /// <param name="maxRedirects">Maximum number of redirects allowed for the request</param>
        /// <returns></returns>
        public static T WithMaxRedirects<T>(this T baseRequest, int maxRedirects) where T : IBaseRequest
        {
            string redirectOptionKey = nameof(RedirectHandlerOption);
            if (baseRequest.MiddlewareOptions.ContainsKey(redirectOptionKey))
            {
                (baseRequest.MiddlewareOptions[redirectOptionKey] as RedirectHandlerOption).MaxRedirect = maxRedirects;
            }
            else
            {
                baseRequest.MiddlewareOptions.Add(redirectOptionKey, new RedirectHandlerOption { MaxRedirect = maxRedirects });
            }
            return baseRequest;
        }

        /// <summary>
        /// Replaces the default response handler with a custom response handler for this request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="baseRequest">The <see cref="IBaseRequest"/> for the request.</param>
        /// <param name="responseHandler">The <see cref="IResponseHandler"/> for the request.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">If responseHandler is null.</exception>
        public static T WithResponseHandler<T>(this T baseRequest, IResponseHandler responseHandler) where T : IBaseRequest
        {
            baseRequest.ResponseHandler = responseHandler ?? throw new ArgumentNullException(nameof(responseHandler));
            return baseRequest;
        }

        /// <summary>
        /// Sets Microsoft Graph's scopes that will be used by <see cref="IAuthenticationProvider"/> to authenticate this request
        /// and can be used to perform incremental scope consent.
        /// This only works with the default authentication handler and default set of Microsoft graph authentication providers.
        /// If you use a custom authentication handler or authentication provider, you have to handle it's retrieval in your implementation.
        /// </summary>
        /// <param name="baseRequest">The <see cref="IBaseRequest"/>.</param>
        /// <param name="scopes">Microsoft graph scopes used to authenticate this request.</param>
        public static T WithScopes<T>(this T baseRequest, string[] scopes) where T : IBaseRequest
        {
            string authHandlerOptionKey = nameof(AuthenticationHandlerOption);
            AuthenticationHandlerOption authHandlerOptions; 

            // make sure that the options exist in the middleware otherwise create it
            if (baseRequest.MiddlewareOptions.ContainsKey(authHandlerOptionKey))
            {
                authHandlerOptions = baseRequest.MiddlewareOptions[authHandlerOptionKey] as AuthenticationHandlerOption;
            }
            else
            {
                baseRequest.MiddlewareOptions.Add(authHandlerOptionKey, new AuthenticationHandlerOption());
                authHandlerOptions = baseRequest.MiddlewareOptions[authHandlerOptionKey] as AuthenticationHandlerOption;
            }

            // get the auth handler options or create a new instance if absent
            ScopedAuthenticationProviderOptions scopedAuthenticationProviderOptions = authHandlerOptions.AuthenticationProviderOption as ScopedAuthenticationProviderOptions ?? new ScopedAuthenticationProviderOptions();

            scopedAuthenticationProviderOptions.Scopes = scopes;

            // update the base request object as appropriate
            authHandlerOptions.AuthenticationProviderOption = scopedAuthenticationProviderOptions;
            baseRequest.MiddlewareOptions[authHandlerOptionKey] = authHandlerOptions;

            return baseRequest;
        }
    }
}
