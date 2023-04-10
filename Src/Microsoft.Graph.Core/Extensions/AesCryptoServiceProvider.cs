// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Security.Cryptography;

namespace Microsoft.Graph
{
    internal class AesCryptoServiceProvider : IDisposable
    {
        internal byte[] IV;

        public CipherMode Mode { get; set; }
        public PaddingMode Padding { get; set; }
        public byte[] Key { get; set; }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        internal ICryptoTransform CreateDecryptor()
        {
            throw new NotImplementedException();
        }
    }
}