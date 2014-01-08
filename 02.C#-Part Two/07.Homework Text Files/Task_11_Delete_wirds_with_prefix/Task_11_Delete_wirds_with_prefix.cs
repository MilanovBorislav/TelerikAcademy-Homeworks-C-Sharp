using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;


namespace Task_11_Delete_wirds_with_prefix
{
	class Task_11_Delete_wirds_with_prefix
	{
		static void Main(string[] args)
		{
			string pathToFile1 = "../../test_1.txt";
			string pathToFile2 = "../../test_2.txt";

			using (StreamReader reader = new StreamReader(pathToFile1))
			using (StreamWriter writer = new StreamWriter(pathToFile2))

			using (reader)
			{
				string line = reader.ReadLine();
				while (line != null)
				{
					writer.WriteLine(Regex.Replace(line, @"\btest\w*\b", String.Empty));
					line = reader.ReadLine();
				}

			}
				
			
		}
	}
}
