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
    /// The type Approval.
    /// </summary>
    public partial class Approval : Entity
    {
    
        /// <summary>
        /// Gets or sets stages.
        /// Used for the approvalStages property of approval settings in the requestApprovalSettings property of an access package assignment policy. Specifies the primary, fallback, and escalation approvers of each stage.
        /// </summary>
        [JsonPropertyName("stages")]
        public IApprovalStagesCollectionPage Stages { get; set; }

        /// <summary>
        /// Gets or sets stagesNextLink.
        /// </summary>
        [JsonPropertyName("stages@odata.nextLink")]
        public string StagesNextLink { get; set; }
    
    }
}

