using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesStores.ViewModels
{
    public class StoreViewModel
    {
        public string Name { get; set; }

        public IEnumerable<PhoneViewModel> Phones { get; set; }
    }
}
