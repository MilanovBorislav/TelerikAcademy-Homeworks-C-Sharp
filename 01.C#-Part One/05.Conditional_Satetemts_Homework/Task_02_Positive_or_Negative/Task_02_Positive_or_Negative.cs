using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_Positive_or_Negative
{
    class Task_02_Positive_or_Negative
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first value ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second value ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter third value ");
            int c = int.Parse(Console.ReadLine());

            if ((a<0 && b<0 && c<0) || (a<0 && b>0 && c<0) || (a>0 && b<0 && c>0) || (a<0 && b>0 && c>0))
            {
                Console.WriteLine("Negative");
            }
            else if ((a == 0) || (b == 0) || (c == 0))
            {
                Console.WriteLine("Zero");
            }
            else
            {
                Console.WriteLine("Positive");
            }
        }
    }
}
