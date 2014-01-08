using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwords
{
    class Program
    {
        static void Main(string[] args)
        {
            //string number = "1***0";
            //string number = "***101***";
            string number = Console.ReadLine();
            long counter = 1;

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == '*')
                {
                    counter = counter * 2;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
