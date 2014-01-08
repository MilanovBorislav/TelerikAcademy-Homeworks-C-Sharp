using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;



namespace Task_19_Match_date
{
	class Task_19_Match_date
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
		sed do coc.alolao_bi@abv.com eiusmod 03.09.2002 tempor incididunt ut labore et dolore magna aliqua. Ut enim 
		ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. 
		Duis aute irure 03.09.2002 dolor in  local@abv.bg 16.12.2002 reprehenderit in voluptate velit esse cillum 
		dolore eu fugiat nulla pariatur. Excepteur sint occaecat someEmail@gmail.com cupidatat non proident, 
		sunt in culpa qui officia dell2106@all.bg deserunt mollit anim id est 83.49.3002 laborum.
        83.49.3002  alalbala  83.49.3002 ";

			Regex regex = new Regex(@"(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d");
			MatchCollection matches = regex.Matches(str);
			List<string> matchList = MatchedElements(matches);
			foreach (var item in matchList)
			{
				Console.WriteLine(item);
			}
		}
	}
}
