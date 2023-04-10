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
    /// The type CloudCommunicationsRequest.
    /// </summary>
    public partial class CloudCommunicationsRequest : BaseRequest, ICloudCommunicationsRequest
    {
        /// <summary>
        /// Constructs a new CloudCommunicationsRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public CloudCommunicationsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified CloudCommunications using POST.
        /// </summary>
        /// <param name="cloudCommunicationsToCreate">The CloudCommunications to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CloudCommunications.</returns>
        public async System.Threading.Tasks.Task<CloudCommunications> CreateAsync(CloudCommunications cloudCommunicationsToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<CloudCommunications>(cloudCommunicationsToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified CloudCommunications using POST and returns a <see cref="GraphResponse{CloudCommunications}"/> object.
        /// </summary>
        /// <param name="cloudCommunicationsToCreate">The CloudCommunications to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CloudCommunications}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CloudCommunications>> CreateResponseAsync(CloudCommunications cloudCommunicationsToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<CloudCommunications>(cloudCommunicationsToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified CloudCommunications.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<CloudCommunications>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified CloudCommunications and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified CloudCommunications.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CloudCommunications.</returns>
        public async System.Threading.Tasks.Task<CloudCommunications> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<CloudCommunications>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified CloudCommunications and returns a <see cref="GraphResponse{CloudCommunications}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CloudCommunications}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CloudCommunications>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<CloudCommunications>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified CloudCommunications using PATCH.
        /// </summary>
        /// <param name="cloudCommunicationsToUpdate">The CloudCommunications to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CloudCommunications.</returns>
        public async System.Threading.Tasks.Task<CloudCommunications> UpdateAsync(CloudCommunications cloudCommunicationsToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<CloudCommunications>(cloudCommunicationsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified CloudCommunications using PATCH and returns a <see cref="GraphResponse{CloudCommunications}"/> object.
        /// </summary>
        /// <param name="cloudCommunicationsToUpdate">The CloudCommunications to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{CloudCommunications}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CloudCommunications>> UpdateResponseAsync(CloudCommunications cloudCommunicationsToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<CloudCommunications>(cloudCommunicationsToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified CloudCommunications using PUT.
        /// </summary>
        /// <param name="cloudCommunicationsToUpdate">The CloudCommunications object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<CloudCommunications> PutAsync(CloudCommunications cloudCommunicationsToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<CloudCommunications>(cloudCommunicationsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified CloudCommunications using PUT and returns a <see cref="GraphResponse{CloudCommunications}"/> object.
        /// </summary>
        /// <param name="cloudCommunicationsToUpdate">The CloudCommunications object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{CloudCommunications}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CloudCommunications>> PutResponseAsync(CloudCommunications cloudCommunicationsToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<CloudCommunications>(cloudCommunicationsToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICloudCommunicationsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICloudCommunicationsRequest Expand(Expression<Func<CloudCommunications, object>> expandExpression)
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
        public ICloudCommunicationsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ICloudCommunicationsRequest Select(Expression<Func<CloudCommunications, object>> selectExpression)
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
        /// <param name="cloudCommunicationsToInitialize">The <see cref="CloudCommunications"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(CloudCommunications cloudCommunicationsToInitialize)
        {

            if (cloudCommunicationsToInitialize != null)
            {
                if (cloudCommunicationsToInitialize.Calls != null && cloudCommunicationsToInitialize.Calls.CurrentPage != null)
                {
                    cloudCommunicationsToInitialize.Calls.InitializeNextPageRequest(this.Client, cloudCommunicationsToInitialize.CallsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    cloudCommunicationsToInitialize.Calls.AdditionalData = cloudCommunicationsToInitialize.AdditionalData;
                }
                if (cloudCommunicationsToInitialize.CallRecords != null && cloudCommunicationsToInitialize.CallRecords.CurrentPage != null)
                {
                    cloudCommunicationsToInitialize.CallRecords.InitializeNextPageRequest(this.Client, cloudCommunicationsToInitialize.CallRecordsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    cloudCommunicationsToInitialize.CallRecords.AdditionalData = cloudCommunicationsToInitialize.AdditionalData;
                }
                if (cloudCommunicationsToInitialize.OnlineMeetings != null && cloudCommunicationsToInitialize.OnlineMeetings.CurrentPage != null)
                {
                    cloudCommunicationsToInitialize.OnlineMeetings.InitializeNextPageRequest(this.Client, cloudCommunicationsToInitialize.OnlineMeetingsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    cloudCommunicationsToInitialize.OnlineMeetings.AdditionalData = cloudCommunicationsToInitialize.AdditionalData;
                }
                if (cloudCommunicationsToInitialize.Presences != null && cloudCommunicationsToInitialize.Presences.CurrentPage != null)
                {
                    cloudCommunicationsToInitialize.Presences.InitializeNextPageRequest(this.Client, cloudCommunicationsToInitialize.PresencesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    cloudCommunicationsToInitialize.Presences.AdditionalData = cloudCommunicationsToInitialize.AdditionalData;
                }

            }


        }
    }
}