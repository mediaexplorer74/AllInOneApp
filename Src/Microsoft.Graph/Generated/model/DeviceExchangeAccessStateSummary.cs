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
    /// The type DeviceExchangeAccessStateSummary.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DeviceExchangeAccessStateSummary>))]
    public partial class DeviceExchangeAccessStateSummary
    {

        /// <summary>
        /// Gets or sets allowedDeviceCount.
        /// Total count of devices with Exchange Access State: Allowed.
        /// </summary>
        [JsonPropertyName("allowedDeviceCount")]
        public Int32? AllowedDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets blockedDeviceCount.
        /// Total count of devices with Exchange Access State: Blocked.
        /// </summary>
        [JsonPropertyName("blockedDeviceCount")]
        public Int32? BlockedDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets quarantinedDeviceCount.
        /// Total count of devices with Exchange Access State: Quarantined.
        /// </summary>
        [JsonPropertyName("quarantinedDeviceCount")]
        public Int32? QuarantinedDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets unavailableDeviceCount.
        /// Total count of devices for which no Exchange Access State could be found.
        /// </summary>
        [JsonPropertyName("unavailableDeviceCount")]
        public Int32? UnavailableDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets unknownDeviceCount.
        /// Total count of devices with Exchange Access State: Unknown.
        /// </summary>
        [JsonPropertyName("unknownDeviceCount")]
        public Int32? UnknownDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}