using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyProducts
{
    public class Product : IComparable<Product>
    {
        private string p1;
        private string p2;
        private string p3;
        private double p4;

        public string Barcode { get; private set; }

        public string Vendor { get; private set; }

        public string Title { get; private set; }

        public decimal Price { get; private set; }

        public Product(string barcode, string vendor, string title, decimal price)
        {
            Barcode = barcode;
            Vendor = vendor;
            Title = title;
            Price = price;
        }

    

        public int CompareTo(Product other)
        {
            return string.Compare(this.Title, other.Title);
        }
    }
}