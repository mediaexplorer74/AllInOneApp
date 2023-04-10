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
    /// The enum DiagnosticDataSubmissionMode.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DiagnosticDataSubmissionMode
    {
    
        /// <summary>
        /// User Defined
        /// </summary>
        UserDefined = 0,
	
        /// <summary>
        /// None
        /// </summary>
        None = 1,
	
        /// <summary>
        /// Basic
        /// </summary>
        Basic = 2,
	
        /// <summary>
        /// Enhanced
        /// </summary>
        Enhanced = 3,
	
        /// <summary>
        /// Full
        /// </summary>
        Full = 4,
	
    }
}