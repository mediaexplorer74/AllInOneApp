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
    /// The type WorkbookFunctionsZ_TestRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsZ_TestRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsZ_TestRequest>, IWorkbookFunctionsZ_TestRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsZ_TestRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="array">A array parameter for the OData method call.</param>
        /// <param name="x">A x parameter for the OData method call.</param>
        /// <param name="sigma">A sigma parameter for the OData method call.</param>
        public WorkbookFunctionsZ_TestRequestBuilder(
            string requestUrl,
            IBaseClient client,
            System.Text.Json.JsonDocument array,
            System.Text.Json.JsonDocument x,
            System.Text.Json.JsonDocument sigma)
            : base(requestUrl, client)
        {
            this.SetParameter("array", array, true);
            this.SetParameter("x", x, true);
            this.SetParameter("sigma", sigma, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsZ_TestRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsZ_TestRequest(functionUrl, this.Client, options);

            if (this.HasParameter("array"))
            {
                request.RequestBody.Array = this.GetParameter<System.Text.Json.JsonDocument>("array");
            }

            if (this.HasParameter("x"))
            {
                request.RequestBody.X = this.GetParameter<System.Text.Json.JsonDocument>("x");
            }

            if (this.HasParameter("sigma"))
            {
                request.RequestBody.Sigma = this.GetParameter<System.Text.Json.JsonDocument>("sigma");
            }

            return request;
        }
    }
}