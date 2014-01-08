using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07_Selection_Sort
{
    class Task_07_Selection_Sort
    {
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" {0} ", arr[i]);
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 4, 3, 2, 5, 1 };

            for (int i = 0; i < array.Length; i++)
            {
                for (int g = i + 1; g < array.Length; g++)
                {
                    if (array[i] > array[g])
                    {
                        int changer = array[i];
                        array[i] = array[g];
                        array[g] = changer;
                    }
                }
            }
            Console.WriteLine();
            PrintArray(array);


        }
    }
}
