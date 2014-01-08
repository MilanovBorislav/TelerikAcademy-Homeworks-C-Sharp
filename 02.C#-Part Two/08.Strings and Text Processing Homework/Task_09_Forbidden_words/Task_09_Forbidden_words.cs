using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Task_09_Forbidden_words
{
	class Task_09_Forbidden_words
	{
		static string ReplaceWord(string str,List<string> list) 
		{
			string ast = new String('*',list[0].Length);
			for (int i = 0; i < list.Count; i++)
			{
				string aaa = str.Replace(list[i].ToString(), ast);
				str = aaa;
			}
			return str;
		}

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
			string str = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
			string partternPHP = @"\bPHP\b";
			string partternCLR = @"\bCLR\b";
			string partternMicrosoft = @"\bMicrosoft\b";


			Regex regex1 = new Regex(partternPHP);
			MatchCollection matches1 = regex1.Matches(str);
			List<string> matchList1 = MatchedElements(matches1);

			Regex regex2 = new Regex(partternCLR);
			MatchCollection matches2 = regex2.Matches(str);
			List<string> matchList2 = MatchedElements(matches2);

			Regex regex3 = new Regex(partternMicrosoft);
			MatchCollection matches3 = regex3.Matches(str);
			List<string> matchList3 = MatchedElements(matches3);
			str = ReplaceWord(str, matchList1);
			str = ReplaceWord(str, matchList2);
			str = ReplaceWord(str, matchList3);
			Console.WriteLine(str);
			

		}
	}
}
