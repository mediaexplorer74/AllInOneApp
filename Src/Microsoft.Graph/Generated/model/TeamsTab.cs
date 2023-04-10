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
    /// The type Teams Tab.
    /// </summary>
    public partial class TeamsTab : Entity
    {
    
        /// <summary>
        /// Gets or sets configuration.
        /// Container for custom settings applied to a tab. The tab is considered configured only once this property is set.
        /// </summary>
        [JsonPropertyName("configuration")]
        public TeamsTabConfiguration Configuration { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Name of the tab.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets web url.
        /// Deep link URL of the tab instance. Read only.
        /// </summary>
        [JsonPropertyName("webUrl")]
        public string WebUrl { get; set; }
    
        /// <summary>
        /// Gets or sets teams app.
        /// The application that is linked to the tab.
        /// </summary>
        [JsonPropertyName("teamsApp")]
        public TeamsApp TeamsApp { get; set; }
    
    }
}
