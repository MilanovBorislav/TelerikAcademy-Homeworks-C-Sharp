using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06_Maximal_Sum
{
    class Task_06_Maximal_Sum
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N = ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();


            Console.Write("Enter K = ");
            int K = int.Parse(Console.ReadLine());
            Console.WriteLine();


            Console.WriteLine("Create array of {0} elements",N);
            Console.WriteLine();
           // int[] array = { 2, 4, 5, 7, 8, 9, 5, 4, 3, 3, 23, 2, 3, 4, 5, 5, 66, 6, 6, };
            int[] array = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("array [{0}] = ",i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);

            Console.WriteLine();
            Console.WriteLine("Maximal sum  of {0} elements",K);
            Console.WriteLine();
            int sum = 0;
            for (int i = array.Length-K; i <array.Length; i++)
            {
                sum += array[i];
                Console.Write(" {0} ", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The sum is {0}", sum);
            Console.WriteLine();

        }
    }
}
