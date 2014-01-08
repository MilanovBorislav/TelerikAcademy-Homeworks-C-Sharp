using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taks_01_Invalid_number
{
	class Taks_01_Invalid_number
	{
		static double CalculateSquareRoot(double number)
		{
			if (number <= 0)
			{
				throw new ArgumentException();
			}
			if (number == null)
			{
				throw new ArgumentNullException();
			}
			return Math.Sqrt(number);
		}

		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Enter some number");
				double number = int.Parse(Console.ReadLine());
				double squareRoot = CalculateSquareRoot(number);
				Console.WriteLine(squareRoot);

			}
			catch (Exception)
			{
				Console.WriteLine("Invalid number");
			}

			finally
			{
				Console.WriteLine("Good bay");
			}
		}

	}
}
