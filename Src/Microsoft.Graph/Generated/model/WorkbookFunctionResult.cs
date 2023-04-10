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
    /// The type Workbook Function Result.
    /// </summary>
    public partial class WorkbookFunctionResult : Entity
    {
    
        /// <summary>
        /// Gets or sets error.
        /// </summary>
        [JsonPropertyName("error")]
        public string Error { get; set; }
    
        /// <summary>
        /// Gets or sets value.
        /// </summary>
        [JsonPropertyName("value")]
        public System.Text.Json.JsonDocument Value { get; set; }
    
    }
}
