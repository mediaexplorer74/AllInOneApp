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
    /// The interface IWorkbookCommentReplyRequest.
    /// </summary>
    public partial interface IWorkbookCommentReplyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookCommentReply using POST.
        /// </summary>
        /// <param name="workbookCommentReplyToCreate">The WorkbookCommentReply to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookCommentReply.</returns>
        System.Threading.Tasks.Task<WorkbookCommentReply> CreateAsync(WorkbookCommentReply workbookCommentReplyToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified WorkbookCommentReply using POST and returns a <see cref="GraphResponse{WorkbookCommentReply}"/> object.
        /// </summary>
        /// <param name="workbookCommentReplyToCreate">The WorkbookCommentReply to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookCommentReply}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookCommentReply>> CreateResponseAsync(WorkbookCommentReply workbookCommentReplyToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WorkbookCommentReply.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WorkbookCommentReply and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WorkbookCommentReply.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookCommentReply.</returns>
        System.Threading.Tasks.Task<WorkbookCommentReply> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WorkbookCommentReply and returns a <see cref="GraphResponse{WorkbookCommentReply}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookCommentReply}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookCommentReply>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookCommentReply using PATCH.
        /// </summary>
        /// <param name="workbookCommentReplyToUpdate">The WorkbookCommentReply to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookCommentReply.</returns>
        System.Threading.Tasks.Task<WorkbookCommentReply> UpdateAsync(WorkbookCommentReply workbookCommentReplyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookCommentReply using PATCH and returns a <see cref="GraphResponse{WorkbookCommentReply}"/> object.
        /// </summary>
        /// <param name="workbookCommentReplyToUpdate">The WorkbookCommentReply to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WorkbookCommentReply}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookCommentReply>> UpdateResponseAsync(WorkbookCommentReply workbookCommentReplyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookCommentReply using PUT.
        /// </summary>
        /// <param name="workbookCommentReplyToUpdate">The WorkbookCommentReply object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<WorkbookCommentReply> PutAsync(WorkbookCommentReply workbookCommentReplyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookCommentReply using PUT and returns a <see cref="GraphResponse{WorkbookCommentReply}"/> object.
        /// </summary>
        /// <param name="workbookCommentReplyToUpdate">The WorkbookCommentReply object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{WorkbookCommentReply}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookCommentReply>> PutResponseAsync(WorkbookCommentReply workbookCommentReplyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookCommentReplyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookCommentReplyRequest Expand(Expression<Func<WorkbookCommentReply, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookCommentReplyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookCommentReplyRequest Select(Expression<Func<WorkbookCommentReply, object>> selectExpression);

    }
}
