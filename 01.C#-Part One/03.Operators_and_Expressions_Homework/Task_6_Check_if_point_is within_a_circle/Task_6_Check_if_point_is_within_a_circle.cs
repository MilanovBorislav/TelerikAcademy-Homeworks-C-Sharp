using System;

namespace Task_6_Check_if_point_is_within_a_circle
    {
    class Task_6_Check_if_point_is_within_a_circle
        {
        static void Main ()
            {
            //Write an expression that checks if given point
            //(x,  y) is within a circle K(O, 5).
            
            Console.WriteLine( "Enter coordinate X" );
            double a = double.Parse( Console.ReadLine() );
            Console.WriteLine( "Enter coordinate Y" );
            double b = double.Parse( Console.ReadLine() );
            double c = ( a * a ) + ( b * b);
            double site = Math.Sqrt(c);
            Console.WriteLine("The distance form center to the point is " + site );
            Console.WriteLine(site <= 5.0 ? "The poin is in the circle" : "The point is NOT in the circle");
            }
        }
    }
