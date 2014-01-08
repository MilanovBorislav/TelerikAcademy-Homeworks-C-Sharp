using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06_GenerateSubSets
{
    class SubSets
    {
        public static string[] Words = {"test", "rock", "fun"};

        private static void PrintWords(IList<int> arr)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Write(Words[arr[i]] + " ");
            }
            Console.WriteLine();
        }

        private static void Combinate(int[] arr, int index, int start)
        {
            if (index > arr.Length - 1)
            {
                PrintWords(arr);
                return;
            }
            for (int i = start; i < Words.Length; i++)
            {
                arr[index] = i;
                Combinate(arr, index + 1, arr[0]+1);
            }
        }

        static void Main(string[] args)
        {
            int k = 2;
            Combinate(new int[k], 0, 0);
        }
    }
}
