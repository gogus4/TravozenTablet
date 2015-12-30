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
        public Point CoordXImageAfter { get; set; }

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

                    ImgAfter.Source = category.Constructions[0].ImageDisplayAfter;
                    ImgBefore.Source = category.Constructions[0].ImageDisplayBefore;
                }

                TitleConstruction.Text = "Travozen - " + category.Name;
            }
        }

        private void GoBack_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        private void Img_ManipulationStarted(object sender, ManipulationStartedRoutedEventArgs e)
        {
            this.ImgBefore.Opacity = 0.4;
        }

        private void Img_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            var ttv = ImgBefore.TransformToVisual(Window.Current.Content);
            Point screenCoords = ttv.TransformPoint(new Point(0, 0));

            var ttv1 = ImgAfter.TransformToVisual(Window.Current.Content);
            CoordXImageAfter = ttv1.TransformPoint(new Point(0, 0));

            if (this.Transform.TranslateX >= 500)
            {
                this.ImgBefore.Opacity = 0.2;
            }
            else if (this.Transform.TranslateX <= 500)
            {
                this.ImgBefore.Opacity = 0.8;
            }

            if (screenCoords.X >= CoordXImageAfter.X)
            {
                this.Transform.TranslateX += e.Delta.Translation.X;
            }
            else if (screenCoords.X < CoordXImageAfter.X)
            {
                this.Transform.TranslateX = 0;
            }
        }

        private void Img_ManipulationCompleted(object sender, ManipulationCompletedRoutedEventArgs e)
        {
            // reset the Opacity
            //this.ImgBefore.Opacity = 0.8;
        }
    }
}
