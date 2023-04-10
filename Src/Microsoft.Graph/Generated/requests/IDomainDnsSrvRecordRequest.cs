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
    /// The interface IDomainDnsSrvRecordRequest.
    /// </summary>
    public partial interface IDomainDnsSrvRecordRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DomainDnsSrvRecord using POST.
        /// </summary>
        /// <param name="domainDnsSrvRecordToCreate">The DomainDnsSrvRecord to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DomainDnsSrvRecord.</returns>
        System.Threading.Tasks.Task<DomainDnsSrvRecord> CreateAsync(DomainDnsSrvRecord domainDnsSrvRecordToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified DomainDnsSrvRecord using POST and returns a <see cref="GraphResponse{DomainDnsSrvRecord}"/> object.
        /// </summary>
        /// <param name="domainDnsSrvRecordToCreate">The DomainDnsSrvRecord to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DomainDnsSrvRecord}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DomainDnsSrvRecord>> CreateResponseAsync(DomainDnsSrvRecord domainDnsSrvRecordToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DomainDnsSrvRecord.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DomainDnsSrvRecord and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DomainDnsSrvRecord.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DomainDnsSrvRecord.</returns>
        System.Threading.Tasks.Task<DomainDnsSrvRecord> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DomainDnsSrvRecord and returns a <see cref="GraphResponse{DomainDnsSrvRecord}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DomainDnsSrvRecord}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DomainDnsSrvRecord>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DomainDnsSrvRecord using PATCH.
        /// </summary>
        /// <param name="domainDnsSrvRecordToUpdate">The DomainDnsSrvRecord to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DomainDnsSrvRecord.</returns>
        System.Threading.Tasks.Task<DomainDnsSrvRecord> UpdateAsync(DomainDnsSrvRecord domainDnsSrvRecordToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DomainDnsSrvRecord using PATCH and returns a <see cref="GraphResponse{DomainDnsSrvRecord}"/> object.
        /// </summary>
        /// <param name="domainDnsSrvRecordToUpdate">The DomainDnsSrvRecord to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DomainDnsSrvRecord}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DomainDnsSrvRecord>> UpdateResponseAsync(DomainDnsSrvRecord domainDnsSrvRecordToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DomainDnsSrvRecord using PUT.
        /// </summary>
        /// <param name="domainDnsSrvRecordToUpdate">The DomainDnsSrvRecord object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DomainDnsSrvRecord> PutAsync(DomainDnsSrvRecord domainDnsSrvRecordToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DomainDnsSrvRecord using PUT and returns a <see cref="GraphResponse{DomainDnsSrvRecord}"/> object.
        /// </summary>
        /// <param name="domainDnsSrvRecordToUpdate">The DomainDnsSrvRecord object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DomainDnsSrvRecord}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DomainDnsSrvRecord>> PutResponseAsync(DomainDnsSrvRecord domainDnsSrvRecordToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDomainDnsSrvRecordRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDomainDnsSrvRecordRequest Expand(Expression<Func<DomainDnsSrvRecord, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDomainDnsSrvRecordRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDomainDnsSrvRecordRequest Select(Expression<Func<DomainDnsSrvRecord, object>> selectExpression);

    }
}