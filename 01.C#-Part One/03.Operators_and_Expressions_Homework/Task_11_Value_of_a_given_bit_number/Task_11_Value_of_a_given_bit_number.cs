using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11_Value_of_a_given_bit_number
{
    class Task_11_Value_of_a_given_bit_number
    {
        static void Main()
        {
            Console.Write("Enter Decimal: ");
            int decimalNumber = int.Parse(Console.ReadLine());
            int theNumber = decimalNumber;
            int remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber = decimalNumber / 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine("Binary:  {0}", result);
            Console.Write("Enter position of the bit: ");
            int p = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            int nAndMask = theNumber & mask;
            int bitValue = nAndMask >> p;
            Console.WriteLine("The value is " + bitValue);
           


        }
    }
}
