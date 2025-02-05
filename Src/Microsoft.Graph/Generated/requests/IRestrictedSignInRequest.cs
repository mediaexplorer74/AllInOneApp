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
    /// The interface IRestrictedSignInRequest.
    /// </summary>
    public partial interface IRestrictedSignInRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified RestrictedSignIn using POST.
        /// </summary>
        /// <param name="restrictedSignInToCreate">The RestrictedSignIn to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created RestrictedSignIn.</returns>
        System.Threading.Tasks.Task<RestrictedSignIn> CreateAsync(RestrictedSignIn restrictedSignInToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified RestrictedSignIn using POST and returns a <see cref="GraphResponse{RestrictedSignIn}"/> object.
        /// </summary>
        /// <param name="restrictedSignInToCreate">The RestrictedSignIn to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RestrictedSignIn}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RestrictedSignIn>> CreateResponseAsync(RestrictedSignIn restrictedSignInToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified RestrictedSignIn.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified RestrictedSignIn and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified RestrictedSignIn.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The RestrictedSignIn.</returns>
        System.Threading.Tasks.Task<RestrictedSignIn> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified RestrictedSignIn and returns a <see cref="GraphResponse{RestrictedSignIn}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RestrictedSignIn}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RestrictedSignIn>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified RestrictedSignIn using PATCH.
        /// </summary>
        /// <param name="restrictedSignInToUpdate">The RestrictedSignIn to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated RestrictedSignIn.</returns>
        System.Threading.Tasks.Task<RestrictedSignIn> UpdateAsync(RestrictedSignIn restrictedSignInToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified RestrictedSignIn using PATCH and returns a <see cref="GraphResponse{RestrictedSignIn}"/> object.
        /// </summary>
        /// <param name="restrictedSignInToUpdate">The RestrictedSignIn to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{RestrictedSignIn}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RestrictedSignIn>> UpdateResponseAsync(RestrictedSignIn restrictedSignInToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified RestrictedSignIn using PUT.
        /// </summary>
        /// <param name="restrictedSignInToUpdate">The RestrictedSignIn object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<RestrictedSignIn> PutAsync(RestrictedSignIn restrictedSignInToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified RestrictedSignIn using PUT and returns a <see cref="GraphResponse{RestrictedSignIn}"/> object.
        /// </summary>
        /// <param name="restrictedSignInToUpdate">The RestrictedSignIn object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{RestrictedSignIn}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<RestrictedSignIn>> PutResponseAsync(RestrictedSignIn restrictedSignInToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IRestrictedSignInRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IRestrictedSignInRequest Expand(Expression<Func<RestrictedSignIn, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IRestrictedSignInRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IRestrictedSignInRequest Select(Expression<Func<RestrictedSignIn, object>> selectExpression);

    }
}
