// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Text.Json
{
    internal class ArrayBufferWriter<T>
    {
        internal byte[] WrittenMemory;
        internal int WrittenCount;

        public ArrayBufferWriter()
        {
        }

        internal void Advance(int bytesPending)
        {
            throw new NotImplementedException();
        }

        internal void Clear()
        {
            throw new NotImplementedException();
        }

        internal Memory<byte> GetMemory(int sizeHint)
        {
            throw new NotImplementedException();
        }
    }
}