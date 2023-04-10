﻿// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The converter for deserializing/serializing next link urls
    /// </summary>
    public class NextLinkConverter : JsonConverter<string>
    {
        /// <summary>
        /// Checks if the given object can be converted into a next link url.
        /// </summary>
        /// <param name="objectType">The object type.</param>
        /// <returns>True if the object is of type Duration.</returns>
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }

        /// <summary>
        /// Deserialize the JSON data into a decoded nextLink url string.
        /// </summary>
        /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
        /// <param name="typeToConvert">The object type.</param>
        /// <param name="options">The <see cref="JsonSerializerOptions"/> for conversion.</param>
        /// <returns>A nextLink string parsable by <see cref="BaseRequest"/>.</returns>
        public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (typeToConvert == null)
                throw new ArgumentNullException(nameof(typeToConvert));

            var nextLinkUri = new Uri(reader.GetString());
            // Replace any '+' in the query as it signifies a space character the SDK does url encoding on the query parameter
            // Strip the ? character as .NetFramework may incorrectly build the url by adding a second '?' character
            var queryString = string.Empty;
            if (nextLinkUri.Query != null && nextLinkUri.Query.Length > 1)
                queryString = nextLinkUri.Query.Replace("+", "%20").Substring(1);

            return new UriBuilder(nextLinkUri) { Query = queryString }.ToString();
        }

        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The <see cref="Utf8JsonWriter"/> to write to.</param>
        /// <param name="value">The nextLink url value.</param>
        /// <param name="options">The calling serializer options</param>
        public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
        {
            if (writer == null)
                throw new ArgumentNullException(nameof(writer));

            writer.WriteStringValue(value);
        }
    }
}
