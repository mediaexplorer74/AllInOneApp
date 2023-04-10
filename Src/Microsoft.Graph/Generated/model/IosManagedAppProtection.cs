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
    /// The type Ios Managed App Protection.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<IosManagedAppProtection>))]
    public partial class IosManagedAppProtection : TargetedManagedAppProtection
    {
    
        ///<summary>
        /// The IosManagedAppProtection constructor
        ///</summary>
        public IosManagedAppProtection()
        {
            this.ODataType = "microsoft.graph.iosManagedAppProtection";
        }

        /// <summary>
        /// Gets or sets app data encryption type.
        /// Type of encryption which should be used for data in a managed app. Possible values are: useDeviceSettings, afterDeviceRestart, whenDeviceLockedExceptOpenFiles, whenDeviceLocked.
        /// </summary>
        [JsonPropertyName("appDataEncryptionType")]
        public ManagedAppDataEncryptionType? AppDataEncryptionType { get; set; }
    
        /// <summary>
        /// Gets or sets custom browser protocol.
        /// A custom browser protocol to open weblink on iOS.
        /// </summary>
        [JsonPropertyName("customBrowserProtocol")]
        public string CustomBrowserProtocol { get; set; }
    
        /// <summary>
        /// Gets or sets deployed app count.
        /// Count of apps to which the current policy is deployed.
        /// </summary>
        [JsonPropertyName("deployedAppCount")]
        public Int32? DeployedAppCount { get; set; }
    
        /// <summary>
        /// Gets or sets face id blocked.
        /// Indicates whether use of the FaceID is allowed in place of a pin if PinRequired is set to True.
        /// </summary>
        [JsonPropertyName("faceIdBlocked")]
        public bool? FaceIdBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets minimum required sdk version.
        /// Versions less than the specified version will block the managed app from accessing company data.
        /// </summary>
        [JsonPropertyName("minimumRequiredSdkVersion")]
        public string MinimumRequiredSdkVersion { get; set; }
    
        /// <summary>
        /// Gets or sets apps.
        /// List of apps to which the policy is deployed.
        /// </summary>
        [JsonPropertyName("apps")]
        public IIosManagedAppProtectionAppsCollectionPage Apps { get; set; }

        /// <summary>
        /// Gets or sets appsNextLink.
        /// </summary>
        [JsonPropertyName("apps@odata.nextLink")]
        public string AppsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets deployment summary.
        /// Navigation property to deployment summary of the configuration.
        /// </summary>
        [JsonPropertyName("deploymentSummary")]
        public ManagedAppPolicyDeploymentSummary DeploymentSummary { get; set; }
    
    }
}
