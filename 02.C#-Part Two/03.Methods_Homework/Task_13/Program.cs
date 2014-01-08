using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
	class Program
	{
		static int ReverseFn(int number)
		{
			string reversed = number.ToString();
			char[] revArr = reversed.ToCharArray();
			Array.Reverse(revArr);
			string rev = new String(revArr);
			int reversedNum = int.Parse(rev);
			return reversedNum;
		}
		static decimal AverageFn(decimal[] arr, int length)
		{
			decimal sum = 0;
			Console.WriteLine("Enter the numbers");

			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write("Number {0} = ", i + 1);
				arr[i] = int.Parse(Console.ReadLine());
				sum = sum + arr[i];
			}
			decimal average = sum / length;

			Console.WriteLine("The average is {0}", average);
			return average;
		}
		static decimal LinearEquation(decimal a, decimal b)
		{
			decimal result = -(a) / b;
			Console.WriteLine("X is {0}", result);
			return result;
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Select operation");
			Console.WriteLine("Choose 1 for reverse");
			Console.WriteLine("Choose 2 for calculate the average of a sequence of integers");
			Console.WriteLine("Choose 3 for solve a linear equation a * x + b = 0");

			int number = int.Parse(Console.ReadLine());

			if (number < 4)
			{
				if (number == 1)
				{
					Console.WriteLine("Enter number for reverse");
					int num = int.Parse(Console.ReadLine());
					int reversed = ReverseFn(num);
					Console.WriteLine("Reversed {0}", reversed);
				}
				if (number == 2)
				{
					Console.WriteLine("Enter length of the sequence");
					int length = int.Parse(Console.ReadLine());
					decimal[] arr = new decimal[length];
					AverageFn(arr, length);
				}
				if (number == 3)
				{
					Console.Write("Enter a :");
					decimal a = decimal.Parse(Console.ReadLine());
					//Console.WriteLine();
					Console.Write("Enter b :");
					decimal b = decimal.Parse(Console.ReadLine());
					LinearEquation(a, b);
				}
			}
			else
			{
				Console.WriteLine("Incorrect Data");
			}

		}
	}
}
