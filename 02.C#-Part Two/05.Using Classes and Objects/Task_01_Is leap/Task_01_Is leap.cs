using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_Is_leap
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter some year  ");
			int year = int.Parse(Console.ReadLine());
			bool leapYear = DateTime.IsLeapYear(year);

			if (leapYear)
			{
				Console.WriteLine("{0} is leap year",year);
			}
			else
			{
				Console.WriteLine("{0} is NOT leap year", year);
			}
		}
	}
}
