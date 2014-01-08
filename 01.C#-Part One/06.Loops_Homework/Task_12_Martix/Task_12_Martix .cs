using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_Martix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =3;
            for(int row = 1; row <=n; row++)
            {
                 Console.Write(row);
                 int collcount = n + row -1;

                 for(int coll = row + 1; coll <= collcount; coll++)
                {
                    Console.Write(coll);
                }
                Console.WriteLine();
            }
        }
    }
}
