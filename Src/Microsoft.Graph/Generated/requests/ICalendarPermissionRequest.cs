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
    /// The interface ICalendarPermissionRequest.
    /// </summary>
    public partial interface ICalendarPermissionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified CalendarPermission using POST.
        /// </summary>
        /// <param name="calendarPermissionToCreate">The CalendarPermission to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CalendarPermission.</returns>
        System.Threading.Tasks.Task<CalendarPermission> CreateAsync(CalendarPermission calendarPermissionToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified CalendarPermission using POST and returns a <see cref="GraphResponse{CalendarPermission}"/> object.
        /// </summary>
        /// <param name="calendarPermissionToCreate">The CalendarPermission to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CalendarPermission}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CalendarPermission>> CreateResponseAsync(CalendarPermission calendarPermissionToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified CalendarPermission.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified CalendarPermission and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified CalendarPermission.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CalendarPermission.</returns>
        System.Threading.Tasks.Task<CalendarPermission> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified CalendarPermission and returns a <see cref="GraphResponse{CalendarPermission}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CalendarPermission}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CalendarPermission>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CalendarPermission using PATCH.
        /// </summary>
        /// <param name="calendarPermissionToUpdate">The CalendarPermission to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CalendarPermission.</returns>
        System.Threading.Tasks.Task<CalendarPermission> UpdateAsync(CalendarPermission calendarPermissionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CalendarPermission using PATCH and returns a <see cref="GraphResponse{CalendarPermission}"/> object.
        /// </summary>
        /// <param name="calendarPermissionToUpdate">The CalendarPermission to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{CalendarPermission}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CalendarPermission>> UpdateResponseAsync(CalendarPermission calendarPermissionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CalendarPermission using PUT.
        /// </summary>
        /// <param name="calendarPermissionToUpdate">The CalendarPermission object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<CalendarPermission> PutAsync(CalendarPermission calendarPermissionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CalendarPermission using PUT and returns a <see cref="GraphResponse{CalendarPermission}"/> object.
        /// </summary>
        /// <param name="calendarPermissionToUpdate">The CalendarPermission object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{CalendarPermission}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<CalendarPermission>> PutResponseAsync(CalendarPermission calendarPermissionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICalendarPermissionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICalendarPermissionRequest Expand(Expression<Func<CalendarPermission, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICalendarPermissionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICalendarPermissionRequest Select(Expression<Func<CalendarPermission, object>> selectExpression);

    }
}