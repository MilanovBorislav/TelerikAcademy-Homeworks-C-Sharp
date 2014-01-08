using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05_Find_if_the_third_bit_is_1_or_0
    {
    class Task_05_Find_if_the_third_bit_is_1_or_0
        {
        static void Main ()
            {
            //Write a boolean expression for finding if 
            //the bit 3 (counting from 0) of a given integer is 1 or 0.

            int firstNumber = 365;   //  361=101101001011, 365=101101101                               10110|1|101
            int secondNumber = 8;   //   8=1000;                                                            |1|000
            int a = firstNumber & secondNumber;
            Console.WriteLine( a == 0 ? "The third bit of the number is NOT 1" : "The third bit of the number is 1" );
            }
        }
    }
