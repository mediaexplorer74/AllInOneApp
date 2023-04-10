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
    /// The interface IRoleAssignmentRequest.
    /// </summary>
    public partial interface IRoleAssignmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified RoleAssignment using POST.
        /// </summary>
        /// <param name="roleAssignmentToCreate">The RoleAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created RoleAssignment.</returns>
        System.Threading.Tasks.Task<RoleAssignment> CreateAsync(RoleAssignment roleAssignmentToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified RoleAssignment using POST and returns a <see cref="GraphResponse{RoleAssignment}"/> object.
        /// </summary>
        /// <param name="roleAssignmentToCreate">The RoleAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RoleAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RoleAssignment>> CreateResponseAsync(RoleAssignment roleAssignmentToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified RoleAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified RoleAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified RoleAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The RoleAssignment.</returns>
        System.Threading.Tasks.Task<RoleAssignment> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified RoleAssignment and returns a <see cref="GraphResponse{RoleAssignment}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RoleAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RoleAssignment>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified RoleAssignment using PATCH.
        /// </summary>
        /// <param name="roleAssignmentToUpdate">The RoleAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated RoleAssignment.</returns>
        System.Threading.Tasks.Task<RoleAssignment> UpdateAsync(RoleAssignment roleAssignmentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified RoleAssignment using PATCH and returns a <see cref="GraphResponse{RoleAssignment}"/> object.
        /// </summary>
        /// <param name="roleAssignmentToUpdate">The RoleAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{RoleAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RoleAssignment>> UpdateResponseAsync(RoleAssignment roleAssignmentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified RoleAssignment using PUT.
        /// </summary>
        /// <param name="roleAssignmentToUpdate">The RoleAssignment object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<RoleAssignment> PutAsync(RoleAssignment roleAssignmentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified RoleAssignment using PUT and returns a <see cref="GraphResponse{RoleAssignment}"/> object.
        /// </summary>
        /// <param name="roleAssignmentToUpdate">The RoleAssignment object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{RoleAssignment}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<RoleAssignment>> PutResponseAsync(RoleAssignment roleAssignmentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IRoleAssignmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IRoleAssignmentRequest Expand(Expression<Func<RoleAssignment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IRoleAssignmentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IRoleAssignmentRequest Select(Expression<Func<RoleAssignment, object>> selectExpression);

    }
}