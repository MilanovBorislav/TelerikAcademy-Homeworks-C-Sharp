﻿using System;

namespace Abstraction
{
    class Circle : Figure
    {
        private double radius;

        public double Radius
        {
            get
            {
                return radius;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius can not be zero or negative value");
                }
                this.radius = value;
            }
        }


        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
