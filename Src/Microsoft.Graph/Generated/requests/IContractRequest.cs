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
    /// The interface IContractRequest.
    /// </summary>
    public partial interface IContractRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Contract using POST.
        /// </summary>
        /// <param name="contractToCreate">The Contract to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Contract.</returns>
        System.Threading.Tasks.Task<Contract> CreateAsync(Contract contractToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified Contract using POST and returns a <see cref="GraphResponse{Contract}"/> object.
        /// </summary>
        /// <param name="contractToCreate">The Contract to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Contract}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Contract>> CreateResponseAsync(Contract contractToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Contract.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Contract and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Contract.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Contract.</returns>
        System.Threading.Tasks.Task<Contract> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Contract and returns a <see cref="GraphResponse{Contract}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Contract}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Contract>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Contract using PATCH.
        /// </summary>
        /// <param name="contractToUpdate">The Contract to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Contract.</returns>
        System.Threading.Tasks.Task<Contract> UpdateAsync(Contract contractToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Contract using PATCH and returns a <see cref="GraphResponse{Contract}"/> object.
        /// </summary>
        /// <param name="contractToUpdate">The Contract to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Contract}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Contract>> UpdateResponseAsync(Contract contractToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Contract using PUT.
        /// </summary>
        /// <param name="contractToUpdate">The Contract object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<Contract> PutAsync(Contract contractToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Contract using PUT and returns a <see cref="GraphResponse{Contract}"/> object.
        /// </summary>
        /// <param name="contractToUpdate">The Contract object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{Contract}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<Contract>> PutResponseAsync(Contract contractToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IContractRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IContractRequest Expand(Expression<Func<Contract, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IContractRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IContractRequest Select(Expression<Func<Contract, object>> selectExpression);

    }
}