using System;


namespace Task_03_Calculates_rectangle_s_area
    {
    class Task_03_Calculates_rectangle_s_area
        {
        static void Main ()
            {
            //Write an expression that calculates 
            //rectangle’s area by given width and height.

            Console.WriteLine( "Enter width");
            float rectWidth = float.Parse(Console.ReadLine());
            Console.WriteLine( "Enter height" );
            float rectHeight = float.Parse(Console.ReadLine());
            float area = rectWidth * rectHeight;
            Console.WriteLine("The area of the rectangle is " + area);
            }
        }
    }
