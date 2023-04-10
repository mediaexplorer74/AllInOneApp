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
    /// The type DeviceGeoLocation.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DeviceGeoLocation>))]
    public partial class DeviceGeoLocation
    {

        /// <summary>
        /// Gets or sets altitude.
        /// Altitude, given in meters above sea level
        /// </summary>
        [JsonPropertyName("altitude")]
        public double? Altitude { get; set; }
    
        /// <summary>
        /// Gets or sets heading.
        /// Heading in degrees from true north
        /// </summary>
        [JsonPropertyName("heading")]
        public double? Heading { get; set; }
    
        /// <summary>
        /// Gets or sets horizontalAccuracy.
        /// Accuracy of longitude and latitude in meters
        /// </summary>
        [JsonPropertyName("horizontalAccuracy")]
        public double? HorizontalAccuracy { get; set; }
    
        /// <summary>
        /// Gets or sets lastCollectedDateTime.
        /// Time at which location was recorded, relative to UTC
        /// </summary>
        [JsonPropertyName("lastCollectedDateTime")]
        public DateTimeOffset? LastCollectedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets latitude.
        /// Latitude coordinate of the device's location
        /// </summary>
        [JsonPropertyName("latitude")]
        public double? Latitude { get; set; }
    
        /// <summary>
        /// Gets or sets longitude.
        /// Longitude coordinate of the device's location
        /// </summary>
        [JsonPropertyName("longitude")]
        public double? Longitude { get; set; }
    
        /// <summary>
        /// Gets or sets speed.
        /// Speed the device is traveling in meters per second
        /// </summary>
        [JsonPropertyName("speed")]
        public double? Speed { get; set; }
    
        /// <summary>
        /// Gets or sets verticalAccuracy.
        /// Accuracy of altitude in meters
        /// </summary>
        [JsonPropertyName("verticalAccuracy")]
        public double? VerticalAccuracy { get; set; }
    
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