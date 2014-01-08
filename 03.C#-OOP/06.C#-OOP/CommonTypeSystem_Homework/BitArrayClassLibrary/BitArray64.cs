using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArrayClassLibrary
{
    public class BitArray64:IEnumerable<int>
    {
        ulong number;

        public ulong Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 63; i >= 0; i--)
            {
                yield return this[i];
            }
        }

      
        public override int GetHashCode()
        {
            return this.number.GetHashCode();
        }

        public int this[int index]
        {
            get
            {
                return (int)((this.number >> index) & 1);
            }
        }


        public static bool operator ==(BitArray64 firstArr, BitArray64 secondArr)
        {
            return BitArray64.Equals(firstArr, secondArr);
        }

        public static bool operator !=(BitArray64 firstArr, BitArray64 secondArr)
        {
            return !(BitArray64.Equals(firstArr, secondArr));
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 63; i >= 0; i--)
            {
                stringBuilder.Append(this[i]);
            }
            return stringBuilder.ToString();
        }

        public override bool Equals(object param)
        {
            BitArray64 bitArray = param as BitArray64;

            if ((object)bitArray == null)
            {
                return false;
            }

            if (!Object.Equals(this.number, bitArray.number))
            {
                return false;
            }
            return true;
        }
    }
}
