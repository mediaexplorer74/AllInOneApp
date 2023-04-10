// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookFunctionsPoisson_DistRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsPoisson_DistRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsPoisson_DistRequest>, IWorkbookFunctionsPoisson_DistRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsPoisson_DistRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="x">A x parameter for the OData method call.</param>
        /// <param name="mean">A mean parameter for the OData method call.</param>
        /// <param name="cumulative">A cumulative parameter for the OData method call.</param>
        public WorkbookFunctionsPoisson_DistRequestBuilder(
            string requestUrl,
            IBaseClient client,
            System.Text.Json.JsonDocument x,
            System.Text.Json.JsonDocument mean,
            System.Text.Json.JsonDocument cumulative)
            : base(requestUrl, client)
        {
            this.SetParameter("x", x, true);
            this.SetParameter("mean", mean, true);
            this.SetParameter("cumulative", cumulative, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsPoisson_DistRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsPoisson_DistRequest(functionUrl, this.Client, options);

            if (this.HasParameter("x"))
            {
                request.RequestBody.X = this.GetParameter<System.Text.Json.JsonDocument>("x");
            }

            if (this.HasParameter("mean"))
            {
                request.RequestBody.Mean = this.GetParameter<System.Text.Json.JsonDocument>("mean");
            }

            if (this.HasParameter("cumulative"))
            {
                request.RequestBody.Cumulative = this.GetParameter<System.Text.Json.JsonDocument>("cumulative");
            }

            return request;
        }
    }
}