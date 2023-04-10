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
    /// The type WorkbookFunctionsDollarFrRequestBody.
    /// </summary>
    public partial class WorkbookFunctionsDollarFrRequestBody
    {
    
        /// <summary>
        /// Gets or sets DecimalDollar.
        /// </summary>
        [JsonPropertyName("decimalDollar")]
        public System.Text.Json.JsonDocument DecimalDollar { get; set; }
    
        /// <summary>
        /// Gets or sets Fraction.
        /// </summary>
        [JsonPropertyName("fraction")]
        public System.Text.Json.JsonDocument Fraction { get; set; }
    
    }
}