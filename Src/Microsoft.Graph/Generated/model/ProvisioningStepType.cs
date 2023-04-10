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
    /// The enum ProvisioningStepType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ProvisioningStepType
    {
    
        /// <summary>
        /// Import
        /// </summary>
        Import = 0,
	
        /// <summary>
        /// Scoping
        /// </summary>
        Scoping = 1,
	
        /// <summary>
        /// Matching
        /// </summary>
        Matching = 2,
	
        /// <summary>
        /// Processing
        /// </summary>
        Processing = 3,
	
        /// <summary>
        /// Reference Resolution
        /// </summary>
        ReferenceResolution = 4,
	
        /// <summary>
        /// Export
        /// </summary>
        Export = 5,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 6,
	
    }
}
