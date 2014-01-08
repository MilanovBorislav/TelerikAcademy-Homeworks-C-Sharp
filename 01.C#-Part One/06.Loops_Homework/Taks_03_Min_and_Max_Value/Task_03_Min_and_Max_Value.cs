using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_Min_and_Max_Value
{
    class Task_03_Min_and_Max_Value
    {
        static void Main()
        {
            Console.Write("How many numbers you want to compare: ");
            int countNum = int.Parse(Console.ReadLine());
            int min;
            int max;
            Console.Write("Enter 1 number ");
            int currentNum = int.Parse(Console.ReadLine());
            min = currentNum;
            max = currentNum;
            for(int i = 1; i < countNum; i++)
            {
                Console.Write("Enter {0} number ", i + 1);
                currentNum = int.Parse(Console.ReadLine());
                if(min > currentNum)
                {
                    min = currentNum;
                }
                if(max < currentNum)
                {
                    max = currentNum;
                }
            }
            Console.WriteLine("The smallest number is {0}", min);
            Console.WriteLine("The biggest number is {0}", max);
        }

    }
}

