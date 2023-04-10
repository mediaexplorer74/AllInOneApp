// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace System.Text.Json
{
    internal static partial class ThrowHelper
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentException_DeserializeWrongType(Type type, object value)
        {
            throw new ArgumentException("String.Format(SR.DeserializeWrongType, type, value.GetType())");
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static NotSupportedException GetNotSupportedException_SerializationNotSupportedCollection(
            Type propertyType, Type parentType, MemberInfo memberInfo)
        {
            if (parentType != null && parentType != typeof(object) && memberInfo != null)
            {
                return new NotSupportedException(String.Format("SR.SerializationNotSupportedCollection", 
                    propertyType, $"{parentType}.{memberInfo.Name}"));
            }

            return new NotSupportedException(String.Format("SR.SerializationNotSupportedCollectionType", 
                propertyType));
        }

        public static void ThrowInvalidOperationException_SerializerCycleDetected(int maxDepth)
        {
            throw new JsonException(String.Format("SR.SerializerCycleDetected", maxDepth));
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowJsonException_DeserializeUnableToConvertValue(Type propertyType)
        {
            var ex = new JsonException(String.Format("SR.DeserializeUnableToConvertValue", propertyType));
            ex.AppendPathInformation = true;
            throw ex;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowJsonException_DeserializeUnableToConvertValue(Type propertyType, 
            string path, Exception innerException = null)
        {
            string message = String.Format("SR.DeserializeUnableToConvertValue", propertyType) + $" Path: {path}.";
            throw new JsonException(message, path, null, null, innerException);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowJsonException_DepthTooLarge(int currentDepth, JsonSerializerOptions options)
        {
            throw new JsonException(String.Format("SR.DepthTooLarge", currentDepth, options.EffectiveMaxDepth));
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowJsonException_SerializationConverterRead(JsonConverter converter)
        {
            var ex = new JsonException(String.Format("SR.SerializationConverterRead", converter));
            ex.AppendPathInformation = true;
            throw ex;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowJsonException_SerializationConverterWrite(JsonConverter converter)
        {
            var ex = new JsonException(String.Format("SR.SerializationConverterWrite", converter));
            ex.AppendPathInformation = true;
            throw ex;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowJsonException()
        {
            throw new JsonException();
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowInvalidOperationException_SerializationConverterNotCompatible(Type converterType, Type type)
        {
            throw new InvalidOperationException(String.Format("SR.SerializationConverterNotCompatible",
                converterType, type));
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowInvalidOperationException_SerializationConverterOnAttributeInvalid(Type classType, PropertyInfo propertyInfo)
        {
            string location = classType.ToString();
            if (propertyInfo != null)
            {
                location += $".{propertyInfo.Name}";
            }

            throw new InvalidOperationException(String.Format("SR.SerializationConverterOnAttributeInvalid", 
                location));
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowInvalidOperationException_SerializationConverterOnAttributeNotCompatible(Type classTypeAttributeIsOn, PropertyInfo propertyInfo, Type typeToConvert)
        {
            string location = classTypeAttributeIsOn.ToString();

            if (propertyInfo != null)
            {
                location += $".{propertyInfo.Name}";
            }

            throw new InvalidOperationException(String.Format(
                "SR.SerializationConverterOnAttributeNotCompatible", location, typeToConvert));
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowInvalidOperationException_SerializerOptionsImmutable()
        {
            throw new InvalidOperationException("SR.SerializerOptionsImmutable");
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowInvalidOperationException_SerializerPropertyNameConflict(JsonClassInfo jsonClassInfo, JsonPropertyInfo jsonPropertyInfo)
        {
            throw new InvalidOperationException(String.Format
                ("SR.SerializerPropertyNameConflict", jsonClassInfo.Type, 
                jsonPropertyInfo.PropertyInfo.Name));
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowInvalidOperationException_SerializerPropertyNameNull(Type parentType, 
            JsonPropertyInfo jsonPropertyInfo)
        {
            throw new InvalidOperationException(String.Format("SR.SerializerPropertyNameNull", 
                parentType, jsonPropertyInfo.PropertyInfo.Name));
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowInvalidOperationException_SerializerDictionaryKeyNull(Type policyType)
        {
            throw new InvalidOperationException(String.Format("SR.SerializerDictionaryKeyNull", policyType));
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ReThrowWithPath(in ReadStack readStack, JsonReaderException ex)
        {
            Debug.Assert(ex.Path == null);

            string path = readStack.JsonPath();
            string message = ex.Message;

            // Insert the "Path" portion before "LineNumber" and "BytePositionInLine".
            int iPos = message.LastIndexOf(" LineNumber: ", StringComparison.CurrentCulture/*.InvariantCulture*/);
            if (iPos >= 0)
            {
                message = $"{message.Substring(0, iPos)} Path: {path} |{message.Substring(iPos)}";
            }
            else
            {
                message += $" Path: {path}.";
            }

            throw new JsonException(message, path, ex.LineNumber, ex.BytePositionInLine, ex);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ReThrowWithPath(in ReadStack readStack, in Utf8JsonReader reader, Exception ex)
        {
            JsonException jsonException = new JsonException(null, ex);
            AddExceptionInformation(readStack, reader, jsonException);
            throw jsonException;
        }

        public static void AddExceptionInformation(in ReadStack readStack, in Utf8JsonReader reader, JsonException ex)
        {
            long lineNumber = reader.CurrentState._lineNumber;
            ex.LineNumber = lineNumber;

            long bytePositionInLine = reader.CurrentState._bytePositionInLine;
            ex.BytePositionInLine = bytePositionInLine;

            string path = readStack.JsonPath();
            ex.Path = path;

            string message = ex.Message;

            if (string.IsNullOrEmpty(message))
            {
                // Use a default message.
                Type propertyType = readStack.Current.JsonPropertyInfo?.RuntimePropertyType;
                if (propertyType == null)
                {
                    propertyType = readStack.Current.JsonClassInfo.Type;
                }

                message = "String.Format(SR.DeserializeUnableToConvertValue, propertyType)";
                ex.AppendPathInformation = true;
            }

            if (ex.AppendPathInformation)
            {
                message += $" Path: {path} | LineNumber: {lineNumber} | BytePositionInLine: {bytePositionInLine}.";
                ex.SetMessage(message);
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ReThrowWithPath(in WriteStack writeStack, Exception ex)
        {
            JsonException jsonException = new JsonException(null, ex);
            AddExceptionInformation(writeStack, jsonException);
            throw jsonException;
        }

        public static void AddExceptionInformation(in WriteStack writeStack, JsonException ex)
        {
            string path = writeStack.PropertyPath();
            ex.Path = path;

            string message = ex.Message;
            if (string.IsNullOrEmpty(message))
            {
                // Use a default message.
                message = String.Format("SR.SerializeUnableToSerialize");
                ex.AppendPathInformation = true;
            }

            if (ex.AppendPathInformation)
            {
                message += $" Path: {path}.";
                ex.SetMessage(message);
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowInvalidOperationException_SerializationDuplicateAttribute(Type attribute, Type classType, PropertyInfo propertyInfo)
        {
            string location = classType.ToString();
            if (propertyInfo != null)
            {
                location += $".{propertyInfo.Name}";
            }

            throw new InvalidOperationException(String.Format("SR.SerializationDuplicateAttribute", 
                attribute, location));
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowInvalidOperationException_SerializationDuplicateTypeAttribute(
            Type classType, Type attribute)
        {
            throw new InvalidOperationException(String.Format("SR.SerializationDuplicateTypeAttribute", 
                classType, attribute));
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowInvalidOperationException_SerializationDataExtensionPropertyInvalid(JsonClassInfo jsonClassInfo, JsonPropertyInfo jsonPropertyInfo)
        {
            throw new InvalidOperationException(
                "String.Format(SR.SerializationDataExtensionPropertyInvalid, jsonClassInfo.Type, jsonPropertyInfo.PropertyInfo.Name)");
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowNotSupportedException_DeserializeCreateObjectDelegateIsNull(Type invalidType)
        {
            if (invalidType.GetTypeInfo().IsInterface)
            {
                throw new NotSupportedException(
                    "String.Format(SR.DeserializePolymorphicInterface, invalidType)");
            }
            else
            {
                throw new NotSupportedException(
                    "String.Format(SR.DeserializeMissingParameterlessConstructor, invalidType)");
            }
        }
    }
}
