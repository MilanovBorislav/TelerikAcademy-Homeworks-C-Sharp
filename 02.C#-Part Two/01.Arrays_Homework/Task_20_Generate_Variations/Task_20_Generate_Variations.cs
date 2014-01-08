using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_Generate_Variations
{
	class Task_20_Generate_Variations
	{
		private static void GenerateVariations(int index, int[] arr, int arraySize, int iterations)
		{
			if (index == arraySize)
			{
				PrintArray(arr);
				return;
			}
			else
			{
				for (int i = 1; i <=iterations; i++)
				{
					arr[index] = i;
					GenerateVariations(index + 1, arr, arraySize, iterations);
				}
			}
		}
		static void PrintArray(int[] arr)
		{
			foreach (var item in arr)
			{
				Console.Write(" {0} ", item);
			}
			Console.WriteLine();
		}
		static void Main()
		{
			int arraySize = 2;
			int iterations = 3;
			int[] arr = new int[arraySize];
			GenerateVariations(0, arr, arraySize, iterations);


		}
	}
}
