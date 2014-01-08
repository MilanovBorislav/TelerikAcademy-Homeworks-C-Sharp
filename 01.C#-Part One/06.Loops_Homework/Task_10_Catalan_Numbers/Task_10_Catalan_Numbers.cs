using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Task_10_Catalan_Numbers
{
    class Program
    {
        static BigInteger findFactorial(BigInteger number) 
        {
            uint i = 1;
            BigInteger factorial = 1;
            while(i<=number)
            {
                factorial = factorial * i;
                i++;
            }

            return factorial;
        }
        static void Main()
        {
            Console.Write("Enter some number : ");
            BigInteger CatalanNum = BigInteger.Parse(Console.ReadLine());
            BigInteger Catalan = findFactorial(2 * CatalanNum) / (findFactorial(CatalanNum + 1) * findFactorial(CatalanNum));
            Console.WriteLine("Catalan Number {0}", Catalan); 
        }
    }
}
