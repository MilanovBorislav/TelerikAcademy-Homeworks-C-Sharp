using System;

namespace Abstraction
{
    public abstract class Figure:ICalculateable
    {
        public abstract double CalcPerimeter();
        public abstract double CalcSurface();
    }
}
