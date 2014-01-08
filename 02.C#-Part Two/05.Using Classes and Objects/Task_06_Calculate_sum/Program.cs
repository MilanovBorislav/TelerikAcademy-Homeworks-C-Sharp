using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06_Calculate_sum
{
	class Program
	{
		static int ConvertToIntNumber(List<char> list)
		{
			char[] numChar = list.ToArray();
			string numStr = new string(numChar);
			int number = int.Parse(numStr);
			return number;
		}

		static void Main(string[] args)
		{
			string numberStr = "43 68 9 23 318";
			int sum = 0;
			int number = 0;
			int k = 0;
			List<char> currentNumber = new List<char>();

			for (int i = 0; i < numberStr.Length; i++)
			{
				char digit= numberStr[i];
				if (numberStr[i]== ' ')
				{
					i++;
					continue;		
				}
				else
				{
					for (; k < numberStr.Length; k++)
					{
						if (numberStr[k] == ' ')
						{
							k++;
							break;
						}
						currentNumber.Add(numberStr[k]);
						i++;
					}
				}
				number = ConvertToIntNumber(currentNumber);
				sum = sum + number;
				currentNumber.Clear();
			}
			Console.WriteLine("Sum is {0}",sum);
		}
	}
}
