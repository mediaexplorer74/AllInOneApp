// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type ManagedDeviceMobileAppConfigurationRequest.
    /// </summary>
    public partial class ManagedDeviceMobileAppConfigurationRequest : BaseRequest, IManagedDeviceMobileAppConfigurationRequest
    {
        /// <summary>
        /// Constructs a new ManagedDeviceMobileAppConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ManagedDeviceMobileAppConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ManagedDeviceMobileAppConfiguration using POST.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationToCreate">The ManagedDeviceMobileAppConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedDeviceMobileAppConfiguration.</returns>
        public async System.Threading.Tasks.Task<ManagedDeviceMobileAppConfiguration> CreateAsync(ManagedDeviceMobileAppConfiguration managedDeviceMobileAppConfigurationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<ManagedDeviceMobileAppConfiguration>(managedDeviceMobileAppConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified ManagedDeviceMobileAppConfiguration using POST and returns a <see cref="GraphResponse{ManagedDeviceMobileAppConfiguration}"/> object.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationToCreate">The ManagedDeviceMobileAppConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceMobileAppConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagedDeviceMobileAppConfiguration>> CreateResponseAsync(ManagedDeviceMobileAppConfiguration managedDeviceMobileAppConfigurationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<ManagedDeviceMobileAppConfiguration>(managedDeviceMobileAppConfigurationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified ManagedDeviceMobileAppConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<ManagedDeviceMobileAppConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ManagedDeviceMobileAppConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified ManagedDeviceMobileAppConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedDeviceMobileAppConfiguration.</returns>
        public async System.Threading.Tasks.Task<ManagedDeviceMobileAppConfiguration> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<ManagedDeviceMobileAppConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ManagedDeviceMobileAppConfiguration and returns a <see cref="GraphResponse{ManagedDeviceMobileAppConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceMobileAppConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagedDeviceMobileAppConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<ManagedDeviceMobileAppConfiguration>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ManagedDeviceMobileAppConfiguration using PATCH.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationToUpdate">The ManagedDeviceMobileAppConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedDeviceMobileAppConfiguration.</returns>
        public async System.Threading.Tasks.Task<ManagedDeviceMobileAppConfiguration> UpdateAsync(ManagedDeviceMobileAppConfiguration managedDeviceMobileAppConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<ManagedDeviceMobileAppConfiguration>(managedDeviceMobileAppConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ManagedDeviceMobileAppConfiguration using PATCH and returns a <see cref="GraphResponse{ManagedDeviceMobileAppConfiguration}"/> object.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationToUpdate">The ManagedDeviceMobileAppConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceMobileAppConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagedDeviceMobileAppConfiguration>> UpdateResponseAsync(ManagedDeviceMobileAppConfiguration managedDeviceMobileAppConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<ManagedDeviceMobileAppConfiguration>(managedDeviceMobileAppConfigurationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ManagedDeviceMobileAppConfiguration using PUT.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationToUpdate">The ManagedDeviceMobileAppConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<ManagedDeviceMobileAppConfiguration> PutAsync(ManagedDeviceMobileAppConfiguration managedDeviceMobileAppConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<ManagedDeviceMobileAppConfiguration>(managedDeviceMobileAppConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ManagedDeviceMobileAppConfiguration using PUT and returns a <see cref="GraphResponse{ManagedDeviceMobileAppConfiguration}"/> object.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationToUpdate">The ManagedDeviceMobileAppConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{ManagedDeviceMobileAppConfiguration}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagedDeviceMobileAppConfiguration>> PutResponseAsync(ManagedDeviceMobileAppConfiguration managedDeviceMobileAppConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<ManagedDeviceMobileAppConfiguration>(managedDeviceMobileAppConfigurationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedDeviceMobileAppConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedDeviceMobileAppConfigurationRequest Expand(Expression<Func<ManagedDeviceMobileAppConfiguration, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedDeviceMobileAppConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedDeviceMobileAppConfigurationRequest Select(Expression<Func<ManagedDeviceMobileAppConfiguration, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationToInitialize">The <see cref="ManagedDeviceMobileAppConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ManagedDeviceMobileAppConfiguration managedDeviceMobileAppConfigurationToInitialize)
        {

            if (managedDeviceMobileAppConfigurationToInitialize != null)
            {
                if (managedDeviceMobileAppConfigurationToInitialize.Assignments != null && managedDeviceMobileAppConfigurationToInitialize.Assignments.CurrentPage != null)
                {
                    managedDeviceMobileAppConfigurationToInitialize.Assignments.InitializeNextPageRequest(this.Client, managedDeviceMobileAppConfigurationToInitialize.AssignmentsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    managedDeviceMobileAppConfigurationToInitialize.Assignments.AdditionalData = managedDeviceMobileAppConfigurationToInitialize.AdditionalData;
                }
                if (managedDeviceMobileAppConfigurationToInitialize.DeviceStatuses != null && managedDeviceMobileAppConfigurationToInitialize.DeviceStatuses.CurrentPage != null)
                {
                    managedDeviceMobileAppConfigurationToInitialize.DeviceStatuses.InitializeNextPageRequest(this.Client, managedDeviceMobileAppConfigurationToInitialize.DeviceStatusesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    managedDeviceMobileAppConfigurationToInitialize.DeviceStatuses.AdditionalData = managedDeviceMobileAppConfigurationToInitialize.AdditionalData;
                }
                if (managedDeviceMobileAppConfigurationToInitialize.UserStatuses != null && managedDeviceMobileAppConfigurationToInitialize.UserStatuses.CurrentPage != null)
                {
                    managedDeviceMobileAppConfigurationToInitialize.UserStatuses.InitializeNextPageRequest(this.Client, managedDeviceMobileAppConfigurationToInitialize.UserStatusesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    managedDeviceMobileAppConfigurationToInitialize.UserStatuses.AdditionalData = managedDeviceMobileAppConfigurationToInitialize.AdditionalData;
                }

            }


        }
    }
}