using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A
{
	class Task_A
	{
		static void PrintMartrix(int[,] m){
			for (int row = 0; row < m.GetLength(0); row++)
			{
				for (int col = 0; col < m.GetLength(1); col++)
				{
					Console.Write(" {0,3} ",m[row,col]);
				}
				Console.WriteLine();
			}
		}


		static void Main(string[] args)
		{
			Console.Write("N = ");
			int n = int.Parse(Console.ReadLine());

			int[,] martrix = new int[n, n];
			int counter = 1;

			for (int col = 0; col <martrix.GetLength(0) ; col++)
			{
				for (int row = 0; row < martrix.GetLength(1); row++)
				{
					martrix[row, col] = counter;
					counter++;
				}
			}
			Console.WriteLine();
			PrintMartrix(martrix);
			Console.WriteLine();

		}
	}
}
