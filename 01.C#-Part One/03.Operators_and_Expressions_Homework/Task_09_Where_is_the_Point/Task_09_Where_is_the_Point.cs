using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09_Where_is_the_Point
{
    class Task_09_Where_is_the_Point
    {
        static void Main()
        {
            Console.Write("Enter x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            double y = double.Parse(Console.ReadLine());
            if (((x - 1) * (x - 1) + (y - 1) * (y - 1)) < 9)
            {
                if (y > 1)
                {
                    Console.WriteLine("Point is in circle, outside rectangle");
                }
                else if ((y < 1 || y > -1) && x < -1)
                {
                    Console.WriteLine("Point is in circle, outside rectangle");
                }
                else if (y < -1)
                {
                    Console.WriteLine("Point is in circle, outside rectangle");
                }
                else
                {
                    Console.WriteLine("Point is out of all");
                }
            } 
        }
    }
}
