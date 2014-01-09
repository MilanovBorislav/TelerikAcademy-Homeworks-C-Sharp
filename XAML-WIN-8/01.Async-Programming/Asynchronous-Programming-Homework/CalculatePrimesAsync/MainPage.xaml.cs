using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CalculatePrimesAsync
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private async void CalculatePrimesClickFirst(object sender, RoutedEventArgs e)
        {
            PrimesFirst.Text = "";

            if (TextBoxRangeStartFirst.Text == string.Empty || TextBoxRangeEndFirst.Text == string.Empty)
            {
                return;
            }

            var start = int.Parse(TextBoxRangeStartFirst.Text);
            var end = int.Parse(TextBoxRangeEndFirst.Text);

            var numbers = await PrimesCalculator.GetPrimesCouplesAsync(start, end);

            PrimesFirst.Text = await numbers.JoinAsStringAsync(",");

        }

        private async void CalculatePrimesClickSecond(object sender, RoutedEventArgs e)
        {
            PrimesSecond.Text = "";

            if (TextBoxRangeStartSecond.Text == string.Empty || TextBoxRangeEndSecond.Text == string.Empty)
            {
                return;
            }

            int start = int.Parse(TextBoxRangeStartSecond.Text);
            var end = int.Parse(TextBoxRangeEndSecond.Text);

            var numbers = await PrimesCalculator.GetPrimesCouplesAsync(start, end);

            PrimesSecond.Text = await numbers.JoinAsStringAsync(",");
        }

        private async void CalculatePrimesClickThird(object sender, RoutedEventArgs e)
        {

            PrimesThird.Text = "";

            if (TextBoxRangeStartThird.Text == string.Empty || TextBoxRangeEndThird.Text == string.Empty)
            {
                return;
            }
            int start = int.Parse(TextBoxRangeStartThird.Text);
            var end = int.Parse(TextBoxRangeEndThird.Text);

            var numbers = await PrimesCalculator.GetPrimesCouplesAsync(start, end);

            PrimesThird.Text = await numbers.JoinAsStringAsync(",");
        }

        private async void CalculatePrimesClickFourth(object sender, RoutedEventArgs e)
        {
            PrimesFourth.Text = "";

            if (TextBoxRangeStartFourth.Text == string.Empty || TextBoxRangeEndFourth.Text == string.Empty)
            {
                return;
            }

            int start = int.Parse(TextBoxRangeStartFourth.Text);
            var end = int.Parse(TextBoxRangeEndFourth.Text);

            var numbers = await PrimesCalculator.GetPrimesCouplesAsync(start, end);

            PrimesFourth.Text = await numbers.JoinAsStringAsync(",");
        }
    }
}
