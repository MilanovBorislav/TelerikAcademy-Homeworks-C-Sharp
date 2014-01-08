using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task_10_Calculate_Sum
{
    class Program
    {
        static void Main()
        {
            decimal sum = 0m;
            int count = 1;
            while ((1.0m / count) > 0.001m)
            {
                if ((count % 2 == 0) || (count == 1))
                {
                    sum = sum + 1.0m / count;
                }
                else
                {
                    sum = sum - 1.0m / count;
                }
                count++;
            }
            Console.WriteLine("Sum = {0}", sum);
           

        }
    }
}
