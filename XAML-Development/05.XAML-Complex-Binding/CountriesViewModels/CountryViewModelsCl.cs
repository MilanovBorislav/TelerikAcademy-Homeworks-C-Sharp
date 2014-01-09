using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Data;

namespace CountriesViewModels
{
    public class CountryViewModelsCl
    {
        public string CountriesDocumentPath { get; set; }

        public CountryViewModelsCl()
        {
            this.CountriesDocumentPath = "..\\..\\..\\CountriesViewModels\\countries.xml";
        }

        private IEnumerable<CountryModel> _countriesViewModels;

        public IEnumerable<CountryModel> Countries
        {
            get
            {
                if (this._countriesViewModels == null)
                {
                    this._countriesViewModels = DataPersister.GetAll(CountriesDocumentPath);
                }
                return _countriesViewModels;
            }
        }

        public void PrevCountry()
        {
            var countriesCollectionView = this.GetDefaultView(this._countriesViewModels);
            countriesCollectionView.MoveCurrentToPrevious();

            if (countriesCollectionView.IsCurrentBeforeFirst)
            {
                countriesCollectionView.MoveCurrentToLast();
            }
        }

        public void NextCountry()
        {
            var countriesCollectionView = this.GetDefaultView(this._countriesViewModels);
            countriesCollectionView.MoveCurrentToNext();

            if (countriesCollectionView.IsCurrentAfterLast)
            {
                countriesCollectionView.MoveCurrentToFirst();
            }
        }



        private ICollectionView GetDefaultView<T>(IEnumerable<T> collection)
        {
            return CollectionViewSource.GetDefaultView(collection);
        }
    }
}