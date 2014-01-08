using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_Print_ASCII_Characters
    {
    class Task_12_Print_ASCII_Characters
        {
        static void Main ()
            {
            for ( int i = 0; i <= 255; i++ )
                {
                    Console.WriteLine( "{0} - {1}", i, (char) i );
                }
            }
        }
    }
