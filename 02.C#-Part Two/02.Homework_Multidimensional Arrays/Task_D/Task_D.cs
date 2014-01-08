using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_D
{
	class Task_D
	{
		static int MakeColLeftToRight(int row, int col, int[,] matrix, int counter)
		{
			if (matrix[row, col] != 0 || col > matrix.GetLength(1) - 2)
			{
				return counter;
			}
			matrix[row, col] = counter;
			col++;
			counter++;
			return MakeColLeftToRight(row, col, matrix, counter);
		}

		static int MakeRowTopToBottom(int row, int col, int[,] matrix, int counter)
		{
			if (matrix[row, col] != 0 || row > matrix.GetLength(1) - 2)
			{
				return counter;
			}
			matrix[row, col] = counter;
			row++;
			counter++;

			return MakeRowTopToBottom(row, col, matrix, counter);
		}

		static int MakeColRightToLeft(int row, int col, int[,] matrix, int counter)
		{
			if (matrix[row, col] != 0 ||col < 1 )
			{
				return counter;
			}
			matrix[row, col] = counter;
			col--;
			counter++;
			return MakeColRightToLeft(row, col, matrix, counter);
		}

		static int MakeRowBottomToTop(int row, int col, int[,] matrix, int counter)
		{
			if (matrix[row, col] != 0)
			{
				return counter;
			}
			matrix[row, col] = counter;
			row--;
			counter++;
			return MakeRowBottomToTop(row, col, matrix, counter);
		}



		static void Main(string[] args)
		{
			int n = 5;
			int[,] matrix = new int[n, n];
			int counter = 1;


			int col = 0;
			int row = 0;
	
			int i = 0;
			int length = matrix.GetLength(1);

			for (col = 0; col < matrix.GetLength(1); col++, row++, i++)
			{
				int countC = MakeColLeftToRight(row, col, matrix, counter);

				int countR = MakeRowTopToBottom(row+i, length - 1 - i, matrix, countC);
				int countD = MakeColRightToLeft(length - 1 - i, length - 1 - i, matrix, countR);
				int countT = MakeRowBottomToTop(length - 1 - i, col, matrix, countD);
				counter = countT;

			}



		}
	}
}
