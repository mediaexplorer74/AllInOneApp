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
    /// The interface IRemoteAssistancePartnerRequest.
    /// </summary>
    public partial interface IRemoteAssistancePartnerRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified RemoteAssistancePartner using POST.
        /// </summary>
        /// <param name="remoteAssistancePartnerToCreate">The RemoteAssistancePartner to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created RemoteAssistancePartner.</returns>
        System.Threading.Tasks.Task<RemoteAssistancePartner> CreateAsync(RemoteAssistancePartner remoteAssistancePartnerToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified RemoteAssistancePartner using POST and returns a <see cref="GraphResponse{RemoteAssistancePartner}"/> object.
        /// </summary>
        /// <param name="remoteAssistancePartnerToCreate">The RemoteAssistancePartner to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RemoteAssistancePartner}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RemoteAssistancePartner>> CreateResponseAsync(RemoteAssistancePartner remoteAssistancePartnerToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified RemoteAssistancePartner.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified RemoteAssistancePartner and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified RemoteAssistancePartner.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The RemoteAssistancePartner.</returns>
        System.Threading.Tasks.Task<RemoteAssistancePartner> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified RemoteAssistancePartner and returns a <see cref="GraphResponse{RemoteAssistancePartner}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RemoteAssistancePartner}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RemoteAssistancePartner>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified RemoteAssistancePartner using PATCH.
        /// </summary>
        /// <param name="remoteAssistancePartnerToUpdate">The RemoteAssistancePartner to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated RemoteAssistancePartner.</returns>
        System.Threading.Tasks.Task<RemoteAssistancePartner> UpdateAsync(RemoteAssistancePartner remoteAssistancePartnerToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified RemoteAssistancePartner using PATCH and returns a <see cref="GraphResponse{RemoteAssistancePartner}"/> object.
        /// </summary>
        /// <param name="remoteAssistancePartnerToUpdate">The RemoteAssistancePartner to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{RemoteAssistancePartner}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RemoteAssistancePartner>> UpdateResponseAsync(RemoteAssistancePartner remoteAssistancePartnerToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified RemoteAssistancePartner using PUT.
        /// </summary>
        /// <param name="remoteAssistancePartnerToUpdate">The RemoteAssistancePartner object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<RemoteAssistancePartner> PutAsync(RemoteAssistancePartner remoteAssistancePartnerToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified RemoteAssistancePartner using PUT and returns a <see cref="GraphResponse{RemoteAssistancePartner}"/> object.
        /// </summary>
        /// <param name="remoteAssistancePartnerToUpdate">The RemoteAssistancePartner object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{RemoteAssistancePartner}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<RemoteAssistancePartner>> PutResponseAsync(RemoteAssistancePartner remoteAssistancePartnerToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IRemoteAssistancePartnerRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IRemoteAssistancePartnerRequest Expand(Expression<Func<RemoteAssistancePartner, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IRemoteAssistancePartnerRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IRemoteAssistancePartnerRequest Select(Expression<Func<RemoteAssistancePartner, object>> selectExpression);

    }
}
