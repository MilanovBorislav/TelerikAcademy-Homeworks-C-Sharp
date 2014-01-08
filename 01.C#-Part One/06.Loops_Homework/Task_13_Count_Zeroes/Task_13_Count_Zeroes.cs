using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Task_13_Count_Zeroes
{ 

    class Task_13_Count_Zeroes
    {
        static BigInteger findFactorial(BigInteger number)
        {
            BigInteger factorial = 1;

            for(BigInteger i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Some Number : ");

            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger i = 1;
            uint j = 0;
            while(i<=n)
            {
                if(i%5 == 0)
                {
                    j++;
                }

                i++;
            }
            Console.WriteLine("Zeroes {0}", j);
            Console.WriteLine("Factorial {0}! = {1}",n, findFactorial(n));

        }
    }
}
