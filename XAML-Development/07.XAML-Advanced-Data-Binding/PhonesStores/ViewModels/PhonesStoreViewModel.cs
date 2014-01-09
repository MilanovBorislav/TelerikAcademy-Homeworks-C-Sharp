using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using PhonesStores.Commands;
using System.Windows.Threading;
using System.Windows.Input;
using System.Text;
using System.Threading.Tasks;

namespace PhonesStores.ViewModels
{
    public class PhonesStoreViewModel : ViewModelBase
    {
        private ObservableCollection<StoreViewModel> storesViewModels;
        private ObservableCollection<PhoneViewModel> phonesViewModel;
        //private ObservableCollection<OperatingSystemViewModel> operationalSystemsViewModels;
        //private ObservableCollection<FeaturesViewModel> featuresViewModels;

        private ICommand addNewCommand;
        private string successMessage;
        private string errorMessage;

        private PhoneViewModel newPhoneViewModel;

        public string PhonesStoreDocumentPath { get; set; }

        public PhonesStoreViewModel()
        {
            this.PhonesStoreDocumentPath = "..\\..\\stores.xml";
            this.newPhoneViewModel = new PhoneViewModel();
        }

        public ICommand AddNew
        {
            get
            {
                if (this.addNewCommand == null)
                {
                    this.addNewCommand = new RelayCommand(this.HandleAddNewCommand);
                }
                return this.addNewCommand;
            }
        }

        public PhoneViewModel NewPhone
        {
            get
            {
                return this.newPhoneViewModel;
            }
            set
            {
                this.newPhoneViewModel = value;
                this.OnPropertyChanged("NewPhone");
            }
        }

        public string SuccessMessage
        {
            get
            {
                return this.successMessage;
            }
            set
            {
                this.successMessage = value;
                this.OnPropertyChanged("SuccessMessage");
            }
        }

        public string ErrorMessage
        {
            get
            {
                return this.errorMessage;
            }
            set
            {
                this.errorMessage = value;
                this.OnPropertyChanged("ErrorMessage");
            }
        }

        public IEnumerable<StoreViewModel> Stores
        {
            get
            {
                if (this.storesViewModels == null)
                {
                    this.Stores = DataPersister.GetStores(PhonesStoreDocumentPath);
                }
                return storesViewModels;
            }

            set
            {
                if (this.storesViewModels == null)
                {
                    this.storesViewModels = new ObservableCollection<StoreViewModel>();
                }

                this.storesViewModels.Clear();
                foreach (var item in value)
                {
                    this.storesViewModels.Add(item);
                }
            }
        }

        public IEnumerable<PhoneViewModel> Phones
        {
            get
            {
                if (this.phonesViewModel == null)
                {
                    this.Phones = DataPersister.GetPhones(PhonesStoreDocumentPath);
                }
                return phonesViewModel;
            }
            set
            {
                if (this.phonesViewModel == null)
                {
                    this.phonesViewModel = new ObservableCollection<PhoneViewModel>();
                }
                this.phonesViewModel.Clear();
                foreach (var item in value)
                {
                    this.phonesViewModel.Add(item);
                }
            }
        }

        //public IEnumerable<OperatingSystemViewModel> OperationalSystems
        //{
        //    get
        //    {
        //        if (this.operationalSystemsViewModels == null)
        //        {
        //            this.OperationalSystems = DataPersister.GetAllOperationalSystems(this.PhonesStoreDocumentPath);
        //        }
        //        return this.operationalSystemsViewModels;
        //    }
        //    set
        //    {
        //        if (this.operationalSystemsViewModels == null)
        //        {
        //            this.operationalSystemsViewModels = new ObservableCollection<OperatingSystemViewModel>();
        //        }
        //        this.operationalSystemsViewModels.Clear();
        //        foreach (var item in value)
        //        {
        //            this.operationalSystemsViewModels.Add(item);
        //        }
        //    }
        //}

        //public IEnumerable<FeaturesViewModel> Features
        //{
        //    get
        //    {
        //        if (this.featuresViewModels == null)
        //        {
        //            this.Features = DataPersister.GetAllFeatures(this.PhonesStoreDocumentPath);
        //        }
        //        return this.featuresViewModels;
        //    }
        //    set
        //    {
        //        if (this.featuresViewModels == null)
        //        {
        //            this.featuresViewModels = new ObservableCollection<FeaturesViewModel>();
        //        }
        //        this.featuresViewModels.Clear();
        //        foreach (var item in value)
        //        {
        //            this.featuresViewModels.Add(item);
        //        }
        //    }
        //}

        private void HandleAddNewCommand(object obj)
        {
            try
            {
                DataPersister.AddPhone(this.PhonesStoreDocumentPath, this.NewPhone);
                this.Phones = DataPersister.GetPhones(this.PhonesStoreDocumentPath);
                this.SetSuccessMessage(string.Format("{0} {1} successfully added!", this.NewPhone.Vendor, this.NewPhone.Model));
                this.NewPhone = new PhoneViewModel();
            }
            catch (Exception ex)
            {
                this.SetErrorMessage(string.Format("Adding {0} {1} failed with exception {2} ", this.NewPhone.Vendor, this.NewPhone.Model, ex.Message));
            }
        }

        private void SetSuccessMessage(string text)
        {
            this.SuccessMessage = text;
            var timer = new DispatcherTimer();
            timer.Tick += (snd, args) =>
            {
                this.SuccessMessage = "";
                timer.Stop();
            };
            timer.Interval = TimeSpan.FromSeconds(2);
            timer.Start();
        }

        private void SetErrorMessage(string text)
        {
            this.SuccessMessage = text;
            var timer = new DispatcherTimer();
            timer.Tick += (snd, args) =>
            {
                this.SuccessMessage = "";
                timer.Stop();
            };
            timer.Interval = TimeSpan.FromSeconds(2);
            timer.Start();
        }
    }
}
