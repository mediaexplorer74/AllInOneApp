// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IIosMobileAppConfigurationRequest.
    /// </summary>
    public partial interface IIosMobileAppConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IosMobileAppConfiguration using POST.
        /// </summary>
        /// <param name="iosMobileAppConfigurationToCreate">The IosMobileAppConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosMobileAppConfiguration.</returns>
        System.Threading.Tasks.Task<IosMobileAppConfiguration> CreateAsync(IosMobileAppConfiguration iosMobileAppConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified IosMobileAppConfiguration using POST and returns a <see cref="GraphResponse{IosMobileAppConfiguration}"/> object.
        /// </summary>
        /// <param name="iosMobileAppConfigurationToCreate">The IosMobileAppConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosMobileAppConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosMobileAppConfiguration>> CreateResponseAsync(IosMobileAppConfiguration iosMobileAppConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified IosMobileAppConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified IosMobileAppConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified IosMobileAppConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosMobileAppConfiguration.</returns>
        System.Threading.Tasks.Task<IosMobileAppConfiguration> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified IosMobileAppConfiguration and returns a <see cref="GraphResponse{IosMobileAppConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosMobileAppConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosMobileAppConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IosMobileAppConfiguration using PATCH.
        /// </summary>
        /// <param name="iosMobileAppConfigurationToUpdate">The IosMobileAppConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosMobileAppConfiguration.</returns>
        System.Threading.Tasks.Task<IosMobileAppConfiguration> UpdateAsync(IosMobileAppConfiguration iosMobileAppConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IosMobileAppConfiguration using PATCH and returns a <see cref="GraphResponse{IosMobileAppConfiguration}"/> object.
        /// </summary>
        /// <param name="iosMobileAppConfigurationToUpdate">The IosMobileAppConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IosMobileAppConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosMobileAppConfiguration>> UpdateResponseAsync(IosMobileAppConfiguration iosMobileAppConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IosMobileAppConfiguration using PUT.
        /// </summary>
        /// <param name="iosMobileAppConfigurationToUpdate">The IosMobileAppConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<IosMobileAppConfiguration> PutAsync(IosMobileAppConfiguration iosMobileAppConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IosMobileAppConfiguration using PUT and returns a <see cref="GraphResponse{IosMobileAppConfiguration}"/> object.
        /// </summary>
        /// <param name="iosMobileAppConfigurationToUpdate">The IosMobileAppConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{IosMobileAppConfiguration}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosMobileAppConfiguration>> PutResponseAsync(IosMobileAppConfiguration iosMobileAppConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosMobileAppConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosMobileAppConfigurationRequest Expand(Expression<Func<IosMobileAppConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIosMobileAppConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIosMobileAppConfigurationRequest Select(Expression<Func<IosMobileAppConfiguration, object>> selectExpression);

    }
}