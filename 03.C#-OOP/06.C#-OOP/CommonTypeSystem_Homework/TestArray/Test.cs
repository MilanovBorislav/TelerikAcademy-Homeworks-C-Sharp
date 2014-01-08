using BitArrayClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArray
{
    class Test
    {
        static void Main()
        {
          
            ulong number = 4598;

            BitArray64 bits = new BitArray64(number);
      
            foreach (var bit in bits)
            {
                Console.Write(bit);
            }

            Console.WriteLine();

            BitArray64 bits2 = new BitArray64((ulong)4561);
            Console.WriteLine("firstArr Equals(secondArr)  :  {0}", bits.Equals(bits2));
            Console.WriteLine("firstArr == secondArr  :  {0}", bits == bits2);
            Console.WriteLine("firstArr != secondArr  :  {0}",bits != bits2);
            Console.WriteLine();
            Console.WriteLine("firstArr .ToString()");
            Console.WriteLine(bits);
            Console.WriteLine();
            Console.WriteLine("Index 45");
            Console.WriteLine(bits[45]);
        }
    }
}
