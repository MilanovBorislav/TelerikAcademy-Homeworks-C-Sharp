using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Task_10
{
	class Program
	{
		static BigInteger CalculeteFactorial(BigInteger number)
		{
			BigInteger result = 1;
			for (int i = 1; i <= number; i++)
			{
				result = result * i;
			}
			return result;
		}

		static void Main(string[] args)
		{
			BigInteger a = CalculeteFactorial(10);
			BigInteger[] arr = new BigInteger[100];

			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = CalculeteFactorial(i + 1);
				Console.WriteLine("{0}! = {1}", i + 1, arr[i]);
			}

			Console.WriteLine();


		}
	}
}
