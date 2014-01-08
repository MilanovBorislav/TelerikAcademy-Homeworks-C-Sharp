using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;


namespace Task_02_Circle_Area_and_Perimeter
{
    class Task_02_Circle_Area_and_Perimeter
    {
        static void Main(string[] args)
        {
            //Write a program that reads the radius r of a circle and prints its perimeter and area.
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("това е кирилица");
            Console.Write("Enter the radius of the circle :");
            double Pi = 3.14;
            double radius = double.Parse(Console.ReadLine());
            double area = Pi * (radius * radius);
            double perimeter = 2 * Pi * radius;
            Console.WriteLine("The perimeter is {0,10} * {1} * {2} = {3:F4}", 2, "п", radius, perimeter);
            Console.WriteLine("The area is {0,15} * {1}² = {2}", "п", radius, area);
        }
    }
}
