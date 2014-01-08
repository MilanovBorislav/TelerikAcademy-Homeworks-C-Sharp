using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_Object_variable
    {
    class Task_7_Object_variable
        {
        static void Main ()
            {
            //    Declare two string variables and assign them with “Hello” and “World”. Declare an object
            //    variable and assign it with the concatenation of the first two variables (mind adding an interval).
            //    Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

            string hеllo = "Hello";
            string world = "World";
            object helloworldObj = hеllo + " " + world;
            Console.WriteLine("{0} to object", helloworldObj);
            string helloowrldStr = (string)helloworldObj;
            Console.WriteLine( "{0} object to stirng", helloowrldStr);
            }
        }
    }
