using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_Convert_binary_to_decimal
{
	class Task_02_Convert_binary_to_decimal
	{
		static int Power(int number,int power) 
		{
			int result = 1;
			if (power == 0)
			{
				return 1;
			}

			for (int i = 1; i <= power; i++)
			{
				result= result * number;
			}
			return result;
		}

		static int ConvertToInteger(string binary)
		{
			int number = 0;
			int result = 0;
			for (int i = binary.Length-1,j =0; i>=0 ; i--,j++)
			{
				number = (binary[i] - '0') * Power(2, j); ;

				result = result + number;
			}
			return result;
		}

		static void Main(string[] args)
		{
			string binaryStr = "1111";
			int local = ConvertToInteger(binaryStr);
			Console.WriteLine(local);
		}
	}
}
