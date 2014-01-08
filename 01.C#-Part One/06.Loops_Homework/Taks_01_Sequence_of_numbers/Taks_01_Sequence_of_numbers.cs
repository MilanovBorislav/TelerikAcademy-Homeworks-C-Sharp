using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Taks_01_Sequence_of_numbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter end of the sequence : ");
        int a = int.Parse(Console.ReadLine());
        for(int i = 1; i <= a; i++ )
        {
            Console.WriteLine(i);
        }
    }
}

