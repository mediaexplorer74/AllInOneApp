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
    /// The type Managed App Status Raw.
    /// </summary>
    public partial class ManagedAppStatusRaw : ManagedAppStatus
    {
    
        ///<summary>
        /// The ManagedAppStatusRaw constructor
        ///</summary>
        public ManagedAppStatusRaw()
        {
            this.ODataType = "microsoft.graph.managedAppStatusRaw";
        }

        /// <summary>
        /// Gets or sets content.
        /// Status report content.
        /// </summary>
        [JsonPropertyName("content")]
        public System.Text.Json.JsonDocument Content { get; set; }
    
    }
}

