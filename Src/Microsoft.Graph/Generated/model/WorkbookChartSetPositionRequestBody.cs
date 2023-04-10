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
    /// The type WorkbookChartSetPositionRequestBody.
    /// </summary>
    public partial class WorkbookChartSetPositionRequestBody
    {
    
        /// <summary>
        /// Gets or sets StartCell.
        /// </summary>
        [JsonPropertyName("startCell")]
        public System.Text.Json.JsonDocument StartCell { get; set; }
    
        /// <summary>
        /// Gets or sets EndCell.
        /// </summary>
        [JsonPropertyName("endCell")]
        public System.Text.Json.JsonDocument EndCell { get; set; }
    
    }
}