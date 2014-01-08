using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling
{
    public class Cuboide
    {
        private double width;
        private double height;
        private double depth;

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width should be positive value!");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height should be positive value!");
                }

                this.height = value;
            }
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Depth should be positive value!");
                }
                this.depth = value;
            }
        }

        public Cuboide(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double CalcVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }

        public double CalcDiagonalXYZ()
        {
            double distance = CalcDistanceUtils.CalcDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
            return distance;
        }

        public double CalcDiagonalXY()
        {
            double distance = CalcDistanceUtils.CalcDistance2D(0, 0, this.Width, this.Height);
            return distance;
        }

        public double CalcDiagonalXZ()
        {
            double distance = CalcDistanceUtils.CalcDistance2D(0, 0, this.Width, this.Depth);
            return distance;
        }

        public double CalcDiagonalYZ()
        {
            double distance = CalcDistanceUtils.CalcDistance2D(0, 0, this.Height, this.Depth);
            return distance;
        }

    }
}
