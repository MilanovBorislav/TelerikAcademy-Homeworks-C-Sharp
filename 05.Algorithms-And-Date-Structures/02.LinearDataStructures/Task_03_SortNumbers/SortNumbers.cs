using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_SortNumbers
{
    class SortNumbers
    {
        public static int[] InsertionSort(int[] arr)
        {
            int[] sorted = arr.Clone() as int[];

            for (int i = 1; i < sorted.Length; i++)
            {
                int key = sorted[i];
                int hole = i;

                while (hole > 0 && key < sorted[hole - 1])
                {
                    sorted[hole] = sorted[hole - 1];
                    hole--;
                }
                sorted[hole] = key;
            }

            return sorted;
        }

        static void Main(string[] args)
        {
            int[] arr = { 5, 7, 3, 8, 4, 6, 1, 9, 2, };

            int[] sorted = InsertionSort(arr);

            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}