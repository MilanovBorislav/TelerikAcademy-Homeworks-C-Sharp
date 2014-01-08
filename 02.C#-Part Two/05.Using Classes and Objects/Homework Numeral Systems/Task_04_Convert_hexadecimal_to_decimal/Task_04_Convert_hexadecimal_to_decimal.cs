using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04_Convert_hexadecimal_to_decimal
{
	class Task_04_Convert_hexadecimal_to_decimal
	{
		static int Power(int number, int power)
		{
			int result = 1;
			if (power == 0)
			{
				return 1;
			}

			for (int i = 1; i <= power; i++)
			{
				result = result * number;
			}
			return result;
		}


		static int ConverIntToHex(string hex)
		{
			char[] hexArr = { '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
			int number = 0;
			int result = 0;

			for (int i = hex.Length - 1, j = 0; i >= 0; i--, j++)
			{
				int index = Array.BinarySearch(hexArr, hex[i]);
				number = (index + 1) * Power(16, j);
				result = result + number;
			}

			return result;
		}

		static void Main(string[] args)
		{
			//int hexNum = ConverIntToHex("2A8");//680
			//int hexNum = ConverIntToHex("4AB");//1195
			//int hexNum = ConverIntToHex("D12E");//53550
			int hexNum = ConverIntToHex("AAA");//2730
			Console.WriteLine(hexNum);
		}

	}
}
