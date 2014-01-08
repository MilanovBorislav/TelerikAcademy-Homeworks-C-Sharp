using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;



namespace Task_03_Longest_sequence
{
	class Task_03_Longest_sequence
	{
		static List<int> SearchLRDiagonal(int element, int[,] matrix, int row, int col, List<int> list, int r, int c)
		{
			row++;
			col++;

			if (row > r - 1 || col > c - 1)
			{
				return list;
			}
			else if ((element != matrix[row, col]))
			{
				return list;
			}
			else
			{
				list.Add(matrix[row, col]);
				return SearchLRDiagonal(element, matrix, row++, col++, list, r, c);
			}
		}

		static List<int> SearchRLDiagonal(int element, int[,] matrix, int row, int col, List<int> list, int r, int c)
		{
			row++;
			col--;

			if (col < 0 || row > r - 1)
			{
				return list;
			}
			if ((element != matrix[row, col]))
			{
				return list;
			}
			else
			{
				list.Add(matrix[row, col]);
				return SearchRLDiagonal(element, matrix, row++, col--, list, r, c);
			}
		}

		static void Main(string[] args)
		{
			int[,] matrix = {
			   			{1, 2, 3, 5, 5, 6, 8, 8},
			   			{2, 1, 5, 1, 9, 2, 8, 3},
			   			{3, 5, 1, 2, 3, 4, 1, 7},
			   			{5, 1, 2, 1, 8, 6, 7, 4},
			   			{1, 2, 4, 8, 1, 7, 6, 5},
			   							   };
// 
// 			int[,] matrix = {
// 			 				{9, 2,},
// 			 				{9, 1,},
// 			 					};
			// 
// 			int[,] matrix = {
//  			 			{5, 2, 5, 2, 8, 2},
//  			 			{1, 5, 5, 1, 5, 5},
//  			 			{1, 9, 5, 3, 4, 3,},
//  			 			{1, 9, 7, 5, 4, 3,},
//  			 			{1, 9, 5, 3, 5, 3,},
//  			 				};


			List<int> list = new List<int>();
			List<int> bestList = new List<int>();
			List<int> result = new List<int>();
			List<int> myList = new List<int>();
			int matrixRowlength = matrix.GetLength(0);
			int matrixCollength = matrix.GetLength(1);
			int len1 = 0;
			int len2 = 0;

			for (int row = 0; row < matrixRowlength; row++)
			{

				for (int col = 0; col < matrixCollength; col++)
				{
					List<int> searchLeft_to_Right = SearchLRDiagonal(matrix[row, col], matrix, row, col, list, matrixRowlength, matrixCollength);

					searchLeft_to_Right.Add(matrix[row, col]);
					List<int> cloneList_1 = new List<int>(searchLeft_to_Right);
					len1 = cloneList_1.Count;
					list.Clear();

					List<int> searchRight_to_Left = SearchRLDiagonal(matrix[row, col], matrix, row, col, list, matrixRowlength, matrixCollength);
					searchRight_to_Left.Add(matrix[row, col]);
					List<int> cloneList_2 = new List<int>(searchRight_to_Left);
					len2 = cloneList_2.Count;
					list.Clear();

					if (len1 > len2)
					{
						bestList = cloneList_1;
					}
					else
					{
						bestList = cloneList_2;
					}
					if (bestList.Count > myList.Count)
					{
						result = bestList;
						myList.Clear();
						foreach (var item in result)
						{
							myList.Add(item);
						}
						bestList.Clear();
					}
					searchRight_to_Left.Clear();
					searchLeft_to_Right.Clear();
				}
			}

			int len = 1;
			int bestLen = 1;
			int start = 0;
			int bestStart = 0;

			for (int row = 0; row < matrixRowlength; row++)
			{
				for (int i = 1; i < matrixCollength; i++)
				{
					if (matrix[row, i] == matrix[row, i - 1])
					{
						len++;
					}
					else
					{
						len = 1;
					}
					if (len > bestLen)
					{
						bestLen = len;
						start = i - bestLen;
						bestStart = start + 1;

					}
				}
				if (bestLen > myList.Count)
				{
					myList.Clear();
					for (int j = bestStart; j < bestStart + bestLen; j++)
					{
						myList.Add(matrix[row, j]);
					}
				}
				len = 1;
				bestLen = 1;
				start = 0;
				bestStart = 0;
			}


			for (int col = 0; col < matrixCollength; col++)
			{
				for (int p = 1; p < matrixRowlength; p++)
				{
					if (matrix[p, col] == matrix[p - 1, col])
					{
						len++;
					}
					else
					{
						len = 1;
					}
					if (len > bestLen)
					{
						bestLen = len;
						start = p - bestLen;
						bestStart = start + 1;

					}
				}
				if (bestLen > myList.Count)
				{
					myList.Clear();
					for (int j = bestStart; j < bestStart + bestLen; j++)
					{
						myList.Add(matrix[j, col]);
					}
				}
				len = 1;
				bestLen = 1;
				start = 0;
				bestStart = 0;
			}

			foreach (var item in myList)
			{
				Console.WriteLine(item);
			}
		}
	}
}
