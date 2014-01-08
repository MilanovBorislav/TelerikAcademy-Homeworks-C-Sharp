using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task_14_Dictionary
{
	class Task_14_Dictionary
	{
		static void Main(string[] args)
		{
			string dictionary = @".NET – platform for applications from Microsoft
								   CLR – managed execution environment for .NET
								   namespace – hierarchical organization of classes";

			string[] partterns = { "^(.NET).+", "CLR.+", "namespace.+" };
			string[] values = { ".NET", "CLR", "namespace" };

			Console.Write("Enter word | .NET,CLR or namespace | : ");
			string word = Console.ReadLine();
			int i = Array.BinarySearch(values,word);
			foreach (Match match in Regex.Matches(dictionary, partterns[i]))
			{
				Console.WriteLine("{0}", match.Value);
			}
		}
	}
}
