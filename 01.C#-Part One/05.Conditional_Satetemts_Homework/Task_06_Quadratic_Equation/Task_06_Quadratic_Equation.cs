using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06_Quadratic_Equation
{
    class Task_06_Quadratic_Equation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a value of A: ");
            int a;
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Please  enter a value of B: ");
            int b;
            int.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Please enter a value of C: ");
            int c;
            int.TryParse(Console.ReadLine(), out c);
            int desc = (b * b) - (4 * a * c);
            float d = (float)Math.Sqrt(desc);
            float x, x1, x2;
            if(desc == 0)
            {
                x = (-b) / (2 * a);
                Console.WriteLine("The descriminant is 0, so x = -b/2a = " + x);
            }
            else if(desc < 0)
            {
                Console.WriteLine("No real roots!!!");
            }
            else
            {
                x1 = (-b + d) / (2 * a);
                x2 = (-b - d) / (2 * a);
                Console.WriteLine("The roots of the quadratic equation are:\nX1 = {0}\nX2 = {1}", x1, x2);
            }
        }
    }
}
