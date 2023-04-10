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
    /// The type Web App.
    /// </summary>
    public partial class WebApp : MobileApp
    {
    
        ///<summary>
        /// The WebApp constructor
        ///</summary>
        public WebApp()
        {
            this.ODataType = "microsoft.graph.webApp";
        }

        /// <summary>
        /// Gets or sets app url.
        /// The web app URL. This property cannot be PATCHed.
        /// </summary>
        [JsonPropertyName("appUrl")]
        public string AppUrl { get; set; }
    
        /// <summary>
        /// Gets or sets use managed browser.
        /// Whether or not to use managed browser. This property is only applicable for Android and IOS.
        /// </summary>
        [JsonPropertyName("useManagedBrowser")]
        public bool? UseManagedBrowser { get; set; }
    
    }
}
