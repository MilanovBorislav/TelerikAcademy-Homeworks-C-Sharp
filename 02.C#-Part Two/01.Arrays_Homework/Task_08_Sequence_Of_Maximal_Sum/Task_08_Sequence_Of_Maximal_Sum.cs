using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_08_Sequence_Of_Maximal_Sum
{
    class Task_08_Sequence_Of_Maximal_Sum
    {


        static void Main(string[] args)
        {
            int bestSum = int.MinValue;
            int sum = 0;
            int start = 0;
            int end = 0;
            int newStart = 0;

            int[] arr = { 2, 3, -6, 8, 4, -3, 12, -50, -6, -1, 2, -1, 6, 4, -8, 8 };

            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    start = newStart;
                    end = i;
                }
                if (sum < 0)
                {
                    newStart = i + 1;
                    sum = 0;
                }
            }

            for (int i = start; i <= end; i++)
            {
                Console.Write(" {0} ", arr[i]);
            }

        }
    }
}
