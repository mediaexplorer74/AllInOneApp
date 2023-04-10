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
    /// The type PrivacyProfile.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<PrivacyProfile>))]
    public partial class PrivacyProfile
    {

        /// <summary>
        /// Gets or sets contactEmail.
        /// A valid smtp email address for the privacy statement contact. Not required.
        /// </summary>
        [JsonPropertyName("contactEmail")]
        public string ContactEmail { get; set; }
    
        /// <summary>
        /// Gets or sets statementUrl.
        /// A valid URL format that begins with http:// or https://. Maximum length is 255 characters. The URL that directs to the company's privacy statement. Not required.
        /// </summary>
        [JsonPropertyName("statementUrl")]
        public string StatementUrl { get; set; }
    
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