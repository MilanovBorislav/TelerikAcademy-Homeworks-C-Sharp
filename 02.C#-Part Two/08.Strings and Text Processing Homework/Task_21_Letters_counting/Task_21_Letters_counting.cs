using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_Letters_counting
{
	class Task_21_Letters_counting
	{
		static void Main(string[] args)
		{
			string word = "askldjldskjfalkdsfloioiz";
			int counter = 0;
			char[] arr = word.ToCharArray();
			Array.Sort(arr);

			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write("Letter {0} ",arr[i]);
				counter = 1;
				for (int r = i+1; r < arr.Length; r++)
				{
					if (arr[i]==arr[r])
					{
						counter++;
						i++;
					}
					if (arr[i]!=arr[r])
					{
						break;
					}
				}
				Console.WriteLine(" {0} repears ",counter);
			}



		}
	}
}
