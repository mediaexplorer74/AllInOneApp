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
    /// The interface IManagedAppRequest.
    /// </summary>
    public partial interface IManagedAppRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ManagedApp using POST.
        /// </summary>
        /// <param name="managedAppToCreate">The ManagedApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedApp.</returns>
        System.Threading.Tasks.Task<ManagedApp> CreateAsync(ManagedApp managedAppToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified ManagedApp using POST and returns a <see cref="GraphResponse{ManagedApp}"/> object.
        /// </summary>
        /// <param name="managedAppToCreate">The ManagedApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedApp>> CreateResponseAsync(ManagedApp managedAppToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ManagedApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ManagedApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ManagedApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedApp.</returns>
        System.Threading.Tasks.Task<ManagedApp> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ManagedApp and returns a <see cref="GraphResponse{ManagedApp}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedApp>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedApp using PATCH.
        /// </summary>
        /// <param name="managedAppToUpdate">The ManagedApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedApp.</returns>
        System.Threading.Tasks.Task<ManagedApp> UpdateAsync(ManagedApp managedAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedApp using PATCH and returns a <see cref="GraphResponse{ManagedApp}"/> object.
        /// </summary>
        /// <param name="managedAppToUpdate">The ManagedApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ManagedApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedApp>> UpdateResponseAsync(ManagedApp managedAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedApp using PUT.
        /// </summary>
        /// <param name="managedAppToUpdate">The ManagedApp object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ManagedApp> PutAsync(ManagedApp managedAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedApp using PUT and returns a <see cref="GraphResponse{ManagedApp}"/> object.
        /// </summary>
        /// <param name="managedAppToUpdate">The ManagedApp object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ManagedApp}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedApp>> PutResponseAsync(ManagedApp managedAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppRequest Expand(Expression<Func<ManagedApp, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppRequest Select(Expression<Func<ManagedApp, object>> selectExpression);

    }
}