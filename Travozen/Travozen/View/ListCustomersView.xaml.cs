using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Travozen.Model;
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

namespace Travozen.View
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class ListCustomersView : Page
    {
        public ListCustomersView()
        {
            this.InitializeComponent();

            ListCustomers.ItemsSource = DatasVM.Instance.Customers;
        }

        private void ListCustomers_ItemClick(object sender, ItemClickEventArgs e)
        {
            var customer = e.ClickedItem as Customer;

            if (customer != null)
            {
                Frame frame = Window.Current.Content as Frame;
                frame.Navigate(typeof(CustomerView), customer);
            }
        }
    }
}
