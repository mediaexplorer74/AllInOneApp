// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum AttachmentType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AttachmentType
    {
    
        /// <summary>
        /// File
        /// </summary>
        File = 0,
	
        /// <summary>
        /// Item
        /// </summary>
        Item = 1,
	
        /// <summary>
        /// Reference
        /// </summary>
        Reference = 2,
	
    }
}
