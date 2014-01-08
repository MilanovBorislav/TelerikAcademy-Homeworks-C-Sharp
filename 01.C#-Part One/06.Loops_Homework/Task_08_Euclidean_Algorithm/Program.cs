using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_08_Euclidean_Algorithm
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter first number : ");
            int f = int.Parse(Console.ReadLine());
            Console.Write("Enter second number : ");
            int g = int.Parse(Console.ReadLine());
            int change = f;
            if(g > f)
            {
                f = g;
                g = change;
            }
            
            int GCD = 1;
            Console.Write("GCD of {0} and {1} is ",f,g);
            while(true)
            {
                GCD = f - g;
                if(GCD >= g)
                {
                    f = GCD;
                }
                if(GCD <= g)
                {
                    f = g;
                    g = GCD;
                }
                if(GCD == 0)
                {
                    GCD = f;
                    break;
                }

            }
            Console.WriteLine( GCD);


        }
    }
}
