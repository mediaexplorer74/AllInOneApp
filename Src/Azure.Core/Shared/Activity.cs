// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.Core.Pipeline
{
    internal class Activity
    {
        internal static Activity? Current;
        internal string? Id;
        internal string OperationName;
        private string operationName;

        public Activity(string operationName)
        {
            this.operationName = operationName;
        }

        internal void AddTag(string key, string value)
        {
            throw new NotImplementedException();
        }

        internal void SetParentId(string id)
        {
            throw new NotImplementedException();
        }
    }
}