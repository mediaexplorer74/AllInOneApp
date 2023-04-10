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
    /// The type EBook Install Summary.
    /// </summary>
    public partial class EBookInstallSummary : Entity
    {
    
        /// <summary>
        /// Gets or sets failed device count.
        /// Number of Devices that have failed to install this book.
        /// </summary>
        [JsonPropertyName("failedDeviceCount")]
        public Int32? FailedDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets failed user count.
        /// Number of Users that have 1 or more device that failed to install this book.
        /// </summary>
        [JsonPropertyName("failedUserCount")]
        public Int32? FailedUserCount { get; set; }
    
        /// <summary>
        /// Gets or sets installed device count.
        /// Number of Devices that have successfully installed this book.
        /// </summary>
        [JsonPropertyName("installedDeviceCount")]
        public Int32? InstalledDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets installed user count.
        /// Number of Users whose devices have all succeeded to install this book.
        /// </summary>
        [JsonPropertyName("installedUserCount")]
        public Int32? InstalledUserCount { get; set; }
    
        /// <summary>
        /// Gets or sets not installed device count.
        /// Number of Devices that does not have this book installed.
        /// </summary>
        [JsonPropertyName("notInstalledDeviceCount")]
        public Int32? NotInstalledDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets not installed user count.
        /// Number of Users that did not install this book.
        /// </summary>
        [JsonPropertyName("notInstalledUserCount")]
        public Int32? NotInstalledUserCount { get; set; }
    
    }
}
