using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task_17_Calculate_time
{
	class Task_17_Calculate_time
	{
		static void Main(string[] args)
		{
			string givenDate = "15.08.2006 21:30:00";

			DateTime date = DateTime.ParseExact(givenDate, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
		    Console.WriteLine("{0} {1}",date.ToString("dddd", new CultureInfo("bg-BG")),date);
			Console.WriteLine("+ 6.5 hours");
			date = date.AddHours(6.5);
			Console.WriteLine("{0} {1}", date.ToString("dddd", new CultureInfo("bg-BG")), date);
		}
	}
}
