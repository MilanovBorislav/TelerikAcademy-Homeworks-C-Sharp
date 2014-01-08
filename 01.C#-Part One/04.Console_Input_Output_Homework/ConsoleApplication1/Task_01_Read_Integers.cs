using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_Read_Integers
{
    class Task_01_Read_Integers
    {
        static void Main(string[] args)
        {
            //Write a program that reads 3 integer numbers from the console and prints their sum.
            Console.WriteLine("Enter Three Numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, a+b+c);
        }
    }
}
