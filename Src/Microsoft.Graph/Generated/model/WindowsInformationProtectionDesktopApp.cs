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
    /// The type WindowsInformationProtectionDesktopApp.
    /// </summary>
    public partial class WindowsInformationProtectionDesktopApp : WindowsInformationProtectionApp
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsInformationProtectionDesktopApp"/> class.
        /// </summary>
        public WindowsInformationProtectionDesktopApp()
        {
            this.ODataType = "microsoft.graph.windowsInformationProtectionDesktopApp";
        }

        /// <summary>
        /// Gets or sets binaryName.
        /// The binary name.
        /// </summary>
        [JsonPropertyName("binaryName")]
        public string BinaryName { get; set; }
    
        /// <summary>
        /// Gets or sets binaryVersionHigh.
        /// The high binary version.
        /// </summary>
        [JsonPropertyName("binaryVersionHigh")]
        public string BinaryVersionHigh { get; set; }
    
        /// <summary>
        /// Gets or sets binaryVersionLow.
        /// The lower binary version.
        /// </summary>
        [JsonPropertyName("binaryVersionLow")]
        public string BinaryVersionLow { get; set; }
    
    }
}