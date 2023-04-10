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
    /// The interface IWorkbookRangeViewRequest.
    /// </summary>
    public partial interface IWorkbookRangeViewRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookRangeView using POST.
        /// </summary>
        /// <param name="workbookRangeViewToCreate">The WorkbookRangeView to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookRangeView.</returns>
        System.Threading.Tasks.Task<WorkbookRangeView> CreateAsync(WorkbookRangeView workbookRangeViewToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified WorkbookRangeView using POST and returns a <see cref="GraphResponse{WorkbookRangeView}"/> object.
        /// </summary>
        /// <param name="workbookRangeViewToCreate">The WorkbookRangeView to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookRangeView}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookRangeView>> CreateResponseAsync(WorkbookRangeView workbookRangeViewToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WorkbookRangeView.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WorkbookRangeView and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WorkbookRangeView.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookRangeView.</returns>
        System.Threading.Tasks.Task<WorkbookRangeView> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WorkbookRangeView and returns a <see cref="GraphResponse{WorkbookRangeView}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookRangeView}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookRangeView>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookRangeView using PATCH.
        /// </summary>
        /// <param name="workbookRangeViewToUpdate">The WorkbookRangeView to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookRangeView.</returns>
        System.Threading.Tasks.Task<WorkbookRangeView> UpdateAsync(WorkbookRangeView workbookRangeViewToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookRangeView using PATCH and returns a <see cref="GraphResponse{WorkbookRangeView}"/> object.
        /// </summary>
        /// <param name="workbookRangeViewToUpdate">The WorkbookRangeView to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WorkbookRangeView}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookRangeView>> UpdateResponseAsync(WorkbookRangeView workbookRangeViewToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookRangeView using PUT.
        /// </summary>
        /// <param name="workbookRangeViewToUpdate">The WorkbookRangeView object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<WorkbookRangeView> PutAsync(WorkbookRangeView workbookRangeViewToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookRangeView using PUT and returns a <see cref="GraphResponse{WorkbookRangeView}"/> object.
        /// </summary>
        /// <param name="workbookRangeViewToUpdate">The WorkbookRangeView object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{WorkbookRangeView}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookRangeView>> PutResponseAsync(WorkbookRangeView workbookRangeViewToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeViewRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeViewRequest Expand(Expression<Func<WorkbookRangeView, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeViewRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeViewRequest Select(Expression<Func<WorkbookRangeView, object>> selectExpression);

    }
}