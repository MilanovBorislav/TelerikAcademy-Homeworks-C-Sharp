using System;

namespace Task_02_Devided_by_5and_7
    {
    class Task_02_Devided_by_5_and_7
        {
        static void Main ()
            {
            //Write a boolean expression that checks for given integer if it
            //can be divided (without remainder) by 7 and 5 in the same time.

            Console.WriteLine( "Enter some number" );
            int myNumber = int.Parse( Console.ReadLine( ) );
            Console.WriteLine( myNumber % 35 == 0 ? "Your number is devided by 5 and 7 in the same time" : "Your number is NOT devided by 5 and 7 in the same time" );
            }
        }
    }
