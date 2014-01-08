using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04_Surface_of_a_triangle
{
	class Program
	{
		static double CalcTriangleSurfice1(double side, double altitude)
		{
			return (side * altitude) / 2;
		}

		static double CalcTriangleSurfice2(double a, double b, double c)
		{
			double p = (a + b + c) / 2;

			return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
		}

		static double CalcTriangleSurfice3(double a, double b, double alpha)
		{
			return (a * b * Math.Sin(Math.PI * alpha / 180)) / 2;
		}

		static void Main(string[] args)
		{
			double surf1 = CalcTriangleSurfice1(4D, 6D);
			Console.WriteLine("Surfice is {0}", surf1);
			double surf2 = CalcTriangleSurfice2(a: 9, b: 3, c: 7);
			Console.WriteLine("Surfice is {0}", surf2);
			double surf3 = CalcTriangleSurfice3(a: 9, b: 3, alpha: 90);
			Console.WriteLine("Surfice is {0}", surf3);
		}
	}
}
