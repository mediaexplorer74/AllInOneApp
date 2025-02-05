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
    /// The type FileSecurityState.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<FileSecurityState>))]
    public partial class FileSecurityState
    {

        /// <summary>
        /// Gets or sets fileHash.
        /// Complex type containing file hashes (cryptographic and location-sensitive).
        /// </summary>
        [JsonPropertyName("fileHash")]
        public FileHash FileHash { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// File name (without path).
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets path.
        /// Full file path of the file/imageFile.
        /// </summary>
        [JsonPropertyName("path")]
        public string Path { get; set; }
    
        /// <summary>
        /// Gets or sets riskScore.
        /// Provider generated/calculated risk score of the alert file. Recommended value range of 0-1, which equates to a percentage.
        /// </summary>
        [JsonPropertyName("riskScore")]
        public string RiskScore { get; set; }
    
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
