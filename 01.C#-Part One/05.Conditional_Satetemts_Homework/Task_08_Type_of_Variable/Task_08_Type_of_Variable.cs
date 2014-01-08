using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_08_Type_of_Variable
{
    class Task_08_Type_of_Variable
    {
        static void Main(string[] args)
        {
            while(true)
            {

                Console.WriteLine("Enter something");
                var value = Console.ReadLine();
                int numberInt;
                double numberDouble;

                bool ifInt = int.TryParse(value, out numberInt);
                bool ifDouble = double.TryParse(value, out numberDouble);

                if(ifInt == true)
                {
                    Console.WriteLine("Integer");
                    Console.WriteLine(numberInt + 1); 
                }
                else if(ifDouble == true)
                {
                    Console.WriteLine("Double");
                    Console.WriteLine(numberDouble + 1);
                }
                else
                {
                    Console.WriteLine("String");
                    Console.WriteLine(value + "*");
                }
                Console.WriteLine();
            }
        }
    }
}
