using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task_02_Numbers_Not_Divisible_By_3_and_7
{
    static void Main()
    {
        Console.Write("Enter end of the sequence : ");
        int a = int.Parse(Console.ReadLine());

        for(int i = 1; i <= a; i++)
        {
            if(i % 21 != 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine("{0} Divisible by 7 and 3 at the same time",i);
            }
        }
    }
}

