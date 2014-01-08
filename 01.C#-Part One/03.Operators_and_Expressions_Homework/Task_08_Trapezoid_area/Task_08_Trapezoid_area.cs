using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_08_Trapezoid_area
{
    class Task_08_Trapezoid_area
    {
        static void Main()
        {
            Console.WriteLine("Enter side A");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter side B");
            double b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter height");
            double h = int.Parse(Console.ReadLine());
            double area = ((a + b) * h) / 2;
            Console.WriteLine("The area of trapezoid is " + area);
        }
    }
}
