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
    /// The type WorkbookFunctionsDdbRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsDdbRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsDdbRequest>, IWorkbookFunctionsDdbRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsDdbRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="cost">A cost parameter for the OData method call.</param>
        /// <param name="salvage">A salvage parameter for the OData method call.</param>
        /// <param name="life">A life parameter for the OData method call.</param>
        /// <param name="period">A period parameter for the OData method call.</param>
        /// <param name="factor">A factor parameter for the OData method call.</param>
        public WorkbookFunctionsDdbRequestBuilder(
            string requestUrl,
            IBaseClient client,
            System.Text.Json.JsonDocument cost,
            System.Text.Json.JsonDocument salvage,
            System.Text.Json.JsonDocument life,
            System.Text.Json.JsonDocument period,
            System.Text.Json.JsonDocument factor)
            : base(requestUrl, client)
        {
            this.SetParameter("cost", cost, true);
            this.SetParameter("salvage", salvage, true);
            this.SetParameter("life", life, true);
            this.SetParameter("period", period, true);
            this.SetParameter("factor", factor, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsDdbRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsDdbRequest(functionUrl, this.Client, options);

            if (this.HasParameter("cost"))
            {
                request.RequestBody.Cost = this.GetParameter<System.Text.Json.JsonDocument>("cost");
            }

            if (this.HasParameter("salvage"))
            {
                request.RequestBody.Salvage = this.GetParameter<System.Text.Json.JsonDocument>("salvage");
            }

            if (this.HasParameter("life"))
            {
                request.RequestBody.Life = this.GetParameter<System.Text.Json.JsonDocument>("life");
            }

            if (this.HasParameter("period"))
            {
                request.RequestBody.Period = this.GetParameter<System.Text.Json.JsonDocument>("period");
            }

            if (this.HasParameter("factor"))
            {
                request.RequestBody.Factor = this.GetParameter<System.Text.Json.JsonDocument>("factor");
            }

            return request;
        }
    }
}