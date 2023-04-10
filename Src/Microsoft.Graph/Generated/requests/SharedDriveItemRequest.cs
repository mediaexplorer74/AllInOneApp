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
    /// The type SharedDriveItemRequest.
    /// </summary>
    public partial class SharedDriveItemRequest : BaseRequest, ISharedDriveItemRequest
    {
        /// <summary>
        /// Constructs a new SharedDriveItemRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public SharedDriveItemRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified SharedDriveItem using POST.
        /// </summary>
        /// <param name="sharedDriveItemToCreate">The SharedDriveItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SharedDriveItem.</returns>
        public async System.Threading.Tasks.Task<SharedDriveItem> CreateAsync(SharedDriveItem sharedDriveItemToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<SharedDriveItem>(sharedDriveItemToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified SharedDriveItem using POST and returns a <see cref="GraphResponse{SharedDriveItem}"/> object.
        /// </summary>
        /// <param name="sharedDriveItemToCreate">The SharedDriveItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SharedDriveItem}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SharedDriveItem>> CreateResponseAsync(SharedDriveItem sharedDriveItemToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<SharedDriveItem>(sharedDriveItemToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified SharedDriveItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<SharedDriveItem>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified SharedDriveItem and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified SharedDriveItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SharedDriveItem.</returns>
        public async System.Threading.Tasks.Task<SharedDriveItem> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<SharedDriveItem>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified SharedDriveItem and returns a <see cref="GraphResponse{SharedDriveItem}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SharedDriveItem}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SharedDriveItem>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<SharedDriveItem>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified SharedDriveItem using PATCH.
        /// </summary>
        /// <param name="sharedDriveItemToUpdate">The SharedDriveItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SharedDriveItem.</returns>
        public async System.Threading.Tasks.Task<SharedDriveItem> UpdateAsync(SharedDriveItem sharedDriveItemToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<SharedDriveItem>(sharedDriveItemToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified SharedDriveItem using PATCH and returns a <see cref="GraphResponse{SharedDriveItem}"/> object.
        /// </summary>
        /// <param name="sharedDriveItemToUpdate">The SharedDriveItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SharedDriveItem}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SharedDriveItem>> UpdateResponseAsync(SharedDriveItem sharedDriveItemToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<SharedDriveItem>(sharedDriveItemToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified SharedDriveItem using PUT.
        /// </summary>
        /// <param name="sharedDriveItemToUpdate">The SharedDriveItem object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<SharedDriveItem> PutAsync(SharedDriveItem sharedDriveItemToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<SharedDriveItem>(sharedDriveItemToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified SharedDriveItem using PUT and returns a <see cref="GraphResponse{SharedDriveItem}"/> object.
        /// </summary>
        /// <param name="sharedDriveItemToUpdate">The SharedDriveItem object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{SharedDriveItem}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SharedDriveItem>> PutResponseAsync(SharedDriveItem sharedDriveItemToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<SharedDriveItem>(sharedDriveItemToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISharedDriveItemRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISharedDriveItemRequest Expand(Expression<Func<SharedDriveItem, object>> expandExpression)
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
        public ISharedDriveItemRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ISharedDriveItemRequest Select(Expression<Func<SharedDriveItem, object>> selectExpression)
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
        /// <param name="sharedDriveItemToInitialize">The <see cref="SharedDriveItem"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(SharedDriveItem sharedDriveItemToInitialize)
        {

            if (sharedDriveItemToInitialize != null)
            {
                if (sharedDriveItemToInitialize.Items != null && sharedDriveItemToInitialize.Items.CurrentPage != null)
                {
                    sharedDriveItemToInitialize.Items.InitializeNextPageRequest(this.Client, sharedDriveItemToInitialize.ItemsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    sharedDriveItemToInitialize.Items.AdditionalData = sharedDriveItemToInitialize.AdditionalData;
                }

            }


        }
    }
}