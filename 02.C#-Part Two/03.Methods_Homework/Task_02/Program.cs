using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
	class Program
	{
		static int FindMBiggestNumber(params int[] arg)
		{
			int max = arg[0];
			for (int i = 1; i < arg.Length; i++)
			{
				if (max < arg[i])
				{
					max = arg[i];
				}
			}
			return max;
		}

		static void Main(string[] args)
		{
			int numbers = FindMBiggestNumber(6, 90, 1);
			Console.WriteLine("Is biggest {0}", numbers);
		}
	}
}
