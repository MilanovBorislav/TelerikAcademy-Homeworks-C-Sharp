using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05_Greater_Number
{
    class Task_05_Greater_Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b = int.Parse(Console.ReadLine());
            int c = Math.Max(a, b);
            Console.WriteLine("The greater number is {0}",c);
        }
    }
}
