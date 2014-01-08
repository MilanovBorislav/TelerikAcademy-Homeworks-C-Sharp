using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace Task_06_Sort_names
{
	class Task_06_Sort_names
	{
		static void Main(string[] args)
		{
			string pathToFile1 = "../../test_1.txt";
			string pathToFile2 = "../../test_2.txt";

			StreamReader stream = new StreamReader(pathToFile1);

			string line = stream.ReadLine();
			List<string> list = new List<string>();
			while (line != null)
			{
				list.Add(line);
				line = stream.ReadLine();
			}
			list.Sort();

			StreamWriter streamWriter = new StreamWriter(pathToFile2);

			using (streamWriter)
			{
				for (int i = 0; i<list.Count; i++)
				{
					streamWriter.WriteLine(list[i]);
				}
			}
		}
	}
}
