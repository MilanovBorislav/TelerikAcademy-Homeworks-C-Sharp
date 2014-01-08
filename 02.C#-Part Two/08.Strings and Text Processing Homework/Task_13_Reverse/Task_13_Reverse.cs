using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Task_13_Reverse
{
	class Task_13_Reverse
	{
		static string ConvertStringArrayToString(string[] array)
		{
			StringBuilder builder = new StringBuilder();
 			
			for (int i = 0; i < array.Length; i++)
			{
				builder.Append(array[i]);
				if (i==array.Length-1)
				{
					break;
				}
				builder.Append(' ');
			}
			return builder.ToString();
		}

		static void Main(string[] args)
		{   //Example: "C# is not C++, not PHP and not Delphi!" 
			//"Delphi not and PHP, not C++ not is C#!".
			string str = "C# is not C++, not PHP and not Delphi!";
			string pattern = @"!|\.|\?";
			string sign = "";
			foreach (Match match in Regex.Matches(str, pattern))
			{
				sign = match.Value;
			}
			str = str.Replace(sign, "");
			string[] arr = str.Split(' ');
			Array.Reverse(arr);
			str = ConvertStringArrayToString(arr)+sign;
			Console.WriteLine(str);
		}
	}
}
