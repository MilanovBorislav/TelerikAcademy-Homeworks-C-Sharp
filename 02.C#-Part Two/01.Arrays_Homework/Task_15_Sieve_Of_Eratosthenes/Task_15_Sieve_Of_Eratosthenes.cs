using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task_15_Sieve_Of_Eratosthenes
{
    class Task_15_Sieve_Of_Eratosthenes
    {
        static void Main(string[] args)
        {
             List<int> list = Enumerable.Range(1, 100000).ToList();
             int counter = 0;
             list.RemoveAt(0);
             for (int i = 0; i < Math.Sqrt(list.Count) ; i++)
             {
                 int number = list[i];
                 int divider = 2;
                 int maxDivider = (int)Math.Sqrt(number);
                 bool prime = true;
                 while (prime && (divider <= maxDivider))
                 {
                     if (number % divider == 0)
                     {
                         prime = false;
                     }
                     divider++;
                 }
                 if (prime == true)
                 {
                     for (int remove = i; remove < list.Count; remove++)
                     {
                         if (remove == i)
                         {
                             Console.WriteLine(list[i]);
                             continue;
                         }
                         if (list[remove] % number == 0)
                         {
                             list.RemoveAt(remove);
                         }

                     }
                     
                 }
 
             }

        }
         

    }
}
