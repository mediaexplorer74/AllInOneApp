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
    /// The type Fido2KeyRestrictions.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Fido2KeyRestrictions>))]
    public partial class Fido2KeyRestrictions
    {

        /// <summary>
        /// Gets or sets aaGuids.
        /// A collection of Authenticator Attestation GUIDs. AADGUIDs define key types and manufacturers.
        /// </summary>
        [JsonPropertyName("aaGuids")]
        public IEnumerable<string> AaGuids { get; set; }
    
        /// <summary>
        /// Gets or sets enforcementType.
        /// Enforcement type. Possible values are: allow, block.
        /// </summary>
        [JsonPropertyName("enforcementType")]
        public Fido2RestrictionEnforcementType? EnforcementType { get; set; }
    
        /// <summary>
        /// Gets or sets isEnforced.
        /// Determines if the configured key enforcement is enabled.
        /// </summary>
        [JsonPropertyName("isEnforced")]
        public bool? IsEnforced { get; set; }
    
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