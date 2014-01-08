using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Task_10_Extract_text_from_XML
{
	class Task_10_Extract_text_from_XML
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
			StreamReader reader = new StreamReader("../../Test_XML.xml");
			StringBuilder builder = new StringBuilder();
			string str = "";
			using (reader)
			{
				string line = reader.ReadLine();

				while (line != null)
				{
					builder.Append(line);
					line = reader.ReadLine();
				}
				str = builder.ToString();

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
}
