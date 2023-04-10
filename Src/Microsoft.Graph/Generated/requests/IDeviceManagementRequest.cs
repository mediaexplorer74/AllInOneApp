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
    /// The interface IDeviceManagementRequest.
    /// </summary>
    public partial interface IDeviceManagementRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceManagement using POST.
        /// </summary>
        /// <param name="deviceManagementToCreate">The DeviceManagement to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagement.</returns>
        System.Threading.Tasks.Task<DeviceManagement> CreateAsync(DeviceManagement deviceManagementToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified DeviceManagement using POST and returns a <see cref="GraphResponse{DeviceManagement}"/> object.
        /// </summary>
        /// <param name="deviceManagementToCreate">The DeviceManagement to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagement}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagement>> CreateResponseAsync(DeviceManagement deviceManagementToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceManagement.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceManagement and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceManagement.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagement.</returns>
        System.Threading.Tasks.Task<DeviceManagement> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceManagement and returns a <see cref="GraphResponse{DeviceManagement}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagement}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagement>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagement using PATCH.
        /// </summary>
        /// <param name="deviceManagementToUpdate">The DeviceManagement to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagement.</returns>
        System.Threading.Tasks.Task<DeviceManagement> UpdateAsync(DeviceManagement deviceManagementToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagement using PATCH and returns a <see cref="GraphResponse{DeviceManagement}"/> object.
        /// </summary>
        /// <param name="deviceManagementToUpdate">The DeviceManagement to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagement}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagement>> UpdateResponseAsync(DeviceManagement deviceManagementToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagement using PUT.
        /// </summary>
        /// <param name="deviceManagementToUpdate">The DeviceManagement object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DeviceManagement> PutAsync(DeviceManagement deviceManagementToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagement using PUT and returns a <see cref="GraphResponse{DeviceManagement}"/> object.
        /// </summary>
        /// <param name="deviceManagementToUpdate">The DeviceManagement object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DeviceManagement}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagement>> PutResponseAsync(DeviceManagement deviceManagementToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementRequest Expand(Expression<Func<DeviceManagement, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementRequest Select(Expression<Func<DeviceManagement, object>> selectExpression);

    }
}