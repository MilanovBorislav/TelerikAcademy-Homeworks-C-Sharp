using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04_LongestSubsequence
{
    public class EqualsNumberDemo
    {
        static void Main()
        {
            int[] arr = { 3, 4, 6, 6, 6, 6, 1, 1, 2, 2, 2 };

            List<int> equals = LongestSubsequence.FindLongestEqualSequence(arr);

            for (int i = 0; i < equals.Count; i++)
            {
                Console.WriteLine(equals[i]);
            }
        }
    }
}