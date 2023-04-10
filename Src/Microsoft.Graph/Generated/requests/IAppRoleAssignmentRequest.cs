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
    /// The interface IAppRoleAssignmentRequest.
    /// </summary>
    public partial interface IAppRoleAssignmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AppRoleAssignment using POST.
        /// </summary>
        /// <param name="appRoleAssignmentToCreate">The AppRoleAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AppRoleAssignment.</returns>
        System.Threading.Tasks.Task<AppRoleAssignment> CreateAsync(AppRoleAssignment appRoleAssignmentToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified AppRoleAssignment using POST and returns a <see cref="GraphResponse{AppRoleAssignment}"/> object.
        /// </summary>
        /// <param name="appRoleAssignmentToCreate">The AppRoleAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AppRoleAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AppRoleAssignment>> CreateResponseAsync(AppRoleAssignment appRoleAssignmentToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AppRoleAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AppRoleAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AppRoleAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AppRoleAssignment.</returns>
        System.Threading.Tasks.Task<AppRoleAssignment> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AppRoleAssignment and returns a <see cref="GraphResponse{AppRoleAssignment}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AppRoleAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AppRoleAssignment>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AppRoleAssignment using PATCH.
        /// </summary>
        /// <param name="appRoleAssignmentToUpdate">The AppRoleAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AppRoleAssignment.</returns>
        System.Threading.Tasks.Task<AppRoleAssignment> UpdateAsync(AppRoleAssignment appRoleAssignmentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AppRoleAssignment using PATCH and returns a <see cref="GraphResponse{AppRoleAssignment}"/> object.
        /// </summary>
        /// <param name="appRoleAssignmentToUpdate">The AppRoleAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AppRoleAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AppRoleAssignment>> UpdateResponseAsync(AppRoleAssignment appRoleAssignmentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AppRoleAssignment using PUT.
        /// </summary>
        /// <param name="appRoleAssignmentToUpdate">The AppRoleAssignment object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<AppRoleAssignment> PutAsync(AppRoleAssignment appRoleAssignmentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AppRoleAssignment using PUT and returns a <see cref="GraphResponse{AppRoleAssignment}"/> object.
        /// </summary>
        /// <param name="appRoleAssignmentToUpdate">The AppRoleAssignment object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{AppRoleAssignment}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<AppRoleAssignment>> PutResponseAsync(AppRoleAssignment appRoleAssignmentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAppRoleAssignmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAppRoleAssignmentRequest Expand(Expression<Func<AppRoleAssignment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAppRoleAssignmentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAppRoleAssignmentRequest Select(Expression<Func<AppRoleAssignment, object>> selectExpression);

    }
}