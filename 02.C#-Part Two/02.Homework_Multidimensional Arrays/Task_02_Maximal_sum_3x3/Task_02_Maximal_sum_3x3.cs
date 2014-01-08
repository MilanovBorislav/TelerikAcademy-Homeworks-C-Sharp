using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task_02_Maximal_sum_3x3
{
	class Task_02_Maximal_sum_3x3
	{
		static void Main(string[] args)
		{
			int[,] matrix = 
		{
			{0, 2, 4, 0, 9, 5, 9, 9, 9},
			{7, 1, 3, 3, 2, 1, 9, 9, 9},
			{1, 3, 9, 8, 5, 6, 9, 9, 9},
			{4, 6, 7, 9, 1, 0, 4, 3, 1},
		};
			int sum = 0;
			int bestSum = sum;

			int platformX = 3;
			int platformY = 3;

			int bestRow = 0;
			int bestCol = 0;

			for (int row = 0; row < matrix.GetLength(0) - platformY + 1; row++)
			{

				for (int col = 0; col < matrix.GetLength(1) - platformX + 1; col++)
				{
					sum = 0;
					for (int i = row; i < row + platformY; i++)
					{

						for (int j = col; j < col + platformX; j++)
						{
							sum = sum + matrix[i, j];
						}
					}
					if (sum > bestSum)
					{
						bestSum = sum;
						bestRow = row;
						bestCol = col;

					}
				}
			}

			for (int i = bestRow; i < bestRow + platformY; i++)
			{
				for (int j = bestCol; j < bestCol+platformX; j++)
				{
					Console.Write(" {0} ",matrix[i,j]);
				}
				Console.WriteLine();
			}
			Console.WriteLine("Best Sum {0}",bestSum);

		}
	}
}
