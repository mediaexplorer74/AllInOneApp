// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type ServicePrincipalRequest.
    /// </summary>
    public partial class ServicePrincipalRequest : BaseRequest, IServicePrincipalRequest
    {
        /// <summary>
        /// Constructs a new ServicePrincipalRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ServicePrincipalRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ServicePrincipal using POST.
        /// </summary>
        /// <param name="servicePrincipalToCreate">The ServicePrincipal to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ServicePrincipal.</returns>
        public async System.Threading.Tasks.Task<ServicePrincipal> CreateAsync(ServicePrincipal servicePrincipalToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<ServicePrincipal>(servicePrincipalToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified ServicePrincipal using POST and returns a <see cref="GraphResponse{ServicePrincipal}"/> object.
        /// </summary>
        /// <param name="servicePrincipalToCreate">The ServicePrincipal to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ServicePrincipal}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ServicePrincipal>> CreateResponseAsync(ServicePrincipal servicePrincipalToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<ServicePrincipal>(servicePrincipalToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified ServicePrincipal.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<ServicePrincipal>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ServicePrincipal and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified ServicePrincipal.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ServicePrincipal.</returns>
        public async System.Threading.Tasks.Task<ServicePrincipal> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<ServicePrincipal>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ServicePrincipal and returns a <see cref="GraphResponse{ServicePrincipal}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ServicePrincipal}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ServicePrincipal>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<ServicePrincipal>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ServicePrincipal using PATCH.
        /// </summary>
        /// <param name="servicePrincipalToUpdate">The ServicePrincipal to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ServicePrincipal.</returns>
        public async System.Threading.Tasks.Task<ServicePrincipal> UpdateAsync(ServicePrincipal servicePrincipalToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<ServicePrincipal>(servicePrincipalToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ServicePrincipal using PATCH and returns a <see cref="GraphResponse{ServicePrincipal}"/> object.
        /// </summary>
        /// <param name="servicePrincipalToUpdate">The ServicePrincipal to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ServicePrincipal}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ServicePrincipal>> UpdateResponseAsync(ServicePrincipal servicePrincipalToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<ServicePrincipal>(servicePrincipalToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ServicePrincipal using PUT.
        /// </summary>
        /// <param name="servicePrincipalToUpdate">The ServicePrincipal object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<ServicePrincipal> PutAsync(ServicePrincipal servicePrincipalToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<ServicePrincipal>(servicePrincipalToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ServicePrincipal using PUT and returns a <see cref="GraphResponse{ServicePrincipal}"/> object.
        /// </summary>
        /// <param name="servicePrincipalToUpdate">The ServicePrincipal object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{ServicePrincipal}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ServicePrincipal>> PutResponseAsync(ServicePrincipal servicePrincipalToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<ServicePrincipal>(servicePrincipalToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IServicePrincipalRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IServicePrincipalRequest Expand(Expression<Func<ServicePrincipal, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IServicePrincipalRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IServicePrincipalRequest Select(Expression<Func<ServicePrincipal, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="servicePrincipalToInitialize">The <see cref="ServicePrincipal"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ServicePrincipal servicePrincipalToInitialize)
        {

            if (servicePrincipalToInitialize != null)
            {
                if (servicePrincipalToInitialize.AppRoleAssignedTo != null && servicePrincipalToInitialize.AppRoleAssignedTo.CurrentPage != null)
                {
                    servicePrincipalToInitialize.AppRoleAssignedTo.InitializeNextPageRequest(this.Client, servicePrincipalToInitialize.AppRoleAssignedToNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    servicePrincipalToInitialize.AppRoleAssignedTo.AdditionalData = servicePrincipalToInitialize.AdditionalData;
                }
                if (servicePrincipalToInitialize.AppRoleAssignments != null && servicePrincipalToInitialize.AppRoleAssignments.CurrentPage != null)
                {
                    servicePrincipalToInitialize.AppRoleAssignments.InitializeNextPageRequest(this.Client, servicePrincipalToInitialize.AppRoleAssignmentsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    servicePrincipalToInitialize.AppRoleAssignments.AdditionalData = servicePrincipalToInitialize.AdditionalData;
                }
                if (servicePrincipalToInitialize.ClaimsMappingPolicies != null && servicePrincipalToInitialize.ClaimsMappingPolicies.CurrentPage != null)
                {
                    servicePrincipalToInitialize.ClaimsMappingPolicies.InitializeNextPageRequest(this.Client, servicePrincipalToInitialize.ClaimsMappingPoliciesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    servicePrincipalToInitialize.ClaimsMappingPolicies.AdditionalData = servicePrincipalToInitialize.AdditionalData;
                }
                if (servicePrincipalToInitialize.CreatedObjects != null && servicePrincipalToInitialize.CreatedObjects.CurrentPage != null)
                {
                    servicePrincipalToInitialize.CreatedObjects.InitializeNextPageRequest(this.Client, servicePrincipalToInitialize.CreatedObjectsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    servicePrincipalToInitialize.CreatedObjects.AdditionalData = servicePrincipalToInitialize.AdditionalData;
                }
                if (servicePrincipalToInitialize.DelegatedPermissionClassifications != null && servicePrincipalToInitialize.DelegatedPermissionClassifications.CurrentPage != null)
                {
                    servicePrincipalToInitialize.DelegatedPermissionClassifications.InitializeNextPageRequest(this.Client, servicePrincipalToInitialize.DelegatedPermissionClassificationsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    servicePrincipalToInitialize.DelegatedPermissionClassifications.AdditionalData = servicePrincipalToInitialize.AdditionalData;
                }
                if (servicePrincipalToInitialize.Endpoints != null && servicePrincipalToInitialize.Endpoints.CurrentPage != null)
                {
                    servicePrincipalToInitialize.Endpoints.InitializeNextPageRequest(this.Client, servicePrincipalToInitialize.EndpointsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    servicePrincipalToInitialize.Endpoints.AdditionalData = servicePrincipalToInitialize.AdditionalData;
                }
                if (servicePrincipalToInitialize.HomeRealmDiscoveryPolicies != null && servicePrincipalToInitialize.HomeRealmDiscoveryPolicies.CurrentPage != null)
                {
                    servicePrincipalToInitialize.HomeRealmDiscoveryPolicies.InitializeNextPageRequest(this.Client, servicePrincipalToInitialize.HomeRealmDiscoveryPoliciesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    servicePrincipalToInitialize.HomeRealmDiscoveryPolicies.AdditionalData = servicePrincipalToInitialize.AdditionalData;
                }
                if (servicePrincipalToInitialize.MemberOf != null && servicePrincipalToInitialize.MemberOf.CurrentPage != null)
                {
                    servicePrincipalToInitialize.MemberOf.InitializeNextPageRequest(this.Client, servicePrincipalToInitialize.MemberOfNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    servicePrincipalToInitialize.MemberOf.AdditionalData = servicePrincipalToInitialize.AdditionalData;
                }
                if (servicePrincipalToInitialize.Oauth2PermissionGrants != null && servicePrincipalToInitialize.Oauth2PermissionGrants.CurrentPage != null)
                {
                    servicePrincipalToInitialize.Oauth2PermissionGrants.InitializeNextPageRequest(this.Client, servicePrincipalToInitialize.Oauth2PermissionGrantsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    servicePrincipalToInitialize.Oauth2PermissionGrants.AdditionalData = servicePrincipalToInitialize.AdditionalData;
                }
                if (servicePrincipalToInitialize.OwnedObjects != null && servicePrincipalToInitialize.OwnedObjects.CurrentPage != null)
                {
                    servicePrincipalToInitialize.OwnedObjects.InitializeNextPageRequest(this.Client, servicePrincipalToInitialize.OwnedObjectsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    servicePrincipalToInitialize.OwnedObjects.AdditionalData = servicePrincipalToInitialize.AdditionalData;
                }
                if (servicePrincipalToInitialize.Owners != null && servicePrincipalToInitialize.Owners.CurrentPage != null)
                {
                    servicePrincipalToInitialize.Owners.InitializeNextPageRequest(this.Client, servicePrincipalToInitialize.OwnersNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    servicePrincipalToInitialize.Owners.AdditionalData = servicePrincipalToInitialize.AdditionalData;
                }
                if (servicePrincipalToInitialize.TokenIssuancePolicies != null && servicePrincipalToInitialize.TokenIssuancePolicies.CurrentPage != null)
                {
                    servicePrincipalToInitialize.TokenIssuancePolicies.InitializeNextPageRequest(this.Client, servicePrincipalToInitialize.TokenIssuancePoliciesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    servicePrincipalToInitialize.TokenIssuancePolicies.AdditionalData = servicePrincipalToInitialize.AdditionalData;
                }
                if (servicePrincipalToInitialize.TokenLifetimePolicies != null && servicePrincipalToInitialize.TokenLifetimePolicies.CurrentPage != null)
                {
                    servicePrincipalToInitialize.TokenLifetimePolicies.InitializeNextPageRequest(this.Client, servicePrincipalToInitialize.TokenLifetimePoliciesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    servicePrincipalToInitialize.TokenLifetimePolicies.AdditionalData = servicePrincipalToInitialize.AdditionalData;
                }
                if (servicePrincipalToInitialize.TransitiveMemberOf != null && servicePrincipalToInitialize.TransitiveMemberOf.CurrentPage != null)
                {
                    servicePrincipalToInitialize.TransitiveMemberOf.InitializeNextPageRequest(this.Client, servicePrincipalToInitialize.TransitiveMemberOfNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    servicePrincipalToInitialize.TransitiveMemberOf.AdditionalData = servicePrincipalToInitialize.AdditionalData;
                }

            }


        }
    }
}
