// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;

namespace Azure
{
    public class BinaryData
    {
        private object value;

        public BinaryData(object value)
        {
            this.value = value;
        }

        internal Stream ToStream()
        {
            throw new NotImplementedException();
        }
    }
}