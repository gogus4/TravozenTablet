﻿using System;
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

                    //ImgAfter.Source = category.Constructions[0].ImageDisplayAfter;
                    //ImgBefore.Source = category.Constructions[0].ImageDisplayBefore;
                }

                TitleConstruction.Text = "Travozen - " + category.Name;
            }
        }

        private void GoBack_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        private void Slider_ManipulationStarted(object sender, ManipulationStartedRoutedEventArgs e)
        {

        }

        private void Slider_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            try
            {
                var ttv = Slider.TransformToVisual(Window.Current.Content);
                Point screenCoords = ttv.TransformPoint(new Point(0, 0));
                if (((this.Transform.TranslateX + e.Delta.Translation.X) >= 0) && ((this.Transform.TranslateX + e.Delta.Translation.X) <= 880))
                {
                    this.Transform.TranslateX += e.Delta.Translation.X;

                    GeneralTransform gt = ImgBefore.TransformToVisual(null);
                    Point pt = gt.TransformPoint(new Point(0, 0));
                    var _rect = new RectangleGeometry();

                    var point = new Point(screenCoords.X - 300, 0);
                    _rect.Rect = new Rect(point, new Size(ImgBefore.ActualWidth - screenCoords.X + 300, ImgBefore.ActualHeight));

                    ImgBefore.Clip = _rect;
                    //Slider.Width = photoBefore.ActualWidth - screenCoords.X;

                    //Slider.Margin = new Thickness(-this.Transform.TranslateX, 0, 0, 0);
                    //Slider.X1 = -photoAfter.ActualWidth;
                    //Slider.X2 = 0;

                    //Slider.Y1 = -photoAfter.ActualHeight;
                    //Slider.Y2 = 0;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void Slider_ManipulationCompleted(object sender, ManipulationCompletedRoutedEventArgs e)
        {

        }

        private void ImgBefore_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            initImage();
        }

        private void initImage()
        {
            double i = 100;
            GeneralTransform gt = ImgBefore.TransformToVisual(null);
            Point pt = gt.TransformPoint(new Point(0, 0));
            var _rect = new RectangleGeometry();

            if (i > ImgBefore.ActualWidth)
            {
                i = ImgBefore.ActualWidth - 100;
            }

            var point = new Point(i, 0);
            _rect.Rect = new Rect(point, new Size(ImgBefore.ActualWidth - i, ImgBefore.ActualHeight));
            ImgBefore.Clip = _rect;
            Slider.HorizontalAlignment = HorizontalAlignment.Left;

            Slider.Margin = new Thickness((ImgAfter.ActualWidth - (ImgBefore.ActualWidth - i)) - 30, 0, 0, 0);
        }
    }
}
