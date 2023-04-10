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
    /// The type TargetedManagedAppConfigurationRequest.
    /// </summary>
    public partial class TargetedManagedAppConfigurationRequest : BaseRequest, ITargetedManagedAppConfigurationRequest
    {
        /// <summary>
        /// Constructs a new TargetedManagedAppConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public TargetedManagedAppConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified TargetedManagedAppConfiguration using POST.
        /// </summary>
        /// <param name="targetedManagedAppConfigurationToCreate">The TargetedManagedAppConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TargetedManagedAppConfiguration.</returns>
        public async System.Threading.Tasks.Task<TargetedManagedAppConfiguration> CreateAsync(TargetedManagedAppConfiguration targetedManagedAppConfigurationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<TargetedManagedAppConfiguration>(targetedManagedAppConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified TargetedManagedAppConfiguration using POST and returns a <see cref="GraphResponse{TargetedManagedAppConfiguration}"/> object.
        /// </summary>
        /// <param name="targetedManagedAppConfigurationToCreate">The TargetedManagedAppConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TargetedManagedAppConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TargetedManagedAppConfiguration>> CreateResponseAsync(TargetedManagedAppConfiguration targetedManagedAppConfigurationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<TargetedManagedAppConfiguration>(targetedManagedAppConfigurationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified TargetedManagedAppConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<TargetedManagedAppConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified TargetedManagedAppConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified TargetedManagedAppConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TargetedManagedAppConfiguration.</returns>
        public async System.Threading.Tasks.Task<TargetedManagedAppConfiguration> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<TargetedManagedAppConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified TargetedManagedAppConfiguration and returns a <see cref="GraphResponse{TargetedManagedAppConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TargetedManagedAppConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TargetedManagedAppConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<TargetedManagedAppConfiguration>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified TargetedManagedAppConfiguration using PATCH.
        /// </summary>
        /// <param name="targetedManagedAppConfigurationToUpdate">The TargetedManagedAppConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TargetedManagedAppConfiguration.</returns>
        public async System.Threading.Tasks.Task<TargetedManagedAppConfiguration> UpdateAsync(TargetedManagedAppConfiguration targetedManagedAppConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<TargetedManagedAppConfiguration>(targetedManagedAppConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified TargetedManagedAppConfiguration using PATCH and returns a <see cref="GraphResponse{TargetedManagedAppConfiguration}"/> object.
        /// </summary>
        /// <param name="targetedManagedAppConfigurationToUpdate">The TargetedManagedAppConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TargetedManagedAppConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TargetedManagedAppConfiguration>> UpdateResponseAsync(TargetedManagedAppConfiguration targetedManagedAppConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<TargetedManagedAppConfiguration>(targetedManagedAppConfigurationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified TargetedManagedAppConfiguration using PUT.
        /// </summary>
        /// <param name="targetedManagedAppConfigurationToUpdate">The TargetedManagedAppConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<TargetedManagedAppConfiguration> PutAsync(TargetedManagedAppConfiguration targetedManagedAppConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<TargetedManagedAppConfiguration>(targetedManagedAppConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified TargetedManagedAppConfiguration using PUT and returns a <see cref="GraphResponse{TargetedManagedAppConfiguration}"/> object.
        /// </summary>
        /// <param name="targetedManagedAppConfigurationToUpdate">The TargetedManagedAppConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{TargetedManagedAppConfiguration}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TargetedManagedAppConfiguration>> PutResponseAsync(TargetedManagedAppConfiguration targetedManagedAppConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<TargetedManagedAppConfiguration>(targetedManagedAppConfigurationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITargetedManagedAppConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITargetedManagedAppConfigurationRequest Expand(Expression<Func<TargetedManagedAppConfiguration, object>> expandExpression)
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
        public ITargetedManagedAppConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ITargetedManagedAppConfigurationRequest Select(Expression<Func<TargetedManagedAppConfiguration, object>> selectExpression)
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
        /// <param name="targetedManagedAppConfigurationToInitialize">The <see cref="TargetedManagedAppConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(TargetedManagedAppConfiguration targetedManagedAppConfigurationToInitialize)
        {

            if (targetedManagedAppConfigurationToInitialize != null)
            {
                if (targetedManagedAppConfigurationToInitialize.Apps != null && targetedManagedAppConfigurationToInitialize.Apps.CurrentPage != null)
                {
                    targetedManagedAppConfigurationToInitialize.Apps.InitializeNextPageRequest(this.Client, targetedManagedAppConfigurationToInitialize.AppsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    targetedManagedAppConfigurationToInitialize.Apps.AdditionalData = targetedManagedAppConfigurationToInitialize.AdditionalData;
                }
                if (targetedManagedAppConfigurationToInitialize.Assignments != null && targetedManagedAppConfigurationToInitialize.Assignments.CurrentPage != null)
                {
                    targetedManagedAppConfigurationToInitialize.Assignments.InitializeNextPageRequest(this.Client, targetedManagedAppConfigurationToInitialize.AssignmentsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    targetedManagedAppConfigurationToInitialize.Assignments.AdditionalData = targetedManagedAppConfigurationToInitialize.AdditionalData;
                }

            }


        }
    }
}