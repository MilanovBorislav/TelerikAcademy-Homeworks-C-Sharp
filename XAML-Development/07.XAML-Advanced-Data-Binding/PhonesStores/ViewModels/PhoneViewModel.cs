using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesStores.ViewModels
{
    public class PhoneViewModel
    {
        public string Model { get; set; }

        public OperatingSystemViewModel OS { get; set; }

        public FeaturesViewModel Features { get; set; }

        public string Vendor { get; set; }

        public int Year { get; set; }

        public string ImagePath { get; set; }
    }
}
