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
    /// The interface IManagedAndroidStoreAppRequest.
    /// </summary>
    public partial interface IManagedAndroidStoreAppRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ManagedAndroidStoreApp using POST.
        /// </summary>
        /// <param name="managedAndroidStoreAppToCreate">The ManagedAndroidStoreApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedAndroidStoreApp.</returns>
        System.Threading.Tasks.Task<ManagedAndroidStoreApp> CreateAsync(ManagedAndroidStoreApp managedAndroidStoreAppToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified ManagedAndroidStoreApp using POST and returns a <see cref="GraphResponse{ManagedAndroidStoreApp}"/> object.
        /// </summary>
        /// <param name="managedAndroidStoreAppToCreate">The ManagedAndroidStoreApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedAndroidStoreApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedAndroidStoreApp>> CreateResponseAsync(ManagedAndroidStoreApp managedAndroidStoreAppToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ManagedAndroidStoreApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ManagedAndroidStoreApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ManagedAndroidStoreApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedAndroidStoreApp.</returns>
        System.Threading.Tasks.Task<ManagedAndroidStoreApp> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ManagedAndroidStoreApp and returns a <see cref="GraphResponse{ManagedAndroidStoreApp}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedAndroidStoreApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedAndroidStoreApp>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedAndroidStoreApp using PATCH.
        /// </summary>
        /// <param name="managedAndroidStoreAppToUpdate">The ManagedAndroidStoreApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedAndroidStoreApp.</returns>
        System.Threading.Tasks.Task<ManagedAndroidStoreApp> UpdateAsync(ManagedAndroidStoreApp managedAndroidStoreAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedAndroidStoreApp using PATCH and returns a <see cref="GraphResponse{ManagedAndroidStoreApp}"/> object.
        /// </summary>
        /// <param name="managedAndroidStoreAppToUpdate">The ManagedAndroidStoreApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ManagedAndroidStoreApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedAndroidStoreApp>> UpdateResponseAsync(ManagedAndroidStoreApp managedAndroidStoreAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedAndroidStoreApp using PUT.
        /// </summary>
        /// <param name="managedAndroidStoreAppToUpdate">The ManagedAndroidStoreApp object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ManagedAndroidStoreApp> PutAsync(ManagedAndroidStoreApp managedAndroidStoreAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedAndroidStoreApp using PUT and returns a <see cref="GraphResponse{ManagedAndroidStoreApp}"/> object.
        /// </summary>
        /// <param name="managedAndroidStoreAppToUpdate">The ManagedAndroidStoreApp object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ManagedAndroidStoreApp}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedAndroidStoreApp>> PutResponseAsync(ManagedAndroidStoreApp managedAndroidStoreAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAndroidStoreAppRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAndroidStoreAppRequest Expand(Expression<Func<ManagedAndroidStoreApp, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAndroidStoreAppRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAndroidStoreAppRequest Select(Expression<Func<ManagedAndroidStoreApp, object>> selectExpression);

    }
}