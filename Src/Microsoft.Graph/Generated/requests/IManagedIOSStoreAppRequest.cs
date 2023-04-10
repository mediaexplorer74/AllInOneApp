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
    /// The interface IManagedIOSStoreAppRequest.
    /// </summary>
    public partial interface IManagedIOSStoreAppRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ManagedIOSStoreApp using POST.
        /// </summary>
        /// <param name="managedIOSStoreAppToCreate">The ManagedIOSStoreApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedIOSStoreApp.</returns>
        System.Threading.Tasks.Task<ManagedIOSStoreApp> CreateAsync(ManagedIOSStoreApp managedIOSStoreAppToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified ManagedIOSStoreApp using POST and returns a <see cref="GraphResponse{ManagedIOSStoreApp}"/> object.
        /// </summary>
        /// <param name="managedIOSStoreAppToCreate">The ManagedIOSStoreApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedIOSStoreApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedIOSStoreApp>> CreateResponseAsync(ManagedIOSStoreApp managedIOSStoreAppToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ManagedIOSStoreApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ManagedIOSStoreApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ManagedIOSStoreApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedIOSStoreApp.</returns>
        System.Threading.Tasks.Task<ManagedIOSStoreApp> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ManagedIOSStoreApp and returns a <see cref="GraphResponse{ManagedIOSStoreApp}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedIOSStoreApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedIOSStoreApp>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedIOSStoreApp using PATCH.
        /// </summary>
        /// <param name="managedIOSStoreAppToUpdate">The ManagedIOSStoreApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedIOSStoreApp.</returns>
        System.Threading.Tasks.Task<ManagedIOSStoreApp> UpdateAsync(ManagedIOSStoreApp managedIOSStoreAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedIOSStoreApp using PATCH and returns a <see cref="GraphResponse{ManagedIOSStoreApp}"/> object.
        /// </summary>
        /// <param name="managedIOSStoreAppToUpdate">The ManagedIOSStoreApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ManagedIOSStoreApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedIOSStoreApp>> UpdateResponseAsync(ManagedIOSStoreApp managedIOSStoreAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedIOSStoreApp using PUT.
        /// </summary>
        /// <param name="managedIOSStoreAppToUpdate">The ManagedIOSStoreApp object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ManagedIOSStoreApp> PutAsync(ManagedIOSStoreApp managedIOSStoreAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedIOSStoreApp using PUT and returns a <see cref="GraphResponse{ManagedIOSStoreApp}"/> object.
        /// </summary>
        /// <param name="managedIOSStoreAppToUpdate">The ManagedIOSStoreApp object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ManagedIOSStoreApp}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedIOSStoreApp>> PutResponseAsync(ManagedIOSStoreApp managedIOSStoreAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedIOSStoreAppRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedIOSStoreAppRequest Expand(Expression<Func<ManagedIOSStoreApp, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedIOSStoreAppRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedIOSStoreAppRequest Select(Expression<Func<ManagedIOSStoreApp, object>> selectExpression);

    }
}