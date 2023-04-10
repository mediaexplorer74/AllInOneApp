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
    /// The type Device Compliance Setting State.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DeviceComplianceSettingState>))]
    public partial class DeviceComplianceSettingState : Entity
    {
    
        /// <summary>
        /// Gets or sets compliance grace period expiration date time.
        /// The DateTime when device compliance grace period expires
        /// </summary>
        [JsonPropertyName("complianceGracePeriodExpirationDateTime")]
        public DateTimeOffset? ComplianceGracePeriodExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets device id.
        /// The Device Id that is being reported
        /// </summary>
        [JsonPropertyName("deviceId")]
        public string DeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets device model.
        /// The device model that is being reported
        /// </summary>
        [JsonPropertyName("deviceModel")]
        public string DeviceModel { get; set; }
    
        /// <summary>
        /// Gets or sets device name.
        /// The Device Name that is being reported
        /// </summary>
        [JsonPropertyName("deviceName")]
        public string DeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets setting.
        /// The setting class name and property name.
        /// </summary>
        [JsonPropertyName("setting")]
        public string Setting { get; set; }
    
        /// <summary>
        /// Gets or sets setting name.
        /// The Setting Name that is being reported
        /// </summary>
        [JsonPropertyName("settingName")]
        public string SettingName { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// The compliance state of the setting. Possible values are: unknown, notApplicable, compliant, remediated, nonCompliant, error, conflict, notAssigned.
        /// </summary>
        [JsonPropertyName("state")]
        public ComplianceStatus? State { get; set; }
    
        /// <summary>
        /// Gets or sets user email.
        /// The User email address that is being reported
        /// </summary>
        [JsonPropertyName("userEmail")]
        public string UserEmail { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// The user Id that is being reported
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets user name.
        /// The User Name that is being reported
        /// </summary>
        [JsonPropertyName("userName")]
        public string UserName { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// The User PrincipalName that is being reported
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
    }
}
