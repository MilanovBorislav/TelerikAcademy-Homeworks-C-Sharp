using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Task_02_Concatenate_two_file_into_another
{
	class Task_02_Concatenate_two_file_into_another
	{
		static void Main(string[] args)
		{
			string path1 = "../../file_1.txt";
			string path2 = "../../file_2.txt";
			string concatPaht = "../../concatenate.txt";
			string content1 = File.ReadAllText(path1);
			string content2= File.ReadAllText(path2);
			string concat = content1 +"\n"+ content2;
			File.AppendAllText(concatPaht, concat);
		}
	}
}
