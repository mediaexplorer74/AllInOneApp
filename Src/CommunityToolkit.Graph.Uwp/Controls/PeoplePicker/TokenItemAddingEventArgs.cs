// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace CommunityToolkit.Graph.Uwp.Controls
{
    internal class TokenItemAddingEventArgs
    {
        internal object Item;
        internal bool Cancel;

        internal IDisposable GetDeferral()
        {
            throw new NotImplementedException();
        }
    }
}