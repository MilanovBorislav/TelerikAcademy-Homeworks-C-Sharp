using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05_Calculations_with_Factorials
{
    class Program
    {
        static void Main()
        {   
            Console.WriteLine("1<N<K");
            Console.Write("Enter N :");
            ulong N = ulong.Parse(Console.ReadLine());
            Console.Write("Enter K :");
            ulong K = ulong.Parse(Console.ReadLine());

            ulong N_factorial = 1;
            ulong K_factorial = 1;
            ulong K_minus_N = K - N;
            ulong N_K_fact = 1;

            for(ulong i = 1; i <= N; i++)
            {
                N_factorial = N_factorial * i;
            }
            Console.WriteLine("N! {0}", N_factorial);

            for(ulong i = 1; i <= K; i++)
            {
                K_factorial = K_factorial * i;
            }
            Console.WriteLine("K! {0}", K_factorial);

            for(ulong i = 1; i <= K_minus_N; i++)
            {
                N_K_fact = N_K_fact * i;
            }
            Console.WriteLine("(K-N)! {0}", N_K_fact);
            ulong result = (N_factorial * K_factorial) / N_K_fact;
            Console.WriteLine("N! * K! / (K-N)! = {0} ",result);
        }
    }
}
