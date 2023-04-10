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
    /// The interface IWorkbookTableRequest.
    /// </summary>
    public partial interface IWorkbookTableRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookTable using POST.
        /// </summary>
        /// <param name="workbookTableToCreate">The WorkbookTable to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookTable.</returns>
        System.Threading.Tasks.Task<WorkbookTable> CreateAsync(WorkbookTable workbookTableToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified WorkbookTable using POST and returns a <see cref="GraphResponse{WorkbookTable}"/> object.
        /// </summary>
        /// <param name="workbookTableToCreate">The WorkbookTable to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookTable}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookTable>> CreateResponseAsync(WorkbookTable workbookTableToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WorkbookTable.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WorkbookTable and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WorkbookTable.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookTable.</returns>
        System.Threading.Tasks.Task<WorkbookTable> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WorkbookTable and returns a <see cref="GraphResponse{WorkbookTable}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookTable}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookTable>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookTable using PATCH.
        /// </summary>
        /// <param name="workbookTableToUpdate">The WorkbookTable to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookTable.</returns>
        System.Threading.Tasks.Task<WorkbookTable> UpdateAsync(WorkbookTable workbookTableToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookTable using PATCH and returns a <see cref="GraphResponse{WorkbookTable}"/> object.
        /// </summary>
        /// <param name="workbookTableToUpdate">The WorkbookTable to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WorkbookTable}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookTable>> UpdateResponseAsync(WorkbookTable workbookTableToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookTable using PUT.
        /// </summary>
        /// <param name="workbookTableToUpdate">The WorkbookTable object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<WorkbookTable> PutAsync(WorkbookTable workbookTableToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookTable using PUT and returns a <see cref="GraphResponse{WorkbookTable}"/> object.
        /// </summary>
        /// <param name="workbookTableToUpdate">The WorkbookTable object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{WorkbookTable}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookTable>> PutResponseAsync(WorkbookTable workbookTableToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookTableRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookTableRequest Expand(Expression<Func<WorkbookTable, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookTableRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookTableRequest Select(Expression<Func<WorkbookTable, object>> selectExpression);

    }
}