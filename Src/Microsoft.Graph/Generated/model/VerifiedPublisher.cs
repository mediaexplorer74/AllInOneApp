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
    /// The type VerifiedPublisher.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<VerifiedPublisher>))]
    public partial class VerifiedPublisher
    {

        /// <summary>
        /// Gets or sets addedDateTime.
        /// The timestamp when the verified publisher was first added or most recently updated.
        /// </summary>
        [JsonPropertyName("addedDateTime")]
        public DateTimeOffset? AddedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets displayName.
        /// The verified publisher name from the app publisher's Microsoft Partner Network (MPN) account.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets verifiedPublisherId.
        /// The ID of the verified publisher from the app publisher's Partner Center account.
        /// </summary>
        [JsonPropertyName("verifiedPublisherId")]
        public string VerifiedPublisherId { get; set; }
    
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
