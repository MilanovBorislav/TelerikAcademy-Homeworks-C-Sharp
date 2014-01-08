using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09_Fibonacci_Sequence
{
    class Task_09_Fibonacci_Sequence
    {
        static void Main(string[] args)
        {
            int countNumber = 10;
            int a = 3;
            int var1 = 0;
            int var2 = 1;
            int var3;
            Console.WriteLine("Fibonacci");
            Console.WriteLine( var1);
            Console.WriteLine( var2);

            while (a <= countNumber)
            {
                var3 = var1 + var2;
                var1 = var2;
                var2 = var3;
                Console.WriteLine(var3);
                a++;
            }
  
            //Console.Write("Enter the count of the numbers: ");
            //int countNumber = int.Parse(Console.ReadLine());
            //int var1 = 0;
            //int var2 = 1;
            //int var3;
            //Console.WriteLine(var1);
            //Console.WriteLine(var2);
            //for (int i = 3; i <= countNumber; i++ )
            //{
            //    var3 = var1 + var2;
            //    var1 = var2;
            //    var2 = var3;
            //    Console.WriteLine(var3);
            //}
        }
    }
}
