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
    /// The type Mobile App Content File.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MobileAppContentFile>))]
    public partial class MobileAppContentFile : Entity
    {
    
        /// <summary>
        /// Gets or sets azure storage uri.
        /// The Azure Storage URI.
        /// </summary>
        [JsonPropertyName("azureStorageUri")]
        public string AzureStorageUri { get; set; }
    
        /// <summary>
        /// Gets or sets azure storage uri expiration date time.
        /// The time the Azure storage Uri expires.
        /// </summary>
        [JsonPropertyName("azureStorageUriExpirationDateTime")]
        public DateTimeOffset? AzureStorageUriExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The time the file was created.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets is committed.
        /// A value indicating whether the file is committed.
        /// </summary>
        [JsonPropertyName("isCommitted")]
        public bool? IsCommitted { get; set; }
    
        /// <summary>
        /// Gets or sets manifest.
        /// The manifest information.
        /// </summary>
        [JsonPropertyName("manifest")]
        public byte[] Manifest { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// the file name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets size.
        /// The size of the file prior to encryption.
        /// </summary>
        [JsonPropertyName("size")]
        public Int64? Size { get; set; }
    
        /// <summary>
        /// Gets or sets size encrypted.
        /// The size of the file after encryption.
        /// </summary>
        [JsonPropertyName("sizeEncrypted")]
        public Int64? SizeEncrypted { get; set; }
    
        /// <summary>
        /// Gets or sets upload state.
        /// The state of the current upload request. Possible values are: success, transientError, error, unknown, azureStorageUriRequestSuccess, azureStorageUriRequestPending, azureStorageUriRequestFailed, azureStorageUriRequestTimedOut, azureStorageUriRenewalSuccess, azureStorageUriRenewalPending, azureStorageUriRenewalFailed, azureStorageUriRenewalTimedOut, commitFileSuccess, commitFilePending, commitFileFailed, commitFileTimedOut.
        /// </summary>
        [JsonPropertyName("uploadState")]
        public MobileAppContentFileUploadState? UploadState { get; set; }
    
    }
}
