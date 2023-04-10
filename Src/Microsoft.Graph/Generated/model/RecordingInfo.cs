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
    /// The type RecordingInfo.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<RecordingInfo>))]
    public partial class RecordingInfo
    {

        /// <summary>
        /// Gets or sets initiator.
        /// The identities of recording initiator.
        /// </summary>
        [JsonPropertyName("initiator")]
        public IdentitySet Initiator { get; set; }
    
        /// <summary>
        /// Gets or sets recordingStatus.
        /// Possible values are: unknown, notRecording, recording, or failed.
        /// </summary>
        [JsonPropertyName("recordingStatus")]
        public RecordingStatus? RecordingStatus { get; set; }
    
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