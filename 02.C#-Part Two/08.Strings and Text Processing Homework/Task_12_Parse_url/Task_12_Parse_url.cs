using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;



namespace Task_12_Parse_url
{
	class Task_12_Parse_url
	{
		static void Main(string[] args)
		{
			string urlAddress = "http://www.devbg.org/forum/index.php ";
			string[] template = { "[protocol]", "[server]", "[resource]" };
			string[] pattern = { "(ht|f)tps?", "(w){3}.+?/", "(/\\w+){2}.\\w*" };

			for (int i = 0; i <pattern.Length ; i++)
			{
				foreach (Match match in Regex.Matches(urlAddress, pattern[i]))
				{
					Console.WriteLine("{0} = \"{1}\"",template[i], match.Value);
				}
			}

		}
	}
}
