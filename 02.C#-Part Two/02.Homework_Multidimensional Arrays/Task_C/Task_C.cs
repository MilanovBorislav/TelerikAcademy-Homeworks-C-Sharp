using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C
{
	class Task_C
	{
		

		static void Main()
		{
			int n = 4;

			int[,] matrix = new int[n, n];
			int counter = 1;

			for (int row = 0; row <= n - 1; row++)
			{
				for (int col = 0; col <= row; col++)
				{
					matrix[n - row + col - 1, col] = counter++;
				}
			}


			for (int row = n - 2; row >= 0; row--)
			{
				for (int col = row; col >= 0; col--)
				{
					matrix[row - col, n - col - 1] = counter++;
				}
			}

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write("{0,3}",matrix[i,j]);
				}
				Console.WriteLine();
			}

		}
	}
}
