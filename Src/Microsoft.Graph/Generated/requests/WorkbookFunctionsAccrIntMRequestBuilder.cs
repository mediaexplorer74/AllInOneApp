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
    /// The type WorkbookFunctionsAccrIntMRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsAccrIntMRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsAccrIntMRequest>, IWorkbookFunctionsAccrIntMRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsAccrIntMRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="issue">A issue parameter for the OData method call.</param>
        /// <param name="settlement">A settlement parameter for the OData method call.</param>
        /// <param name="rate">A rate parameter for the OData method call.</param>
        /// <param name="par">A par parameter for the OData method call.</param>
        /// <param name="basis">A basis parameter for the OData method call.</param>
        public WorkbookFunctionsAccrIntMRequestBuilder(
            string requestUrl,
            IBaseClient client,
            System.Text.Json.JsonDocument issue,
            System.Text.Json.JsonDocument settlement,
            System.Text.Json.JsonDocument rate,
            System.Text.Json.JsonDocument par,
            System.Text.Json.JsonDocument basis)
            : base(requestUrl, client)
        {
            this.SetParameter("issue", issue, true);
            this.SetParameter("settlement", settlement, true);
            this.SetParameter("rate", rate, true);
            this.SetParameter("par", par, true);
            this.SetParameter("basis", basis, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsAccrIntMRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsAccrIntMRequest(functionUrl, this.Client, options);

            if (this.HasParameter("issue"))
            {
                request.RequestBody.Issue = this.GetParameter<System.Text.Json.JsonDocument>("issue");
            }

            if (this.HasParameter("settlement"))
            {
                request.RequestBody.Settlement = this.GetParameter<System.Text.Json.JsonDocument>("settlement");
            }

            if (this.HasParameter("rate"))
            {
                request.RequestBody.Rate = this.GetParameter<System.Text.Json.JsonDocument>("rate");
            }

            if (this.HasParameter("par"))
            {
                request.RequestBody.Par = this.GetParameter<System.Text.Json.JsonDocument>("par");
            }

            if (this.HasParameter("basis"))
            {
                request.RequestBody.Basis = this.GetParameter<System.Text.Json.JsonDocument>("basis");
            }

            return request;
        }
    }
}