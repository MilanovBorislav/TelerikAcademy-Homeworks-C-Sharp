using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05_Sorts_the_array_by_the_length
{
	class Task_05_Sorts_the_array_by_the_length
	{

		public class ArrComparer : IComparer<string>
		{
			public int Compare(string firstEl,string secondEl) 
			{
				int first = firstEl.Length;
				int second = secondEl.Length;

				return first.CompareTo(second);
			}
		}

		static void Main(string[] args)
		{
			string[] arr = { "lpo", "lobal","alabala", "lala", "aa", };
			//Array.Sort(arr, new ArrComparer());
			Array.Sort(arr, (x, y) => x.Length.CompareTo(y.Length));

			foreach (var item in arr)
			{
				Console.WriteLine(item);
			}
		}
	}
}
