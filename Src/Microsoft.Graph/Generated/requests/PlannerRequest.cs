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
    /// The type PlannerRequest.
    /// </summary>
    public partial class PlannerRequest : BaseRequest, IPlannerRequest
    {
        /// <summary>
        /// Constructs a new PlannerRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public PlannerRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Planner using POST.
        /// </summary>
        /// <param name="plannerToCreate">The Planner to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Planner.</returns>
        public async System.Threading.Tasks.Task<Planner> CreateAsync(Planner plannerToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<Planner>(plannerToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Planner using POST and returns a <see cref="GraphResponse{Planner}"/> object.
        /// </summary>
        /// <param name="plannerToCreate">The Planner to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Planner}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Planner>> CreateResponseAsync(Planner plannerToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<Planner>(plannerToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified Planner.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<Planner>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Planner and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified Planner.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Planner.</returns>
        public async System.Threading.Tasks.Task<Planner> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<Planner>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Planner and returns a <see cref="GraphResponse{Planner}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Planner}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Planner>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<Planner>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Planner using PATCH.
        /// </summary>
        /// <param name="plannerToUpdate">The Planner to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Planner.</returns>
        public async System.Threading.Tasks.Task<Planner> UpdateAsync(Planner plannerToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<Planner>(plannerToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Planner using PATCH and returns a <see cref="GraphResponse{Planner}"/> object.
        /// </summary>
        /// <param name="plannerToUpdate">The Planner to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Planner}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Planner>> UpdateResponseAsync(Planner plannerToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<Planner>(plannerToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Planner using PUT.
        /// </summary>
        /// <param name="plannerToUpdate">The Planner object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<Planner> PutAsync(Planner plannerToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<Planner>(plannerToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Planner using PUT and returns a <see cref="GraphResponse{Planner}"/> object.
        /// </summary>
        /// <param name="plannerToUpdate">The Planner object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{Planner}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Planner>> PutResponseAsync(Planner plannerToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<Planner>(plannerToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPlannerRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPlannerRequest Expand(Expression<Func<Planner, object>> expandExpression)
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
        public IPlannerRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IPlannerRequest Select(Expression<Func<Planner, object>> selectExpression)
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
        /// <param name="plannerToInitialize">The <see cref="Planner"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Planner plannerToInitialize)
        {

            if (plannerToInitialize != null)
            {
                if (plannerToInitialize.Buckets != null && plannerToInitialize.Buckets.CurrentPage != null)
                {
                    plannerToInitialize.Buckets.InitializeNextPageRequest(this.Client, plannerToInitialize.BucketsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    plannerToInitialize.Buckets.AdditionalData = plannerToInitialize.AdditionalData;
                }
                if (plannerToInitialize.Plans != null && plannerToInitialize.Plans.CurrentPage != null)
                {
                    plannerToInitialize.Plans.InitializeNextPageRequest(this.Client, plannerToInitialize.PlansNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    plannerToInitialize.Plans.AdditionalData = plannerToInitialize.AdditionalData;
                }
                if (plannerToInitialize.Tasks != null && plannerToInitialize.Tasks.CurrentPage != null)
                {
                    plannerToInitialize.Tasks.InitializeNextPageRequest(this.Client, plannerToInitialize.TasksNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    plannerToInitialize.Tasks.AdditionalData = plannerToInitialize.AdditionalData;
                }

            }


        }
    }
}