using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_Correc_brackets
{
	class Program
	{
		static void Main(string[] args)
		{   
			string expression = "((a+b)/5-d)(";

			int indexIncorrect = expression.IndexOf(")(");

			if (indexIncorrect==-1)
			{
				Console.WriteLine(expression);
				Console.WriteLine("Correct Expession");
			}
			else
			{
				Console.WriteLine(expression);
				Console.WriteLine("Incorrect Epression");
			}


		}
	}
}
