using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public static class Distance
    {

        private static double CalculatePowerOfTwo(double a, double b)
        {
            return (a - b) * (a - b);
        }

        public static double CalculateDistance(_3DPoint point1, _3DPoint point2)
        {
            return Math.Sqrt( CalculatePowerOfTwo( point2.X_Coordinate, point1.X_Coordinate ) +
                              CalculatePowerOfTwo( point2.Y_Coordinate, point1.Y_Coordinate ) +
                              CalculatePowerOfTwo( point2.Z_Coordinate, point1.Z_Coordinate )
                );
        }
    }
}
