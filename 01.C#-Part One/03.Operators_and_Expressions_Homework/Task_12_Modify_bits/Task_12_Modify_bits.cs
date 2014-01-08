using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_Modify_bits
{
    class Task_12_Modify_bits
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
            Console.Write("Enter value of the bit: ");
            int bitValue = int.Parse(Console.ReadLine());
            if (bitValue == 1)
            {
                int nAndMask = theNumber | mask;
                Console.WriteLine("The decimal value is " + nAndMask);

                string newResult = string.Empty;
                while (nAndMask > 0)
                {
                    remainder = nAndMask % 2;
                    nAndMask = nAndMask / 2;
                    newResult = remainder.ToString() + newResult;
                }
                Console.WriteLine("Old Binary:  {0}", result);
                Console.WriteLine("New Binary:  {0}", newResult);
            }
            else
            {
                int nAndMask = theNumber ^ mask;
                Console.WriteLine("The decimal value is " + nAndMask);

                string newResult = string.Empty;
                while (nAndMask > 0)
                {
                    remainder = nAndMask % 2;
                    nAndMask = nAndMask / 2;
                    newResult = remainder.ToString() + newResult;
                }
                Console.WriteLine("Old Binary:  {0}", result);
                Console.WriteLine("New Binary:  {0}", newResult);
            }
        }
    }
}
