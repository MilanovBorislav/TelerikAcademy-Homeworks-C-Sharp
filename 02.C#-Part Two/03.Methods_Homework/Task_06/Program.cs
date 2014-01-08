using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06
{
	class Program
	{
		static int FindFirstBiggerElement(int[] arr)
		{
			int index = -1;

			for (int i = 1; i < arr.Length - 1; i++)
			{
				if ((arr[i - 1] < arr[i]) && (arr[i] > arr[i + 1]))
				{
					index = i;
					break;
				}
			}

			return index;
		}

		static void Main(string[] args)
		{
			int[] arr = { 1, 200, 6, 6, 5, 6, 6, 9, 9, 3 };
			int result = FindFirstBiggerElement(arr);
			Console.WriteLine("The index is {0}", result);
		}
	}
}
