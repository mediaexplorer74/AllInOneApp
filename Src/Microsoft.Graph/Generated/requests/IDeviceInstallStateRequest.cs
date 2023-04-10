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
    /// The interface IDeviceInstallStateRequest.
    /// </summary>
    public partial interface IDeviceInstallStateRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceInstallState using POST.
        /// </summary>
        /// <param name="deviceInstallStateToCreate">The DeviceInstallState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceInstallState.</returns>
        System.Threading.Tasks.Task<DeviceInstallState> CreateAsync(DeviceInstallState deviceInstallStateToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified DeviceInstallState using POST and returns a <see cref="GraphResponse{DeviceInstallState}"/> object.
        /// </summary>
        /// <param name="deviceInstallStateToCreate">The DeviceInstallState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceInstallState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceInstallState>> CreateResponseAsync(DeviceInstallState deviceInstallStateToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceInstallState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceInstallState and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceInstallState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceInstallState.</returns>
        System.Threading.Tasks.Task<DeviceInstallState> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceInstallState and returns a <see cref="GraphResponse{DeviceInstallState}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceInstallState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceInstallState>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceInstallState using PATCH.
        /// </summary>
        /// <param name="deviceInstallStateToUpdate">The DeviceInstallState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceInstallState.</returns>
        System.Threading.Tasks.Task<DeviceInstallState> UpdateAsync(DeviceInstallState deviceInstallStateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceInstallState using PATCH and returns a <see cref="GraphResponse{DeviceInstallState}"/> object.
        /// </summary>
        /// <param name="deviceInstallStateToUpdate">The DeviceInstallState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceInstallState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceInstallState>> UpdateResponseAsync(DeviceInstallState deviceInstallStateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceInstallState using PUT.
        /// </summary>
        /// <param name="deviceInstallStateToUpdate">The DeviceInstallState object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DeviceInstallState> PutAsync(DeviceInstallState deviceInstallStateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceInstallState using PUT and returns a <see cref="GraphResponse{DeviceInstallState}"/> object.
        /// </summary>
        /// <param name="deviceInstallStateToUpdate">The DeviceInstallState object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DeviceInstallState}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceInstallState>> PutResponseAsync(DeviceInstallState deviceInstallStateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceInstallStateRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceInstallStateRequest Expand(Expression<Func<DeviceInstallState, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceInstallStateRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceInstallStateRequest Select(Expression<Func<DeviceInstallState, object>> selectExpression);

    }
}