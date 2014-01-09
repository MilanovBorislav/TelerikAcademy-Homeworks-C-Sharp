using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;
using Windows.Storage.Streams;
using System.IO;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PaintRT
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        StringBuilder sb = new StringBuilder();

        RotateTransform canvasRotation = new RotateTransform();
        TranslateTransform canvasTranslate = new TranslateTransform();

        SolidColorBrush[] colors = new SolidColorBrush[] {
            new SolidColorBrush(Windows.UI.Colors.Black),
            new SolidColorBrush(Windows.UI.Colors.Red),
            new SolidColorBrush(Windows.UI.Colors.Blue),
            new SolidColorBrush(Windows.UI.Colors.Green)            
        };
        Windows.Storage.StorageFile fileToUse = null;
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

            if ((canvasRotation.Angle > 175 && canvasRotation.Angle < 182) || (canvasRotation.Angle < -175 && canvasRotation.Angle > -182))
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
                currentColor.Text = "Red";
            }

            else if (currentRect.Fill == colors[1])
            {
                currentRect.Fill = colors[2];
                currentColor.Text = "Blue";
            }

            else if (currentRect.Fill == colors[2])
            {
                currentRect.Fill = colors[3];
                currentColor.Text = "Green";
            }

            else
            {
                currentRect.Fill = colors[0];
                currentColor.Text = "Black";
            }
        }

        private void DoubleTappedEllipse(object sender, TappedRoutedEventArgs e)
        {           
            var currentRect = sender as Ellipse;
            
            e.Handled = true;

            if (currentRect.Fill == colors[0])
            {
                currentRect.Fill = colors[1];
                currentColor.Text = "Red";
            }

            else if (currentRect.Fill == colors[1])
            {
                currentRect.Fill = colors[2];
                currentColor.Text = "Blue";
            }

            else if (currentRect.Fill == colors[2])
            {
                currentRect.Fill = colors[3];
                currentColor.Text = "Green";
            }

            else
            {
                currentRect.Fill = colors[0];
                currentColor.Text = "Black";
            }

        }

        private void DoubleTappedLine(object sender, TappedRoutedEventArgs e)
        {
            var currentRect = sender as Rectangle;

            e.Handled = true;

            if (currentRect.Fill == colors[0])
            {
                currentRect.Fill = colors[1];
                currentColor.Text = "Red";
            }

            else if (currentRect.Fill == colors[1])
            {
                currentRect.Fill = colors[2];
                currentColor.Text = "Blue";
            }

            else if (currentRect.Fill == colors[2])
            {
                currentRect.Fill = colors[3];
                currentColor.Text = "Green";
            }

            else
            {
                currentRect.Fill = colors[0];
                currentColor.Text = "Black";
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
                sb.AppendLine("Rectangle " + currentColor.Text.ToString());
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
                sb.AppendLine("Ellipse " + currentColor.Text.ToString());
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
                sb.AppendLine("Line " + currentColor.Text.ToString());
            }
        }

        private async void SaveProjectButtonClick(object sender, RoutedEventArgs e)
        {
            var savePicker = new Windows.Storage.Pickers.FileSavePicker();
            var plainTextFileTypes = new List<string>(new string[] { ".txt" });
            
            savePicker.FileTypeChoices.Add(
                new KeyValuePair<string, IList<string>>("Text Document", plainTextFileTypes));
            var saveFile = await savePicker.PickSaveFileAsync();
            if (saveFile != null)
            {
                await Windows.Storage.FileIO.WriteTextAsync(saveFile, sb.ToString());
                await new Windows.UI.Popups.MessageDialog("File Saved!").ShowAsync();
            }
        }
        
        public async void LoadProjectButtonClick(object sender, RoutedEventArgs e)
        {
            var filePicker = new Windows.Storage.Pickers.FileOpenPicker();

            filePicker.FileTypeFilter.Add("*");

            fileToUse = await filePicker.PickSingleFileAsync();

            

            if (fileToUse != null)
            {
                try
                {
                    if (dynamicStackPanel.Children.Count > 2)
                    {
                        for (int index = dynamicStackPanel.Children.Count - 1; index >= 2; index--)
                        {
                            dynamicStackPanel.Children.Remove(dynamicStackPanel.Children[index]);
                            sb.Clear();
                        }

                    }

                    var text = await Windows.Storage.FileIO.ReadLinesAsync(fileToUse);
                    string curColor = "";
                        foreach (var line in text)
                        {
                            if (line.Contains("Rectangle"))
                            {
                                Rectangle rect = new Rectangle();
                                rect.Width = 50;
                                rect.Height = 50;
                                rect.Tapped += DoubleTappedRect;
                                if (line.Contains("Red"))
                                {
                                    rect.Fill = new SolidColorBrush(Windows.UI.Colors.Red);
                                    curColor = "Red";
                                }
                                if (line.Contains("Green"))
                                {
                                    rect.Fill = new SolidColorBrush(Windows.UI.Colors.Green);
                                    curColor = "Green";
                                }
                                if (line.Contains("Blue"))
                                {
                                    rect.Fill = new SolidColorBrush(Windows.UI.Colors.Blue);
                                    curColor = "Blue";
                                }
                                if (line.Contains("Black"))
                                {
                                    rect.Fill = new SolidColorBrush(Windows.UI.Colors.Black);
                                    curColor = "Black";
                                }

                                dynamicStackPanel.Children.Add(rect);
                                sb.AppendLine("Rectangle " + curColor);
                            }
                            if (line.Contains("Line"))
                            {
                                Rectangle curLine = new Rectangle();
                                curLine.Width = 20;
                                curLine.Height = 50;
                                curLine.Tapped += DoubleTappedLine;
                                if (line.Contains("Red"))
                                {
                                    curLine.Fill = new SolidColorBrush(Windows.UI.Colors.Red);
                                    curColor = "Red";
                                }
                                if (line.Contains("Green"))
                                {
                                    curLine.Fill = new SolidColorBrush(Windows.UI.Colors.Green);
                                    curColor = "Green";
                                }
                                if (line.Contains("Blue"))
                                {
                                    curLine.Fill = new SolidColorBrush(Windows.UI.Colors.Blue);
                                    curColor = "Blue";
                                }
                                if (line.Contains("Black"))
                                {
                                    curLine.Fill = new SolidColorBrush(Windows.UI.Colors.Black);
                                    curColor = "Black";
                                }

                                dynamicStackPanel.Children.Add(curLine);
                                sb.AppendLine("Line " + curColor);
                            }
                            if (line.Contains("Ellipse"))
                            {
                                Ellipse ellipse = new Ellipse();
                                ellipse.Width = 50;
                                ellipse.Height = 50;
                                ellipse.Tapped += DoubleTappedEllipse;
                                if (line.Contains("Red"))
                                {
                                    ellipse.Fill = new SolidColorBrush(Windows.UI.Colors.Red);
                                    curColor = "Red";
                                }
                                if (line.Contains("Green"))
                                {
                                    ellipse.Fill = new SolidColorBrush(Windows.UI.Colors.Green);
                                    curColor = "Green";
                                }
                                if (line.Contains("Blue"))
                                {
                                    ellipse.Fill = new SolidColorBrush(Windows.UI.Colors.Blue);
                                    curColor = "Blue";
                                }
                                if (line.Contains("Black"))
                                {
                                    ellipse.Fill = new SolidColorBrush(Windows.UI.Colors.Black);
                                    curColor = "Black";
                                }

                                dynamicStackPanel.Children.Add(ellipse);
                                sb.AppendLine("Ellipse " + curColor);
                            }
                        }
                }
                catch (Exception)
                {
                    new Windows.UI.Popups.MessageDialog("Something went wrong").ShowAsync();
                }
            }
        }
    }
}
