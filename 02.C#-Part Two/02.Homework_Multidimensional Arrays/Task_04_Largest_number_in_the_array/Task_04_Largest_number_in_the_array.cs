using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04_Largest_number_in_the_array
{
	class Task_04_Largest_number_in_the_array
	{
		static void Main(string[] args)
		{
			int K = 20;

			int[] arr = {1,2,4,5,6,7,11,22,14,24,1,14,17,32 };

			Array.Sort(arr);

			bool stop = false;
			int index = -1;
			while (stop == false)
			{
				
			    K--;
				index =	Array.BinarySearch(arr,K);
				if (index>=0)
				{
					stop = true;
				}
				
			}
			Console.WriteLine(arr[index]);

		}
	}
}
