using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_Quoted_strings
    {
    class Task_8_Quoted_strings
        {
        static void Main ()
            {
                //Declare two string variables and assign them with following value:
                //The "use" of quotations causes difficulties.
                //Do the above in two different ways: with and without using quoted strings.

                string first = "The \"use\" of quotations causes difficulties.";
                Console.WriteLine( first);
                string second = "The \u0022use\u0022 of quotations causes difficulties.";
                Console.WriteLine( second);
            }
        }
    }
