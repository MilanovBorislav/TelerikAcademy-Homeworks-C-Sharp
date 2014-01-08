using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;



namespace Task_08_Extract
{
	class Program
	{
		static void Main(string[] args)
		{
			string str = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
			string pattern = @"(?i)((?=[^.\n]*\bin\b)[^.\n]+\.?)";
			Regex regex = new Regex(pattern);
			MatchCollection matches = regex.Matches(str);

			foreach (Match match in matches)
			{
				Console.WriteLine(match);
			}
		}
	}
}
