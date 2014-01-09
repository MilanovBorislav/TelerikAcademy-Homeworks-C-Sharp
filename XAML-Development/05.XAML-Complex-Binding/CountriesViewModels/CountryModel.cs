using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesViewModels
{
    public class CountryModel
    {
        public string Name { get; set; }

        public string Language { get; set; }

        public string FlagPath { get; set; }

        public IEnumerable<TownModel> TownModels { get; set; }
    }
}
