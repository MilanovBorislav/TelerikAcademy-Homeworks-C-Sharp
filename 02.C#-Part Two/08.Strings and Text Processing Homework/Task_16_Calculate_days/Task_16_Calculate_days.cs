using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task_16_Calculate_days
{
	class Task_16_Calculate_days
	{
		static void Main(string[] args)
		{
			Console.Write("Enter the first date : ");
			string first = Console.ReadLine();
			Console.Write("Enter the second date : ");
			string second = Console.ReadLine();

			DateTime start = DateTime.ParseExact(first, "d.MM.yyyy", CultureInfo.InvariantCulture);
			DateTime end = DateTime.ParseExact(second, "d.MM.yyyy", CultureInfo.InvariantCulture);

			Console.WriteLine((end -start).TotalDays + " between dates");

		}
	}
}
