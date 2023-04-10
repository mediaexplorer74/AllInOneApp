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
    /// The type WorkbookFunctionsQuartile_IncRequestBody.
    /// </summary>
    public partial class WorkbookFunctionsQuartile_IncRequestBody
    {
    
        /// <summary>
        /// Gets or sets Array.
        /// </summary>
        [JsonPropertyName("array")]
        public System.Text.Json.JsonDocument Array { get; set; }
    
        /// <summary>
        /// Gets or sets Quart.
        /// </summary>
        [JsonPropertyName("quart")]
        public System.Text.Json.JsonDocument Quart { get; set; }
    
    }
}