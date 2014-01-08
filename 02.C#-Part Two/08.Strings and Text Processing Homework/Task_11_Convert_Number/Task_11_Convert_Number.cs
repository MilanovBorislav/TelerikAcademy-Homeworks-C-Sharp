using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11_Convert_Number
{
	class Task_11_Convert_Number
	{
		static void Main(string[] args)
		{	
			int number = int.Parse(Console.ReadLine());

			Console.WriteLine("{0,15}", number);   
			Console.WriteLine("{0,15:X}", number); 
			Console.WriteLine("{0,15:P}", number); 
			Console.WriteLine("{0,15:E}", number); 
		}
	}
}
