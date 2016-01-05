using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Travozen.Model;
using Travozen.View;
using Travozen.ViewModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Travozen
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ListFlipView.Items.Add(new ListCategoriesView());
            ListFlipView.Items.Add(new ListCustomersView());

        }

        private void HamburgerRadioButton_Click(object sender, RoutedEventArgs e)
        {
            SplitView.IsPaneOpen = !SplitView.IsPaneOpen;
        }

        private void DisplayCategories_Click(object sender, RoutedEventArgs e)
        {
            ListFlipView.SelectedIndex = 0;
        }

        private void DisplayFolder_Click(object sender, RoutedEventArgs e)
        {
            ListFlipView.SelectedIndex = 1;
        }
    }
}
