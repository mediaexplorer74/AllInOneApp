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
    /// The type PrintTaskTriggerWithReferenceRequest.
    /// </summary>
    public partial class PrintTaskTriggerWithReferenceRequest : BaseRequest, IPrintTaskTriggerWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new PrintTaskTriggerWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public PrintTaskTriggerWithReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified PrintTaskTrigger.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PrintTaskTrigger.</returns>
        public async System.Threading.Tasks.Task<PrintTaskTrigger> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<PrintTaskTrigger>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified PrintTaskTrigger and returns a <see cref="GraphResponse{PrintTaskTrigger}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PrintTaskTrigger}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PrintTaskTrigger>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<PrintTaskTrigger>(null, cancellationToken);
        }

		/// <summary>
        /// Creates the specified PrintTaskTrigger using POST.
        /// </summary>
        /// <param name="printTaskTriggerToCreate">The PrintTaskTrigger to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PrintTaskTrigger.</returns>
        public async System.Threading.Tasks.Task<PrintTaskTrigger> CreateAsync(PrintTaskTrigger printTaskTriggerToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<PrintTaskTrigger>(printTaskTriggerToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Creates the specified PrintTaskTrigger using POST and returns a <see cref="GraphResponse{PrintTaskTrigger}"/> object.
        /// </summary>
        /// <param name="printTaskTriggerToCreate">The PrintTaskTrigger to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PrintTaskTrigger}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PrintTaskTrigger>> CreateResponseAsync(PrintTaskTrigger printTaskTriggerToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<PrintTaskTrigger>(printTaskTriggerToCreate, cancellationToken);
        }

		/// <summary>
        /// Updates the specified PrintTaskTrigger using PATCH.
        /// </summary>
        /// <param name="printTaskTriggerToUpdate">The PrintTaskTrigger to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PrintTaskTrigger.</returns>
        public async System.Threading.Tasks.Task<PrintTaskTrigger> UpdateAsync(PrintTaskTrigger printTaskTriggerToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<PrintTaskTrigger>(printTaskTriggerToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Updates the specified PrintTaskTrigger using PATCH and returns a <see cref="GraphResponse{PrintTaskTrigger}"/> object.
        /// </summary>
        /// <param name="printTaskTriggerToUpdate">The PrintTaskTrigger to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PrintTaskTrigger}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PrintTaskTrigger>> UpdateResponseAsync(PrintTaskTrigger printTaskTriggerToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<PrintTaskTrigger>(printTaskTriggerToUpdate, cancellationToken);
        }

		/// <summary>
        /// Deletes the specified PrintTaskTrigger.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<PrintTaskTrigger>(null, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified PrintTaskTrigger and returns a <see cref="GraphResponse"/> object.
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
        public IPrintTaskTriggerWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPrintTaskTriggerWithReferenceRequest Expand(Expression<Func<PrintTaskTrigger, object>> expandExpression)
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
        public IPrintTaskTriggerWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IPrintTaskTriggerWithReferenceRequest Select(Expression<Func<PrintTaskTrigger, object>> selectExpression)
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
