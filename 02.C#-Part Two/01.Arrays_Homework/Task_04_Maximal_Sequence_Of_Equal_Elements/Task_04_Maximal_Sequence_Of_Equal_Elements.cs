using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04_Maximal_Sequence_Of_Equal_Elements
{
    class Task_04_Maximal_Sequence_Of_Equal_Elements
    {
        static void Main(string[] args)
        {
            // int[] arr = { 2, 1, 1, 2, 4, 4, 4, 4, 4, 4, 4, 4, 3, 3, 2, 2, 2, 1, };
            Console.Write("Enter the length of array = ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] arr = new int[length];
            Console.WriteLine("Enter the numbers");
            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();


            int len = 1;
            int bestLen = 1;
            int start = 0;
            int bestStart = 0;


            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    len++;
                }
                else
                {
                    len = 1;
                }
                if (len > bestLen)
                {
                    bestLen = len;

                    start = i - bestLen;

                    bestStart = start + 1;

                }

            }
            //             Console.WriteLine("best start {0}", bestStart);
            //             Console.WriteLine("best len {0}", bestLen);

            Console.WriteLine("Number {0} Repeats {1} times", arr[bestStart], bestLen);
            for (int i = bestStart; i < bestStart + bestLen; i++)
            {
                Console.Write(" {0} ", arr[i]);
            }
            Console.WriteLine();
        }
    }
}
