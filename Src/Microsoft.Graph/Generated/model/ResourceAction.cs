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
    /// The type ResourceAction.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ResourceAction>))]
    public partial class ResourceAction
    {

        /// <summary>
        /// Gets or sets allowedResourceActions.
        /// Allowed Actions
        /// </summary>
        [JsonPropertyName("allowedResourceActions")]
        public IEnumerable<string> AllowedResourceActions { get; set; }
    
        /// <summary>
        /// Gets or sets notAllowedResourceActions.
        /// Not Allowed Actions.
        /// </summary>
        [JsonPropertyName("notAllowedResourceActions")]
        public IEnumerable<string> NotAllowedResourceActions { get; set; }
    
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