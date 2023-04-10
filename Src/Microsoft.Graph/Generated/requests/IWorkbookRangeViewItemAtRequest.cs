// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IMethodRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IWorkbookRangeViewItemAtRequest.
    /// </summary>
    public partial interface IWorkbookRangeViewItemAtRequest : IBaseRequest
    {

        /// <summary>
        /// Issues the GET request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<WorkbookRangeView> GetAsync(
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Issues the GET request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookRangeView>> GetResponseAsync(CancellationToken cancellationToken = default);


        /// <summary>
        /// Issues the PATCH request.
        /// </summary>
        /// <param name="workbookrangeview">The WorkbookRangeView object set with the properties to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<WorkbookRangeView> PatchAsync(WorkbookRangeView workbookrangeview,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Issues the PATCH request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="workbookrangeview">The WorkbookRangeView object set with the properties to update.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookRangeView>> PatchResponseAsync(WorkbookRangeView workbookrangeview, CancellationToken cancellationToken = default);


        /// <summary>
        /// Issues the PUT request.
        /// </summary>
        /// <param name="workbookrangeview">The WorkbookRangeView object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<WorkbookRangeView> PutAsync(WorkbookRangeView workbookrangeview,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Issues the PUT request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="workbookrangeview">The WorkbookRangeView object set with the properties to update.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookRangeView>> PutResponseAsync(WorkbookRangeView workbookrangeview, CancellationToken cancellationToken = default);


        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeViewItemAtRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeViewItemAtRequest Select(string value);
    }
}
