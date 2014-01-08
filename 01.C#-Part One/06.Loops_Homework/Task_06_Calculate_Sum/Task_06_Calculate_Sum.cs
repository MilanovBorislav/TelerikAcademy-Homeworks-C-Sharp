using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06_Calculate_Sum
{
    class Task_06_Calculate_Sum
    {          // S = 1 + 1!/X + 2!/X2 + … + N!/XN
        static void Main()
        {
            Console.Write("Enter N :");
            decimal N = decimal.Parse(Console.ReadLine());
            Console.Write("Enter X :");
            decimal X = decimal.Parse(Console.ReadLine());
            decimal factorial = 1;
            decimal S = 1;
            decimal power = 1;
            Console.Write("S = 1");
            for(int i = 1; i <= N; i++)
            {

                factorial = factorial * i;

                power = power * X;

                S = S + factorial / power;
                Console.Write(" + {0}!/{1}^{2}",i,X,i);
            }
            Console.WriteLine("");
            Console.WriteLine("S = {0}",S);
            

        }
    }
}
