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
    /// The type WindowsDeviceAzureADAccount.
    /// </summary>
    public partial class WindowsDeviceAzureADAccount : WindowsDeviceAccount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsDeviceAzureADAccount"/> class.
        /// </summary>
        public WindowsDeviceAzureADAccount()
        {
            this.ODataType = "microsoft.graph.windowsDeviceAzureADAccount";
        }

        /// <summary>
        /// Gets or sets userPrincipalName.
        /// Not yet documented
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
    }
}