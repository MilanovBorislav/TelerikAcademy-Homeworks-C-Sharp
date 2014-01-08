using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09
{
	class Program
	{
		static int GetMax(int[] arr, int startIndex)
		{
			int max = arr[startIndex];

			for (int i = startIndex; i < arr.Length; i++)
			{
				if (max < arr[i])
				{
					max = arr[i];
				}
			}
			return Array.IndexOf(arr, max);

		}

		static int[] Swap(int[] arr, ref int firstElement, ref int secondElement)
		{
			int changer = firstElement;
			firstElement = secondElement;
			secondElement = changer;
			return arr;
		}

		static int[] SelectionSortDescending(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				int max = GetMax(arr, i);
				Swap(arr, ref arr[i], ref arr[max]);
			}
			return arr;
		}


		static int[] SelectionSortAscending(int[] arr)
		{
			SelectionSortDescending(arr);
			Array.Reverse(arr);
			return arr;
		}

		static void PrintArray(int[] arr)
		{
			foreach (var item in arr)
			{
				Console.Write(" {0} ", item);
			}
			Console.WriteLine();
		}
		static void Main(string[] args)
		{
			int[] arr = { 9, 4, 2, 17, 66, 1, 5 };

			PrintArray(SelectionSortAscending(arr));
			PrintArray(SelectionSortDescending(arr));

		}
	}
}
