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
    /// The type IdentityContainerRequest.
    /// </summary>
    public partial class IdentityContainerRequest : BaseRequest, IIdentityContainerRequest
    {
        /// <summary>
        /// Constructs a new IdentityContainerRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public IdentityContainerRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified IdentityContainer using POST.
        /// </summary>
        /// <param name="identityContainerToCreate">The IdentityContainer to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IdentityContainer.</returns>
        public async System.Threading.Tasks.Task<IdentityContainer> CreateAsync(IdentityContainer identityContainerToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<IdentityContainer>(identityContainerToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified IdentityContainer using POST and returns a <see cref="GraphResponse{IdentityContainer}"/> object.
        /// </summary>
        /// <param name="identityContainerToCreate">The IdentityContainer to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IdentityContainer}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IdentityContainer>> CreateResponseAsync(IdentityContainer identityContainerToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<IdentityContainer>(identityContainerToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified IdentityContainer.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<IdentityContainer>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified IdentityContainer and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified IdentityContainer.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IdentityContainer.</returns>
        public async System.Threading.Tasks.Task<IdentityContainer> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<IdentityContainer>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified IdentityContainer and returns a <see cref="GraphResponse{IdentityContainer}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IdentityContainer}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IdentityContainer>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<IdentityContainer>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified IdentityContainer using PATCH.
        /// </summary>
        /// <param name="identityContainerToUpdate">The IdentityContainer to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IdentityContainer.</returns>
        public async System.Threading.Tasks.Task<IdentityContainer> UpdateAsync(IdentityContainer identityContainerToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<IdentityContainer>(identityContainerToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified IdentityContainer using PATCH and returns a <see cref="GraphResponse{IdentityContainer}"/> object.
        /// </summary>
        /// <param name="identityContainerToUpdate">The IdentityContainer to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IdentityContainer}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IdentityContainer>> UpdateResponseAsync(IdentityContainer identityContainerToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<IdentityContainer>(identityContainerToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified IdentityContainer using PUT.
        /// </summary>
        /// <param name="identityContainerToUpdate">The IdentityContainer object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<IdentityContainer> PutAsync(IdentityContainer identityContainerToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<IdentityContainer>(identityContainerToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified IdentityContainer using PUT and returns a <see cref="GraphResponse{IdentityContainer}"/> object.
        /// </summary>
        /// <param name="identityContainerToUpdate">The IdentityContainer object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{IdentityContainer}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IdentityContainer>> PutResponseAsync(IdentityContainer identityContainerToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<IdentityContainer>(identityContainerToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIdentityContainerRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIdentityContainerRequest Expand(Expression<Func<IdentityContainer, object>> expandExpression)
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
        public IIdentityContainerRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IIdentityContainerRequest Select(Expression<Func<IdentityContainer, object>> selectExpression)
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
        /// <param name="identityContainerToInitialize">The <see cref="IdentityContainer"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(IdentityContainer identityContainerToInitialize)
        {

            if (identityContainerToInitialize != null)
            {
                if (identityContainerToInitialize.ApiConnectors != null && identityContainerToInitialize.ApiConnectors.CurrentPage != null)
                {
                    identityContainerToInitialize.ApiConnectors.InitializeNextPageRequest(this.Client, identityContainerToInitialize.ApiConnectorsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    identityContainerToInitialize.ApiConnectors.AdditionalData = identityContainerToInitialize.AdditionalData;
                }
                if (identityContainerToInitialize.B2xUserFlows != null && identityContainerToInitialize.B2xUserFlows.CurrentPage != null)
                {
                    identityContainerToInitialize.B2xUserFlows.InitializeNextPageRequest(this.Client, identityContainerToInitialize.B2xUserFlowsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    identityContainerToInitialize.B2xUserFlows.AdditionalData = identityContainerToInitialize.AdditionalData;
                }
                if (identityContainerToInitialize.IdentityProviders != null && identityContainerToInitialize.IdentityProviders.CurrentPage != null)
                {
                    identityContainerToInitialize.IdentityProviders.InitializeNextPageRequest(this.Client, identityContainerToInitialize.IdentityProvidersNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    identityContainerToInitialize.IdentityProviders.AdditionalData = identityContainerToInitialize.AdditionalData;
                }
                if (identityContainerToInitialize.UserFlowAttributes != null && identityContainerToInitialize.UserFlowAttributes.CurrentPage != null)
                {
                    identityContainerToInitialize.UserFlowAttributes.InitializeNextPageRequest(this.Client, identityContainerToInitialize.UserFlowAttributesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    identityContainerToInitialize.UserFlowAttributes.AdditionalData = identityContainerToInitialize.AdditionalData;
                }

            }


        }
    }
}