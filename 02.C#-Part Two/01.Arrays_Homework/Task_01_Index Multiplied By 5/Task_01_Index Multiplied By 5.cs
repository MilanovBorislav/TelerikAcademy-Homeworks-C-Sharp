using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_Index_Multiplied_By_5
{
    class Task_01_Index_Multiplied_By_5
    {
        static void Main(string[] args)
        {
            int length = 20;
            int[] intArr = new int[length];

            for (int i = 0; i < length; i++)
            {
                intArr[i] = i * 5;
            }
            Console.Write("Array = {");
            for (int i = 0; i < length; i++)
            {
                Console.Write(" {0} " ,intArr[i]);
            }
            Console.Write("}");
            Console.WriteLine();
        }
    }
}
