using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_08
{
	class Program
	{
		static List<int> SumBigNumbers(List<int> firstnum, List<int> secondnum)
		{
			List<int> result = new List<int>();
			List<int> changer = new List<int>();

			int firstcount = firstnum.Count;
			int secondcount = secondnum.Count;

			if (firstcount < secondcount)
			{
				changer = firstnum;
				firstnum = secondnum;
				secondnum = changer;

				firstcount = firstnum.Count;
				secondcount = secondnum.Count;
			}

			int countDif = firstcount - secondcount;

			List<int> zeros = new List<int>();

			for (int i = 0; i < countDif; i++)
			{
				zeros.Add(0);
			}

			zeros.AddRange(secondnum);

			for (int i = zeros.Count; i > 0; i--)
			{
				int res = firstnum[i - 1] + zeros[i - 1];
				if (res > 9 && i > 1)
				{
					res = res - 10;
					firstnum[i - 2] = firstnum[i - 2] + 1;
				}
				result.Add(res);
			}
			result.Reverse();
			return result;
		}

		static void Main(string[] args)
		{
			List<int> firstnum = new List<int>();
			List<int> secondnum = new List<int>();

			for (int i = 0; i < 10000; i++)
			{
				firstnum.Add(2);
			}

			for (int i = 0; i < 10000; i++)
			{
				secondnum.Add(5);
			}

			List<int> list = SumBigNumbers(firstnum, secondnum);

			Console.WriteLine("Result : ");
			foreach (var item in list)
			{
				Console.Write(item);
			}

			Console.WriteLine();
		}
	}
}
