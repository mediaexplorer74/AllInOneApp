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
    /// The type Device Compliance User Overview.
    /// </summary>
    public partial class DeviceComplianceUserOverview : Entity
    {
    
        /// <summary>
        /// Gets or sets configuration version.
        /// Version of the policy for that overview
        /// </summary>
        [JsonPropertyName("configurationVersion")]
        public Int32? ConfigurationVersion { get; set; }
    
        /// <summary>
        /// Gets or sets error count.
        /// Number of error Users
        /// </summary>
        [JsonPropertyName("errorCount")]
        public Int32? ErrorCount { get; set; }
    
        /// <summary>
        /// Gets or sets failed count.
        /// Number of failed Users
        /// </summary>
        [JsonPropertyName("failedCount")]
        public Int32? FailedCount { get; set; }
    
        /// <summary>
        /// Gets or sets last update date time.
        /// Last update time
        /// </summary>
        [JsonPropertyName("lastUpdateDateTime")]
        public DateTimeOffset? LastUpdateDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets not applicable count.
        /// Number of not applicable users
        /// </summary>
        [JsonPropertyName("notApplicableCount")]
        public Int32? NotApplicableCount { get; set; }
    
        /// <summary>
        /// Gets or sets pending count.
        /// Number of pending Users
        /// </summary>
        [JsonPropertyName("pendingCount")]
        public Int32? PendingCount { get; set; }
    
        /// <summary>
        /// Gets or sets success count.
        /// Number of succeeded Users
        /// </summary>
        [JsonPropertyName("successCount")]
        public Int32? SuccessCount { get; set; }
    
    }
}

