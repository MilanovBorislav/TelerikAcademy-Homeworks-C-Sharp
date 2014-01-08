using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Task_03_Insert_line_numbers
{
	class Task_03_Insert_line_numbers
	{
		static void WriteInFile( string path,string content) 
		{
			StreamWriter streamWriter = new StreamWriter(path);
			using (streamWriter)
			{	
				streamWriter.WriteLine(content);
			}
		}

		static string ReadFromFile(string path)
		{
			StringBuilder strBilder = new StringBuilder();
			StreamReader reader = new StreamReader(path);
			using (reader)
			{
				int lineNumber = 0;
				string line = reader.ReadLine();
				while (line != null)
				{
					lineNumber++;
					string str = "Line Number : " + lineNumber.ToString()+"\n" + line +"\n\n";
					strBilder.Append(str);
					line = reader.ReadLine();
				}
				string content = strBilder.ToString();
				return content;
			}
		}
		static void Main(string[] args)
		{
			string pathToFile1 = "../../test_1.txt";
			string pathToFile2 = "../../test_2.txt";
			string content = ReadFromFile(pathToFile1);
			WriteInFile(pathToFile2, content);			
		}
	}
}
