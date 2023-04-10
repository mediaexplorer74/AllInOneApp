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
    /// The type WorkbookFunctionsAmorLincRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsAmorLincRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsAmorLincRequest>, IWorkbookFunctionsAmorLincRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsAmorLincRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="cost">A cost parameter for the OData method call.</param>
        /// <param name="datePurchased">A datePurchased parameter for the OData method call.</param>
        /// <param name="firstPeriod">A firstPeriod parameter for the OData method call.</param>
        /// <param name="salvage">A salvage parameter for the OData method call.</param>
        /// <param name="period">A period parameter for the OData method call.</param>
        /// <param name="rate">A rate parameter for the OData method call.</param>
        /// <param name="basis">A basis parameter for the OData method call.</param>
        public WorkbookFunctionsAmorLincRequestBuilder(
            string requestUrl,
            IBaseClient client,
            System.Text.Json.JsonDocument cost,
            System.Text.Json.JsonDocument datePurchased,
            System.Text.Json.JsonDocument firstPeriod,
            System.Text.Json.JsonDocument salvage,
            System.Text.Json.JsonDocument period,
            System.Text.Json.JsonDocument rate,
            System.Text.Json.JsonDocument basis)
            : base(requestUrl, client)
        {
            this.SetParameter("cost", cost, true);
            this.SetParameter("datePurchased", datePurchased, true);
            this.SetParameter("firstPeriod", firstPeriod, true);
            this.SetParameter("salvage", salvage, true);
            this.SetParameter("period", period, true);
            this.SetParameter("rate", rate, true);
            this.SetParameter("basis", basis, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsAmorLincRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsAmorLincRequest(functionUrl, this.Client, options);

            if (this.HasParameter("cost"))
            {
                request.RequestBody.Cost = this.GetParameter<System.Text.Json.JsonDocument>("cost");
            }

            if (this.HasParameter("datePurchased"))
            {
                request.RequestBody.DatePurchased = this.GetParameter<System.Text.Json.JsonDocument>("datePurchased");
            }

            if (this.HasParameter("firstPeriod"))
            {
                request.RequestBody.FirstPeriod = this.GetParameter<System.Text.Json.JsonDocument>("firstPeriod");
            }

            if (this.HasParameter("salvage"))
            {
                request.RequestBody.Salvage = this.GetParameter<System.Text.Json.JsonDocument>("salvage");
            }

            if (this.HasParameter("period"))
            {
                request.RequestBody.Period = this.GetParameter<System.Text.Json.JsonDocument>("period");
            }

            if (this.HasParameter("rate"))
            {
                request.RequestBody.Rate = this.GetParameter<System.Text.Json.JsonDocument>("rate");
            }

            if (this.HasParameter("basis"))
            {
                request.RequestBody.Basis = this.GetParameter<System.Text.Json.JsonDocument>("basis");
            }

            return request;
        }
    }
}