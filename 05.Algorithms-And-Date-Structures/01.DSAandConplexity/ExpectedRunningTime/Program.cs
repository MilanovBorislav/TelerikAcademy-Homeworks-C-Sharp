using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpectedRunningTime
{
    class Program
    {
        long Compute(int[] arr)
        {
            long count = 0;
            //  first cycle n steps where n is arr.length
            for (int i = 0; i < arr.Length; i++)
            {
                int start = 0, end = arr.Length - 1;
                //second cycle n-1 steps where n is arr.length
                while (start < end)
                    if (arr[start] < arr[end])
                    {
                        start++;
                        count++;
                    }
                    else
                    {
                        end--;
                    }
            }

            return count;
        }

        long CalcCount(int[,] matrix)
        {
            long count = 0;
            //first cycle with n steps where n is matrix.GetLength(0);
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (matrix[row, 0] % 2 == 0)
                { //second cycle dependable on the above condition.
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] > 0)
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }
        
        static void Main(string[] args)
        {
        }
        /*Compute
        * The complexity of the algorithm is: O(n * n)
        * First step: Through the whole array with length n.
        * Second step: Through a while cycle which contains (n-1) steps.
        */

        /*CalcCount
        * The complexity of the algorithm is: O(n * m)
        * First step: Through the whole array with length n.
        * Second step: Through a second cycle which contains (m) steps.
        * The second cycle depends on variable (parameter) and we can ignore it. 
        */
    }
}