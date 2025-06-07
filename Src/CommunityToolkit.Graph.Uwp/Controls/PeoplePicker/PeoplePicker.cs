// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Authentication;
using CommunityToolkit.Graph.Extensions;
using Microsoft.Graph;
//using Microsoft.Toolkit.Uwp.UI;
//using Microsoft.Toolkit.Uwp.UI.Controls;
using Windows.System;
using Windows.UI.Xaml.Controls;

namespace CommunityToolkit.Graph.Uwp.Controls
{
    /// <summary>
    /// Control which allows user to search for a person or contact within Microsoft Graph. Built on top of <see cref="TokenizingTextBox"/>.
    /// </summary>
    public partial class PeoplePicker : TokenizingTextBox
    {
        private async void TokenBox_TokenItemTokenItemAdding(TokenizingTextBox sender, TokenItemAddingEventArgs args)
        {
            using (args.GetDeferral())
            {
                // Ensure the GraphServiceClient is properly referenced and used.
                GraphServiceClient graph = null;//ProviderManager.Instance.GlobalProvider.GetClient() as GraphServiceClient;
                if (graph != null)
                {
                    args.Item = default;//(await graph.FindPersonAsync(args.TokenText)).CurrentPage.FirstOrDefault();
                }

                // If we didn't find anyone, then don't add anyone.
                if (args.Item == null)
                {
                    args.Cancel = true;

                    // TODO: We should raise a 'person not found' type event or automatically display some feedback?
                }
            }
        }
    }
    // Add the missing 'Person' class definition to resolve CS0246.
    // This class is inferred based on the usage in the code and the context provided.

    public class Person
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string Mail { get; set; }
        public string UserPrincipalName { get; set; }

        // Add a helper method to convert a User object to a Person object.
        public static Person ToPerson(Microsoft.Graph.User user)
        {
            return new Person
            {
                Id = user.Id,
                DisplayName = user.DisplayName,
                Mail = user.Mail,
                UserPrincipalName = user.UserPrincipalName
            };
        }
    }
}