using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_09_RemoveLines
{
	class Task_09_RemoveLines
	{
		static void Main(string[] args)
		{
		
			string pathToFile1 = "../../test_1.txt";
			List<string> list = new List<string>();

			using (StreamReader sr = new StreamReader(pathToFile1))
			{
				string line = sr.ReadLine();
				int a = 0;
				while (line != null)
				{
					a++;
					if (a%2 == 0)
					{
						list.Add(line);
					}

					line = sr.ReadLine();
				}
			}
			using (StreamWriter writer = new StreamWriter(pathToFile1))
			{
				foreach (var item in list)
				{
					writer.WriteLine(item);
				}
			}


			Console.WriteLine();
		}
	}
}
