// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type CloudCommunicationsGetPresencesByUserIdRequestBody.
    /// </summary>
    public partial class CloudCommunicationsGetPresencesByUserIdRequestBody
    {
    
        /// <summary>
        /// Gets or sets Ids.
        /// </summary>
        [JsonPropertyName("ids")]
        public IEnumerable<string> Ids { get; set; }
    
    }
}