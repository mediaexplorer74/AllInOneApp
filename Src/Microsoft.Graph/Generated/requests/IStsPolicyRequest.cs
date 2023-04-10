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
    /// The interface IStsPolicyRequest.
    /// </summary>
    public partial interface IStsPolicyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified StsPolicy using POST.
        /// </summary>
        /// <param name="stsPolicyToCreate">The StsPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created StsPolicy.</returns>
        System.Threading.Tasks.Task<StsPolicy> CreateAsync(StsPolicy stsPolicyToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified StsPolicy using POST and returns a <see cref="GraphResponse{StsPolicy}"/> object.
        /// </summary>
        /// <param name="stsPolicyToCreate">The StsPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{StsPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<StsPolicy>> CreateResponseAsync(StsPolicy stsPolicyToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified StsPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified StsPolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified StsPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The StsPolicy.</returns>
        System.Threading.Tasks.Task<StsPolicy> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified StsPolicy and returns a <see cref="GraphResponse{StsPolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{StsPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<StsPolicy>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified StsPolicy using PATCH.
        /// </summary>
        /// <param name="stsPolicyToUpdate">The StsPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated StsPolicy.</returns>
        System.Threading.Tasks.Task<StsPolicy> UpdateAsync(StsPolicy stsPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified StsPolicy using PATCH and returns a <see cref="GraphResponse{StsPolicy}"/> object.
        /// </summary>
        /// <param name="stsPolicyToUpdate">The StsPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{StsPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<StsPolicy>> UpdateResponseAsync(StsPolicy stsPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified StsPolicy using PUT.
        /// </summary>
        /// <param name="stsPolicyToUpdate">The StsPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<StsPolicy> PutAsync(StsPolicy stsPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified StsPolicy using PUT and returns a <see cref="GraphResponse{StsPolicy}"/> object.
        /// </summary>
        /// <param name="stsPolicyToUpdate">The StsPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{StsPolicy}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<StsPolicy>> PutResponseAsync(StsPolicy stsPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IStsPolicyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IStsPolicyRequest Expand(Expression<Func<StsPolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IStsPolicyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IStsPolicyRequest Select(Expression<Func<StsPolicy, object>> selectExpression);

    }
}