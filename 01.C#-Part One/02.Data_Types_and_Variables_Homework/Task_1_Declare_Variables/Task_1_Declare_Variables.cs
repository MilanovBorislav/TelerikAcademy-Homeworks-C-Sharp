using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Declare_Variables
{
    class Task_1_Declare_Variables
    {
        static void Main()
        {
            //Declare five variables choosing for each of them the most 
            //appropriate of the types byte, sbyte, short, ushort, int,
            //uint, long, ulong to represent the following values:
            //52130, -115, 4825932, 97, -10000.
        
            sbyte sbyteVariable = 97;  //sbyte from -128 to 127

            sbyte anotherSbyteVariable = -115;   //sbyte from -128 to 127

            ushort ushortVariable = 52130; //ushort from 0 to 65535

            short shortVariable = -10000;  //short from -32768 to 32767

            int intVariable = 4825932;   //int from -2147483648 to 2147483647

            Console.WriteLine( "  {0} is sbyte, but can be byte.", sbyteVariable);
            Console.WriteLine( "  {0} is sbyte.", anotherSbyteVariable);
            Console.WriteLine( "  {0} is ushort.", ushortVariable);
            Console.WriteLine( "  {0} is short.", shortVariable);
            Console.WriteLine( "  {0} is int.", intVariable);
        }
    }
}
