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
    public sealed partial class ConstructionView : Page
    {
        public ConstructionView()
        {
            this.InitializeComponent();
        }

        public ConstructionView(Construction construction)
        {
            this.InitializeComponent();

            ImgAfter.Source = construction.ImageDisplayAfter;
            ImgBefore.Source = construction.ImageDisplayBefore;
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
                if (((this.Transform.TranslateX + e.Delta.Translation.X) >= 0) && ((this.Transform.TranslateX + e.Delta.Translation.X) <= 950))
                {
                    this.Transform.TranslateX += e.Delta.Translation.X;

                    GeneralTransform gt = ImgBefore.TransformToVisual(null);
                    Point pt = gt.TransformPoint(new Point(0, 0));
                    var _rect = new RectangleGeometry();

                    var point = new Point(screenCoords.X - 300, 0);
                    _rect.Rect = new Rect(point, new Size(ImgBefore.ActualWidth - screenCoords.X + 300, ImgBefore.ActualHeight));

                    ImgBefore.Clip = _rect;
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
            double i = 30;
            GeneralTransform gt = ImgBefore.TransformToVisual(null);
            Point pt = gt.TransformPoint(new Point(0, 0));
            var _rect = new RectangleGeometry();

            var point = new Point(i, 0);
            _rect.Rect = new Rect(point, new Size(ImgBefore.ActualWidth - i, ImgBefore.ActualHeight));
            ImgBefore.Clip = _rect;
            Slider.HorizontalAlignment = HorizontalAlignment.Left;

            Slider.Margin = new Thickness((ImgAfter.ActualWidth - (ImgBefore.ActualWidth - i)) - 30, 0, 0, 0); // 30
        }
    }
}
