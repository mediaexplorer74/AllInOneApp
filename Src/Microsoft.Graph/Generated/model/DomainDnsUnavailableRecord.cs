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
    /// The type Domain Dns Unavailable Record.
    /// </summary>
    public partial class DomainDnsUnavailableRecord : DomainDnsRecord
    {
    
        ///<summary>
        /// The DomainDnsUnavailableRecord constructor
        ///</summary>
        public DomainDnsUnavailableRecord()
        {
            this.ODataType = "microsoft.graph.domainDnsUnavailableRecord";
        }

        /// <summary>
        /// Gets or sets description.
        /// Provides the reason why the DomainDnsUnavailableRecord entity is returned.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
    }
}

