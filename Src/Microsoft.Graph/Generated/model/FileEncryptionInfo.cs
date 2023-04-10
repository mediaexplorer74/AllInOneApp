// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type FileEncryptionInfo.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<FileEncryptionInfo>))]
    public partial class FileEncryptionInfo
    {

        /// <summary>
        /// Gets or sets encryptionKey.
        /// The key used to encrypt the file content.
        /// </summary>
        [JsonPropertyName("encryptionKey")]
        public byte[] EncryptionKey { get; set; }
    
        /// <summary>
        /// Gets or sets fileDigest.
        /// The file digest prior to encryption.
        /// </summary>
        [JsonPropertyName("fileDigest")]
        public byte[] FileDigest { get; set; }
    
        /// <summary>
        /// Gets or sets fileDigestAlgorithm.
        /// The file digest algorithm.
        /// </summary>
        [JsonPropertyName("fileDigestAlgorithm")]
        public string FileDigestAlgorithm { get; set; }
    
        /// <summary>
        /// Gets or sets initializationVector.
        /// The initialization vector used for the encryption algorithm.
        /// </summary>
        [JsonPropertyName("initializationVector")]
        public byte[] InitializationVector { get; set; }
    
        /// <summary>
        /// Gets or sets mac.
        /// The hash of the encrypted file content + IV (content hash).
        /// </summary>
        [JsonPropertyName("mac")]
        public byte[] Mac { get; set; }
    
        /// <summary>
        /// Gets or sets macKey.
        /// The key used to get mac.
        /// </summary>
        [JsonPropertyName("macKey")]
        public byte[] MacKey { get; set; }
    
        /// <summary>
        /// Gets or sets profileIdentifier.
        /// The the profile identifier.
        /// </summary>
        [JsonPropertyName("profileIdentifier")]
        public string ProfileIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}