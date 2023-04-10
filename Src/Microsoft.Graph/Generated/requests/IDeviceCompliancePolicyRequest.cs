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
    /// The interface IDeviceCompliancePolicyRequest.
    /// </summary>
    public partial interface IDeviceCompliancePolicyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceCompliancePolicy using POST.
        /// </summary>
        /// <param name="deviceCompliancePolicyToCreate">The DeviceCompliancePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceCompliancePolicy.</returns>
        System.Threading.Tasks.Task<DeviceCompliancePolicy> CreateAsync(DeviceCompliancePolicy deviceCompliancePolicyToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified DeviceCompliancePolicy using POST and returns a <see cref="GraphResponse{DeviceCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="deviceCompliancePolicyToCreate">The DeviceCompliancePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceCompliancePolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceCompliancePolicy>> CreateResponseAsync(DeviceCompliancePolicy deviceCompliancePolicyToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceCompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceCompliancePolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceCompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceCompliancePolicy.</returns>
        System.Threading.Tasks.Task<DeviceCompliancePolicy> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceCompliancePolicy and returns a <see cref="GraphResponse{DeviceCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceCompliancePolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceCompliancePolicy>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceCompliancePolicy using PATCH.
        /// </summary>
        /// <param name="deviceCompliancePolicyToUpdate">The DeviceCompliancePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceCompliancePolicy.</returns>
        System.Threading.Tasks.Task<DeviceCompliancePolicy> UpdateAsync(DeviceCompliancePolicy deviceCompliancePolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceCompliancePolicy using PATCH and returns a <see cref="GraphResponse{DeviceCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="deviceCompliancePolicyToUpdate">The DeviceCompliancePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceCompliancePolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceCompliancePolicy>> UpdateResponseAsync(DeviceCompliancePolicy deviceCompliancePolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceCompliancePolicy using PUT.
        /// </summary>
        /// <param name="deviceCompliancePolicyToUpdate">The DeviceCompliancePolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DeviceCompliancePolicy> PutAsync(DeviceCompliancePolicy deviceCompliancePolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceCompliancePolicy using PUT and returns a <see cref="GraphResponse{DeviceCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="deviceCompliancePolicyToUpdate">The DeviceCompliancePolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DeviceCompliancePolicy}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceCompliancePolicy>> PutResponseAsync(DeviceCompliancePolicy deviceCompliancePolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicyRequest Expand(Expression<Func<DeviceCompliancePolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicyRequest Select(Expression<Func<DeviceCompliancePolicy, object>> selectExpression);

    }
}