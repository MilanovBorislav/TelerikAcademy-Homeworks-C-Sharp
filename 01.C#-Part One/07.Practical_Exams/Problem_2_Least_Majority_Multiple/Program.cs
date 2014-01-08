using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_Least_Majority_Multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for(int k = 0; k <= 4; k++)
            {

                arr[k] = int.Parse(Console.ReadLine());

            }
            int devider = 0;
            int i = 0;
            int a = 1;
            int bestA = 1;
            int maxDevider = 1;
                while(a<3)
                {   
                    
                    devider++;
                    a = 0;
                    for(i = 0; i < arr.Length; i++)
                    {
                        if(devider % arr[i] == 0)
                        {
                            a++;
                        }
                    }
                    if (a>bestA)
                    {
                       bestA = a;
                       maxDevider = devider;
                    }
                   
                }
                Console.WriteLine(maxDevider);
        }
    }
}
