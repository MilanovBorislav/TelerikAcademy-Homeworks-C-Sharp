using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_CombinationsWithDuplicates
{
    class Combinations
    {
        static void PrintCollection(IEnumerable<int> arr)
        {
            foreach (var item in arr)
            {
                Console.Write(" {0}", item);
            }
            Console.WriteLine();
        }

        private static void GenerateCombinations(int index, int nested, IList<int> arr)
        {
            if (arr == null) throw new ArgumentNullException("arr");
            if (index > arr.Count - 1)
            {
                PrintCollection(arr);
                return;
            }

            for (int i = 1; i <= nested; i++)
            {
                arr[index] = i;
                GenerateCombinations(index+1,nested,arr);
            }
        }

        static void Main(string[] args)
        {
            int n = 3;
            int k = 2;
            int[] arr = new int[k];
            GenerateCombinations(0, n, arr);
        }
    }
}
