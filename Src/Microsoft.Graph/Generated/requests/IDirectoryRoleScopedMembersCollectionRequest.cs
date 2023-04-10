// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDirectoryRoleScopedMembersCollectionRequest.
    /// </summary>
    public partial interface IDirectoryRoleScopedMembersCollectionRequest : IBaseRequest
    {
        /// <summary>
        /// Adds the specified ScopedRoleMembership to the collection via POST.
        /// </summary>
        /// <param name="scopedRoleMembership">The ScopedRoleMembership to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ScopedRoleMembership.</returns>
        System.Threading.Tasks.Task<ScopedRoleMembership> AddAsync(ScopedRoleMembership scopedRoleMembership, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified ScopedRoleMembership to the collection via POST and returns a <see cref="GraphResponse{ScopedRoleMembership}"/> object of the request.
        /// </summary>
        /// <param name="scopedRoleMembership">The ScopedRoleMembership to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ScopedRoleMembership}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ScopedRoleMembership>> AddResponseAsync(ScopedRoleMembership scopedRoleMembership, CancellationToken cancellationToken = default);


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDirectoryRoleScopedMembersCollectionPage> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{DirectoryRoleScopedMembersCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DirectoryRoleScopedMembersCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<DirectoryRoleScopedMembersCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryRoleScopedMembersCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryRoleScopedMembersCollectionRequest Expand(Expression<Func<ScopedRoleMembership, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryRoleScopedMembersCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryRoleScopedMembersCollectionRequest Select(Expression<Func<ScopedRoleMembership, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryRoleScopedMembersCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryRoleScopedMembersCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryRoleScopedMembersCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryRoleScopedMembersCollectionRequest OrderBy(string value);
    }
}
