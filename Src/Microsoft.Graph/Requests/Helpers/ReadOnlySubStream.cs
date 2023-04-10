// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ---------------

namespace Microsoft.Graph
{
    using System;
    using System.Diagnostics;
    using System.IO;

    internal class ReadOnlySubStream:Stream
    {
        private readonly long startInSuperStream;
        private long positionInSuperStream;
        private readonly long endInSuperStream;
        private readonly Stream superStream;
        private bool canRead;
        private bool isDisposed;

        public ReadOnlySubStream(Stream superStream, long startPosition, long maxLength)
        {
            this.startInSuperStream = startPosition;
            this.positionInSuperStream = startPosition;
            this.endInSuperStream = startPosition + maxLength;
            this.superStream = superStream;
            this.canRead = true;
            this.isDisposed = false;
        }

        public override long Length
        {
            get
            {
                ThrowIfDisposed();

                return endInSuperStream - startInSuperStream;
            }
        }

        public override long Position
        {
            get
            {
                ThrowIfDisposed();

                return positionInSuperStream - startInSuperStream;
            }
            set
            {
                ThrowIfDisposed();

                throw new NotSupportedException("seek not support");
            }
        }

        public override bool CanRead => superStream.CanRead && canRead;

        public override bool CanSeek => false;

        public override bool CanWrite => false;

        private void ThrowIfDisposed()
        {
            if (isDisposed)
                throw new ObjectDisposedException(GetType().ToString(), nameof(this.superStream));
        }

        private void ThrowIfCantRead()
        {
            if (!CanRead)
                throw new NotSupportedException("read not support");
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            // parameter validation sent to _superStream.Read
            int origCount = count;

            ThrowIfDisposed();
            ThrowIfCantRead();

            if (superStream.Position != positionInSuperStream)
                superStream.Seek(positionInSuperStream, SeekOrigin.Begin);
            if (positionInSuperStream + count > endInSuperStream)
                count = (int)(endInSuperStream - positionInSuperStream);

            Debug.Assert(count >= 0);
            Debug.Assert(count <= origCount);

            int ret = superStream.Read(buffer, offset, count);

            positionInSuperStream += ret;
            return ret;
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            ThrowIfDisposed();
            throw new NotSupportedException("seek not support");
        }

        public override void SetLength(long value)
        {
            ThrowIfDisposed();
            throw new NotSupportedException("seek and write not support");
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            ThrowIfDisposed();
            throw new NotSupportedException("write not support");
        }

        public override void Flush()
        {
            ThrowIfDisposed();
            throw new NotSupportedException("write not support");
        }

        // Close the stream for reading.  Note that this does NOT close the superStream (since
        // the substream is just 'a chunk' of the super-stream
        protected override void Dispose(bool disposing)
        {
            if (disposing && !isDisposed)
            {
                canRead = false;
                isDisposed = true;
            }
            base.Dispose(disposing);
        }
    }
}
