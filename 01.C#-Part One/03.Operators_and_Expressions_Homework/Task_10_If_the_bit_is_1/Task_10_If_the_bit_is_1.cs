using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_If_the_bit_is_1
{
    class Task_10_If_the_bit_is_1
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
            //Console.WriteLine( "This is the number  " + Convert.ToInt32(result, 2));
            Console.Write("Enter position of the bit: ");
            int p = int.Parse(Console.ReadLine()); 
            int mask = 1 << p;
            int nAndMask = theNumber & mask;
            if (nAndMask == 0)
            {
                Console.WriteLine("There is NO 1 on  position " + p);
            }
            else
            {
                Console.WriteLine("There IS   1 on  position " +p);
            }
                Console.WriteLine("Binary:  {0}", result);
        }
    }
}
