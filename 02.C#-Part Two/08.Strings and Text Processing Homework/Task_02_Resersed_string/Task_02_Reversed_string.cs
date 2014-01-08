using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_Resersed_string
{
	class Task_02_Reversed_string
	{
		static string ReverseString(string str)
		{
			char[] charArr = str.ToCharArray();
			Array.Reverse(charArr);
			return new string(charArr);
		}

		static void Main(string[] args)
		{
			//string str = "sample";
			string str = "hello";
			string reversed = ReverseString(str);
			Console.WriteLine(reversed);
		}
	}
}
