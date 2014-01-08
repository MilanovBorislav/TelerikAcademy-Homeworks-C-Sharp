using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_B
{
	class Task_B
	{
		static int[] ReverseRow(int[] arr, int row)
		{

			return arr;
		}

		static void Main(string[] args)
		{
			Console.Write("N = ");
			int n = int.Parse(Console.ReadLine());
			Console.WriteLine();

			int[,] matrix = new int[n, n];
			int counter = 1;

			for (int col = 0; col < matrix.GetLength(0); col++)
			{
				for ( int row = 0; row < matrix.GetLength(1); row++)
				{
					matrix[row, col] = counter;
					counter++;
				}

				if (col == 1 || col % 2 != 0)
				{
					for (int i = 0; i < n / 2; i++)//Reverse col
					{
						int a = matrix[i, col];
						matrix[i, col] = matrix[(n - i - 1), col];
						matrix[(n - i - 1), col] = a;

					}
				}
			}


			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				for (int col = 0; col < matrix.GetLength(1); col++)
				{
					Console.Write(" {0,3} ", matrix[row, col]);
				}
				Console.WriteLine();
				Console.WriteLine();
			}
		}
	}
}
