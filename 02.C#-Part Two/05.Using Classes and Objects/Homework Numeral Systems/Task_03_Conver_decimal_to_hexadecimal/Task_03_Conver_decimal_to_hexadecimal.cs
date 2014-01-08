using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_Conver_decimal_to_hexadecimal
{
	class Task_03_Conver_decimal_to_hexadecimal
	{
		static string ConvertToHexadecimal(int number)
		{
			char[] hexArr = { '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', };
			List<char> list = new List<char>();
			string hex = "";
			int balance = number;
			while (balance >= 1)
			{
				number = number % 16;
				char strNum = hexArr[number-1];
				list.Add(strNum);
				balance = balance / 16;
				number = balance;
			}
			list.Reverse();

			foreach (var item in list)
			{
				string c = item.ToString();
				hex = string.Concat(hex, c);
			}
			return hex;
		}

		static void Main(string[] args)
		{
			string hex = ConvertToHexadecimal(680);
			Console.WriteLine(hex);
		}
	}
}
