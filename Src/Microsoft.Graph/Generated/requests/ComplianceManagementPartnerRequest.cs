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
    /// The type ComplianceManagementPartnerRequest.
    /// </summary>
    public partial class ComplianceManagementPartnerRequest : BaseRequest, IComplianceManagementPartnerRequest
    {
        /// <summary>
        /// Constructs a new ComplianceManagementPartnerRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ComplianceManagementPartnerRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ComplianceManagementPartner using POST.
        /// </summary>
        /// <param name="complianceManagementPartnerToCreate">The ComplianceManagementPartner to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ComplianceManagementPartner.</returns>
        public async System.Threading.Tasks.Task<ComplianceManagementPartner> CreateAsync(ComplianceManagementPartner complianceManagementPartnerToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<ComplianceManagementPartner>(complianceManagementPartnerToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified ComplianceManagementPartner using POST and returns a <see cref="GraphResponse{ComplianceManagementPartner}"/> object.
        /// </summary>
        /// <param name="complianceManagementPartnerToCreate">The ComplianceManagementPartner to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ComplianceManagementPartner}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ComplianceManagementPartner>> CreateResponseAsync(ComplianceManagementPartner complianceManagementPartnerToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<ComplianceManagementPartner>(complianceManagementPartnerToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified ComplianceManagementPartner.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<ComplianceManagementPartner>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ComplianceManagementPartner and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified ComplianceManagementPartner.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ComplianceManagementPartner.</returns>
        public async System.Threading.Tasks.Task<ComplianceManagementPartner> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<ComplianceManagementPartner>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ComplianceManagementPartner and returns a <see cref="GraphResponse{ComplianceManagementPartner}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ComplianceManagementPartner}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ComplianceManagementPartner>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<ComplianceManagementPartner>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ComplianceManagementPartner using PATCH.
        /// </summary>
        /// <param name="complianceManagementPartnerToUpdate">The ComplianceManagementPartner to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ComplianceManagementPartner.</returns>
        public async System.Threading.Tasks.Task<ComplianceManagementPartner> UpdateAsync(ComplianceManagementPartner complianceManagementPartnerToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<ComplianceManagementPartner>(complianceManagementPartnerToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ComplianceManagementPartner using PATCH and returns a <see cref="GraphResponse{ComplianceManagementPartner}"/> object.
        /// </summary>
        /// <param name="complianceManagementPartnerToUpdate">The ComplianceManagementPartner to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ComplianceManagementPartner}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ComplianceManagementPartner>> UpdateResponseAsync(ComplianceManagementPartner complianceManagementPartnerToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<ComplianceManagementPartner>(complianceManagementPartnerToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ComplianceManagementPartner using PUT.
        /// </summary>
        /// <param name="complianceManagementPartnerToUpdate">The ComplianceManagementPartner object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<ComplianceManagementPartner> PutAsync(ComplianceManagementPartner complianceManagementPartnerToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<ComplianceManagementPartner>(complianceManagementPartnerToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ComplianceManagementPartner using PUT and returns a <see cref="GraphResponse{ComplianceManagementPartner}"/> object.
        /// </summary>
        /// <param name="complianceManagementPartnerToUpdate">The ComplianceManagementPartner object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{ComplianceManagementPartner}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ComplianceManagementPartner>> PutResponseAsync(ComplianceManagementPartner complianceManagementPartnerToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<ComplianceManagementPartner>(complianceManagementPartnerToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IComplianceManagementPartnerRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IComplianceManagementPartnerRequest Expand(Expression<Func<ComplianceManagementPartner, object>> expandExpression)
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
        public IComplianceManagementPartnerRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IComplianceManagementPartnerRequest Select(Expression<Func<ComplianceManagementPartner, object>> selectExpression)
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
        /// <param name="complianceManagementPartnerToInitialize">The <see cref="ComplianceManagementPartner"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ComplianceManagementPartner complianceManagementPartnerToInitialize)
        {

        }
    }
}
