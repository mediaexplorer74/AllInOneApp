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
    /// The type PlannerCategoryDescriptions.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<PlannerCategoryDescriptions>))]
    public partial class PlannerCategoryDescriptions
    {

        /// <summary>
        /// Gets or sets category1.
        /// The label associated with Category 1
        /// </summary>
        [JsonPropertyName("category1")]
        public string Category1 { get; set; }
    
        /// <summary>
        /// Gets or sets category2.
        /// The label associated with Category 2
        /// </summary>
        [JsonPropertyName("category2")]
        public string Category2 { get; set; }
    
        /// <summary>
        /// Gets or sets category3.
        /// The label associated with Category 3
        /// </summary>
        [JsonPropertyName("category3")]
        public string Category3 { get; set; }
    
        /// <summary>
        /// Gets or sets category4.
        /// The label associated with Category 4
        /// </summary>
        [JsonPropertyName("category4")]
        public string Category4 { get; set; }
    
        /// <summary>
        /// Gets or sets category5.
        /// The label associated with Category 5
        /// </summary>
        [JsonPropertyName("category5")]
        public string Category5 { get; set; }
    
        /// <summary>
        /// Gets or sets category6.
        /// The label associated with Category 6
        /// </summary>
        [JsonPropertyName("category6")]
        public string Category6 { get; set; }
    
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
