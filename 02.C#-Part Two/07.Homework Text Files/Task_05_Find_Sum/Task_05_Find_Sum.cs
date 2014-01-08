using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Task_05_Find_Sum
{
	class Task_05_Find_Sum
	{
		static int FindSum(int[,]matrix,int platform)
		{
			int sum = 0;
			int bestSum = sum;

			int platformX = platform;
			int platformY = platform;

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
			return bestSum;
		}

		static void Main(string[] args)
		{
			string pathToFile1 = "../../test_1.txt";
			string pathToFile2 = "../../test_2.txt";

			StreamReader reader = new StreamReader(pathToFile1);
			using (reader)
			{
				int n = int.Parse(reader.ReadLine());
				int[,] matrix = new int[n, n];
				int a = 0;
				string line = reader.ReadLine();

				while (line != null)
				{
					string[] arr = line.Split(' ');
					for (int i = 0; i < n; i++)
					{
						matrix[a, i] = int.Parse(arr[i]);
					}
					a++;
					line = reader.ReadLine();
				}
				int platform = 2;
				int sum = FindSum(matrix, platform);
				StreamWriter streamWriter = new StreamWriter(pathToFile2);
				using (streamWriter)
				{
						streamWriter.WriteLine(sum);
				}
			}
		}
	}
}
