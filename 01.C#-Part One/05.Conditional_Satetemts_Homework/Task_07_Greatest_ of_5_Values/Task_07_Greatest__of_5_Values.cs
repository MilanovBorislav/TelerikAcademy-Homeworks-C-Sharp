using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07_Greatest__of_5_Values
{
    class Task_07_Greatest__of_5_Values
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int second = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int third = int.Parse(Console.ReadLine());
            Console.Write("d = ");
            int fourth = int.Parse(Console.ReadLine());
            Console.Write("e = ");
            int fifth = int.Parse(Console.ReadLine());
            int a = Math.Max(first, second);
            int b = Math.Max(third, fourth);
            int c = fifth;
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
