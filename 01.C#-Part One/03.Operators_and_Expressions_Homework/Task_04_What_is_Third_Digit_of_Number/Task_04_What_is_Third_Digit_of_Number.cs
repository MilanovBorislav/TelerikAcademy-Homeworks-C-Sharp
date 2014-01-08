using System;

namespace Task_04_What_is_Third_Digit_of_Number
    {
    class Task_04_What_is_Third_Digit_of_Number
        {
        static void Main ()
            {
            //Write an expression that checks for given integer
            //if its third digit (right-to-left) is 7. E. g. 1732  true.

            Console.WriteLine( "Enter Some Number" );
            int myInt = int.Parse( Console.ReadLine( ) );
            int a = myInt / 100;
            int b = a % 10;
            Console.WriteLine( b == 7 ? "The third digit (right-to-left) is 7" : "The third digit (right-to-left) is NOT 7" );
            }
        }
    }
