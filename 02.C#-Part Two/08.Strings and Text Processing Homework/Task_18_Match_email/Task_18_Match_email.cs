using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Task_18_Match_email
{
	class Task_18_Match_email
	{
		static List<string> MatchedElements(MatchCollection matches)
		{
			List<string> list = new List<string>();
			foreach (Match match in matches)
			{
				string item = match.ToString();
				list.Add(item);
			}
			return list;
		}

		static void Main(string[] args)
		{
			string str = @"Lorem ipsum dolor sit amet, consectetur ADFl@DFF.FSD adipisicing elit,
		sed do coc.alolao_bi@abv.com eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim 
		ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. 
		Duis aute irure dolor in  local@abv.bg reprehenderit in voluptate velit esse cillum 
		dolore eu fugiat nulla pariatur. Excepteur sint occaecat someEmail@gmail.com cupidatat non proident, 
		sunt in culpa qui officia dell2106@all.bg deserunt mollit anim id est laborum.";

			Regex regex = new Regex(@"\w+@\w+\.\w+");
			MatchCollection matches = regex.Matches(str);
			List<string> matchList = MatchedElements(matches);
			foreach (var item in matchList)
			{
				Console.WriteLine(item);
			}
		}
	}
}
