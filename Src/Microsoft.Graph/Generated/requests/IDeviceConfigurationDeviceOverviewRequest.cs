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
    /// The interface IDeviceConfigurationDeviceOverviewRequest.
    /// </summary>
    public partial interface IDeviceConfigurationDeviceOverviewRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceConfigurationDeviceOverview using POST.
        /// </summary>
        /// <param name="deviceConfigurationDeviceOverviewToCreate">The DeviceConfigurationDeviceOverview to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceConfigurationDeviceOverview.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationDeviceOverview> CreateAsync(DeviceConfigurationDeviceOverview deviceConfigurationDeviceOverviewToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified DeviceConfigurationDeviceOverview using POST and returns a <see cref="GraphResponse{DeviceConfigurationDeviceOverview}"/> object.
        /// </summary>
        /// <param name="deviceConfigurationDeviceOverviewToCreate">The DeviceConfigurationDeviceOverview to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceConfigurationDeviceOverview}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceConfigurationDeviceOverview>> CreateResponseAsync(DeviceConfigurationDeviceOverview deviceConfigurationDeviceOverviewToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceConfigurationDeviceOverview.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceConfigurationDeviceOverview and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceConfigurationDeviceOverview.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceConfigurationDeviceOverview.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationDeviceOverview> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceConfigurationDeviceOverview and returns a <see cref="GraphResponse{DeviceConfigurationDeviceOverview}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceConfigurationDeviceOverview}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceConfigurationDeviceOverview>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceConfigurationDeviceOverview using PATCH.
        /// </summary>
        /// <param name="deviceConfigurationDeviceOverviewToUpdate">The DeviceConfigurationDeviceOverview to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceConfigurationDeviceOverview.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationDeviceOverview> UpdateAsync(DeviceConfigurationDeviceOverview deviceConfigurationDeviceOverviewToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceConfigurationDeviceOverview using PATCH and returns a <see cref="GraphResponse{DeviceConfigurationDeviceOverview}"/> object.
        /// </summary>
        /// <param name="deviceConfigurationDeviceOverviewToUpdate">The DeviceConfigurationDeviceOverview to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceConfigurationDeviceOverview}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceConfigurationDeviceOverview>> UpdateResponseAsync(DeviceConfigurationDeviceOverview deviceConfigurationDeviceOverviewToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceConfigurationDeviceOverview using PUT.
        /// </summary>
        /// <param name="deviceConfigurationDeviceOverviewToUpdate">The DeviceConfigurationDeviceOverview object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationDeviceOverview> PutAsync(DeviceConfigurationDeviceOverview deviceConfigurationDeviceOverviewToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceConfigurationDeviceOverview using PUT and returns a <see cref="GraphResponse{DeviceConfigurationDeviceOverview}"/> object.
        /// </summary>
        /// <param name="deviceConfigurationDeviceOverviewToUpdate">The DeviceConfigurationDeviceOverview object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DeviceConfigurationDeviceOverview}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceConfigurationDeviceOverview>> PutResponseAsync(DeviceConfigurationDeviceOverview deviceConfigurationDeviceOverviewToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationDeviceOverviewRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationDeviceOverviewRequest Expand(Expression<Func<DeviceConfigurationDeviceOverview, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationDeviceOverviewRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationDeviceOverviewRequest Select(Expression<Func<DeviceConfigurationDeviceOverview, object>> selectExpression);

    }
}