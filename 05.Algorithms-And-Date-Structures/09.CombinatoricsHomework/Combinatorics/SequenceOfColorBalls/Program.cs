using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SequenceOfColorBalls
{
    class Program
    {
        static List<char> list = new List<char>();
        static List<int> counters = new List<int>();
        static Dictionary<string, int> colors = new Dictionary<string, int>();

        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
             //string input = "BYYBB";
            //string input = "RYYRYBY";
            char[] arr = input.ToCharArray();
            Array.Sort(arr);
            list = arr.ToList();
            CountColors();
            BigInteger len = Factorial(arr.Length);
            BigInteger deviders = FindDeviders(counters);
            BigInteger answer = len / deviders;
            Console.WriteLine(answer);
        }

        private static BigInteger FindDeviders(List<int> counters)
        {
            BigInteger number = 1;

            for (int i = 0; i < counters.Count; i++)
            {
                number = number * Factorial(counters[i]);
            }

            return number;
        }

        private static BigInteger Factorial(BigInteger number)
        {
            BigInteger factorialNumber = 1;
            for (int i = 1; i <= number; i++)
            {
                factorialNumber = factorialNumber * i;
            }
            return factorialNumber;
        }


        private static void CountColors()
        {
            for (int i = 0; i < list.Count; i++)
            {
                int count = 1;
                string digit = list[i].ToString();
                if (colors.ContainsKey(digit))
                {
                    count = colors[digit] + 1;
                }
                colors[digit] = count;
            }
            foreach (var item in colors)
            {
                counters.Add(item.Value);
            }
        }
    }
}

