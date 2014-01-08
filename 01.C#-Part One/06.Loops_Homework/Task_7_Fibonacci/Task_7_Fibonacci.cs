using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Task_7_Fibonacci
{
    class Task_7_Fibonacci
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of Fibonacci sequence :");
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger fib1 = 0;
            BigInteger fib2 = 1;
            BigInteger fib3;
            Console.WriteLine("Fibonacci {0} ",n);
            Console.Write("0, 1",n);
            for(BigInteger i = 3; i <= n; i++)
            {
                fib3 = fib1 + fib2;
                fib1 = fib2;
                fib2 = fib3;
                Console.Write(", {0}", fib3);
            }
            Console.WriteLine();
        }
    }
}
