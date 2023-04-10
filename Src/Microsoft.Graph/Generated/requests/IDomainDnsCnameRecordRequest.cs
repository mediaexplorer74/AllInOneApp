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
    /// The interface IDomainDnsCnameRecordRequest.
    /// </summary>
    public partial interface IDomainDnsCnameRecordRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DomainDnsCnameRecord using POST.
        /// </summary>
        /// <param name="domainDnsCnameRecordToCreate">The DomainDnsCnameRecord to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DomainDnsCnameRecord.</returns>
        System.Threading.Tasks.Task<DomainDnsCnameRecord> CreateAsync(DomainDnsCnameRecord domainDnsCnameRecordToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified DomainDnsCnameRecord using POST and returns a <see cref="GraphResponse{DomainDnsCnameRecord}"/> object.
        /// </summary>
        /// <param name="domainDnsCnameRecordToCreate">The DomainDnsCnameRecord to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DomainDnsCnameRecord}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DomainDnsCnameRecord>> CreateResponseAsync(DomainDnsCnameRecord domainDnsCnameRecordToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DomainDnsCnameRecord.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DomainDnsCnameRecord and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DomainDnsCnameRecord.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DomainDnsCnameRecord.</returns>
        System.Threading.Tasks.Task<DomainDnsCnameRecord> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DomainDnsCnameRecord and returns a <see cref="GraphResponse{DomainDnsCnameRecord}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DomainDnsCnameRecord}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DomainDnsCnameRecord>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DomainDnsCnameRecord using PATCH.
        /// </summary>
        /// <param name="domainDnsCnameRecordToUpdate">The DomainDnsCnameRecord to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DomainDnsCnameRecord.</returns>
        System.Threading.Tasks.Task<DomainDnsCnameRecord> UpdateAsync(DomainDnsCnameRecord domainDnsCnameRecordToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DomainDnsCnameRecord using PATCH and returns a <see cref="GraphResponse{DomainDnsCnameRecord}"/> object.
        /// </summary>
        /// <param name="domainDnsCnameRecordToUpdate">The DomainDnsCnameRecord to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DomainDnsCnameRecord}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DomainDnsCnameRecord>> UpdateResponseAsync(DomainDnsCnameRecord domainDnsCnameRecordToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DomainDnsCnameRecord using PUT.
        /// </summary>
        /// <param name="domainDnsCnameRecordToUpdate">The DomainDnsCnameRecord object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DomainDnsCnameRecord> PutAsync(DomainDnsCnameRecord domainDnsCnameRecordToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DomainDnsCnameRecord using PUT and returns a <see cref="GraphResponse{DomainDnsCnameRecord}"/> object.
        /// </summary>
        /// <param name="domainDnsCnameRecordToUpdate">The DomainDnsCnameRecord object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DomainDnsCnameRecord}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DomainDnsCnameRecord>> PutResponseAsync(DomainDnsCnameRecord domainDnsCnameRecordToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDomainDnsCnameRecordRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDomainDnsCnameRecordRequest Expand(Expression<Func<DomainDnsCnameRecord, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDomainDnsCnameRecordRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDomainDnsCnameRecordRequest Select(Expression<Func<DomainDnsCnameRecord, object>> selectExpression);

    }
}