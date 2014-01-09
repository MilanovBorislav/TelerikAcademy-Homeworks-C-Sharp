using System.Windows;
using CountriesViewModels;

namespace CountriesWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void OnNextCountryButtonClick(object sender, RoutedEventArgs e)
        {
            var dataContext = this.GetDataContext();
            dataContext.NextCountry();
        }

        public void OnPrevCountryButtonClick(object sender, RoutedEventArgs e)
        {
            var dataContext = this.GetDataContext();
            dataContext.PrevCountry();
        }

        private CountryViewModelsCl GetDataContext()
        {
            var dataContext = this.DataContext;

            var data = dataContext as CountryViewModelsCl;

            return data;
        }
    }
}
