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
    /// The interface IPlayPromptOperationRequest.
    /// </summary>
    public partial interface IPlayPromptOperationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PlayPromptOperation using POST.
        /// </summary>
        /// <param name="playPromptOperationToCreate">The PlayPromptOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PlayPromptOperation.</returns>
        System.Threading.Tasks.Task<PlayPromptOperation> CreateAsync(PlayPromptOperation playPromptOperationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified PlayPromptOperation using POST and returns a <see cref="GraphResponse{PlayPromptOperation}"/> object.
        /// </summary>
        /// <param name="playPromptOperationToCreate">The PlayPromptOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PlayPromptOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlayPromptOperation>> CreateResponseAsync(PlayPromptOperation playPromptOperationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified PlayPromptOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified PlayPromptOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified PlayPromptOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PlayPromptOperation.</returns>
        System.Threading.Tasks.Task<PlayPromptOperation> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified PlayPromptOperation and returns a <see cref="GraphResponse{PlayPromptOperation}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PlayPromptOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlayPromptOperation>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified PlayPromptOperation using PATCH.
        /// </summary>
        /// <param name="playPromptOperationToUpdate">The PlayPromptOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PlayPromptOperation.</returns>
        System.Threading.Tasks.Task<PlayPromptOperation> UpdateAsync(PlayPromptOperation playPromptOperationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified PlayPromptOperation using PATCH and returns a <see cref="GraphResponse{PlayPromptOperation}"/> object.
        /// </summary>
        /// <param name="playPromptOperationToUpdate">The PlayPromptOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PlayPromptOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlayPromptOperation>> UpdateResponseAsync(PlayPromptOperation playPromptOperationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified PlayPromptOperation using PUT.
        /// </summary>
        /// <param name="playPromptOperationToUpdate">The PlayPromptOperation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<PlayPromptOperation> PutAsync(PlayPromptOperation playPromptOperationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified PlayPromptOperation using PUT and returns a <see cref="GraphResponse{PlayPromptOperation}"/> object.
        /// </summary>
        /// <param name="playPromptOperationToUpdate">The PlayPromptOperation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{PlayPromptOperation}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlayPromptOperation>> PutResponseAsync(PlayPromptOperation playPromptOperationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlayPromptOperationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlayPromptOperationRequest Expand(Expression<Func<PlayPromptOperation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPlayPromptOperationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPlayPromptOperationRequest Select(Expression<Func<PlayPromptOperation, object>> selectExpression);

    }
}