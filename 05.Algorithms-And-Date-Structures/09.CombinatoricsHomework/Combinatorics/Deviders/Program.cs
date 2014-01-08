using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devision
{
    class Program
    {



        static readonly List<int> Numbers = new List<int>();

        static void Swap(ref int first, ref int second)
        {
            int oldFirst = first;
            first = second;
            second = oldFirst;
        }

        static void GeneratePermutations(int[] arr, int k)
        {
            if (k >= arr.Length)
            {
                ConvertToNumber(arr);
            }
            else
            {
                GeneratePermutations(arr, k + 1);
                for (int i = k + 1; i < arr.Length; i++)
                {
                    Swap(ref arr[k], ref arr[i]);
                    GeneratePermutations(arr, k + 1);
                    Swap(ref arr[k], ref arr[i]);
                }
            }
        }

        private static void ConvertToNumber(int[] arr)
        {
            string str = "";

            for (int i = 0; i < arr.Length; i++)
            {
                int test = arr[i];
                str += test.ToString();
            }

            int num = int.Parse(str);
            Numbers.Add(num);
        }

        private static void FindDeviders(List<int> numbers)
        {
            var numbersCounters = new List<int>();
            foreach (int t in numbers)
            {
                int counter = 0;
                for (int j = 1; j <= t; j++)
                {
                    if (t % j == 0)
                    {
                        counter++;
                    }
                }
                numbersCounters.Add(counter);
            }
            int min = numbersCounters[0];
            int index = 0;
            for (var i = 1; i < numbersCounters.Count; i++)
            {
                if (min > numbersCounters[i])
                {
                    min = numbersCounters[i];
                    index = i;
                }
            }
            Console.WriteLine(numbers[index]);
        }


        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());
            int[] arr = new int[len];
            for (int i = 0; i < len; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            GeneratePermutations(arr, 0);
            //Console.WriteLine();
            FindDeviders(Numbers);
        }
    }
}
