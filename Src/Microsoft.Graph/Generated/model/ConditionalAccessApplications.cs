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
    /// The type ConditionalAccessApplications.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ConditionalAccessApplications>))]
    public partial class ConditionalAccessApplications
    {

        /// <summary>
        /// Gets or sets excludeApplications.
        /// The list of application IDs explicitly excluded from the policy.
        /// </summary>
        [JsonPropertyName("excludeApplications")]
        public IEnumerable<string> ExcludeApplications { get; set; }
    
        /// <summary>
        /// Gets or sets includeApplications.
        /// The list of application IDs the policy applies to, unless explicitly excluded (in excludeApplications). Can also be set to All.
        /// </summary>
        [JsonPropertyName("includeApplications")]
        public IEnumerable<string> IncludeApplications { get; set; }
    
        /// <summary>
        /// Gets or sets includeUserActions.
        /// User actions to include. Supported values are urn:user:registersecurityinfo and urn:user:registerdevice
        /// </summary>
        [JsonPropertyName("includeUserActions")]
        public IEnumerable<string> IncludeUserActions { get; set; }
    
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