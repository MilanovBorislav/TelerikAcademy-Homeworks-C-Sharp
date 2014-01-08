using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;




namespace Task_08_Replace
{
	class Task_08_Replace
	{
		static void Main(string[] args)
		{
			string pathToFile1 = "../../test_1.txt";
			string pathToFile2 = "../../test_2.txt";

			StreamReader stream = new StreamReader(pathToFile1);
			StreamWriter strWritet = new StreamWriter(pathToFile2);
			using (strWritet)
			{
				string line = stream.ReadLine();
				while (line != null)
				{
					strWritet.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));
					line = stream.ReadLine();
				}
			}

		}
	}
}
