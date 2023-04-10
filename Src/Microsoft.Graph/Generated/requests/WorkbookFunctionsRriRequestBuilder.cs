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
    /// The type WorkbookFunctionsRriRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsRriRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsRriRequest>, IWorkbookFunctionsRriRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsRriRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="nper">A nper parameter for the OData method call.</param>
        /// <param name="pv">A pv parameter for the OData method call.</param>
        /// <param name="fv">A fv parameter for the OData method call.</param>
        public WorkbookFunctionsRriRequestBuilder(
            string requestUrl,
            IBaseClient client,
            System.Text.Json.JsonDocument nper,
            System.Text.Json.JsonDocument pv,
            System.Text.Json.JsonDocument fv)
            : base(requestUrl, client)
        {
            this.SetParameter("nper", nper, true);
            this.SetParameter("pv", pv, true);
            this.SetParameter("fv", fv, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsRriRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsRriRequest(functionUrl, this.Client, options);

            if (this.HasParameter("nper"))
            {
                request.RequestBody.Nper = this.GetParameter<System.Text.Json.JsonDocument>("nper");
            }

            if (this.HasParameter("pv"))
            {
                request.RequestBody.Pv = this.GetParameter<System.Text.Json.JsonDocument>("pv");
            }

            if (this.HasParameter("fv"))
            {
                request.RequestBody.Fv = this.GetParameter<System.Text.Json.JsonDocument>("fv");
            }

            return request;
        }
    }
}
