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
    /// The type DeleteUserFromSharedAppleDeviceActionResult.
    /// </summary>
    public partial class DeleteUserFromSharedAppleDeviceActionResult : DeviceActionResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteUserFromSharedAppleDeviceActionResult"/> class.
        /// </summary>
        public DeleteUserFromSharedAppleDeviceActionResult()
        {
            this.ODataType = "microsoft.graph.deleteUserFromSharedAppleDeviceActionResult";
        }

        /// <summary>
        /// Gets or sets userPrincipalName.
        /// User principal name of the user to be deleted
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
    }
}