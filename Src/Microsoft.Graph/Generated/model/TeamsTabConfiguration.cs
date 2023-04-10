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
    /// The type TeamsTabConfiguration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<TeamsTabConfiguration>))]
    public partial class TeamsTabConfiguration
    {

        /// <summary>
        /// Gets or sets contentUrl.
        /// Url used for rendering tab contents in Teams. Required.
        /// </summary>
        [JsonPropertyName("contentUrl")]
        public string ContentUrl { get; set; }
    
        /// <summary>
        /// Gets or sets entityId.
        /// Identifier for the entity hosted by the tab provider.
        /// </summary>
        [JsonPropertyName("entityId")]
        public string EntityId { get; set; }
    
        /// <summary>
        /// Gets or sets removeUrl.
        /// Url called by Teams client when a Tab is removed using the Teams Client.
        /// </summary>
        [JsonPropertyName("removeUrl")]
        public string RemoveUrl { get; set; }
    
        /// <summary>
        /// Gets or sets websiteUrl.
        /// Url for showing tab contents outside of Teams.
        /// </summary>
        [JsonPropertyName("websiteUrl")]
        public string WebsiteUrl { get; set; }
    
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