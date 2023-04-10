// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.Core.Pipeline
{
    internal class DiagnosticListener
    {
        private string clientNamespace;

        public DiagnosticListener(string clientNamespace)
        {
            this.clientNamespace = clientNamespace;
        }

        internal bool IsEnabled(string name)
        {
            //throw new NotImplementedException();
            return false;
        }

        internal bool IsEnabled()
        {
            //throw new NotImplementedException();
            return false;
        }

        internal void StartActivity(DiagnosticActivity activity1, DiagnosticActivity activity2)
        {
            //throw new NotImplementedException();
            return;
        }


        internal void StopActivity(DiagnosticActivity activity, object value)
        {
            //throw new NotImplementedException();
            return;
        }

        internal void Write(string v, Exception e)
        {
            //throw new NotImplementedException();
            return;
        }
    }
}