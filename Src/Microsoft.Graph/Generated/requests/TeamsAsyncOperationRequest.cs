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
    /// The type TeamsAsyncOperationRequest.
    /// </summary>
    public partial class TeamsAsyncOperationRequest : BaseRequest, ITeamsAsyncOperationRequest
    {
        /// <summary>
        /// Constructs a new TeamsAsyncOperationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public TeamsAsyncOperationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified TeamsAsyncOperation using POST.
        /// </summary>
        /// <param name="teamsAsyncOperationToCreate">The TeamsAsyncOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TeamsAsyncOperation.</returns>
        public async System.Threading.Tasks.Task<TeamsAsyncOperation> CreateAsync(TeamsAsyncOperation teamsAsyncOperationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<TeamsAsyncOperation>(teamsAsyncOperationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified TeamsAsyncOperation using POST and returns a <see cref="GraphResponse{TeamsAsyncOperation}"/> object.
        /// </summary>
        /// <param name="teamsAsyncOperationToCreate">The TeamsAsyncOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamsAsyncOperation}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TeamsAsyncOperation>> CreateResponseAsync(TeamsAsyncOperation teamsAsyncOperationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<TeamsAsyncOperation>(teamsAsyncOperationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified TeamsAsyncOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<TeamsAsyncOperation>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified TeamsAsyncOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified TeamsAsyncOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TeamsAsyncOperation.</returns>
        public async System.Threading.Tasks.Task<TeamsAsyncOperation> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<TeamsAsyncOperation>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified TeamsAsyncOperation and returns a <see cref="GraphResponse{TeamsAsyncOperation}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamsAsyncOperation}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TeamsAsyncOperation>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<TeamsAsyncOperation>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified TeamsAsyncOperation using PATCH.
        /// </summary>
        /// <param name="teamsAsyncOperationToUpdate">The TeamsAsyncOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TeamsAsyncOperation.</returns>
        public async System.Threading.Tasks.Task<TeamsAsyncOperation> UpdateAsync(TeamsAsyncOperation teamsAsyncOperationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<TeamsAsyncOperation>(teamsAsyncOperationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified TeamsAsyncOperation using PATCH and returns a <see cref="GraphResponse{TeamsAsyncOperation}"/> object.
        /// </summary>
        /// <param name="teamsAsyncOperationToUpdate">The TeamsAsyncOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TeamsAsyncOperation}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TeamsAsyncOperation>> UpdateResponseAsync(TeamsAsyncOperation teamsAsyncOperationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<TeamsAsyncOperation>(teamsAsyncOperationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified TeamsAsyncOperation using PUT.
        /// </summary>
        /// <param name="teamsAsyncOperationToUpdate">The TeamsAsyncOperation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<TeamsAsyncOperation> PutAsync(TeamsAsyncOperation teamsAsyncOperationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<TeamsAsyncOperation>(teamsAsyncOperationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified TeamsAsyncOperation using PUT and returns a <see cref="GraphResponse{TeamsAsyncOperation}"/> object.
        /// </summary>
        /// <param name="teamsAsyncOperationToUpdate">The TeamsAsyncOperation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{TeamsAsyncOperation}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TeamsAsyncOperation>> PutResponseAsync(TeamsAsyncOperation teamsAsyncOperationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<TeamsAsyncOperation>(teamsAsyncOperationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITeamsAsyncOperationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITeamsAsyncOperationRequest Expand(Expression<Func<TeamsAsyncOperation, object>> expandExpression)
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
        public ITeamsAsyncOperationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ITeamsAsyncOperationRequest Select(Expression<Func<TeamsAsyncOperation, object>> selectExpression)
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
        /// <param name="teamsAsyncOperationToInitialize">The <see cref="TeamsAsyncOperation"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(TeamsAsyncOperation teamsAsyncOperationToInitialize)
        {

        }
    }
}
