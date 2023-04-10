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
    /// The type WorkbookFunctionsRoundUpRequestBody.
    /// </summary>
    public partial class WorkbookFunctionsRoundUpRequestBody
    {
    
        /// <summary>
        /// Gets or sets Number.
        /// </summary>
        [JsonPropertyName("number")]
        public System.Text.Json.JsonDocument Number { get; set; }
    
        /// <summary>
        /// Gets or sets NumDigits.
        /// </summary>
        [JsonPropertyName("numDigits")]
        public System.Text.Json.JsonDocument NumDigits { get; set; }
    
    }
}