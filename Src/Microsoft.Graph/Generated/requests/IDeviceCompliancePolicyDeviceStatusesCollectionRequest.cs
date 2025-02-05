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
    /// The interface IDeviceCompliancePolicyDeviceStatusesCollectionRequest.
    /// </summary>
    public partial interface IDeviceCompliancePolicyDeviceStatusesCollectionRequest : IBaseRequest
    {
        /// <summary>
        /// Adds the specified DeviceComplianceDeviceStatus to the collection via POST.
        /// </summary>
        /// <param name="deviceComplianceDeviceStatus">The DeviceComplianceDeviceStatus to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceComplianceDeviceStatus.</returns>
        System.Threading.Tasks.Task<DeviceComplianceDeviceStatus> AddAsync(DeviceComplianceDeviceStatus deviceComplianceDeviceStatus, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified DeviceComplianceDeviceStatus to the collection via POST and returns a <see cref="GraphResponse{DeviceComplianceDeviceStatus}"/> object of the request.
        /// </summary>
        /// <param name="deviceComplianceDeviceStatus">The DeviceComplianceDeviceStatus to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceComplianceDeviceStatus}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceComplianceDeviceStatus>> AddResponseAsync(DeviceComplianceDeviceStatus deviceComplianceDeviceStatus, CancellationToken cancellationToken = default);


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDeviceCompliancePolicyDeviceStatusesCollectionPage> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{DeviceCompliancePolicyDeviceStatusesCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceCompliancePolicyDeviceStatusesCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceCompliancePolicyDeviceStatusesCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicyDeviceStatusesCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicyDeviceStatusesCollectionRequest Expand(Expression<Func<DeviceComplianceDeviceStatus, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicyDeviceStatusesCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicyDeviceStatusesCollectionRequest Select(Expression<Func<DeviceComplianceDeviceStatus, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicyDeviceStatusesCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicyDeviceStatusesCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicyDeviceStatusesCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicyDeviceStatusesCollectionRequest OrderBy(string value);
    }
}
