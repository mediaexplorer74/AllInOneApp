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
    /// The interface ITeamsAppRequest.
    /// </summary>
    public partial interface ITeamsAppRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TeamsApp using POST.
        /// </summary>
        /// <param name="teamsAppToCreate">The TeamsApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TeamsApp.</returns>
        System.Threading.Tasks.Task<TeamsApp> CreateAsync(TeamsApp teamsAppToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified TeamsApp using POST and returns a <see cref="GraphResponse{TeamsApp}"/> object.
        /// </summary>
        /// <param name="teamsAppToCreate">The TeamsApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamsApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsApp>> CreateResponseAsync(TeamsApp teamsAppToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified TeamsApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified TeamsApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified TeamsApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TeamsApp.</returns>
        System.Threading.Tasks.Task<TeamsApp> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified TeamsApp and returns a <see cref="GraphResponse{TeamsApp}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamsApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsApp>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TeamsApp using PATCH.
        /// </summary>
        /// <param name="teamsAppToUpdate">The TeamsApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TeamsApp.</returns>
        System.Threading.Tasks.Task<TeamsApp> UpdateAsync(TeamsApp teamsAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TeamsApp using PATCH and returns a <see cref="GraphResponse{TeamsApp}"/> object.
        /// </summary>
        /// <param name="teamsAppToUpdate">The TeamsApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TeamsApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsApp>> UpdateResponseAsync(TeamsApp teamsAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TeamsApp using PUT.
        /// </summary>
        /// <param name="teamsAppToUpdate">The TeamsApp object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<TeamsApp> PutAsync(TeamsApp teamsAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TeamsApp using PUT and returns a <see cref="GraphResponse{TeamsApp}"/> object.
        /// </summary>
        /// <param name="teamsAppToUpdate">The TeamsApp object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{TeamsApp}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsApp>> PutResponseAsync(TeamsApp teamsAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsAppRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsAppRequest Expand(Expression<Func<TeamsApp, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsAppRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsAppRequest Select(Expression<Func<TeamsApp, object>> selectExpression);

    }
}
