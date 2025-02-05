﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Reflection;

namespace System.Text.Json.Serialization.Converters
{
    internal sealed class JsonKeyValuePairConverter : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert)
        {
            if (!typeToConvert.GetTypeInfo().IsGenericType)
                return false;

            Type generic = typeToConvert.GetGenericTypeDefinition();
            return (generic == typeof(KeyValuePair<,>));
        }

        public override JsonConverter CreateConverter(Type type, JsonSerializerOptions options)
        {
            Type keyType = type.GetTypeInfo().GenericTypeArguments[0];
            Type valueType = type.GetTypeInfo().GenericTypeArguments[1];

            JsonConverter converter = (JsonConverter)Activator.CreateInstance(
                typeof(JsonKeyValuePairConverter<,>).MakeGenericType(
                    new Type[] { keyType, valueType }),
                /*BindingFlags.Instance | BindingFlags.Public*/default//,
                //binder: null,
                //args: null//,
                //culture: null
                );

            return converter;
        }
    }
}
