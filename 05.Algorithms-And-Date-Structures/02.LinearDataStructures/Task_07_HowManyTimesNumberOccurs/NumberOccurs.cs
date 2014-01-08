using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07HowManyTimesNumberOccurs
{
    public class NumberOccurs
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 2, 3, 7, 7, 5, 9, 9, 7, 7, 7, 3, 4, 4, 4 };
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                int current = arr[i];
                int counter = 1;
                Console.Write("Number " + current + " appears ");
                for (int j = i; j < arr.Length; j++)
                { 
                    if (j == arr.Length - 1 || current != arr[j + 1])
                    {
                        Console.Write(counter + " times");
                        Console.WriteLine("");
                        break;
                    }
                    counter++;
                    i++;
                }
            }
        }
    }
}