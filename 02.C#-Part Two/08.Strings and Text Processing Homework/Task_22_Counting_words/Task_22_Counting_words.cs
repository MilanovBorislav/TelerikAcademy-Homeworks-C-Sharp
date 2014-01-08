using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_22_Counting_words
{
	class Task_22_Counting_words
	{
		static void Main(string[] args)
		{


			string[] arr = { "ala", "bala", "portocala", "bala", "portocala", "ala", "ala", "ala", "ala", "portocala", "bala", "bala", "ala", "ala" };
			//string[] arr = {"ala"};
			
			Array.Sort(arr);

			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write("Word {0} ", arr[i]);
				int counter = 1;
				for (int r = i + 1; r < arr.Length; r++)
				{
					if (arr[i] == arr[r])
					{
						counter++;
						i++;
					}
					if (arr[i] != arr[r])
					{
						break;
					}
				}
				Console.WriteLine(" {0} repears ", counter);
			}
		}
	}
}
