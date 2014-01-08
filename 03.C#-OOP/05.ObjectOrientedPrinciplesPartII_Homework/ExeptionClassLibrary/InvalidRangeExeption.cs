using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionClassLibrary
{
    public class InvalidRangeExeption<T>:ApplicationException
    {
        private T min;
        private T max;

        public T Min
        {
            get { return this.min; }
            set { this.min = value; }
        }
        public T Max
        {
            get { return this.max; }
            set { this.max = value; }
        }

        public InvalidRangeExeption(T min, T max)
        {
            this.Min = min;
            this.Max = max;
        }

        public override string Message
        {
            get
            {
                string result = string.Format( "The value of number is not in the range from {0} to {1}", this.Min, this.Max );
                return result;
            }
        }
    }
}
