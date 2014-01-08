using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_Biggest_Number
{
    class Task_03_Biggest_Number
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

                if(a >= b)
                {
                    if(b >= c)
                    {
                        Console.WriteLine("The bigger is {0}", a);
                    }
                    else
                    {
                        if(a <= c)
                        {
                            Console.WriteLine("The bigger is {0}", c);
                        }
                        else
                        {
                            Console.WriteLine("The bigger is {0}", a);
                        }
                    }
                }
                else
                {
                    if(b >= a)
                    {
                        if(b >= c)
                        {
                            Console.WriteLine("The bigger is {0}", b);
                        }
                        else
                        {
                            Console.WriteLine("The bigger is {0}", c);
                        }
                    }
                }
            }
        }
    }
}
