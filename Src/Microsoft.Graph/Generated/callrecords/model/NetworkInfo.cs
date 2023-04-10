// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.CallRecords
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type NetworkInfo.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<NetworkInfo>))]
    public partial class NetworkInfo
    {

        /// <summary>
        /// Gets or sets bandwidthLowEventRatio.
        /// Fraction of the call that the media endpoint detected the available bandwidth or bandwidth policy was low enough to cause poor quality of the audio sent.
        /// </summary>
        [JsonPropertyName("bandwidthLowEventRatio")]
        public Single? BandwidthLowEventRatio { get; set; }
    
        /// <summary>
        /// Gets or sets basicServiceSetIdentifier.
        /// The wireless LAN basic service set identifier of the media endpoint used to connect to the network.
        /// </summary>
        [JsonPropertyName("basicServiceSetIdentifier")]
        public string BasicServiceSetIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets connectionType.
        /// Type of network used by the media endpoint. Possible values are: unknown, wired, wifi, mobile, tunnel, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("connectionType")]
        public NetworkConnectionType? ConnectionType { get; set; }
    
        /// <summary>
        /// Gets or sets delayEventRatio.
        /// Fraction of the call that the media endpoint detected the network delay was significant enough to impact the ability to have real-time two-way communication.
        /// </summary>
        [JsonPropertyName("delayEventRatio")]
        public Single? DelayEventRatio { get; set; }
    
        /// <summary>
        /// Gets or sets dnsSuffix.
        /// DNS suffix associated with the network adapter of the media endpoint.
        /// </summary>
        [JsonPropertyName("dnsSuffix")]
        public string DnsSuffix { get; set; }
    
        /// <summary>
        /// Gets or sets ipAddress.
        /// IP address of the media endpoint.
        /// </summary>
        [JsonPropertyName("ipAddress")]
        public string IpAddress { get; set; }
    
        /// <summary>
        /// Gets or sets linkSpeed.
        /// Link speed in bits per second reported by the network adapter used by the media endpoint.
        /// </summary>
        [JsonPropertyName("linkSpeed")]
        public Int64? LinkSpeed { get; set; }
    
        /// <summary>
        /// Gets or sets macAddress.
        /// The media access control (MAC) address of the media endpoint's network device.
        /// </summary>
        [JsonPropertyName("macAddress")]
        public string MacAddress { get; set; }
    
        /// <summary>
        /// Gets or sets port.
        /// Network port number used by media endpoint.
        /// </summary>
        [JsonPropertyName("port")]
        public Int32? Port { get; set; }
    
        /// <summary>
        /// Gets or sets receivedQualityEventRatio.
        /// Fraction of the call that the media endpoint detected the network was causing poor quality of the audio received.
        /// </summary>
        [JsonPropertyName("receivedQualityEventRatio")]
        public Single? ReceivedQualityEventRatio { get; set; }
    
        /// <summary>
        /// Gets or sets reflexiveIPAddress.
        /// IP address of the media endpoint as seen by the media relay server. This is typically the public internet IP address associated to the endpoint.
        /// </summary>
        [JsonPropertyName("reflexiveIPAddress")]
        public string ReflexiveIPAddress { get; set; }
    
        /// <summary>
        /// Gets or sets relayIPAddress.
        /// IP address of the media relay server allocated by the media endpoint.
        /// </summary>
        [JsonPropertyName("relayIPAddress")]
        public string RelayIPAddress { get; set; }
    
        /// <summary>
        /// Gets or sets relayPort.
        /// Network port number allocated on the media relay server by the media endpoint.
        /// </summary>
        [JsonPropertyName("relayPort")]
        public Int32? RelayPort { get; set; }
    
        /// <summary>
        /// Gets or sets sentQualityEventRatio.
        /// Fraction of the call that the media endpoint detected the network was causing poor quality of the audio sent.
        /// </summary>
        [JsonPropertyName("sentQualityEventRatio")]
        public Single? SentQualityEventRatio { get; set; }
    
        /// <summary>
        /// Gets or sets subnet.
        /// Subnet used for media stream by the media endpoint.
        /// </summary>
        [JsonPropertyName("subnet")]
        public string Subnet { get; set; }
    
        /// <summary>
        /// Gets or sets wifiBand.
        /// WiFi band used by the media endpoint. Possible values are: unknown, frequency24GHz, frequency50GHz, frequency60GHz, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("wifiBand")]
        public WifiBand? WifiBand { get; set; }
    
        /// <summary>
        /// Gets or sets wifiBatteryCharge.
        /// Estimated remaining battery charge in percentage reported by the media endpoint.
        /// </summary>
        [JsonPropertyName("wifiBatteryCharge")]
        public Int32? WifiBatteryCharge { get; set; }
    
        /// <summary>
        /// Gets or sets wifiChannel.
        /// WiFi channel used by the media endpoint.
        /// </summary>
        [JsonPropertyName("wifiChannel")]
        public Int32? WifiChannel { get; set; }
    
        /// <summary>
        /// Gets or sets wifiMicrosoftDriver.
        /// Name of the Microsoft WiFi driver used by the media endpoint. Value may be localized based on the language used by endpoint.
        /// </summary>
        [JsonPropertyName("wifiMicrosoftDriver")]
        public string WifiMicrosoftDriver { get; set; }
    
        /// <summary>
        /// Gets or sets wifiMicrosoftDriverVersion.
        /// Version of the Microsoft WiFi driver used by the media endpoint.
        /// </summary>
        [JsonPropertyName("wifiMicrosoftDriverVersion")]
        public string WifiMicrosoftDriverVersion { get; set; }
    
        /// <summary>
        /// Gets or sets wifiRadioType.
        /// Type of WiFi radio used by the media endpoint. Possible values are: unknown, wifi80211a, wifi80211b, wifi80211g, wifi80211n, wifi80211ac, wifi80211ax, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("wifiRadioType")]
        public WifiRadioType? WifiRadioType { get; set; }
    
        /// <summary>
        /// Gets or sets wifiSignalStrength.
        /// WiFi signal strength in percentage reported by the media endpoint.
        /// </summary>
        [JsonPropertyName("wifiSignalStrength")]
        public Int32? WifiSignalStrength { get; set; }
    
        /// <summary>
        /// Gets or sets wifiVendorDriver.
        /// Name of the WiFi driver used by the media endpoint. Value may be localized based on the language used by endpoint.
        /// </summary>
        [JsonPropertyName("wifiVendorDriver")]
        public string WifiVendorDriver { get; set; }
    
        /// <summary>
        /// Gets or sets wifiVendorDriverVersion.
        /// Version of the WiFi driver used by the media endpoint.
        /// </summary>
        [JsonPropertyName("wifiVendorDriverVersion")]
        public string WifiVendorDriverVersion { get; set; }
    
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