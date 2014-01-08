using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsForIEnumerable_T
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {5,6,9,4,121,42,7,18 };



            int minElemnt= arr.Min(); 
            Console.WriteLine("Min element int the array  {0}", minElemnt);

            int maxElement = arr.Max();
            Console.WriteLine( "Max element int the array  {0}", maxElement );

            long productOfElemtns = arr.Product();
            Console.WriteLine("Product is  {0}",productOfElemtns);

            int sumOfElemnts = arr.Sum();
            Console.WriteLine("Sum of elemtns in the array is  {0}",sumOfElemnts);

            decimal averageOfElemtns = arr.Average();
            Console.WriteLine("Average of elements in the array is {0}", averageOfElemtns);


        }
    }
}
