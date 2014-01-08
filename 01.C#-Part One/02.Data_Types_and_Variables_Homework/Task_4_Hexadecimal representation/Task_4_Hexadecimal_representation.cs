using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_Hexadecimal_representation
{
    class Task_4_Hexadecimal_representation
    {
        static void Main()
        {
            //Declare an integer variable and assign it with the value 254 in hexadecimal
            //format. Use Windows Calculator to find its hexadecimal representation.
            int myInt = 254;
            string myHex = myInt.ToString("X");  // give us hexdecimal
            Console.WriteLine( "Integer value is " + myInt );
            Console.WriteLine("Hexadecimal value of {0} is {1}",myInt, myHex);
            Console.WriteLine( "Declaration is     int myInt=0xFE; ");
            //int myInt = 0xFE;
            //int myNewInt = Convert.ToInt32(myHex, 16);  // back to int 
        }
    }
}
