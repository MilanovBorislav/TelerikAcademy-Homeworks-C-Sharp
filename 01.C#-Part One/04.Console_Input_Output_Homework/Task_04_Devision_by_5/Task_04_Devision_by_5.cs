using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04_Devision_by_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter start of sequence");
            uint start = uint.Parse(Console.ReadLine());
            Console.WriteLine("Enter end of sequence");
            uint end = uint.Parse(Console.ReadLine());
            uint i = 0;
            while (start <= end)
            {
                if (start % 5 == 0)
                {
                    i++;
                    //Console.WriteLine(" {0} " ,start);
                }
                start++;
            }
            Console.WriteLine("In this sequence there are {0} numbers multiple of five",i);
        }
    }
}
