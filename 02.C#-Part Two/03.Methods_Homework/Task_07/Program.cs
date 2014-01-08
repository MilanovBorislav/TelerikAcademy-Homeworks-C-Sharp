using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07
{
	class Program
	{
		static int ReverseNumber(int num)
		{
			string numStr = num.ToString();
			char[] charArr = numStr.ToCharArray();
			for (int i = 0; i < charArr.Length / 2; i++)
			{
				char str = charArr[i];
				charArr[i] = charArr[charArr.Length - 1 - i];
				charArr[charArr.Length - 1 - i] = str;
			}
			string local = new String(charArr);
			int newNum;
			int.TryParse(local, out newNum);
			return newNum;
		}


		static void Main(string[] args)
		{
			int number = 1234;

			int local = ReverseNumber(number);
			Console.WriteLine(local);
		}
	}
}
