using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_Generate_Combinations
{
	class Task_21_Generate_Combinations
	{// {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}


		static int arrCount = 5;
		static int arrSize = 3;
		private static void GenerateCombinations( int[] arr,int index,int counter )
		{
			if (index == arrSize)
			{
				PrintArray(arr);
				return;
			}
			else
			{
				for (int i = counter; i <= arrCount;  i++)
				{
					arr[index] = i;
					GenerateCombinations(arr,index+1,i+1);
				}
			}
		
		}
		static void Main(string[] args)
		{
			int[] arr = new int[arrSize];
			GenerateCombinations(arr,0,1);

		}

		static void PrintArray(int[] arr)
		{
			foreach (var item in arr)
			{
				Console.Write(" {0} ", item);
			}
			Console.WriteLine();
		}
	}
}
