using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_ReverseNumbers
{
    class ReverseNumbers
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "")
                {
                    break;
                }
                int number = int.Parse(line);
                numbers.Push(number);
            }

            Console.WriteLine("Reversed order");

            while (numbers.Count > 0)
            {
                int number = numbers.Pop();
                Console.WriteLine(number);
            }
        }
    }
}