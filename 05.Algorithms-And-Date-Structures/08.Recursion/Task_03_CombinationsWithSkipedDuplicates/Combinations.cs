using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinationsWithSkipedDuplicates
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

        private static void Combinate(IList<int> arr, int index, 
            int start, int end)
        {
            if (index > arr.Count - 1)
            {
                PrintCollection(arr);
                return;
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    arr[index] = i;
                    Combinate(arr, index + 1, i + 1, end);
                }
            }
        }

        private static void Main(string[] args)
        {
            int n = 4;
            int k = 2;
            Combinate(new int[k], 0, 1, n);
        }
    }
}