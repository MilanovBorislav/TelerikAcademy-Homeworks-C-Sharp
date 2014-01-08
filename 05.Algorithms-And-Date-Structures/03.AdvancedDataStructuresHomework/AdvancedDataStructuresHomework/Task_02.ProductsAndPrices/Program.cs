using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace Task_02.ProductsAndPrices
{
    class Program
    {
        private static Random rand = new Random();

        static void Main()
        {
            OrderedBag<Product> products = new OrderedBag<Product>();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 1; i <= 500000; i++)
            {
                Product product = new Product("product" + i,GetRandomNumber(20, 400) * i * GetRandomNumber(2, 7) / GetRandomNumber(3, 5));
                products.Add(product);
            }

            stopwatch.Stop();
            Console.WriteLine("Added 500000 products to bag: {0}", stopwatch.Elapsed);

            List<Product> prodRange = new List<Product>();
            stopwatch.Reset();
            stopwatch.Restart();
            for (int i = 1; i <= 10000; i++)
            {
                int min = GetRandomNumber(20, 400) * i * GetRandomNumber(2, 7) / GetRandomNumber(3, 5);
                int max = GetRandomNumber(20, 400) * i * 18 * GetRandomNumber(2, 7);

                prodRange.AddRange(products.Range(new Product("product" + i,min), true, new Product("product" + i,max), true).Take(20));
            }
            stopwatch.Stop();
            Console.WriteLine("Search for 10000 random price products: {0}", stopwatch.Elapsed);
        }

        public static int GetRandomNumber(int min, int max)
        {
            return rand.Next(min, max);
        }
    }
}