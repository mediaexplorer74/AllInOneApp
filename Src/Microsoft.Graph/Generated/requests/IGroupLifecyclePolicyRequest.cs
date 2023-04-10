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
    /// The interface IGroupLifecyclePolicyRequest.
    /// </summary>
    public partial interface IGroupLifecyclePolicyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified GroupLifecyclePolicy using POST.
        /// </summary>
        /// <param name="groupLifecyclePolicyToCreate">The GroupLifecyclePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GroupLifecyclePolicy.</returns>
        System.Threading.Tasks.Task<GroupLifecyclePolicy> CreateAsync(GroupLifecyclePolicy groupLifecyclePolicyToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified GroupLifecyclePolicy using POST and returns a <see cref="GraphResponse{GroupLifecyclePolicy}"/> object.
        /// </summary>
        /// <param name="groupLifecyclePolicyToCreate">The GroupLifecyclePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupLifecyclePolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GroupLifecyclePolicy>> CreateResponseAsync(GroupLifecyclePolicy groupLifecyclePolicyToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified GroupLifecyclePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified GroupLifecyclePolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified GroupLifecyclePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GroupLifecyclePolicy.</returns>
        System.Threading.Tasks.Task<GroupLifecyclePolicy> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified GroupLifecyclePolicy and returns a <see cref="GraphResponse{GroupLifecyclePolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupLifecyclePolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GroupLifecyclePolicy>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified GroupLifecyclePolicy using PATCH.
        /// </summary>
        /// <param name="groupLifecyclePolicyToUpdate">The GroupLifecyclePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GroupLifecyclePolicy.</returns>
        System.Threading.Tasks.Task<GroupLifecyclePolicy> UpdateAsync(GroupLifecyclePolicy groupLifecyclePolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified GroupLifecyclePolicy using PATCH and returns a <see cref="GraphResponse{GroupLifecyclePolicy}"/> object.
        /// </summary>
        /// <param name="groupLifecyclePolicyToUpdate">The GroupLifecyclePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{GroupLifecyclePolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GroupLifecyclePolicy>> UpdateResponseAsync(GroupLifecyclePolicy groupLifecyclePolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified GroupLifecyclePolicy using PUT.
        /// </summary>
        /// <param name="groupLifecyclePolicyToUpdate">The GroupLifecyclePolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<GroupLifecyclePolicy> PutAsync(GroupLifecyclePolicy groupLifecyclePolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified GroupLifecyclePolicy using PUT and returns a <see cref="GraphResponse{GroupLifecyclePolicy}"/> object.
        /// </summary>
        /// <param name="groupLifecyclePolicyToUpdate">The GroupLifecyclePolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{GroupLifecyclePolicy}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<GroupLifecyclePolicy>> PutResponseAsync(GroupLifecyclePolicy groupLifecyclePolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupLifecyclePolicyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupLifecyclePolicyRequest Expand(Expression<Func<GroupLifecyclePolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupLifecyclePolicyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupLifecyclePolicyRequest Select(Expression<Func<GroupLifecyclePolicy, object>> selectExpression);

    }
}
