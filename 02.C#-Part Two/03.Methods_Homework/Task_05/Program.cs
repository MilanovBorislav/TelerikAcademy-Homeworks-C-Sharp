using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05
{
	class Program
	{
		static void IsBigger(int[] arr, int givenPosition)
		{
			if ((arr.Length > 2) && (givenPosition > 0 && givenPosition < arr.Length - 1))
			{
				if (arr[givenPosition] > arr[givenPosition - 1] && arr[givenPosition] > arr[givenPosition + 1])
				{
					Console.WriteLine("Number {0} on position {1} is bigger than its two neighbours {2}<--({3})-->{4}", arr[givenPosition], givenPosition, arr[givenPosition - 1], arr[givenPosition], arr[givenPosition + 1]);
				}
				else
				{
					Console.WriteLine("The number {0} is not bigger than its neighbours", arr[givenPosition]);
				}
			}
			else
			{
				Console.WriteLine("Incorrect data");
			}
		}

		static void Main(string[] args)
		{
			int givenPosition = 2;
			int[] arr = { 1, 2, 8, 6, 5, 6, 7, 2, 9, 3 };
			IsBigger(arr, givenPosition);
		}
	}
}
