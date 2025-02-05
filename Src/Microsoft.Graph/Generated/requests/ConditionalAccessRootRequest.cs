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
    /// The type ConditionalAccessRootRequest.
    /// </summary>
    public partial class ConditionalAccessRootRequest : BaseRequest, IConditionalAccessRootRequest
    {
        /// <summary>
        /// Constructs a new ConditionalAccessRootRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ConditionalAccessRootRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ConditionalAccessRoot using POST.
        /// </summary>
        /// <param name="conditionalAccessRootToCreate">The ConditionalAccessRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ConditionalAccessRoot.</returns>
        public async System.Threading.Tasks.Task<ConditionalAccessRoot> CreateAsync(ConditionalAccessRoot conditionalAccessRootToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<ConditionalAccessRoot>(conditionalAccessRootToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified ConditionalAccessRoot using POST and returns a <see cref="GraphResponse{ConditionalAccessRoot}"/> object.
        /// </summary>
        /// <param name="conditionalAccessRootToCreate">The ConditionalAccessRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ConditionalAccessRoot}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ConditionalAccessRoot>> CreateResponseAsync(ConditionalAccessRoot conditionalAccessRootToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<ConditionalAccessRoot>(conditionalAccessRootToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified ConditionalAccessRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<ConditionalAccessRoot>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ConditionalAccessRoot and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified ConditionalAccessRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ConditionalAccessRoot.</returns>
        public async System.Threading.Tasks.Task<ConditionalAccessRoot> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<ConditionalAccessRoot>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ConditionalAccessRoot and returns a <see cref="GraphResponse{ConditionalAccessRoot}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ConditionalAccessRoot}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ConditionalAccessRoot>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<ConditionalAccessRoot>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ConditionalAccessRoot using PATCH.
        /// </summary>
        /// <param name="conditionalAccessRootToUpdate">The ConditionalAccessRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ConditionalAccessRoot.</returns>
        public async System.Threading.Tasks.Task<ConditionalAccessRoot> UpdateAsync(ConditionalAccessRoot conditionalAccessRootToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<ConditionalAccessRoot>(conditionalAccessRootToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ConditionalAccessRoot using PATCH and returns a <see cref="GraphResponse{ConditionalAccessRoot}"/> object.
        /// </summary>
        /// <param name="conditionalAccessRootToUpdate">The ConditionalAccessRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ConditionalAccessRoot}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ConditionalAccessRoot>> UpdateResponseAsync(ConditionalAccessRoot conditionalAccessRootToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<ConditionalAccessRoot>(conditionalAccessRootToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ConditionalAccessRoot using PUT.
        /// </summary>
        /// <param name="conditionalAccessRootToUpdate">The ConditionalAccessRoot object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<ConditionalAccessRoot> PutAsync(ConditionalAccessRoot conditionalAccessRootToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<ConditionalAccessRoot>(conditionalAccessRootToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ConditionalAccessRoot using PUT and returns a <see cref="GraphResponse{ConditionalAccessRoot}"/> object.
        /// </summary>
        /// <param name="conditionalAccessRootToUpdate">The ConditionalAccessRoot object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{ConditionalAccessRoot}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ConditionalAccessRoot>> PutResponseAsync(ConditionalAccessRoot conditionalAccessRootToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<ConditionalAccessRoot>(conditionalAccessRootToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IConditionalAccessRootRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IConditionalAccessRootRequest Expand(Expression<Func<ConditionalAccessRoot, object>> expandExpression)
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
        public IConditionalAccessRootRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IConditionalAccessRootRequest Select(Expression<Func<ConditionalAccessRoot, object>> selectExpression)
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
        /// <param name="conditionalAccessRootToInitialize">The <see cref="ConditionalAccessRoot"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ConditionalAccessRoot conditionalAccessRootToInitialize)
        {

            if (conditionalAccessRootToInitialize != null)
            {
                if (conditionalAccessRootToInitialize.NamedLocations != null && conditionalAccessRootToInitialize.NamedLocations.CurrentPage != null)
                {
                    conditionalAccessRootToInitialize.NamedLocations.InitializeNextPageRequest(this.Client, conditionalAccessRootToInitialize.NamedLocationsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    conditionalAccessRootToInitialize.NamedLocations.AdditionalData = conditionalAccessRootToInitialize.AdditionalData;
                }
                if (conditionalAccessRootToInitialize.Policies != null && conditionalAccessRootToInitialize.Policies.CurrentPage != null)
                {
                    conditionalAccessRootToInitialize.Policies.InitializeNextPageRequest(this.Client, conditionalAccessRootToInitialize.PoliciesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    conditionalAccessRootToInitialize.Policies.AdditionalData = conditionalAccessRootToInitialize.AdditionalData;
                }

            }


        }
    }
}
