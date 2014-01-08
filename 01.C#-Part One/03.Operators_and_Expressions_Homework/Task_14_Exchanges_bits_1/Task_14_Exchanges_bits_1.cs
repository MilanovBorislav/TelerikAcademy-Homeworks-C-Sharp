using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_Exchanges_bits_1
{
    class Task_14_Exchanges_bits_1
    {
        static void Main()
        {
            int p = 4;
            int k = 6;
            int q = 19;
            int P_plus_K_minus_One = p + k - 1; //9
            int Q_plus_K_minus_One = q + k - 1; //24
            int number = Convert.ToInt32("0000000000110000000001000001110", 2);
            int num = number;
            Console.WriteLine("OLD " + Convert.ToString(number, 2).PadLeft(32, '0') + " = " + Convert.ToInt32(number));//print
            int mask1 = 3;//011
            int mask2 = 1;//01
            int getBits_P_P_plusOne = (mask1 << p) & number;//get bits p, p+1
            int getBit_P_plus_K_minus_One = (mask2 << P_plus_K_minus_One) & number;//get bit p+k-1;
            //                                                                                                               Console.WriteLine("p,p+1  " + Convert.ToString(getBits_P_P_plusOne, 2).PadLeft(32, '0'));
            //                                                                                                               Console.WriteLine("p+k-1  " + Convert.ToString(getBit_P_plus_K_minus_One, 2).PadLeft(32, '0'));
            int getBits_Q_Q_plus_One = (mask1 << q) & number;//get bits q, q+1
            int getBits_Q_plus_K_minus_One = (mask2 << Q_plus_K_minus_One) & number;//get bit q+k-1
            //                                                                                                               Console.WriteLine("q, q+1 " + Convert.ToString(getBits_Q_Q_plus_One, 2).PadLeft(32, '0'));
            //                                                                                                               Console.WriteLine("q+k-1  " + Convert.ToString(getBits_Q_plus_K_minus_One, 2).PadLeft(32, '0'));
            number = number & (~(mask1 << p)); //null p, p+1;
            //                                                                                                               Console.WriteLine("null p " + Convert.ToString(number, 2).PadLeft(32, '0'));
            number = number | (getBits_Q_Q_plus_One >> (q - p));//concatenate
            //                                                                                                               Console.WriteLine("Binary " + Convert.ToString(number, 2).PadLeft(32, '0'));
            number = number & (~(mask1 << q)); //null null q, q+1;
            //                                                                                                               Console.WriteLine("Binary " + Convert.ToString(number, 2).PadLeft(32, '0'));
            number = number | (getBits_P_P_plusOne << (q - p));//concatenate
            //                                                                                                               Console.WriteLine("Binary " + Convert.ToString(number, 2).PadLeft(32, '0'));
            number = number & (~(mask2 << P_plus_K_minus_One));//null p+k-1
            //                                                                                                               Console.WriteLine("Binary " + Convert.ToString(number, 2).PadLeft(32, '0'));
            number = number & (~(mask2 << Q_plus_K_minus_One));//null q+k-1
            //                                                                                                               Console.WriteLine("Binary " + Convert.ToString(number, 2).PadLeft(32, '0'));
            number = number | (getBit_P_plus_K_minus_One << (Q_plus_K_minus_One - P_plus_K_minus_One));//concatenate
            //                                                                                                               Console.WriteLine("Binary " + Convert.ToString(number, 2).PadLeft(32, '0'));
            number = number | (getBits_Q_plus_K_minus_One >> (Q_plus_K_minus_One - P_plus_K_minus_One));//concatenate
            Console.WriteLine("NEW " + Convert.ToString(number, 2).PadLeft(32, '0') + " = " + Convert.ToInt32(number));//print
        }
    }
}
