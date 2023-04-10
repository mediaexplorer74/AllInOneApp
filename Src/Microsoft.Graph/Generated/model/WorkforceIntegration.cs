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
    /// The type Workforce Integration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<WorkforceIntegration>))]
    public partial class WorkforceIntegration : ChangeTrackedEntity
    {
    
        ///<summary>
        /// The WorkforceIntegration constructor
        ///</summary>
        public WorkforceIntegration()
        {
            this.ODataType = "microsoft.graph.workforceIntegration";
        }

        /// <summary>
        /// Gets or sets api version.
        /// API version for the call back URL. Start with 1.
        /// </summary>
        [JsonPropertyName("apiVersion")]
        public Int32? ApiVersion { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Name of the workforce integration.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets encryption.
        /// The workforce integration encryption resource.
        /// </summary>
        [JsonPropertyName("encryption")]
        public WorkforceIntegrationEncryption Encryption { get; set; }
    
        /// <summary>
        /// Gets or sets is active.
        /// Indicates whether this workforce integration is currently active and available.
        /// </summary>
        [JsonPropertyName("isActive")]
        public bool? IsActive { get; set; }
    
        /// <summary>
        /// Gets or sets supported entities.
        /// This property will replace supports in v1.0. We recommend that you use this property instead of supports. The supports property will still be supported in beta for the time being. Possible values are none, shift, swapRequest, openshift, openShiftRequest, userShiftPreferences, offerShiftRequest, timeCard, timeOffReason, timeOff, timeOffRequest and unknownFutureValue. If selecting more than one value, all values must start with the first letter in uppercase.
        /// </summary>
        [JsonPropertyName("supportedEntities")]
        public WorkforceIntegrationSupportedEntities? SupportedEntities { get; set; }
    
        /// <summary>
        /// Gets or sets url.
        /// Workforce Integration URL for callbacks from the Shifts service.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    }
}
