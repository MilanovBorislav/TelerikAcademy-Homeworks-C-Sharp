using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_Greater_Value
{
    class Task_01_Greater_Value
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first value = ");
            int firstValue = int.Parse(Console.ReadLine());
            Console.Write("Enter second value = ");
            int secondValue = int.Parse(Console.ReadLine());
            int contValue = secondValue;
            if(firstValue > secondValue)
            {
                secondValue = firstValue;
                firstValue = contValue;
            }
            Console.WriteLine("First value is {0}", firstValue);
            Console.WriteLine("Second value is {0}", secondValue);
        }
    }
}
