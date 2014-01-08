using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
	class Program
	{
		static string ShowLastDigit(int digit)
		{
			string[] numbersSrt = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
			string digitStr = digit.ToString();
			char[] numArr = digitStr.ToCharArray();
			int index = numArr[numArr.Length - 1] - '0';

			return numbersSrt[index];
		}
		static void Main(string[] args)
		{
			int number = 156541;
			Console.WriteLine("The number is {0}", number);
			Console.WriteLine("The last digit of {0} is \"{1}\"", number, ShowLastDigit(number));
		}
	}
}
