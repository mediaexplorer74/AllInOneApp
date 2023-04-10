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
    /// The type AppRole.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AppRole>))]
    public partial class AppRole
    {

        /// <summary>
        /// Gets or sets allowedMemberTypes.
        /// Specifies whether this app role can be assigned to users and groups (by setting to ['User']), to other application's (by setting to ['Application'], or both (by setting to ['User', 'Application']). App roles supporting assignment to other applications' service principals are also known as application permissions. The 'Application' value is only supported for app roles defined on application entities.
        /// </summary>
        [JsonPropertyName("allowedMemberTypes")]
        public IEnumerable<string> AllowedMemberTypes { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// The description for the app role. This is displayed when the app role is being assigned and, if the app role functions as an application permission, during  consent experiences.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets displayName.
        /// Display name for the permission that appears in the app role assignment and consent experiences.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets id.
        /// Unique role identifier inside the appRoles collection. When creating a new app role, a new Guid identifier must be provided.
        /// </summary>
        [JsonPropertyName("id")]
        public Guid? Id { get; set; }
    
        /// <summary>
        /// Gets or sets isEnabled.
        /// When creating or updating an app role, this must be set to true (which is the default). To delete a role, this must first be set to false.  At that point, in a subsequent call, this role may be removed.
        /// </summary>
        [JsonPropertyName("isEnabled")]
        public bool? IsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets origin.
        /// Specifies if the app role is defined on the application object or on the servicePrincipal entity. Must not be included in any POST or PATCH requests. Read-only.
        /// </summary>
        [JsonPropertyName("origin")]
        public string Origin { get; set; }
    
        /// <summary>
        /// Gets or sets value.
        /// Specifies the value to include in the roles claim in ID tokens and access tokens authenticating an assigned user or service principal. Must not exceed 120 characters in length. Allowed characters are : ! # $ % &amp; ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed. May not begin with ..
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    
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