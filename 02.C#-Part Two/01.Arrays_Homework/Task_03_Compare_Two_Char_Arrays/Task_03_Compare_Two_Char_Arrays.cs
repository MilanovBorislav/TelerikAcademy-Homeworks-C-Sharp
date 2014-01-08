using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_Compare_Two_Char_Arrays
{
    class Task_03_Compare_Two_Char_Arrays
    {
        static void Main(string[] args)
        {
            Console.Write("Write length of first Array = ");
            int length1 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Write length of second Array = ");
            int length2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            char[] arr1 = new char[length1];
            char[] arr2 = new char[length2];

            if (length1 == length2)
            {
                Console.WriteLine();
                Console.WriteLine("Full the numbers of first Array");
                for (int i = 0; i < length1; i++)
                {
                    arr1[i] = char.Parse(Console.ReadLine());
                }

                Console.WriteLine();
                Console.WriteLine("Full the numbers of second Array");
                for (int i = 0; i < length2; i++)
                {
                    arr2[i] = char.Parse(Console.ReadLine());
                }

                bool equal = true;

                for (int i = 0; i < length1; i++)
                {
                    if ((int)arr1[i] == (int)arr2[i])
                    {
                        equal = true;
                    }
                    else
                    {
                        equal = false;
                        break;
                    }
                }
                if (equal == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("They are equal");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("They are not equal");
                }


            }
            else
            {
                Console.WriteLine("The arrays are not equal");
            }
        }
    }
}
