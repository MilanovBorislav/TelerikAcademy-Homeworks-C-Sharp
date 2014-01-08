using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Common
{
   public class Circle :Shape
    {
        public Circle(double radius) :base(width:radius,height:radius){}

        public override double CalculateSurface()
        {
            return Math.PI * (this.Width * this.Width);
        }
    }
}
