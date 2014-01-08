using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Precision_Compare
{
    class Task_3_Precision_Compare
    {
        static void Main()
        {
            //Write a program that safely compares floating-point numbers with
            //precision of 0.000001. Examples:(5.3 ; 6.01) false
            //(5.00000001 ; 5.00000003)  true

        decimal first = 4.000000232323234m;
        decimal second = 9.0000000676878990m;
        decimal sumOfNumers = first + second;
        decimal sum =13.0000003000111330m;
        bool eqal = ( sumOfNumers == sum );
        Console.WriteLine( eqal);
        Console.WriteLine( "The sum of {0} and {1} is {2} and it's equal to {3}",first, second, sumOfNumers, sum );
        }
    }
}
