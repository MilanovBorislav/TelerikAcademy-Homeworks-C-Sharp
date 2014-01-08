using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_08_Binary_Representation
{
	class Task_08_Binary_Representation
	{
		static string GetBinary(short number)
		{
			string cont = String.Empty;

			for (int i = 0; i < 16; i++)
			{
				cont = (number >> i & 1) + cont; 
			}
			return cont;
		}

		static void Main()
		{
			Console.WriteLine(GetBinary(16));
		}
	}
}
