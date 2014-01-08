using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_Convert_string_to_unicode
{
	class Task_10_Convert_string_to_unicode
	{
		static void Main(string[] args)
		{
			string text = "Hi!";
			foreach (char c in text)
			{
				Console.Write("\\u{0:x4}", (int)c);
			}
		}
	}
}
