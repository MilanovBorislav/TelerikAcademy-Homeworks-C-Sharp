using System;
using System.Globalization;
using System.Threading;

namespace Methods
{
    class Methods
    {
        static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        static string ConvertDigitToWord(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
            }

            throw new ArgumentException("Invalid number!");
        }

        static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentOutOfRangeException("There is no elements in the array");
            }

            int max = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (max < elements[i])
                {
                    max = elements[i];
                }
            }
            return max;
        }

        static void PrintAsFloatNumber(object number)
        {
            Console.WriteLine("{0:f2}", number);
        }

        static void PrintAsPrecent(object number)
        {
            Console.WriteLine("{0:p0}", number);
        }

        static void PrintRightAlignedNumber(object number)
        {
            Console.WriteLine("{0,8}", number);
        }

        static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        static bool IsHorizontal(double x1, double y1)
        {
            bool horizontal = x1 == y1;

            return horizontal;
        }

        static bool IsVertical(double y1, double y2)
        {
            bool vertical = y1 == y2;

            return vertical;
        }

        static void Main()
        {
            //Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine(CalcTriangleArea(3, 4, 5));

            Console.WriteLine(ConvertDigitToWord(5));

            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintAsFloatNumber(1.3);
            PrintAsPrecent(0.75);
            PrintRightAlignedNumber(2.30);

            Console.WriteLine(CalcDistance(3, -1, 3, 2.5));

            bool horizontal = IsHorizontal(3, 3);
            Console.WriteLine("Horizontal? " + horizontal);

            bool vertical = IsVertical(-1, 2.5);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student("Peter", "Ivanov", "From Sofia", "17.03.1992");
            Student stella = new Student("Stella", "Markova", "From Vidin, gamer, high results", "03.11.1993");
            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
