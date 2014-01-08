using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;




namespace Task_08_Create_Sequence
{
    class Task_08_Create_Sequence
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the end of the sequence: ");
            int count = int.Parse(Console.ReadLine());
            int a = 0;
            while (a < count)
            {
                a++;
                Console.WriteLine(a);
            }
        }
    }
}
