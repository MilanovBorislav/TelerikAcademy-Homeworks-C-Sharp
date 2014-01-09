using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;
using System.Threading;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PaintRT
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        RotateTransform canvasRotation = new RotateTransform();
        TranslateTransform canvasTranslate = new TranslateTransform();

        SolidColorBrush[] colors = new SolidColorBrush[] {
            new SolidColorBrush(Windows.UI.Colors.Black),
            new SolidColorBrush(Windows.UI.Colors.Red),
            new SolidColorBrush(Windows.UI.Colors.Blue),
            new SolidColorBrush(Windows.UI.Colors.Green)            
        };

        StackPanel stPanel;

        public MainPage()
        {
            this.InitializeComponent();
            RotatingCanvas.RenderTransform = canvasRotation;
            MovingCanvas.RenderTransform = canvasTranslate;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void MovingCanvasManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            var xOffset = e.Delta.Translation.X;
            canvasTranslate.X += xOffset;
            if (canvasTranslate.X > 50 && canvasTranslate.X < 100)
            {
                currentFigure.Text = "Rectangle";
            }

            if (canvasTranslate.X > 140 && canvasTranslate.X < 180)
            {
                currentFigure.Text = "Circle";
            }

            if (canvasTranslate.X > 220 && canvasTranslate.X < 250)
            {
                currentFigure.Text = "Line";
            }
            if (canvasTranslate.X < 50 || (canvasTranslate.X > 100 && canvasTranslate.X < 140)
                || (canvasTranslate.X > 180 && canvasTranslate.X < 220) || canvasTranslate.X > 250)
            {
                currentFigure.Text = "";
            }
        }

        private void RotatingEllipseManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            var canvas = sender as Canvas;

            canvasRotation.CenterX = canvas.Width / 2;
            canvasRotation.CenterY = canvas.Height / 2;
            canvasRotation.Angle += e.Delta.Rotation;
            if (canvasRotation.Angle >= 360 || canvasRotation.Angle <= -360)
            {
                canvasRotation.Angle = 0;
                currentColor.Text = "Black";
            }

            if (canvasRotation.Angle > 0 && canvasRotation.Angle < 5)
            {
                currentColor.Text = "Black";
            }
            if ((canvasRotation.Angle > 88 && canvasRotation.Angle < 92) || (canvasRotation.Angle < -264 && canvasRotation.Angle > -272))
            {
                currentColor.Text = "Red";
            }

            if ((canvasRotation.Angle > 178 && canvasRotation.Angle < 182) || (canvasRotation.Angle < -178 && canvasRotation.Angle > -182))
            {
                currentColor.Text = "Green";
            }
            if ((canvasRotation.Angle > 264 && canvasRotation.Angle < 272) || canvasRotation.Angle < -88 && canvasRotation.Angle > -92)
            {
                currentColor.Text = "Blue";
            }
        }

        private void DoubleTappedRect(object sender, TappedRoutedEventArgs e)
        {

            var currentRect = sender as Rectangle;

            e.Handled = true;

            if (currentRect.Fill == colors[0])
            {
                currentRect.Fill = colors[1];
            }

            else if (currentRect.Fill == colors[1])
            {
                currentRect.Fill = colors[2];
            }

            else if (currentRect.Fill == colors[2])
            {
                currentRect.Fill = colors[3];
            }

            else
            {
                currentRect.Fill = colors[0];
            }
        }

        private void DoubleTappedEllipse(object sender, TappedRoutedEventArgs e)
        {           
            var currentRect = sender as Ellipse;
            
            e.Handled = true;

            if (currentRect.Fill == colors[0])
            {
                currentRect.Fill = colors[1];
            }

            else if (currentRect.Fill == colors[1])
            {
                currentRect.Fill = colors[2];
            }

            else if (currentRect.Fill == colors[2])
            {
                currentRect.Fill = colors[3];
            }

            else
            {
                currentRect.Fill = colors[0];
            }

        }

        private void DoubleTappedLine(object sender, TappedRoutedEventArgs e)
        {
            var currentRect = sender as Rectangle;

            e.Handled = true;

            if (currentRect.Fill == colors[0])
            {
                currentRect.Fill = colors[1];
            }

            else if (currentRect.Fill == colors[1])
            {
                currentRect.Fill = colors[2];
            }

            else if (currentRect.Fill == colors[2])
            {
                currentRect.Fill = colors[3];
            }

            else
            {
                currentRect.Fill = colors[0];
            }

        }

        private void StackPanel_Tapped(object sender, TappedRoutedEventArgs e)
        {
            
            stPanel = sender as StackPanel;
            Ellipse newEllipse = new Ellipse();
            Rectangle newLine = new Rectangle();
            Rectangle newRectangle = new Rectangle();
            newRectangle.Tapped += DoubleTappedRect;
            newEllipse.Tapped += DoubleTappedEllipse;
            newLine.Tapped += DoubleTappedLine;
            newRectangle.Width = 50;
            newRectangle.Height = 50;
            newEllipse.Width = 50;
            newEllipse.Height = 50;
            newLine.Width = 20;
            newLine.Height = 50;

            if (currentFigure.Text == "Rectangle")
            {
                if (currentColor.Text == "Black")
                {
                    newRectangle.Fill = colors[0];
                }
                if (currentColor.Text == "Red")
                {
                    newRectangle.Fill = colors[1];
                }
                if (currentColor.Text == "Blue")
                {
                    newRectangle.Fill = colors[2];
                }
                if (currentColor.Text == "Green")
                {
                    newRectangle.Fill = colors[3];
                }

                stPanel.Children.Add(newRectangle);

            }

            if (currentFigure.Text == "Circle")
            {

                if (currentColor.Text == "Black")
                {
                    newEllipse.Fill = colors[0];
                }
                if (currentColor.Text == "Red")
                {
                    newEllipse.Fill = colors[1];
                }
                if (currentColor.Text == "Blue")
                {
                    newEllipse.Fill = colors[2];
                }
                if (currentColor.Text == "Green")
                {
                    newEllipse.Fill = colors[3];
                }

                stPanel.Children.Add(newEllipse);
            }
            if (currentFigure.Text == "Line")
            {

                if (currentColor.Text == "Black")
                {
                    newLine.Fill = colors[0];
                }
                if (currentColor.Text == "Red")
                {
                    newLine.Fill = colors[1];
                }
                if (currentColor.Text == "Blue")
                {
                    newLine.Fill = colors[2];
                }
                if (currentColor.Text == "Green")
                {
                    newLine.Fill = colors[3];
                }

                stPanel.Children.Add(newLine);
            }
        }
    }
}
