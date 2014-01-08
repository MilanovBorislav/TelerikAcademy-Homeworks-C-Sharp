using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar
{
	class Guitar
	{
		static void Main(string[] args)
		{
			string[] intervals = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
			int firstStep = int.Parse(Console.ReadLine());
			int maxStep = int.Parse(Console.ReadLine());
			int[] changeSteps = new int[intervals.Length];
			for (int i = 0; i < intervals.Length; i++)
			{
				changeSteps[i] = int.Parse(intervals[i]);
			}
			int answer = maxFinal(changeSteps, firstStep, maxStep);
			Console.WriteLine(answer);
		}

		static int maxFinal(int[] changeSteps, int firstStep, int maxStep)
		{
			int n = changeSteps.Length;
			int[,] a = new int[n + 1, maxStep + 1];
			a[0, firstStep] = 1;
			for (int i = 1; i <= n; i++)
			{
				for (int j = 0; j <= maxStep; j++)
				{
					if (a[i - 1, j] == 1)
					{
						int x = changeSteps[i - 1];
						if (j - x >= 0)
						{
							a[i, j - x] = 1;
						}
						if (j + x <= maxStep)
						{
							a[i, j + x] = 1;
						}
					}
				}
			}

			for (int i = maxStep; i >= 0; i--)
			{
				if (a[n, i] == 1)
				{
					return i;
				}
			}
			return -1;
		}
	}
}
