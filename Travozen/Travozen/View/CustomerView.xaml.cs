using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Travozen.Model;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Travozen.View
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class CustomerView : Page
    {
        public CustomerView()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var customer = e.Parameter as Customer;

            if (customer != null)
            {
                if (customer.Constructions.Count > 0)
                {
                    ListConstructions.ItemsSource = customer.Constructions;
                    ListConstructions.SelectedIndex = 0;

                    foreach (var construction in customer.Constructions)
                    {
                        ConstructionsFlipView.Items.Add(new ConstructionView(construction));
                    }

                    ConstructionsFlipView.SelectedIndex = 0;
                }

                TitleConstruction.Text = "Vision architecte - Dossier n°" + customer.CustomerNumber;
            }
        }

        private void GoBack_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        private void ListConstructions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ConstructionsFlipView.SelectedIndex != -1)
            {
                ConstructionsFlipView.SelectedIndex = ListConstructions.SelectedIndex;
            }
        }

        private void ConstructionsFlipView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ConstructionsFlipView.SelectedIndex != -1)
            {
                ListConstructions.SelectedIndex = ConstructionsFlipView.SelectedIndex;
            }
        }
    }
}
