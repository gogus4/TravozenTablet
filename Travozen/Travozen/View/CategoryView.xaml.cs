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
    public sealed partial class CategoryView : Page
    {
        public CategoryView()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var category = e.Parameter as Category;

            if (category != null)
            {
                if (category.Constructions.Count > 0)
                {
                    ListConstructions.ItemsSource = category.Constructions;
                    ListConstructions.SelectedIndex = 0;

                    foreach(var construction in category.Constructions)
                    {
                        ConstructionsFlipView.Items.Add(new ConstructionView(construction));

                        //ImgAfter.Source = category.Constructions[0].ImageDisplayAfter;
                        //ImgBefore.Source = category.Constructions[0].ImageDisplayBefore;
                    }
                    ConstructionsFlipView.SelectedIndex = 0;
                }

                TitleConstruction.Text = "Vision architecte - " + category.Name;
            }
        }

        private void GoBack_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        private void ListConstructions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var construction = ListConstructions.SelectedItem as Construction;

            if (construction != null)
            {
                //ImgAfter.Source = construction.ImageDisplayAfter;
                //ImgBefore.Source = construction.ImageDisplayBefore;
            }
        }
    }
}
