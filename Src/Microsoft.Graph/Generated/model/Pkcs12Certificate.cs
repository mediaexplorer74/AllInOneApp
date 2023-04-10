// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Pkcs12Certificate.
    /// </summary>
    public partial class Pkcs12Certificate : ApiAuthenticationConfigurationBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pkcs12Certificate"/> class.
        /// </summary>
        public Pkcs12Certificate()
        {
            this.ODataType = "microsoft.graph.pkcs12Certificate";
        }

        /// <summary>
        /// Gets or sets password.
        /// This is the password for the pfx file. Required. If no password is used, must still provide a value of ''.
        /// </summary>
        [JsonPropertyName("password")]
        public string Password { get; set; }
    
        /// <summary>
        /// Gets or sets pkcs12Value.
        /// This is the field for sending pfx content. The value should be a base-64 encoded version of the actual certificate content. Required.
        /// </summary>
        [JsonPropertyName("pkcs12Value")]
        public string Pkcs12Value { get; set; }
    
    }
}
