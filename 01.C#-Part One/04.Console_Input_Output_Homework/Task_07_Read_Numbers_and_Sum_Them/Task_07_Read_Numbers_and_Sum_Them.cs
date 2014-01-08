using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07_Read_Numbers_and_Sum_Them
{
    class Task_07_Read_Numbers_and_Sum_Them
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of input values");
            int count = int.Parse(Console.ReadLine());
            int sum = 0;
            for (var i = 0; i < count; i++)
            {
                Console.Write("Enter Value: ");
                int number = int.Parse(Console.ReadLine());
                sum = sum + number;
            }
            Console.WriteLine("The sum is {0}", sum);
        }
    }
}
