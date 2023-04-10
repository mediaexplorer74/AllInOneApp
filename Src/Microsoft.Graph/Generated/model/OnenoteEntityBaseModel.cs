// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Onenote Entity Base Model.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<OnenoteEntityBaseModel>))]
    public partial class OnenoteEntityBaseModel : Entity
    {
    
        ///<summary>
        /// The internal OnenoteEntityBaseModel constructor
        ///</summary>
        protected internal OnenoteEntityBaseModel()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets self.
        /// The endpoint where you can get details about the page. Read-only.
        /// </summary>
        [JsonPropertyName("self")]
        public string Self { get; set; }
    
    }
}
