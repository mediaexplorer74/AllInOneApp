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
    /// The type IosMobileAppIdentifier.
    /// </summary>
    public partial class IosMobileAppIdentifier : MobileAppIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IosMobileAppIdentifier"/> class.
        /// </summary>
        public IosMobileAppIdentifier()
        {
            this.ODataType = "microsoft.graph.iosMobileAppIdentifier";
        }

        /// <summary>
        /// Gets or sets bundleId.
        /// The identifier for an app, as specified in the app store.
        /// </summary>
        [JsonPropertyName("bundleId")]
        public string BundleId { get; set; }
    
    }
}