using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06_Binary_to_hexadecimal
{
	class Task_06_Binary_to_hexadecimal
	{
		static string ConvertBinaryToHex(string binaryNumber)
		{
			char[] hexArr = { '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
			binaryNumber.PadLeft(32, '0');
			List<char> list = new List<char>();
			char[] charArr = new char[4];
			string hexNumber =null;

			for (int i = binaryNumber.Length - 1, counter = 1; i >= 0; i--, counter++)
			{
				charArr[counter - 1] = binaryNumber[i];
				if (counter == 4)
				{
					Array.Reverse(charArr);
					string num = new String(charArr);
					int index = Convert.ToInt32(num, 2) - 1;
					list.Add(hexArr[index]);
					counter = 0;
					charArr = new char[4];
					num = null;
				}
				if (i==0 && counter>0)
				{
					for (int j= counter; j < charArr.Length; j++)
					{
						charArr[j] = '0';
					}
					Array.Reverse(charArr);
					string num = new String(charArr);
					int index = Convert.ToInt32(num, 2) - 1;
					list.Add(hexArr[index]);
				}
			}
			list.Reverse();
			foreach (var item in list)
			{
				hexNumber = String.Concat(hexNumber, item);
			}

			return hexNumber;
		}

		static void Main(string[] args)
		{
			string binNum = "111100110100";//F34
			//string binNum = "1100110011";//333
			//string binNum = "011";//3
			//string binNum = "1010";//A
			//string binNum = "11111111";//FF
			string binaryNum = ConvertBinaryToHex(binNum);
			Console.WriteLine(binaryNum);
		}
	}
}
