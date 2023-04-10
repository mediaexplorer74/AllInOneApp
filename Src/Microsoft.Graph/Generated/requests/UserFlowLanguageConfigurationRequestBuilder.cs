// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type UserFlowLanguageConfigurationRequestBuilder.
    /// </summary>
    public partial class UserFlowLanguageConfigurationRequestBuilder : EntityRequestBuilder, IUserFlowLanguageConfigurationRequestBuilder
    {

        /// <summary>
        /// Constructs a new UserFlowLanguageConfigurationRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public UserFlowLanguageConfigurationRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IUserFlowLanguageConfigurationRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IUserFlowLanguageConfigurationRequest Request(IEnumerable<Option> options)
        {
            return new UserFlowLanguageConfigurationRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for DefaultPages.
        /// </summary>
        /// <returns>The <see cref="IUserFlowLanguageConfigurationDefaultPagesCollectionRequestBuilder"/>.</returns>
        public IUserFlowLanguageConfigurationDefaultPagesCollectionRequestBuilder DefaultPages
        {
            get
            {
                return new UserFlowLanguageConfigurationDefaultPagesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("defaultPages"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for OverridesPages.
        /// </summary>
        /// <returns>The <see cref="IUserFlowLanguageConfigurationOverridesPagesCollectionRequestBuilder"/>.</returns>
        public IUserFlowLanguageConfigurationOverridesPagesCollectionRequestBuilder OverridesPages
        {
            get
            {
                return new UserFlowLanguageConfigurationOverridesPagesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("overridesPages"), this.Client);
            }
        }
    
    }
}
