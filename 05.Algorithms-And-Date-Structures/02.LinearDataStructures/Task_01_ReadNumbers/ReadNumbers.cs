using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_ReadNumbers
{
    class ReadNumbers
    {
        public static int SumNumbers(LinkedList<int> numbers)
        {
            int sum = 0;
            var item = numbers.First;

            while (item != null)
            {
                sum += item.Value;
                item = item.Next;
            }
            
            return sum;
        }

        public static double GetAverage(LinkedList<int> numbers)
        {
            double sum = SumNumbers(numbers);
            return (double)sum / numbers.Count;
        }

        static void Main(string[] args)
        {
            LinkedList<int> numbers = new LinkedList<int>();
            
            while (true)
            { 
                string line = Console.ReadLine();
                if (line == "")
                {
                    break;
                }
                int number = int.Parse(line);
                numbers.AddFirst(number);
            }
    
            int sum = SumNumbers(numbers);
            double average = GetAverage(numbers);

            Console.WriteLine("The sum is : " + sum);
            Console.WriteLine("The sum average is : " + average);
        }
    }
}