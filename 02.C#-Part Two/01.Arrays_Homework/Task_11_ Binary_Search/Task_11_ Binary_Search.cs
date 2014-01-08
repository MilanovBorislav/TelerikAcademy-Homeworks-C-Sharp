using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11__Binary_Search
{
    class Task_11_Binary_Search
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 4, 5, 6, 9, 11, 13, 14, 16, 17, 19, 20, 21,33 };
            int length = arr.Length;
            int beginning = 0;
            int target = 1;
            int test = 0;

            while (beginning + 1 < length)
            {
                test = (beginning + length) / 2;
                if (arr[test] > target)
                {
                    length = test;
                }
                else
                {
                    beginning = test;
                }


                if (arr[beginning] == target)
                {
                    Console.WriteLine("Found arr[{0}] = {1}",beginning,arr[beginning]);

                    break;
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
            Console.WriteLine();
        }
    }
}
