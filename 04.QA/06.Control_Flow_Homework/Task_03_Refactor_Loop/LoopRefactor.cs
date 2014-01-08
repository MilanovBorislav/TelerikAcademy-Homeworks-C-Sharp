using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_Refactor_Loop
{
    class LoopRefactor
    {
        static void Main(string[] args)
        {
            int[] array = { 15, 2, 3, 4, 5, 34, 3, 2, 2, 2, 4, 8, 9, 5 };
                      
            bool found = false;
            int searchedValue = 5;

            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine(array[index]);

                if (index % 10 == 0)
                {
                    if (array[index] == searchedValue)
                    {
                        found = true;
                        break;
                    }
                }
            }

            if (found)
            {
                Console.WriteLine("Value Found!");
            }
        }
    }
}
