using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;

namespace PhonesStores.ViewModels
{
    public class DataPersister
    {
        public static IEnumerable<StoreViewModel> GetStores(string phoneStoresDocumentPath)
        {
            var storesDocumentRoot = XDocument.Load(phoneStoresDocumentPath).Root;

            var storesModel =
                from storeElement in storesDocumentRoot.Elements("store")
                select new StoreViewModel()
                {
                    Name = storeElement.Element("name").Value,
                    Phones = from phoneElement in storeElement.Element("phones").Elements("phone")
                             select new PhoneViewModel()
                             {
                                 Vendor = phoneElement.Element("vendor").Value,
                                 Model = phoneElement.Element("model").Value,
                                 Year = int.Parse(phoneElement.Element("year").Value),
                                 ImagePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), phoneElement.Element("image").Value),
                                 OS = new OperatingSystemViewModel()
                                 {
                                     Name = phoneElement.Element("os").Element("name").Value,
                                     Manufacturer = phoneElement.Element("os").Element("manufacturer").Value,
                                     Version = phoneElement.Element("os").Element("version").Value
                                 },
                                 Features = new FeaturesViewModel()
                                 {
                                     DisplayType = phoneElement.Element("features").Element("display").Value,
                                     DisplaySize = phoneElement.Element("features").Element("displaySize").Value
                                 }
                             }
                };
            return storesModel;
        }

        internal static IEnumerable<PhoneViewModel> GetPhones(string phonesStoreDocumentpath)
        {
            var root = XDocument.Load(phonesStoreDocumentpath).Root;

            var pVMs =
                from phoneElement in root.Elements("store").Elements("phones")    
                select new PhoneViewModel()
                {
                    Vendor = phoneElement.Element("phone").Element("vendor").Value,
                    Model = phoneElement.Element("phone").Element("model").Value,
                    Year = int.Parse(phoneElement.Element("phone").Element("year").Value),
                    ImagePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), phoneElement.Element("phone").Element("image").Value),
                    OS = new OperatingSystemViewModel()
                    {
                        Name = phoneElement.Element("phone").Element("os").Element("name").Value,
                        Manufacturer = phoneElement.Element("phone").Element("os").Element("manufacturer").Value,
                        Version = phoneElement.Element("phone").Element("os").Element("version").Value
                    },
                    Features = new FeaturesViewModel()
                    {
                        DisplayType = phoneElement.Element("phone").Element("features").Element("display").Value,
                        DisplaySize = phoneElement.Element("phone").Element("features").Element("displaySize").Value
                    }
                };
            return pVMs.Union(new List<PhoneViewModel>());

        }

        //internal static IEnumerable<OperatingSystemViewModel> GetAllOperationalSystems(string phonesStoreDocumentpath)
        //{
        //    var root = XDocument.Load(phonesStoreDocumentpath).Root.Element("store").Element("phones");

        //    var osVMs =
        //        from phoneElement in root.Elements("phone")
        //        select new OperatingSystemViewModel()
        //        {
        //            Name = phoneElement.Element("os").Element("name").Value,
        //            Manufacturer = phoneElement.Element("os").Element("manufacturer").Value,
        //            Version = phoneElement.Element("os").Element("version").Value,
        //        };
        //    return osVMs.Union(new List<OperatingSystemViewModel>());
        //}

        //internal static IEnumerable<FeaturesViewModel> GetAllFeatures(string phonesStoreDocumentpath)
        //{
        //    var root = XDocument.Load(phonesStoreDocumentpath).Root.Element("store").Element("phones");

        //    var fVMs =
        //        from phoneElement in root.Elements("phone")
        //        select new FeaturesViewModel()
        //        {
        //            DisplayType = phoneElement.Element("features").Element("display").Value,
        //            DisplaySize = phoneElement.Element("features").Element("displaySize").Value
        //        };
        //    return fVMs.Union(new List<FeaturesViewModel>());
        //}

        internal static void AddPhone(string documentPath, PhoneViewModel phone)
        {
            var root = XDocument.Load(documentPath).Root.Element("store").Element("phones");
            root.Add(new XElement("phone",
                new XElement("vendor", phone.Vendor),
                new XElement("model", phone.Model),
                new XElement("year", phone.Year),
                new XElement("image", phone.ImagePath),
                new XElement("os",
                    new XElement("name", phone.OS.Name),
                        new XElement("version", phone.OS.Name),
                        new XElement("manufacturer", phone.OS.Manufacturer)),
                        new XElement("features",
                            new XElement("display", phone.Features.DisplayType),
                            new XElement("displaySize", phone.Features.DisplaySize))));
            root.Document.Save(documentPath);
        }
    }
}
