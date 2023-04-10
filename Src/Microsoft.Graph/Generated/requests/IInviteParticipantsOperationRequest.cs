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
    /// The interface IInviteParticipantsOperationRequest.
    /// </summary>
    public partial interface IInviteParticipantsOperationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified InviteParticipantsOperation using POST.
        /// </summary>
        /// <param name="inviteParticipantsOperationToCreate">The InviteParticipantsOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created InviteParticipantsOperation.</returns>
        System.Threading.Tasks.Task<InviteParticipantsOperation> CreateAsync(InviteParticipantsOperation inviteParticipantsOperationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified InviteParticipantsOperation using POST and returns a <see cref="GraphResponse{InviteParticipantsOperation}"/> object.
        /// </summary>
        /// <param name="inviteParticipantsOperationToCreate">The InviteParticipantsOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{InviteParticipantsOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<InviteParticipantsOperation>> CreateResponseAsync(InviteParticipantsOperation inviteParticipantsOperationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified InviteParticipantsOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified InviteParticipantsOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified InviteParticipantsOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The InviteParticipantsOperation.</returns>
        System.Threading.Tasks.Task<InviteParticipantsOperation> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified InviteParticipantsOperation and returns a <see cref="GraphResponse{InviteParticipantsOperation}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{InviteParticipantsOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<InviteParticipantsOperation>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified InviteParticipantsOperation using PATCH.
        /// </summary>
        /// <param name="inviteParticipantsOperationToUpdate">The InviteParticipantsOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated InviteParticipantsOperation.</returns>
        System.Threading.Tasks.Task<InviteParticipantsOperation> UpdateAsync(InviteParticipantsOperation inviteParticipantsOperationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified InviteParticipantsOperation using PATCH and returns a <see cref="GraphResponse{InviteParticipantsOperation}"/> object.
        /// </summary>
        /// <param name="inviteParticipantsOperationToUpdate">The InviteParticipantsOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{InviteParticipantsOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<InviteParticipantsOperation>> UpdateResponseAsync(InviteParticipantsOperation inviteParticipantsOperationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified InviteParticipantsOperation using PUT.
        /// </summary>
        /// <param name="inviteParticipantsOperationToUpdate">The InviteParticipantsOperation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<InviteParticipantsOperation> PutAsync(InviteParticipantsOperation inviteParticipantsOperationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified InviteParticipantsOperation using PUT and returns a <see cref="GraphResponse{InviteParticipantsOperation}"/> object.
        /// </summary>
        /// <param name="inviteParticipantsOperationToUpdate">The InviteParticipantsOperation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{InviteParticipantsOperation}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<InviteParticipantsOperation>> PutResponseAsync(InviteParticipantsOperation inviteParticipantsOperationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IInviteParticipantsOperationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IInviteParticipantsOperationRequest Expand(Expression<Func<InviteParticipantsOperation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IInviteParticipantsOperationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IInviteParticipantsOperationRequest Select(Expression<Func<InviteParticipantsOperation, object>> selectExpression);

    }
}