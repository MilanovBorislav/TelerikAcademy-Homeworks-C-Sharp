using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Task_14
{
	class Program
	{
		static int FindMinimum(params int[] arguments)
		{
			int min = arguments[0];
			for (int i = 0; i < arguments.Length; i++)
			{
				if (min > arguments[i])
				{
					min = arguments[i];
				}
			}
			return min;

		}

		static int FindMaximum(params int[] arguments)
		{
			int max = arguments[0];
			for (int i = 0; i < arguments.Length; i++)
			{
				if (max < arguments[i])
				{
					max = arguments[i];
				}
			}
			return max;

		}
		static int FindSum(params int[] arguments)
		{
			int sum = 0;
			for (int i = 0; i < arguments.Length; i++)
			{
				sum = sum + arguments[i];
			}
			return sum;

		}

		static BigInteger FindProduct(params int[] arguments)
		{
			BigInteger product = 1;
			for (int i = 0; i < arguments.Length; i++)
			{
				product = product * arguments[i];
			}
			return product;

		}
		static void Main(string[] args)
		{

			int minimum = FindMinimum(4, 5, 5, 9, 0, 8, 7, 74, 5, 8, 4, 1, 4, 7);
			Console.WriteLine("Minimum is {0}", minimum);

			int maximum = FindMaximum(4, 5, 5, 9, 8, 0, 74, 1, 4, 7);
			Console.WriteLine("Maximum is {0}", maximum);


			int sum = FindSum(4, 5, 5, 9, 8, 74, 5, 8, 4, 1, 4, 7);
			Console.WriteLine("Sum is {0}", sum);

			BigInteger product = FindProduct(4, 5, 5, 9, 8, 74, 5, 8, 4, 1, 4, 7);
			Console.WriteLine("Product is {0}", product);

		}
	}
}
