using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
	class Program
	{
		static void CountEqualNumbers(int[] arr)
		{
			Array.Sort(arr);
			int length = arr.Length;
			int start = 0;
			int bestStart = 0;
			int len = 1;
			int bestLen = 1;
			for (int i = 1; i < arr.Length; i++)
			{
				if (arr[i] == arr[i - 1])
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
			Console.WriteLine("Number {0} Repeats {1} times", arr[bestStart], bestLen);
			for (int i = bestStart; i < bestStart + bestLen; i++)
			{
				Console.Write(" {0} ", arr[i]);
			}
			Console.WriteLine();
		}

		static void Main(string[] args)
		{
			int[] myArr = { 1, 2, 9, 8, 9, 7, 9, 1, 9, 9, 4, 6, 6, 8 };
			Console.Write("Array ");

			foreach (var item in myArr)
			{
				Console.Write(" {0} ", item);
			}
			Console.WriteLine();

			CountEqualNumbers(myArr);
		}
	}
}
