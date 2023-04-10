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
    /// The enum EducationGender.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EducationGender
    {
    
        /// <summary>
        /// Female
        /// </summary>
        Female = 0,
	
        /// <summary>
        /// Male
        /// </summary>
        Male = 1,
	
        /// <summary>
        /// Other
        /// </summary>
        Other = 2,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 3,
	
    }
}