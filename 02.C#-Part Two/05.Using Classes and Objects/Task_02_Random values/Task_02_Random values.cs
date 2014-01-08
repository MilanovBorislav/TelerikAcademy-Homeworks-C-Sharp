using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_Random_values
{
	class Program
	{
		static Random randomNumber = new Random();

		static void Main(string[] args)
		{
			for (int i = 1; i <= 10; i++)
			{
				int randNum = randomNumber.Next(100, 201);
				Console.WriteLine(randNum);
			}
		}
	}
}
