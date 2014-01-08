using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06_Print_20_string
{
	class Task_06_Print_20_string
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter some world");
			string str = Console.ReadLine();

			StringBuilder strbild = new StringBuilder();
			for (int i = 0; i < 20 - str.Length; i++)
			{
				strbild.Append("*");
			}
			string result = strbild.ToString();

			string newWord = str + result;
			Console.WriteLine(newWord);

		}
	}
}
