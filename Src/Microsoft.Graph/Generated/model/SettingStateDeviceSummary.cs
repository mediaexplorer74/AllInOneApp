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
    /// The type Setting State Device Summary.
    /// </summary>
    public partial class SettingStateDeviceSummary : Entity
    {
    
        /// <summary>
        /// Gets or sets compliant device count.
        /// Device Compliant count for the setting
        /// </summary>
        [JsonPropertyName("compliantDeviceCount")]
        public Int32? CompliantDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets conflict device count.
        /// Device conflict error count for the setting
        /// </summary>
        [JsonPropertyName("conflictDeviceCount")]
        public Int32? ConflictDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets error device count.
        /// Device error count for the setting
        /// </summary>
        [JsonPropertyName("errorDeviceCount")]
        public Int32? ErrorDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets instance path.
        /// Name of the InstancePath for the setting
        /// </summary>
        [JsonPropertyName("instancePath")]
        public string InstancePath { get; set; }
    
        /// <summary>
        /// Gets or sets non compliant device count.
        /// Device NonCompliant count for the setting
        /// </summary>
        [JsonPropertyName("nonCompliantDeviceCount")]
        public Int32? NonCompliantDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets not applicable device count.
        /// Device Not Applicable count for the setting
        /// </summary>
        [JsonPropertyName("notApplicableDeviceCount")]
        public Int32? NotApplicableDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets remediated device count.
        /// Device Compliant count for the setting
        /// </summary>
        [JsonPropertyName("remediatedDeviceCount")]
        public Int32? RemediatedDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets setting name.
        /// Name of the setting
        /// </summary>
        [JsonPropertyName("settingName")]
        public string SettingName { get; set; }
    
        /// <summary>
        /// Gets or sets unknown device count.
        /// Device Unkown count for the setting
        /// </summary>
        [JsonPropertyName("unknownDeviceCount")]
        public Int32? UnknownDeviceCount { get; set; }
    
    }
}
