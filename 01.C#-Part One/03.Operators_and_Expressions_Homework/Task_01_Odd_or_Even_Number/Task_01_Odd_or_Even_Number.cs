using System;

namespace Task_01_Odd_or_Even_Number
    {
    class Task_01_Odd_or_Even_Number
        {
        static void Main ( string [ ] args )
            {
            // Write an expression that checks if given integer is odd or even.
            Console.WriteLine( "Enter some number" );
            int myNumber = int.Parse( Console.ReadLine( ) );
            Console.WriteLine( myNumber % 2 == 0 ? "Your number is EVEN" : "Your number is ODD" );
            }
        }
    }
