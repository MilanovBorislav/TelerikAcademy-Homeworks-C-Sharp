using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04__Calculate_and_devide_Factorial
{
    class Task_04__Calculate_and_devide_Factorial
    {
        static void Main()
        {
            Console.WriteLine("1<K<N");
            Console.Write("Enter K : ");
            ulong K_factoriral = ulong.Parse(Console.ReadLine());
            Console.Write("Enter N : ");
            ulong N_factiorial = ulong.Parse(Console.ReadLine());
            ulong result = 1;
            for(ulong i = K_factoriral + 1; i <= N_factiorial; i++)
            {
                result = result * i;
            }
            Console.WriteLine("N!/K! = {0}", result);
        }
    }
}
