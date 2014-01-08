using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_Assign_null_value
    {
    class Task_14_Assign_null_value
        {
        static void Main ()
            {
                //Create a program that assigns null values to an integer and to double variables.
                //Try to print them on the console, try to add some values or the null literal to
                //them and see the result.
            int? aNull = null;
            int? bNull = null;
            double? cNull = null;
            double? dNull = null;
            Console.WriteLine( "This is valuea of aNull {0}  !", aNull );
            Console.WriteLine( "This is valuea of bNull {0}  !", bNull );
            Console.WriteLine( "This is valuea of cNull {0}  !", cNull );
            Console.WriteLine( "This is valuea of dNull {0}  !", dNull );
            Console.WriteLine( aNull + 10 );
            Console.WriteLine( bNull +"some string here");
            }
        }
    }
