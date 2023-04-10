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
    /// The type IosDeviceFeaturesConfigurationRequest.
    /// </summary>
    public partial class IosDeviceFeaturesConfigurationRequest : BaseRequest, IIosDeviceFeaturesConfigurationRequest
    {
        /// <summary>
        /// Constructs a new IosDeviceFeaturesConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public IosDeviceFeaturesConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified IosDeviceFeaturesConfiguration using POST.
        /// </summary>
        /// <param name="iosDeviceFeaturesConfigurationToCreate">The IosDeviceFeaturesConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosDeviceFeaturesConfiguration.</returns>
        public async System.Threading.Tasks.Task<IosDeviceFeaturesConfiguration> CreateAsync(IosDeviceFeaturesConfiguration iosDeviceFeaturesConfigurationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<IosDeviceFeaturesConfiguration>(iosDeviceFeaturesConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified IosDeviceFeaturesConfiguration using POST and returns a <see cref="GraphResponse{IosDeviceFeaturesConfiguration}"/> object.
        /// </summary>
        /// <param name="iosDeviceFeaturesConfigurationToCreate">The IosDeviceFeaturesConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosDeviceFeaturesConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IosDeviceFeaturesConfiguration>> CreateResponseAsync(IosDeviceFeaturesConfiguration iosDeviceFeaturesConfigurationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<IosDeviceFeaturesConfiguration>(iosDeviceFeaturesConfigurationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified IosDeviceFeaturesConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<IosDeviceFeaturesConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified IosDeviceFeaturesConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified IosDeviceFeaturesConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosDeviceFeaturesConfiguration.</returns>
        public async System.Threading.Tasks.Task<IosDeviceFeaturesConfiguration> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<IosDeviceFeaturesConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified IosDeviceFeaturesConfiguration and returns a <see cref="GraphResponse{IosDeviceFeaturesConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosDeviceFeaturesConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IosDeviceFeaturesConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<IosDeviceFeaturesConfiguration>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified IosDeviceFeaturesConfiguration using PATCH.
        /// </summary>
        /// <param name="iosDeviceFeaturesConfigurationToUpdate">The IosDeviceFeaturesConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosDeviceFeaturesConfiguration.</returns>
        public async System.Threading.Tasks.Task<IosDeviceFeaturesConfiguration> UpdateAsync(IosDeviceFeaturesConfiguration iosDeviceFeaturesConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<IosDeviceFeaturesConfiguration>(iosDeviceFeaturesConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified IosDeviceFeaturesConfiguration using PATCH and returns a <see cref="GraphResponse{IosDeviceFeaturesConfiguration}"/> object.
        /// </summary>
        /// <param name="iosDeviceFeaturesConfigurationToUpdate">The IosDeviceFeaturesConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IosDeviceFeaturesConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IosDeviceFeaturesConfiguration>> UpdateResponseAsync(IosDeviceFeaturesConfiguration iosDeviceFeaturesConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<IosDeviceFeaturesConfiguration>(iosDeviceFeaturesConfigurationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified IosDeviceFeaturesConfiguration using PUT.
        /// </summary>
        /// <param name="iosDeviceFeaturesConfigurationToUpdate">The IosDeviceFeaturesConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<IosDeviceFeaturesConfiguration> PutAsync(IosDeviceFeaturesConfiguration iosDeviceFeaturesConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<IosDeviceFeaturesConfiguration>(iosDeviceFeaturesConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified IosDeviceFeaturesConfiguration using PUT and returns a <see cref="GraphResponse{IosDeviceFeaturesConfiguration}"/> object.
        /// </summary>
        /// <param name="iosDeviceFeaturesConfigurationToUpdate">The IosDeviceFeaturesConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{IosDeviceFeaturesConfiguration}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IosDeviceFeaturesConfiguration>> PutResponseAsync(IosDeviceFeaturesConfiguration iosDeviceFeaturesConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<IosDeviceFeaturesConfiguration>(iosDeviceFeaturesConfigurationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIosDeviceFeaturesConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIosDeviceFeaturesConfigurationRequest Expand(Expression<Func<IosDeviceFeaturesConfiguration, object>> expandExpression)
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
        public IIosDeviceFeaturesConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IIosDeviceFeaturesConfigurationRequest Select(Expression<Func<IosDeviceFeaturesConfiguration, object>> selectExpression)
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
        /// <param name="iosDeviceFeaturesConfigurationToInitialize">The <see cref="IosDeviceFeaturesConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(IosDeviceFeaturesConfiguration iosDeviceFeaturesConfigurationToInitialize)
        {

        }
    }
}