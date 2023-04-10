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
    /// The interface IMobileAppCategoryRequest.
    /// </summary>
    public partial interface IMobileAppCategoryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MobileAppCategory using POST.
        /// </summary>
        /// <param name="mobileAppCategoryToCreate">The MobileAppCategory to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MobileAppCategory.</returns>
        System.Threading.Tasks.Task<MobileAppCategory> CreateAsync(MobileAppCategory mobileAppCategoryToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified MobileAppCategory using POST and returns a <see cref="GraphResponse{MobileAppCategory}"/> object.
        /// </summary>
        /// <param name="mobileAppCategoryToCreate">The MobileAppCategory to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MobileAppCategory}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MobileAppCategory>> CreateResponseAsync(MobileAppCategory mobileAppCategoryToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified MobileAppCategory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified MobileAppCategory and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified MobileAppCategory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MobileAppCategory.</returns>
        System.Threading.Tasks.Task<MobileAppCategory> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified MobileAppCategory and returns a <see cref="GraphResponse{MobileAppCategory}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MobileAppCategory}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MobileAppCategory>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MobileAppCategory using PATCH.
        /// </summary>
        /// <param name="mobileAppCategoryToUpdate">The MobileAppCategory to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MobileAppCategory.</returns>
        System.Threading.Tasks.Task<MobileAppCategory> UpdateAsync(MobileAppCategory mobileAppCategoryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MobileAppCategory using PATCH and returns a <see cref="GraphResponse{MobileAppCategory}"/> object.
        /// </summary>
        /// <param name="mobileAppCategoryToUpdate">The MobileAppCategory to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MobileAppCategory}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MobileAppCategory>> UpdateResponseAsync(MobileAppCategory mobileAppCategoryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MobileAppCategory using PUT.
        /// </summary>
        /// <param name="mobileAppCategoryToUpdate">The MobileAppCategory object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<MobileAppCategory> PutAsync(MobileAppCategory mobileAppCategoryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MobileAppCategory using PUT and returns a <see cref="GraphResponse{MobileAppCategory}"/> object.
        /// </summary>
        /// <param name="mobileAppCategoryToUpdate">The MobileAppCategory object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{MobileAppCategory}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<MobileAppCategory>> PutResponseAsync(MobileAppCategory mobileAppCategoryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppCategoryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppCategoryRequest Expand(Expression<Func<MobileAppCategory, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppCategoryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppCategoryRequest Select(Expression<Func<MobileAppCategory, object>> selectExpression);

    }
}