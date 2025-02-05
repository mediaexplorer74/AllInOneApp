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
    /// The type DeviceInfo.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<DeviceInfo>))]
    public partial class DeviceInfo
    {

        /// <summary>
        /// Gets or sets captureDeviceDriver.
        /// Name of the capture device driver used by the media endpoint.
        /// </summary>
        [JsonPropertyName("captureDeviceDriver")]
        public string CaptureDeviceDriver { get; set; }
    
        /// <summary>
        /// Gets or sets captureDeviceName.
        /// Name of the capture device used by the media endpoint.
        /// </summary>
        [JsonPropertyName("captureDeviceName")]
        public string CaptureDeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets captureNotFunctioningEventRatio.
        /// Fraction of the call that the media endpoint detected the capture device was not working properly.
        /// </summary>
        [JsonPropertyName("captureNotFunctioningEventRatio")]
        public Single? CaptureNotFunctioningEventRatio { get; set; }
    
        /// <summary>
        /// Gets or sets cpuInsufficentEventRatio.
        /// Fraction of the call that the media endpoint detected the CPU resources available were insufficient and caused poor quality of the audio sent and received.
        /// </summary>
        [JsonPropertyName("cpuInsufficentEventRatio")]
        public Single? CpuInsufficentEventRatio { get; set; }
    
        /// <summary>
        /// Gets or sets deviceClippingEventRatio.
        /// Fraction of the call that the media endpoint detected clipping in the captured audio that caused poor quality of the audio being sent.
        /// </summary>
        [JsonPropertyName("deviceClippingEventRatio")]
        public Single? DeviceClippingEventRatio { get; set; }
    
        /// <summary>
        /// Gets or sets deviceGlitchEventRatio.
        /// Fraction of the call that the media endpoint detected glitches or gaps in the audio played or captured that caused poor quality of the audio being sent or received.
        /// </summary>
        [JsonPropertyName("deviceGlitchEventRatio")]
        public Single? DeviceGlitchEventRatio { get; set; }
    
        /// <summary>
        /// Gets or sets howlingEventCount.
        /// Number of times during the call that the media endpoint detected howling or screeching audio.
        /// </summary>
        [JsonPropertyName("howlingEventCount")]
        public Int32? HowlingEventCount { get; set; }
    
        /// <summary>
        /// Gets or sets initialSignalLevelRootMeanSquare.
        /// The root mean square (RMS) of the incoming signal of up to the first 30 seconds of the call.
        /// </summary>
        [JsonPropertyName("initialSignalLevelRootMeanSquare")]
        public Single? InitialSignalLevelRootMeanSquare { get; set; }
    
        /// <summary>
        /// Gets or sets lowSpeechLevelEventRatio.
        /// Fraction of the call that the media endpoint detected low speech level that caused poor quality of the audio being sent.
        /// </summary>
        [JsonPropertyName("lowSpeechLevelEventRatio")]
        public Single? LowSpeechLevelEventRatio { get; set; }
    
        /// <summary>
        /// Gets or sets lowSpeechToNoiseEventRatio.
        /// Fraction of the call that the media endpoint detected low speech to noise level that caused poor quality of the audio being sent.
        /// </summary>
        [JsonPropertyName("lowSpeechToNoiseEventRatio")]
        public Single? LowSpeechToNoiseEventRatio { get; set; }
    
        /// <summary>
        /// Gets or sets micGlitchRate.
        /// Glitches per 5 minute interval for the media endpoint's microphone.
        /// </summary>
        [JsonPropertyName("micGlitchRate")]
        public Single? MicGlitchRate { get; set; }
    
        /// <summary>
        /// Gets or sets receivedNoiseLevel.
        /// Average energy level of received audio for audio classified as mono noise or left channel of stereo noise by the media endpoint.
        /// </summary>
        [JsonPropertyName("receivedNoiseLevel")]
        public Int32? ReceivedNoiseLevel { get; set; }
    
        /// <summary>
        /// Gets or sets receivedSignalLevel.
        /// Average energy level of received audio for audio classified as mono speech, or left channel of stereo speech by the media endpoint.
        /// </summary>
        [JsonPropertyName("receivedSignalLevel")]
        public Int32? ReceivedSignalLevel { get; set; }
    
        /// <summary>
        /// Gets or sets renderDeviceDriver.
        /// Name of the render device driver used by the media endpoint.
        /// </summary>
        [JsonPropertyName("renderDeviceDriver")]
        public string RenderDeviceDriver { get; set; }
    
        /// <summary>
        /// Gets or sets renderDeviceName.
        /// Name of the render device used by the media endpoint.
        /// </summary>
        [JsonPropertyName("renderDeviceName")]
        public string RenderDeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets renderMuteEventRatio.
        /// Fraction of the call that media endpoint detected device render is muted.
        /// </summary>
        [JsonPropertyName("renderMuteEventRatio")]
        public Single? RenderMuteEventRatio { get; set; }
    
        /// <summary>
        /// Gets or sets renderNotFunctioningEventRatio.
        /// Fraction of the call that the media endpoint detected the render device was not working properly.
        /// </summary>
        [JsonPropertyName("renderNotFunctioningEventRatio")]
        public Single? RenderNotFunctioningEventRatio { get; set; }
    
        /// <summary>
        /// Gets or sets renderZeroVolumeEventRatio.
        /// Fraction of the call that media endpoint detected device render volume is set to 0.
        /// </summary>
        [JsonPropertyName("renderZeroVolumeEventRatio")]
        public Single? RenderZeroVolumeEventRatio { get; set; }
    
        /// <summary>
        /// Gets or sets sentNoiseLevel.
        /// Average energy level of sent audio for audio classified as mono noise or left channel of stereo noise by the media endpoint.
        /// </summary>
        [JsonPropertyName("sentNoiseLevel")]
        public Int32? SentNoiseLevel { get; set; }
    
        /// <summary>
        /// Gets or sets sentSignalLevel.
        /// Average energy level of sent audio for audio classified as mono speech, or left channel of stereo speech by the media endpoint.
        /// </summary>
        [JsonPropertyName("sentSignalLevel")]
        public Int32? SentSignalLevel { get; set; }
    
        /// <summary>
        /// Gets or sets speakerGlitchRate.
        /// Glitches per 5 minute internal for the media endpoint's loudspeaker.
        /// </summary>
        [JsonPropertyName("speakerGlitchRate")]
        public Single? SpeakerGlitchRate { get; set; }
    
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
