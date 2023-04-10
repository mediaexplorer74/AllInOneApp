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
    /// The enum RiskLevel.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RiskLevel
    {
    
        /// <summary>
        /// Low
        /// </summary>
        Low = 0,
	
        /// <summary>
        /// Medium
        /// </summary>
        Medium = 1,
	
        /// <summary>
        /// High
        /// </summary>
        High = 2,
	
        /// <summary>
        /// Hidden
        /// </summary>
        Hidden = 3,
	
        /// <summary>
        /// None
        /// </summary>
        None = 4,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 5,
	
    }
}