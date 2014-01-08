using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_Divisible_By_7_And_3
{
    class Program
    {
        public static void ShowResult(dynamic arr)
        {
            foreach( var item in arr )
            {
                Console.Write(" {0} ",item);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] arr = { 49, 18, 45,42, 8, 66, 9, 21, 55, 63 };

            var numbersDevisibeOn3And7LINQ =
             from num in arr
             where num % 21 == 0
             select num;

            Console.WriteLine("LINQ");
            ShowResult( numbersDevisibeOn3And7LINQ );

            Console.WriteLine();
            Console.WriteLine();

            var numbersDevisibeOn3And7Lamda =
                arr.Where( x => x % 21 == 0 );

            Console.WriteLine("Lambda");
            ShowResult( numbersDevisibeOn3And7Lamda);
        }
    }
}
