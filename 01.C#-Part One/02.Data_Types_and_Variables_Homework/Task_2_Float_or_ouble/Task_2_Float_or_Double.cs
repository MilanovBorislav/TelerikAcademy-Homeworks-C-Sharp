using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_Float_or_ouble
{
    class Task_2_Float_or_Double
    {
        static void Main()
        {
            //Which of the following values can be assigned to a variable 
            //of type float and which to a variable of type double:
            //34.567839023, 12.345, 8923.1234857, 3456.091?
            float firts = 12.345f;

            float second = 3456.091f;

            double third = 8923.1234857d;

            double fourth = 34.567839023d;

            Console.WriteLine( "{0} and {1} are floats",firts, second);
            Console.WriteLine( "{0} and {1} are doubles",third, fourth );
        }
    }
}
