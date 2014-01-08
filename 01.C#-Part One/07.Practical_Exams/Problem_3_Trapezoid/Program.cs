using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3_Trapezoid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int width = 2 * n;

            string dotsFL = new String('.', (width - n));
            string starsFL = new String('*', (width - n));
            Console.Write(dotsFL);
            Console.Write(starsFL);
            Console.WriteLine();
            for(int i = 1; i <n; i++)
            {
                string dots = new String('.', (width - n) - i);
                Console.Write(dots);

                string starSingle = "*";
                Console.Write(starSingle);

                string dots2 = new String('.', (n-1) + a);
                Console.Write(dots2);
                Console.Write(starSingle);
                Console.WriteLine();
                a++;
            }
            string bottom = new String('*', (width));
            Console.WriteLine(bottom);
        }
    }
}
