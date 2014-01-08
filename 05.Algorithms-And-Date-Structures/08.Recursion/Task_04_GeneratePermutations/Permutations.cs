using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04_GeneratePermutations
{
    class Permutations
    {
        private const int Len = 3;
        private static readonly int[] UsedCells = new int[Len];
        private static readonly int[] PermutationsArr = new int[3];

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" {0}", PermutationsArr[i] + 1);
            }
            Console.WriteLine();
        }

        private static void Permutate(int i)
        {
            if (i >= Len)
            {
                PrintArray(PermutationsArr);
                return;
            }

            for (int k = 0; k < Len; k++)
            {
                if (UsedCells[k] != 0)
                {
                    continue;
                }
                else
                {
                    UsedCells[k] = 1;
                    PermutationsArr[i] = k;
                    Permutate(i + 1);
                    UsedCells[k] = 0;
                }

            }
        }


        static void Main(string[] args)
        {
            Permutate(0);
        }
    }
}
