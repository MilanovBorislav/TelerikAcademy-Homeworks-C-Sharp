using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task_04_Contain_given_substring
{
	class Task_03_Correc_brackets
	{
		static void Main(string[] args)
		{
			string str = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
			string searched = "in";
			RegexOptions opt = RegexOptions.IgnoreCase;
			int count = System.Text.RegularExpressions.Regex.Matches(str, searched,opt).Count;
			Console.WriteLine("{0} Times with ignore case",count);
		}
	}
}
