using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public struct _3DPoint
    {
        public double X_Coordinate { get; set; }
        public double Y_Coordinate { get; set; }
        public double Z_Coordinate { get; set; }

        static public readonly _3DPoint startPoint = new _3DPoint( 0, 0, 0 );

        public _3DPoint(double x, double y, double z)
            :this()
        {
            this.X_Coordinate = x;
            this.Y_Coordinate = y;
            this.Z_Coordinate = z;
        }

        public override string ToString()
        {
            return string.Format(
            @"

Coordinate X : {0}             
Coordinate Y : {1}             
Coordinate Z : {2}             
",
 this.X_Coordinate,
 this.Y_Coordinate,
 this.Z_Coordinate
                );
        }
    }
}
