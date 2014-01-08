using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09_Most_Frequent_Number_In_An_Array
{
    class Task_09_Most_Frequent_Number_In_An_Array
    {
        static void Main(string[] args)
        {
            int start = 0;
            int bestStart = 0;
            int len = 1;
            int bestLen = 1;
            int[] arr = { 4, 1, 1, 4, 2, 4, 3, 4, 4, 1, 2, 4, 9, 3 };
            Array.Sort(arr);

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

            Console.WriteLine("Number {0}  repeats {1} times", arr[bestStart], bestLen);


            for (int i = bestStart; i < bestLen + bestStart; i++)
            {
                Console.Write(" {0} ", arr[i]);
            }
            Console.WriteLine();


        }
    }
}
