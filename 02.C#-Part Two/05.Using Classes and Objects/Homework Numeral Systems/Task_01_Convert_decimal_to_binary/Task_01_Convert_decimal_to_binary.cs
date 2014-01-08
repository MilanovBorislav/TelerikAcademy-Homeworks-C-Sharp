using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_Convert_decimal_to_binary
{
	class Task_01_Convert_decimal_to_binary
	{
		static string ConvertToBinary(int number)
		{
			List<char> list = new List<char>();
			string binary = "";
			int balance = number;
			while (balance >= 1)
			{
				number = number % 2;
				char strNum = Convert.ToChar(number);
				list.Add(strNum);
				balance = balance / 2;
				number = balance;
			}
			list.Reverse();

			foreach (var item in list)
			{
				int c = item;
				string d = c.ToString();
				binary = string.Concat(binary, d);
			}
			return binary;
		}

		static void Main(string[] args)
		{
			int number = 5;
			string numToBinary = ConvertToBinary(number);
			Console.WriteLine("Number {0}   Binary {1}",number, numToBinary);
		}
	}
}
