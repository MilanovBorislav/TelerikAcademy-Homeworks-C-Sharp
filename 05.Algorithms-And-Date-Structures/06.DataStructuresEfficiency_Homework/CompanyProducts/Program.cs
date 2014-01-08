using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace CompanyProducts
{

    class Program
    {
        static OrderedMultiDictionary<decimal, Product> products =
              new OrderedMultiDictionary<decimal, Product>(true);

        static void FindProducts(decimal min, decimal max)
        {
            var findedProducts = products.Range(min, true, max, true).Values;
            foreach (var product in findedProducts)
            {
                Console.WriteLine(product.Title + " " + product.Price);
            }
        }

        static void Main(string[] args)
        {
            var product1 = new Product("|", "A", "Mineral Water", 10.00m);
            products[product1.Price].Add(product1);
            var product2 = new Product("|", "B", "Cold Water", 8.00m);
            products[product2.Price].Add(product2);
            var product3 = new Product("|", "C", "Some Water", 7.00m);
            products[product3.Price].Add(product3);
            var product4 = new Product("|", "D", "Hot Water", 6.00m);
            products[product4.Price].Add(product4);
            var product5 = new Product("|", "E", "Stream Water", 12.00m);
            products[product5.Price].Add(product5);
            Console.WriteLine();
            FindProducts(6.00m, 8.00m);            
        }
    }
}
