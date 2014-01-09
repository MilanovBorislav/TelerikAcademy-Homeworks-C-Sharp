using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;

namespace CountriesViewModels
{
    public class DataPersister
    {
        public static IEnumerable<CountryModel> GetAll(string countryStoreDocumentPath)
        {
            var countryDocumentRoot = XDocument.Load(countryStoreDocumentPath).Root;
            var countriesVM =
                from country in countryDocumentRoot.Elements("country")
                select new CountryModel
                {
                    Name = country.Element("name").Value,
                    Language = country.Element("language").Value,
                    FlagPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), country.Element("flag").Value),
                    TownModels = from town in country.Elements("towns")
                            select new TownModel
                            {
                                Name = town.Element("town").Element("name").Value,
                                Population = town.Element("town").Element("population").Value
                            }
                    };
             
            return countriesVM;
        } 
    }
}