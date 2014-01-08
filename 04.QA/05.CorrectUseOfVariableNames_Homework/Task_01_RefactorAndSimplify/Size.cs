using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Size
{
    public double widht, height;
    public Size(double sizeWidth, double sizeHeight)
    {
        this.widht = sizeWidth;
        this.height = sizeHeight;
    }

    public static Size GetRotatedSize(Size size, double angleOfRotation)
    {
        double widhtSize = Math.Abs(Math.Cos(angleOfRotation)) * size.widht +
            Math.Abs(Math.Sin(angleOfRotation)) * size.height;

        double heightSize = Math.Abs(Math.Cos(angleOfRotation)) * size.widht +
            Math.Abs(Math.Sin(angleOfRotation)) * size.height; 

        return new Size(widhtSize,heightSize);
    }

    static void Main(string[] args)
    {
        
    }
}
