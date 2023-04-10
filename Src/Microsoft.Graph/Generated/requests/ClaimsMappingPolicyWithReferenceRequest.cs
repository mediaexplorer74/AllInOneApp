// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type ClaimsMappingPolicyWithReferenceRequest.
    /// </summary>
    public partial class ClaimsMappingPolicyWithReferenceRequest : BaseRequest, IClaimsMappingPolicyWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new ClaimsMappingPolicyWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ClaimsMappingPolicyWithReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified ClaimsMappingPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ClaimsMappingPolicy.</returns>
        public async System.Threading.Tasks.Task<ClaimsMappingPolicy> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<ClaimsMappingPolicy>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ClaimsMappingPolicy and returns a <see cref="GraphResponse{ClaimsMappingPolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ClaimsMappingPolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ClaimsMappingPolicy>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<ClaimsMappingPolicy>(null, cancellationToken);
        }

		/// <summary>
        /// Creates the specified ClaimsMappingPolicy using POST.
        /// </summary>
        /// <param name="claimsMappingPolicyToCreate">The ClaimsMappingPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ClaimsMappingPolicy.</returns>
        public async System.Threading.Tasks.Task<ClaimsMappingPolicy> CreateAsync(ClaimsMappingPolicy claimsMappingPolicyToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<ClaimsMappingPolicy>(claimsMappingPolicyToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Creates the specified ClaimsMappingPolicy using POST and returns a <see cref="GraphResponse{ClaimsMappingPolicy}"/> object.
        /// </summary>
        /// <param name="claimsMappingPolicyToCreate">The ClaimsMappingPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ClaimsMappingPolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ClaimsMappingPolicy>> CreateResponseAsync(ClaimsMappingPolicy claimsMappingPolicyToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<ClaimsMappingPolicy>(claimsMappingPolicyToCreate, cancellationToken);
        }

		/// <summary>
        /// Updates the specified ClaimsMappingPolicy using PATCH.
        /// </summary>
        /// <param name="claimsMappingPolicyToUpdate">The ClaimsMappingPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ClaimsMappingPolicy.</returns>
        public async System.Threading.Tasks.Task<ClaimsMappingPolicy> UpdateAsync(ClaimsMappingPolicy claimsMappingPolicyToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<ClaimsMappingPolicy>(claimsMappingPolicyToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Updates the specified ClaimsMappingPolicy using PATCH and returns a <see cref="GraphResponse{ClaimsMappingPolicy}"/> object.
        /// </summary>
        /// <param name="claimsMappingPolicyToUpdate">The ClaimsMappingPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ClaimsMappingPolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ClaimsMappingPolicy>> UpdateResponseAsync(ClaimsMappingPolicy claimsMappingPolicyToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<ClaimsMappingPolicy>(claimsMappingPolicyToUpdate, cancellationToken);
        }

		/// <summary>
        /// Deletes the specified ClaimsMappingPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<ClaimsMappingPolicy>(null, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified ClaimsMappingPolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IClaimsMappingPolicyWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IClaimsMappingPolicyWithReferenceRequest Expand(Expression<Func<ClaimsMappingPolicy, object>> expandExpression)
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
        public IClaimsMappingPolicyWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IClaimsMappingPolicyWithReferenceRequest Select(Expression<Func<ClaimsMappingPolicy, object>> selectExpression)
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

    }
}