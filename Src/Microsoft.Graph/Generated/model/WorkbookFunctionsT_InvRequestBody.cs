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
    /// The type WorkbookFunctionsT_InvRequestBody.
    /// </summary>
    public partial class WorkbookFunctionsT_InvRequestBody
    {
    
        /// <summary>
        /// Gets or sets Probability.
        /// </summary>
        [JsonPropertyName("probability")]
        public System.Text.Json.JsonDocument Probability { get; set; }
    
        /// <summary>
        /// Gets or sets DegFreedom.
        /// </summary>
        [JsonPropertyName("degFreedom")]
        public System.Text.Json.JsonDocument DegFreedom { get; set; }
    
    }
}