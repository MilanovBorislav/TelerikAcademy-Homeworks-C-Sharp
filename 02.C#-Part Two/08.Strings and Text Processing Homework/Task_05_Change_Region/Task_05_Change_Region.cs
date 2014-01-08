using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task_05_Change_Region
{
	class Task_05_Change_Region
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
		{//We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

			string str = "We are living in a <upcase>yellow submarine</upcase>.We don't have <upcase>anything</upcase> else.";
			string pattern1 = @"(?<=<upcase>)[^<>]*(?=</upcase>)";
			string pattern2 = @"<\/?upcase>";
			Regex regex1 = new Regex(pattern1);
			Regex regex2 = new Regex(pattern2);
			MatchCollection matches1 = regex1.Matches(str);
			MatchCollection matches2 = regex2.Matches(str);

			List<string> matchList1 = MatchedElements(matches1);
			List<string> matchList2 = MatchedElements(matches2);

			Console.WriteLine("Old Vesrsion \n {0}", str);
			Console.WriteLine();

			//string aaa = "";
			for (int i = 0; i < matchList1.Count; i++)
			{
			  string aaa = str.Replace(matchList1[i].ToString(),matchList1[i].ToUpper());
			   str = aaa;
			}

			for (int i = 0; i < matches2.Count; i++)
			{
				string aaa = str.Replace(matches2[i].ToString(), "");
				str = aaa;
			}

			Console.WriteLine("New Version \n {0}",str);
			Console.WriteLine();










		}
	}
}
