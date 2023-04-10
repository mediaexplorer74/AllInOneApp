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
    /// The type UserRequest.
    /// </summary>
    public partial class UserRequest : BaseRequest, IUserRequest
    {
        /// <summary>
        /// Constructs a new UserRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public UserRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified User using POST.
        /// </summary>
        /// <param name="userToCreate">The User to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created User.</returns>
        public async System.Threading.Tasks.Task<User> CreateAsync(User userToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<User>(userToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified User using POST and returns a <see cref="GraphResponse{User}"/> object.
        /// </summary>
        /// <param name="userToCreate">The User to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{User}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<User>> CreateResponseAsync(User userToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<User>(userToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified User.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<User>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified User and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified User.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The User.</returns>
        public async System.Threading.Tasks.Task<User> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<User>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified User and returns a <see cref="GraphResponse{User}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{User}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<User>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<User>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified User using PATCH.
        /// </summary>
        /// <param name="userToUpdate">The User to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated User.</returns>
        public async System.Threading.Tasks.Task<User> UpdateAsync(User userToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<User>(userToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified User using PATCH and returns a <see cref="GraphResponse{User}"/> object.
        /// </summary>
        /// <param name="userToUpdate">The User to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{User}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<User>> UpdateResponseAsync(User userToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<User>(userToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified User using PUT.
        /// </summary>
        /// <param name="userToUpdate">The User object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<User> PutAsync(User userToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<User>(userToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified User using PUT and returns a <see cref="GraphResponse{User}"/> object.
        /// </summary>
        /// <param name="userToUpdate">The User object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{User}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<User>> PutResponseAsync(User userToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<User>(userToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUserRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUserRequest Expand(Expression<Func<User, object>> expandExpression)
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
        public IUserRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IUserRequest Select(Expression<Func<User, object>> selectExpression)
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
        /// <param name="userToInitialize">The <see cref="User"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(User userToInitialize)
        {

            if (userToInitialize != null)
            {
                if (userToInitialize.AppRoleAssignments != null && userToInitialize.AppRoleAssignments.CurrentPage != null)
                {
                    userToInitialize.AppRoleAssignments.InitializeNextPageRequest(this.Client, userToInitialize.AppRoleAssignmentsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.AppRoleAssignments.AdditionalData = userToInitialize.AdditionalData;
                }
                if (userToInitialize.CreatedObjects != null && userToInitialize.CreatedObjects.CurrentPage != null)
                {
                    userToInitialize.CreatedObjects.InitializeNextPageRequest(this.Client, userToInitialize.CreatedObjectsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.CreatedObjects.AdditionalData = userToInitialize.AdditionalData;
                }
                if (userToInitialize.DirectReports != null && userToInitialize.DirectReports.CurrentPage != null)
                {
                    userToInitialize.DirectReports.InitializeNextPageRequest(this.Client, userToInitialize.DirectReportsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.DirectReports.AdditionalData = userToInitialize.AdditionalData;
                }
                if (userToInitialize.LicenseDetails != null && userToInitialize.LicenseDetails.CurrentPage != null)
                {
                    userToInitialize.LicenseDetails.InitializeNextPageRequest(this.Client, userToInitialize.LicenseDetailsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.LicenseDetails.AdditionalData = userToInitialize.AdditionalData;
                }
                if (userToInitialize.MemberOf != null && userToInitialize.MemberOf.CurrentPage != null)
                {
                    userToInitialize.MemberOf.InitializeNextPageRequest(this.Client, userToInitialize.MemberOfNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.MemberOf.AdditionalData = userToInitialize.AdditionalData;
                }
                if (userToInitialize.Oauth2PermissionGrants != null && userToInitialize.Oauth2PermissionGrants.CurrentPage != null)
                {
                    userToInitialize.Oauth2PermissionGrants.InitializeNextPageRequest(this.Client, userToInitialize.Oauth2PermissionGrantsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.Oauth2PermissionGrants.AdditionalData = userToInitialize.AdditionalData;
                }
                if (userToInitialize.OwnedDevices != null && userToInitialize.OwnedDevices.CurrentPage != null)
                {
                    userToInitialize.OwnedDevices.InitializeNextPageRequest(this.Client, userToInitialize.OwnedDevicesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.OwnedDevices.AdditionalData = userToInitialize.AdditionalData;
                }
                if (userToInitialize.OwnedObjects != null && userToInitialize.OwnedObjects.CurrentPage != null)
                {
                    userToInitialize.OwnedObjects.InitializeNextPageRequest(this.Client, userToInitialize.OwnedObjectsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.OwnedObjects.AdditionalData = userToInitialize.AdditionalData;
                }
                if (userToInitialize.RegisteredDevices != null && userToInitialize.RegisteredDevices.CurrentPage != null)
                {
                    userToInitialize.RegisteredDevices.InitializeNextPageRequest(this.Client, userToInitialize.RegisteredDevicesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.RegisteredDevices.AdditionalData = userToInitialize.AdditionalData;
                }
                if (userToInitialize.ScopedRoleMemberOf != null && userToInitialize.ScopedRoleMemberOf.CurrentPage != null)
                {
                    userToInitialize.ScopedRoleMemberOf.InitializeNextPageRequest(this.Client, userToInitialize.ScopedRoleMemberOfNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.ScopedRoleMemberOf.AdditionalData = userToInitialize.AdditionalData;
                }
                if (userToInitialize.TransitiveMemberOf != null && userToInitialize.TransitiveMemberOf.CurrentPage != null)
                {
                    userToInitialize.TransitiveMemberOf.InitializeNextPageRequest(this.Client, userToInitialize.TransitiveMemberOfNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.TransitiveMemberOf.AdditionalData = userToInitialize.AdditionalData;
                }
                if (userToInitialize.CalendarGroups != null && userToInitialize.CalendarGroups.CurrentPage != null)
                {
                    userToInitialize.CalendarGroups.InitializeNextPageRequest(this.Client, userToInitialize.CalendarGroupsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.CalendarGroups.AdditionalData = userToInitialize.AdditionalData;
                }
                if (userToInitialize.Calendars != null && userToInitialize.Calendars.CurrentPage != null)
                {
                    userToInitialize.Calendars.InitializeNextPageRequest(this.Client, userToInitialize.CalendarsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.Calendars.AdditionalData = userToInitialize.AdditionalData;
                }
                if (userToInitialize.CalendarView != null && userToInitialize.CalendarView.CurrentPage != null)
                {
                    userToInitialize.CalendarView.InitializeNextPageRequest(this.Client, userToInitialize.CalendarViewNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.CalendarView.AdditionalData = userToInitialize.AdditionalData;
                }
                if (userToInitialize.ContactFolders != null && userToInitialize.ContactFolders.CurrentPage != null)
                {
                    userToInitialize.ContactFolders.InitializeNextPageRequest(this.Client, userToInitialize.ContactFoldersNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.ContactFolders.AdditionalData = userToInitialize.AdditionalData;
                }
                if (userToInitialize.Contacts != null && userToInitialize.Contacts.CurrentPage != null)
                {
                    userToInitialize.Contacts.InitializeNextPageRequest(this.Client, userToInitialize.ContactsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.Contacts.AdditionalData = userToInitialize.AdditionalData;
                }
                if (userToInitialize.Events != null && userToInitialize.Events.CurrentPage != null)
                {
                    userToInitialize.Events.InitializeNextPageRequest(this.Client, userToInitialize.EventsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.Events.AdditionalData = userToInitialize.AdditionalData;
                }
                if (userToInitialize.MailFolders != null && userToInitialize.MailFolders.CurrentPage != null)
                {
                    userToInitialize.MailFolders.InitializeNextPageRequest(this.Client, userToInitialize.MailFoldersNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.MailFolders.AdditionalData = userToInitialize.AdditionalData;
                }
                if (userToInitialize.Messages != null && userToInitialize.Messages.CurrentPage != null)
                {
                    userToInitialize.Messages.InitializeNextPageRequest(this.Client, userToInitialize.MessagesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.Messages.AdditionalData = userToInitialize.AdditionalData;
                }
                if (userToInitialize.People != null && userToInitialize.People.CurrentPage != null)
                {
                    userToInitialize.People.InitializeNextPageRequest(this.Client, userToInitialize.PeopleNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.People.AdditionalData = userToInitialize.AdditionalData;
                }
                if (userToInitialize.Photos != null && userToInitialize.Photos.CurrentPage != null)
                {
                    userToInitialize.Photos.InitializeNextPageRequest(this.Client, userToInitialize.PhotosNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.Photos.AdditionalData = userToInitialize.AdditionalData;
                }
                if (userToInitialize.Drives != null && userToInitialize.Drives.CurrentPage != null)
                {
                    userToInitialize.Drives.InitializeNextPageRequest(this.Client, userToInitialize.DrivesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.Drives.AdditionalData = userToInitialize.AdditionalData;
                }
                if (userToInitialize.FollowedSites != null && userToInitialize.FollowedSites.CurrentPage != null)
                {
                    userToInitialize.FollowedSites.InitializeNextPageRequest(this.Client, userToInitialize.FollowedSitesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.FollowedSites.AdditionalData = userToInitialize.AdditionalData;
                }
                if (userToInitialize.Extensions != null && userToInitialize.Extensions.CurrentPage != null)
                {
                    userToInitialize.Extensions.InitializeNextPageRequest(this.Client, userToInitialize.ExtensionsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.Extensions.AdditionalData = userToInitialize.AdditionalData;
                }
                if (userToInitialize.AgreementAcceptances != null && userToInitialize.AgreementAcceptances.CurrentPage != null)
                {
                    userToInitialize.AgreementAcceptances.InitializeNextPageRequest(this.Client, userToInitialize.AgreementAcceptancesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.AgreementAcceptances.AdditionalData = userToInitialize.AdditionalData;
                }
                if (userToInitialize.ManagedDevices != null && userToInitialize.ManagedDevices.CurrentPage != null)
                {
                    userToInitialize.ManagedDevices.InitializeNextPageRequest(this.Client, userToInitialize.ManagedDevicesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.ManagedDevices.AdditionalData = userToInitialize.AdditionalData;
                }
                if (userToInitialize.ManagedAppRegistrations != null && userToInitialize.ManagedAppRegistrations.CurrentPage != null)
                {
                    userToInitialize.ManagedAppRegistrations.InitializeNextPageRequest(this.Client, userToInitialize.ManagedAppRegistrationsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.ManagedAppRegistrations.AdditionalData = userToInitialize.AdditionalData;
                }
                if (userToInitialize.DeviceManagementTroubleshootingEvents != null && userToInitialize.DeviceManagementTroubleshootingEvents.CurrentPage != null)
                {
                    userToInitialize.DeviceManagementTroubleshootingEvents.InitializeNextPageRequest(this.Client, userToInitialize.DeviceManagementTroubleshootingEventsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.DeviceManagementTroubleshootingEvents.AdditionalData = userToInitialize.AdditionalData;
                }
                if (userToInitialize.Activities != null && userToInitialize.Activities.CurrentPage != null)
                {
                    userToInitialize.Activities.InitializeNextPageRequest(this.Client, userToInitialize.ActivitiesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.Activities.AdditionalData = userToInitialize.AdditionalData;
                }
                if (userToInitialize.OnlineMeetings != null && userToInitialize.OnlineMeetings.CurrentPage != null)
                {
                    userToInitialize.OnlineMeetings.InitializeNextPageRequest(this.Client, userToInitialize.OnlineMeetingsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.OnlineMeetings.AdditionalData = userToInitialize.AdditionalData;
                }
                if (userToInitialize.Chats != null && userToInitialize.Chats.CurrentPage != null)
                {
                    userToInitialize.Chats.InitializeNextPageRequest(this.Client, userToInitialize.ChatsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.Chats.AdditionalData = userToInitialize.AdditionalData;
                }
                if (userToInitialize.JoinedTeams != null && userToInitialize.JoinedTeams.CurrentPage != null)
                {
                    userToInitialize.JoinedTeams.InitializeNextPageRequest(this.Client, userToInitialize.JoinedTeamsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userToInitialize.JoinedTeams.AdditionalData = userToInitialize.AdditionalData;
                }

            }


        }
    }
}