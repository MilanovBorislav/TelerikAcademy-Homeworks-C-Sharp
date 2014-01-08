using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_Which_day_is_today
{

	class Program
	{

		static void Main(string[] args)
		{
			DayOfWeek today = DateTime.Today.DayOfWeek;
			Console.WriteLine("Today is {0}",today);
		}
	}
}
