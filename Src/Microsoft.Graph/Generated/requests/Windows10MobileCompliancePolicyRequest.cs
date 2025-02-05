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
    /// The type Windows10MobileCompliancePolicyRequest.
    /// </summary>
    public partial class Windows10MobileCompliancePolicyRequest : BaseRequest, IWindows10MobileCompliancePolicyRequest
    {
        /// <summary>
        /// Constructs a new Windows10MobileCompliancePolicyRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public Windows10MobileCompliancePolicyRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Windows10MobileCompliancePolicy using POST.
        /// </summary>
        /// <param name="windows10MobileCompliancePolicyToCreate">The Windows10MobileCompliancePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Windows10MobileCompliancePolicy.</returns>
        public async System.Threading.Tasks.Task<Windows10MobileCompliancePolicy> CreateAsync(Windows10MobileCompliancePolicy windows10MobileCompliancePolicyToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<Windows10MobileCompliancePolicy>(windows10MobileCompliancePolicyToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Windows10MobileCompliancePolicy using POST and returns a <see cref="GraphResponse{Windows10MobileCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="windows10MobileCompliancePolicyToCreate">The Windows10MobileCompliancePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Windows10MobileCompliancePolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Windows10MobileCompliancePolicy>> CreateResponseAsync(Windows10MobileCompliancePolicy windows10MobileCompliancePolicyToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<Windows10MobileCompliancePolicy>(windows10MobileCompliancePolicyToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified Windows10MobileCompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<Windows10MobileCompliancePolicy>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Windows10MobileCompliancePolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified Windows10MobileCompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Windows10MobileCompliancePolicy.</returns>
        public async System.Threading.Tasks.Task<Windows10MobileCompliancePolicy> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<Windows10MobileCompliancePolicy>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Windows10MobileCompliancePolicy and returns a <see cref="GraphResponse{Windows10MobileCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Windows10MobileCompliancePolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Windows10MobileCompliancePolicy>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<Windows10MobileCompliancePolicy>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Windows10MobileCompliancePolicy using PATCH.
        /// </summary>
        /// <param name="windows10MobileCompliancePolicyToUpdate">The Windows10MobileCompliancePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Windows10MobileCompliancePolicy.</returns>
        public async System.Threading.Tasks.Task<Windows10MobileCompliancePolicy> UpdateAsync(Windows10MobileCompliancePolicy windows10MobileCompliancePolicyToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<Windows10MobileCompliancePolicy>(windows10MobileCompliancePolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Windows10MobileCompliancePolicy using PATCH and returns a <see cref="GraphResponse{Windows10MobileCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="windows10MobileCompliancePolicyToUpdate">The Windows10MobileCompliancePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Windows10MobileCompliancePolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Windows10MobileCompliancePolicy>> UpdateResponseAsync(Windows10MobileCompliancePolicy windows10MobileCompliancePolicyToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<Windows10MobileCompliancePolicy>(windows10MobileCompliancePolicyToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Windows10MobileCompliancePolicy using PUT.
        /// </summary>
        /// <param name="windows10MobileCompliancePolicyToUpdate">The Windows10MobileCompliancePolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<Windows10MobileCompliancePolicy> PutAsync(Windows10MobileCompliancePolicy windows10MobileCompliancePolicyToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<Windows10MobileCompliancePolicy>(windows10MobileCompliancePolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Windows10MobileCompliancePolicy using PUT and returns a <see cref="GraphResponse{Windows10MobileCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="windows10MobileCompliancePolicyToUpdate">The Windows10MobileCompliancePolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{Windows10MobileCompliancePolicy}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Windows10MobileCompliancePolicy>> PutResponseAsync(Windows10MobileCompliancePolicy windows10MobileCompliancePolicyToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<Windows10MobileCompliancePolicy>(windows10MobileCompliancePolicyToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindows10MobileCompliancePolicyRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindows10MobileCompliancePolicyRequest Expand(Expression<Func<Windows10MobileCompliancePolicy, object>> expandExpression)
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
        public IWindows10MobileCompliancePolicyRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWindows10MobileCompliancePolicyRequest Select(Expression<Func<Windows10MobileCompliancePolicy, object>> selectExpression)
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
        /// <param name="windows10MobileCompliancePolicyToInitialize">The <see cref="Windows10MobileCompliancePolicy"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Windows10MobileCompliancePolicy windows10MobileCompliancePolicyToInitialize)
        {

        }
    }
}
