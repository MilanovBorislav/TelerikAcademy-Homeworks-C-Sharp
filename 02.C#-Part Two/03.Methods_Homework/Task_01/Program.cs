using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
	public class Program
	{
		public static string Greeting(string name)
		{
			Console.WriteLine("Hello {0}", name);
			return name;
		}

		static void Main(string[] args)
		{
			Console.WriteLine("What is your name");
			string name = Console.ReadLine();
			Greeting(name);
		}
	}
}
