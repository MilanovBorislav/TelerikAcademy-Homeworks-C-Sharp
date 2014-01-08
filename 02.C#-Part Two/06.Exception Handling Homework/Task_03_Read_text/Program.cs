using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace Task_03_Read_text
{
	class Program
	{// @"C:\Users\bobi\Desktop\text.txt"
		static void Main(string[] args)
		{

			try
			{
				string textContent = File.ReadAllText
					(@"C:\Users\bobi\Desktop\text.txt");
				Console.WriteLine(textContent);
			}
			catch (PathTooLongException)
			{
				Console.WriteLine("Path to file must less than 248 characters, and file name must be less than 260 characters ");
			}
			catch (ArgumentException)
			{
				Console.WriteLine("Missing or wrong path to file");
			}
			catch (FileNotFoundException)
			{
				Console.WriteLine("File Not Found");
			}
			catch (DirectoryNotFoundException)
			{
				Console.WriteLine("Directory Not Found");
			}
			
		}
	}
}
