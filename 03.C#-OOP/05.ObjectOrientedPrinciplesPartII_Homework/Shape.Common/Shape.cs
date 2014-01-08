using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Common
{
    public  abstract class Shape
    {
       private double width;
       private double height;

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if( value < 0.0 )
                {
                    throw new ArgumentException( "Invalid value" );
                }
                this.height = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if( value<0.0 )
                {
                    throw new ArgumentException( "Invalid value" );
                }
                this.width = value;
            }
        }

        protected Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public abstract double CalculateSurface();


    }
}
