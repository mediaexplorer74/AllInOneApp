﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using CommunityToolkit.Authentication;
//using Microsoft.Toolkit.Uwp;
//using Microsoft.Toolkit.Uwp.Helpers;
using Windows.System;
using Windows.UI.Xaml;

namespace CommunityToolkit.Graph.Uwp
{
    /// <summary>
    /// A StateTrigger for detecting when the global authentication provider has been signed in.
    /// </summary>
    public class ProviderStateTrigger : StateTriggerBase
    {
        /// <summary>
        /// Identifies the <see cref="State"/> DependencyProperty.
        /// </summary>
        public static readonly DependencyProperty StateProperty =
            DependencyProperty.Register(nameof(State), typeof(ProviderState), typeof(ProviderStateTrigger), new PropertyMetadata(null, OnStateChanged));

        private static void OnStateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ProviderStateTrigger instance)
            {
                instance.UpdateState();
            }
        }

        private readonly DispatcherQueue _dispatcherQueue;

        /// <summary>
        /// Gets or sets the expected ProviderState.
        /// </summary>
        public ProviderState? State
        {
            get => (ProviderState?)GetValue(StateProperty);
            set => SetValue(StateProperty, value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderStateTrigger"/> class.
        /// </summary>
        public ProviderStateTrigger()
        {
            _dispatcherQueue = DispatcherQueue.GetForCurrentThread();
           /* var weakEvent =
                new WeakEventListener<ProviderStateTrigger, object, ProviderStateChangedEventArgs>(this)
                {
                    OnEventAction = (instance, source, args) => OnProviderStateChanged(source, args),
                    OnDetachAction = (weakEventListener) => ProviderManager.Instance.ProviderStateChanged -= weakEventListener.OnEvent,
                };
            ProviderManager.Instance.ProviderStateChanged += weakEvent.OnEvent;*/
            UpdateState();
        }

        // Fix for CS1061: Replace the usage of 'EnqueueAsync' with 'TryEnqueue' as 'DispatcherQueue' does not have an 'EnqueueAsync' method.

        private void OnProviderStateChanged(object sender, ProviderStateChangedEventArgs e)
        {
            // Use TryEnqueue instead of EnqueueAsync
            _dispatcherQueue.TryEnqueue(DispatcherQueuePriority.Normal, () => UpdateState());
        }

        private void UpdateState()
        {
            var provider = ProviderManager.Instance.GlobalProvider;
            if (State != null && provider?.State != null)
            {
                SetActive(provider?.State == State);
            }
            else
            {
                SetActive(false);
            }
        }
    }
}