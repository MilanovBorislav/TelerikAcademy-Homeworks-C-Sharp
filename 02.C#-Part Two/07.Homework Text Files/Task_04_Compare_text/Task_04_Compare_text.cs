using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Task_04_Compare_text
{
	class Task_04_Compare_text
	{
		static void Main(string[] args)
		{
			string pathToFile1 = "../../test_1.txt";
			string pathToFile2 = "../../test_2.txt";
		
			int equals = 0;
			int notequals = 0;
			using (StreamReader stream1 = new StreamReader(pathToFile1))
			{
				using (StreamReader stream2 = new StreamReader(pathToFile2))
				{
					string line1 = stream1.ReadLine();
					string line2 = stream2.ReadLine();
					int lineNumber = 0;
					while (line1 != null && line2 != null)
					{
						lineNumber++;
						if (line1 == line2)
						{
							equals++;
							Console.WriteLine("Lines with number {0} are quals",lineNumber);
						}
						else
						{
							notequals++;
							Console.WriteLine("Lines with number {0} are not quals", lineNumber);
						}
						line1 = stream1.ReadLine();
						line2 = stream2.ReadLine();
					}

				}
			}
		}
	}
}
