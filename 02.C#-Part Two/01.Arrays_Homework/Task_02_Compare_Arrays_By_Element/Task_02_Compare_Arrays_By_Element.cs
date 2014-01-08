using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_Compare_Arrays_By_Element
{
    class Task_02_Compare_Arrays_By_Element
    {
        static void Main(string[] args)
        {
            Console.Write("Write length of first Array = ");
            int length1 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Write length of second Array = ");
            int length2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] arr1 = new int[length1];
            int[] arr2 = new int[length2];

            if (length1 == length2)
            {
                Console.WriteLine();
                Console.WriteLine("Full the numbers of first Array");
                for (int i = 0; i < length1; i++)
                {
                    arr1[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine();
                Console.WriteLine("Full the numbers of second Array");
                for (int i = 0; i < length2; i++)
                {
                    arr2[i] = int.Parse(Console.ReadLine());
                }

                bool equal = true;

                for (int i = 0; i < length1; i++)
                {
                    if (arr1[i]==arr2[i])
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
