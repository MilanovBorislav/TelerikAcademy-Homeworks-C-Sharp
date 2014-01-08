using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taks_04_Sort_Values
{
    class Taks_04_Sort_Values
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("b = ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("c = ");
                int c = int.Parse(Console.ReadLine());

                if(a <= b)
                {
                    if(b <= c)
                    {
                        Console.WriteLine("{0}, {1}, {2}", a, b, c);
                    }
                    else
                    {
                        if(a >= c)
                        {
                            Console.WriteLine("{0},{1},{2}", c, a, b);
                        }
                        else
                        {
                            Console.WriteLine("{0}, {1}, {2}", a, c, b);
                        }

                    }
                }
                else
                {
                    if(a > b)
                    {
                        if(b > c)
                        {
                            Console.WriteLine("{0}, {1}, {2}", c, b, a);
                        }
                        else
                        {
                            Console.WriteLine("{0}, {1}, {2}", b, c, a);
                        }
                    }
                }
            }
        }
    }
}
