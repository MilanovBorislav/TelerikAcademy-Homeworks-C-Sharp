using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

// 
// (<a href=")
// 
// ">
// 
// </a>
namespace Task_15_Replace_a_link
{
	class Task_15_Replace_a_link
	{
		static void Main(string[] args)
		{
			string str = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
			string newText = Regex.Replace(str, "<a href=\"(.*?)\">(.*?)</a>","[URL=$1]$2[/URL]");
			Console.WriteLine(newText);
		}
	}
}
