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
    /// The type WorkbookFunctionsIfRequestBody.
    /// </summary>
    public partial class WorkbookFunctionsIfRequestBody
    {
    
        /// <summary>
        /// Gets or sets LogicalTest.
        /// </summary>
        [JsonPropertyName("logicalTest")]
        public System.Text.Json.JsonDocument LogicalTest { get; set; }
    
        /// <summary>
        /// Gets or sets ValueIfTrue.
        /// </summary>
        [JsonPropertyName("valueIfTrue")]
        public System.Text.Json.JsonDocument ValueIfTrue { get; set; }
    
        /// <summary>
        /// Gets or sets ValueIfFalse.
        /// </summary>
        [JsonPropertyName("valueIfFalse")]
        public System.Text.Json.JsonDocument ValueIfFalse { get; set; }
    
    }
}