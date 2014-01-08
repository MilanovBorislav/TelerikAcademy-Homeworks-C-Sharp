using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Task_01__Print_odd_lines
{
	class Task_01__Print_odd_lines
	{
		static void Main(string[] args)
		{
			StreamReader reader = new StreamReader("../../Test_File.txt");
			using (reader)
			{
				int lineNumber = 0;
				string line = reader.ReadLine();
				while (line != null)
				{
					lineNumber++;
					if (lineNumber % 2 != 0)
					{
						Console.WriteLine("Line {0}: {1}", lineNumber, line);
						line = reader.ReadLine();
					}

				}
			}

		}
	}
}
