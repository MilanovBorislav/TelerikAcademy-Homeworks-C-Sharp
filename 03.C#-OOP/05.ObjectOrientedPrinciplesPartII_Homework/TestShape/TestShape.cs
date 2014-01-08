using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forms.Common;


namespace TestShape
{
    class TestShape
    {
        static void CalculateAllSurfices(dynamic list) 
        {
            Console.WriteLine();
            Console.WriteLine();

            foreach( var item in list )
            {
               Console.WriteLine("{0} surfice  : {1:0.00}",item.GetType().Name,item.CalculateSurface()); 
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {

           Rectangle someRectangle = new Rectangle( 3.5, 2.0 );
           double rectangleSufice=  someRectangle.CalculateSurface();
           Console.WriteLine( "Rectangle surfice is  {0:0.00}", rectangleSufice );

           Triangle someTriangle = new Triangle(4.7,2.6);
           double triangleSurfice = someTriangle.CalculateSurface();
           Console.WriteLine( "Tringle surfice is  {0:0.00}", triangleSurfice );

           Circle someCircle = new Circle( 3.2 );
           double circleSurfice = someCircle.CalculateSurface();
           Console.WriteLine( "Circle surfice is  {0:0.00}", circleSurfice);

           Shape[] shapesArray = new Shape[9]
            {
               new Rectangle( 3.7, 2.4 ),
               new Rectangle( 6.5, 4.18 ),
               new Rectangle( 1.5, 6.2 ),
               new Triangle(1.9,4.6),
               new Triangle(7.3,1.8),
               new Triangle(3.7,2.6),
               new Circle(2.9),
               new Circle(4.1),
               new Circle(3.6),
            };

           CalculateAllSurfices( shapesArray );

        }
    }
}
