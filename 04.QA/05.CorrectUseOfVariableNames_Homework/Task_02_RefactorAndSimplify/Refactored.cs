using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_RefactorAndSimplify
{
    class Refactored
    {
        public static void PrintMax(double[] arr)
        {
            double max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine(max);
        }

        public static void PrintMin(double[] arr)
        {
            double min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine(min);
        }

        public static void PrintAverage(double[] arr)
        {
            double total = 0;
            double elementCount = arr.Length;
            for (int i = 0; i < elementCount; i++)
            {
                total = total + arr[i];
            }

            Console.WriteLine(total / elementCount);
        }

        public static void PrintStatistics(double[] arr)
        {
            PrintMax(arr);
            PrintMin(arr);
            PrintAverage(arr);
        }

        static void Main(string[] args)
        {
            double[] arr = { 1.36, 2.58, 3.0, 0.20, 45.97, 56.12, 6.01, 7.78 };
            PrintStatistics(arr);
        }
    }
}
