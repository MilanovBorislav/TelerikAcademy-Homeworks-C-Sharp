using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_DigitsCount
{
    class DigitsCount
    {
        static void Main(string[] args)
        {
            int[] digits = {3, 4, 4, 1, 5, 3, 3, 4, 3, 1, 5};
            CountDigits(digits);

        }

        public static void CountDigits(int[] arr)
        {
            IDictionary<string, int> countDigits = new Dictionary<string, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                string digit = arr[i].ToString();
                if (countDigits.ContainsKey(digit))
                {
                    count = countDigits[digit] + 1;
                }
                countDigits[digit] = count;

            }
            Console.WriteLine();
            foreach (var pair in countDigits)
            {
                Console.WriteLine("{0} --> {1}", pair.Key, pair.Value);
            }
        }
    }
}
