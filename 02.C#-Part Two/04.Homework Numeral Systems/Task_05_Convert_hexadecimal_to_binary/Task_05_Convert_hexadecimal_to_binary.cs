using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05_Convert_hexadecimal_to_binary
{
	class Task_05_Convert_hexadecimal_to_binary
	{
		static string ConvertHexToBinary(string hexNumber)
		{
			char[] hexArr = { '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
			string binNumber = null;

			for (int i = 0; i < hexNumber.Length; i++)
			{
				int index = Array.BinarySearch(hexArr, hexNumber[i]);
				int number = (index + 1);
				string binary = Convert.ToString(number, 2).PadLeft(4, '0');;
				binNumber = String.Concat(binNumber, binary);
			}
			return binNumber;
		}

		static void Main(string[] args)
		{
			//string hexNum = "39E";//1110011110
			string hexNum = "FF1";//111111110001
			string binaryNum = ConvertHexToBinary(hexNum);
			Console.WriteLine(binaryNum);
		}
	}
}
