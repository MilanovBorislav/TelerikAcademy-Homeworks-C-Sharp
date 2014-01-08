using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_Exchanges_bits
{
    class Task_13_Exchanges_bits
    {
        static void Main()
        {
            int number = 134214016;
            int mask = 7;
            int getFirstBits = (7 << 3) & number; //get bits 3 4 5
            int getSecondBits = (7 << 24) & number;  //get bits 24 25 26
            getFirstBits = getFirstBits << 21; //push 3, 4, 5 bit, twenty one positions to the left
            getSecondBits = getSecondBits >> 21; //push 24,25,26 bit, twenty one positions to the right
            Console.WriteLine("OLD " + Convert.ToString(number, 2));
            number = number & (~(mask << 3)); //null the 3,4,5 bits for easier concatenation
            number = number & (~(mask << 21)); //null the 24,25,26 bits for easier concatenation
            number = number | getFirstBits; //concatenate the number and the pushed 3,4,5 bits
            number = number | getSecondBits; //concatenate the number and the pushed 24,25,26 bits
            Console.WriteLine("NEW " + Convert.ToString(number, 2));
            Console.WriteLine(number);
        }

    }
}
