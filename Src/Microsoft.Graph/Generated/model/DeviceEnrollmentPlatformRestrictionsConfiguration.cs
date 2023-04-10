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
    /// The type Device Enrollment Platform Restrictions Configuration.
    /// </summary>
    public partial class DeviceEnrollmentPlatformRestrictionsConfiguration : DeviceEnrollmentConfiguration
    {
    
        ///<summary>
        /// The DeviceEnrollmentPlatformRestrictionsConfiguration constructor
        ///</summary>
        public DeviceEnrollmentPlatformRestrictionsConfiguration()
        {
            this.ODataType = "microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration";
        }

        /// <summary>
        /// Gets or sets android restriction.
        /// Android restrictions based on platform, platform operating system version, and device ownership
        /// </summary>
        [JsonPropertyName("androidRestriction")]
        public DeviceEnrollmentPlatformRestriction AndroidRestriction { get; set; }
    
        /// <summary>
        /// Gets or sets ios restriction.
        /// Ios restrictions based on platform, platform operating system version, and device ownership
        /// </summary>
        [JsonPropertyName("iosRestriction")]
        public DeviceEnrollmentPlatformRestriction IosRestriction { get; set; }
    
        /// <summary>
        /// Gets or sets mac osrestriction.
        /// Mac restrictions based on platform, platform operating system version, and device ownership
        /// </summary>
        [JsonPropertyName("macOSRestriction")]
        public DeviceEnrollmentPlatformRestriction MacOSRestriction { get; set; }
    
        /// <summary>
        /// Gets or sets windows mobile restriction.
        /// Windows mobile restrictions based on platform, platform operating system version, and device ownership
        /// </summary>
        [JsonPropertyName("windowsMobileRestriction")]
        public DeviceEnrollmentPlatformRestriction WindowsMobileRestriction { get; set; }
    
        /// <summary>
        /// Gets or sets windows restriction.
        /// Windows restrictions based on platform, platform operating system version, and device ownership
        /// </summary>
        [JsonPropertyName("windowsRestriction")]
        public DeviceEnrollmentPlatformRestriction WindowsRestriction { get; set; }
    
    }
}

