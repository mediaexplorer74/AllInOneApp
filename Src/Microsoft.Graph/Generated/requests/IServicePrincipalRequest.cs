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
    /// The interface IServicePrincipalRequest.
    /// </summary>
    public partial interface IServicePrincipalRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ServicePrincipal using POST.
        /// </summary>
        /// <param name="servicePrincipalToCreate">The ServicePrincipal to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ServicePrincipal.</returns>
        System.Threading.Tasks.Task<ServicePrincipal> CreateAsync(ServicePrincipal servicePrincipalToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified ServicePrincipal using POST and returns a <see cref="GraphResponse{ServicePrincipal}"/> object.
        /// </summary>
        /// <param name="servicePrincipalToCreate">The ServicePrincipal to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ServicePrincipal}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ServicePrincipal>> CreateResponseAsync(ServicePrincipal servicePrincipalToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ServicePrincipal.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ServicePrincipal and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ServicePrincipal.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ServicePrincipal.</returns>
        System.Threading.Tasks.Task<ServicePrincipal> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ServicePrincipal and returns a <see cref="GraphResponse{ServicePrincipal}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ServicePrincipal}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ServicePrincipal>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ServicePrincipal using PATCH.
        /// </summary>
        /// <param name="servicePrincipalToUpdate">The ServicePrincipal to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ServicePrincipal.</returns>
        System.Threading.Tasks.Task<ServicePrincipal> UpdateAsync(ServicePrincipal servicePrincipalToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ServicePrincipal using PATCH and returns a <see cref="GraphResponse{ServicePrincipal}"/> object.
        /// </summary>
        /// <param name="servicePrincipalToUpdate">The ServicePrincipal to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ServicePrincipal}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ServicePrincipal>> UpdateResponseAsync(ServicePrincipal servicePrincipalToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ServicePrincipal using PUT.
        /// </summary>
        /// <param name="servicePrincipalToUpdate">The ServicePrincipal object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ServicePrincipal> PutAsync(ServicePrincipal servicePrincipalToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ServicePrincipal using PUT and returns a <see cref="GraphResponse{ServicePrincipal}"/> object.
        /// </summary>
        /// <param name="servicePrincipalToUpdate">The ServicePrincipal object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ServicePrincipal}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ServicePrincipal>> PutResponseAsync(ServicePrincipal servicePrincipalToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IServicePrincipalRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IServicePrincipalRequest Expand(Expression<Func<ServicePrincipal, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IServicePrincipalRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IServicePrincipalRequest Select(Expression<Func<ServicePrincipal, object>> selectExpression);

    }
}
