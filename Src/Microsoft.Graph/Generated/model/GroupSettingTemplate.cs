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
    /// The type Group Setting Template.
    /// </summary>
    public partial class GroupSettingTemplate : DirectoryObject
    {
    
        ///<summary>
        /// The GroupSettingTemplate constructor
        ///</summary>
        public GroupSettingTemplate()
        {
            this.ODataType = "microsoft.graph.groupSettingTemplate";
        }

        /// <summary>
        /// Gets or sets description.
        /// Description of the template.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Display name of the template.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets values.
        /// Collection of settingTemplateValues that list the set of available settings, defaults and types that make up this template.
        /// </summary>
        [JsonPropertyName("values")]
        public IEnumerable<SettingTemplateValue> Values { get; set; }
    
    }
}
