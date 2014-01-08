using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_Sequence_Of_Given_Sum
{
    class Task_10_Sequence_Of_Given_Sum
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 3, 1,7, 4, 2, 5, 8 };
            int givenSum = 18;
            int sum = arr[0];
            int start = 0;
            int end = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum = arr[i];
                for (int g = i+1; g < arr.Length; g++)
                {
                    sum = sum + arr[g];
                    if (sum == givenSum)
                    {
                        start = i;
                        end = g;
                        break;
                    }
                    if (sum > givenSum)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("The array is");
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" {0} ",arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Given sum is {0}", givenSum);
            Console.WriteLine();
            for (int i = start; i <= end; i++)
            {
                Console.Write(" {0} ", arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
