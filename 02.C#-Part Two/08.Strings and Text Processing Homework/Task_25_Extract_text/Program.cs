using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task_25_Extract_text
{
	class Program
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
			string str = "<html><head><title>News</title></head><body><p><a href=\"http://academy.telerik.com\">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn intoskillful .NET software engineers.</p></body></html>";

			string pattern1 = @"<[^<]+?>";

			Regex regex1 = new Regex(pattern1);

			MatchCollection matches1 = regex1.Matches(str);

			List<string> matchList1 = MatchedElements(matches1);

			for (int i = 0; i < matches1.Count; i++)
			{
				string aaa = str.Replace(matches1[i].ToString(), "");
				str = aaa;
			}
			Console.WriteLine(str);



		}
	}
}
