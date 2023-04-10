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
    /// The type IosLobAppAssignmentSettings.
    /// </summary>
    public partial class IosLobAppAssignmentSettings : MobileAppAssignmentSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IosLobAppAssignmentSettings"/> class.
        /// </summary>
        public IosLobAppAssignmentSettings()
        {
            this.ODataType = "microsoft.graph.iosLobAppAssignmentSettings";
        }

        /// <summary>
        /// Gets or sets vpnConfigurationId.
        /// The VPN Configuration Id to apply for this app.
        /// </summary>
        [JsonPropertyName("vpnConfigurationId")]
        public string VpnConfigurationId { get; set; }
    
    }
}