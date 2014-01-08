using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04_LongestSubsequence
{
    public class LongestSubsequence
    {

        public static List<int> FindLongestEqualSequence(int[] arr)
        {
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
           // Console.WriteLine("Number {0} Repeats {1} times", arr[bestStart], bestLen);
            List<int> equals = new List<int>();

            for (int i = bestStart; i < bestStart + bestLen; i++)
            {
                equals.Add(arr[i]);
            }

            return equals;
        }
    }
}