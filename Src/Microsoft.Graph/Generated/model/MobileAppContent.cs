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
    /// The type Mobile App Content.
    /// </summary>
    public partial class MobileAppContent : Entity
    {
    
        /// <summary>
        /// Gets or sets files.
        /// The list of files for this app content version.
        /// </summary>
        [JsonPropertyName("files")]
        public IMobileAppContentFilesCollectionPage Files { get; set; }

        /// <summary>
        /// Gets or sets filesNextLink.
        /// </summary>
        [JsonPropertyName("files@odata.nextLink")]
        public string FilesNextLink { get; set; }
    
    }
}
