// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type OnenoteSectionCopyToNotebookRequestBody.
    /// </summary>
    public partial class OnenoteSectionCopyToNotebookRequestBody
    {
    
        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or sets GroupId.
        /// </summary>
        [JsonPropertyName("groupId")]
        public string GroupId { get; set; }
    
        /// <summary>
        /// Gets or sets RenameAs.
        /// </summary>
        [JsonPropertyName("renameAs")]
        public string RenameAs { get; set; }
    
        /// <summary>
        /// Gets or sets SiteCollectionId.
        /// </summary>
        [JsonPropertyName("siteCollectionId")]
        public string SiteCollectionId { get; set; }
    
        /// <summary>
        /// Gets or sets SiteId.
        /// </summary>
        [JsonPropertyName("siteId")]
        public string SiteId { get; set; }
    
    }
}
