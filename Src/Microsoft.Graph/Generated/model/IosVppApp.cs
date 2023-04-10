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
    /// The type Ios Vpp App.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<IosVppApp>))]
    public partial class IosVppApp : MobileApp
    {
    
        ///<summary>
        /// The IosVppApp constructor
        ///</summary>
        public IosVppApp()
        {
            this.ODataType = "microsoft.graph.iosVppApp";
        }

        /// <summary>
        /// Gets or sets applicable device type.
        /// The applicable iOS Device Type.
        /// </summary>
        [JsonPropertyName("applicableDeviceType")]
        public IosDeviceType ApplicableDeviceType { get; set; }
    
        /// <summary>
        /// Gets or sets app store url.
        /// The store URL.
        /// </summary>
        [JsonPropertyName("appStoreUrl")]
        public string AppStoreUrl { get; set; }
    
        /// <summary>
        /// Gets or sets bundle id.
        /// The Identity Name.
        /// </summary>
        [JsonPropertyName("bundleId")]
        public string BundleId { get; set; }
    
        /// <summary>
        /// Gets or sets licensing type.
        /// The supported License Type.
        /// </summary>
        [JsonPropertyName("licensingType")]
        public VppLicensingType LicensingType { get; set; }
    
        /// <summary>
        /// Gets or sets release date time.
        /// The VPP application release date and time.
        /// </summary>
        [JsonPropertyName("releaseDateTime")]
        public DateTimeOffset? ReleaseDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets total license count.
        /// The total number of VPP licenses.
        /// </summary>
        [JsonPropertyName("totalLicenseCount")]
        public Int32? TotalLicenseCount { get; set; }
    
        /// <summary>
        /// Gets or sets used license count.
        /// The number of VPP licenses in use.
        /// </summary>
        [JsonPropertyName("usedLicenseCount")]
        public Int32? UsedLicenseCount { get; set; }
    
        /// <summary>
        /// Gets or sets vpp token account type.
        /// The type of volume purchase program which the given Apple Volume Purchase Program Token is associated with. Possible values are: business, education. Possible values are: business, education.
        /// </summary>
        [JsonPropertyName("vppTokenAccountType")]
        public VppTokenAccountType? VppTokenAccountType { get; set; }
    
        /// <summary>
        /// Gets or sets vpp token apple id.
        /// The Apple Id associated with the given Apple Volume Purchase Program Token.
        /// </summary>
        [JsonPropertyName("vppTokenAppleId")]
        public string VppTokenAppleId { get; set; }
    
        /// <summary>
        /// Gets or sets vpp token organization name.
        /// The organization associated with the Apple Volume Purchase Program Token
        /// </summary>
        [JsonPropertyName("vppTokenOrganizationName")]
        public string VppTokenOrganizationName { get; set; }
    
    }
}
