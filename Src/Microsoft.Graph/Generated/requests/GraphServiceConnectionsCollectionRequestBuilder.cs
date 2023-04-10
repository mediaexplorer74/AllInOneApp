// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type GraphServiceConnectionsCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceConnectionsCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceConnectionsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceConnectionsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceConnectionsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceConnectionsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceConnectionsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceConnectionsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="Microsoft.Graph.ExternalConnectors.IExternalConnectionRequestBuilder"/> for the specified GraphServiceMicrosoft.Graph.ExternalConnectors.ExternalConnection.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceMicrosoft.Graph.ExternalConnectors.ExternalConnection.</param>
        /// <returns>The <see cref="Microsoft.Graph.ExternalConnectors.IExternalConnectionRequestBuilder"/>.</returns>
        public Microsoft.Graph.ExternalConnectors.IExternalConnectionRequestBuilder this[string id]
        {
            get
            {
                return new Microsoft.Graph.ExternalConnectors.ExternalConnectionRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
