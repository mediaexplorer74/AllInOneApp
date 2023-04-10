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
    /// The type ListInfo.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ListInfo>))]
    public partial class ListInfo
    {

        /// <summary>
        /// Gets or sets contentTypesEnabled.
        /// If true, indicates that content types are enabled for this list.
        /// </summary>
        [JsonPropertyName("contentTypesEnabled")]
        public bool? ContentTypesEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets hidden.
        /// If true, indicates that the list is not normally visible in the SharePoint user experience.
        /// </summary>
        [JsonPropertyName("hidden")]
        public bool? Hidden { get; set; }
    
        /// <summary>
        /// Gets or sets template.
        /// An enumerated value that represents the base list template used in creating the list. Possible values include documentLibrary, genericList, task, survey, announcements, contacts, and more.
        /// </summary>
        [JsonPropertyName("template")]
        public string Template { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}