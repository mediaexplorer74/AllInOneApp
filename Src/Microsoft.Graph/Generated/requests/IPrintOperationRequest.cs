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
    /// The interface IPrintOperationRequest.
    /// </summary>
    public partial interface IPrintOperationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PrintOperation using POST.
        /// </summary>
        /// <param name="printOperationToCreate">The PrintOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PrintOperation.</returns>
        System.Threading.Tasks.Task<PrintOperation> CreateAsync(PrintOperation printOperationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified PrintOperation using POST and returns a <see cref="GraphResponse{PrintOperation}"/> object.
        /// </summary>
        /// <param name="printOperationToCreate">The PrintOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PrintOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrintOperation>> CreateResponseAsync(PrintOperation printOperationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified PrintOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified PrintOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified PrintOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PrintOperation.</returns>
        System.Threading.Tasks.Task<PrintOperation> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified PrintOperation and returns a <see cref="GraphResponse{PrintOperation}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PrintOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrintOperation>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified PrintOperation using PATCH.
        /// </summary>
        /// <param name="printOperationToUpdate">The PrintOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PrintOperation.</returns>
        System.Threading.Tasks.Task<PrintOperation> UpdateAsync(PrintOperation printOperationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified PrintOperation using PATCH and returns a <see cref="GraphResponse{PrintOperation}"/> object.
        /// </summary>
        /// <param name="printOperationToUpdate">The PrintOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PrintOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrintOperation>> UpdateResponseAsync(PrintOperation printOperationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified PrintOperation using PUT.
        /// </summary>
        /// <param name="printOperationToUpdate">The PrintOperation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<PrintOperation> PutAsync(PrintOperation printOperationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified PrintOperation using PUT and returns a <see cref="GraphResponse{PrintOperation}"/> object.
        /// </summary>
        /// <param name="printOperationToUpdate">The PrintOperation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{PrintOperation}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrintOperation>> PutResponseAsync(PrintOperation printOperationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrintOperationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrintOperationRequest Expand(Expression<Func<PrintOperation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPrintOperationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPrintOperationRequest Select(Expression<Func<PrintOperation, object>> selectExpression);

    }
}
