using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11_Change_Value_of_Variables
    {
    class Task_11_Change_Value_of_Variables
        {
        static void Main ()
            {
                //Declare  two integer variables and assign them with 5 and 10 and
                //after that exchange their values.
            int a = 5;

            int b = 10;

            int c = a;

            a = b;
            b = c;

            int x = 5;
            int y = 10;
            x = x + y; //     5+10=15     x=15
            y = x - y; //     15-10=5     y=5
            x = x - y; //     15-5=10     x=10

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine( " ");
            Console.WriteLine( x);
            Console.WriteLine( y);



            }
        }
    }
