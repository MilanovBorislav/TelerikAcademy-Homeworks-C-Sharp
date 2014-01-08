using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_after_10_years
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you age");
            int a = sbyte.Parse(Console.ReadLine());
            int b = a + 10;
            Console.WriteLine("Your age after 10 years will be " + b );
        }
    }
}
