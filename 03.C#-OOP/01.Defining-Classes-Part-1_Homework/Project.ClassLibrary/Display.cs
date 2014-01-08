using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ClassLibrary
{
    public class Display
    {
        internal double size;

        internal double Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        internal int numberOfColors;

        internal int NumberOfColors
        {
            get { return this.numberOfColors; }
            set { this.numberOfColors = value; }
        }
        internal Display(double size, int numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public Display()
            : this( 0, 0 )
        {

        }
    }
}
