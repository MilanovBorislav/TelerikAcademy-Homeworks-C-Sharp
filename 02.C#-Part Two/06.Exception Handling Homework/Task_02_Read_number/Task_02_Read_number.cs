using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_Read_number
{
	class Task_02_Read_number
	{
		static int ReadNumber(int start, int end)
		{
			int n = int.Parse(Console.ReadLine());

			if (start > n || n > end) 
			{
				throw new ArgumentException();
			}

			return n;
		}

		static void Main()
		{
			int start = 1;
			int end = 100;

			for (int i = 0; i < 10; i++)
			{
				try
				{
					start = ReadNumber(start, end);
				}
				catch (ArgumentException)
				{
					Console.WriteLine("Number should be bigger from previous ");
				
				}
				catch(FormatException)
				{
					Console.WriteLine("Data should be numer bigger from previous");
				}
			}
		
		}
	}
}
