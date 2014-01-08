using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
	static void Main(string[] args)
	{
		string sizesStr = Console.ReadLine();
		string[] sizes = sizesStr.Split(' ');
		int width = int.Parse(sizes[0]);
		int height = int.Parse(sizes[1]);
		int depth = int.Parse(sizes[2]);
		long totalSum = 0;

		int[, ,] cube = new int[width, height, depth];

		for (int h = 0; h < height; h++)
		{
			string line = Console.ReadLine();
			string[] tokens = line.Split('|');
			for (int d = 0; d < depth; d++)
			{
				string[] numbers = tokens[d].Split(
					new char[] { ' ' },
					StringSplitOptions.RemoveEmptyEntries);
				for (int w = 0; w < width; w++)
				{
					int value = int.Parse(numbers[w]);
					cube[w, h, d] = value;
					totalSum = totalSum + value;
				}
			}
		}

		int sum = 0;

		long currentSum = 0;
		for (int w = 0; w < width - 1; w++)
		{
			for (int h = 0; h < height; h++)
			{
				for (int d = 0; d < depth; d++)
				{
					currentSum = currentSum + cube[w, h, d];
				}
			}
			if (currentSum * 2 == totalSum)
			{
				sum++;
			}
		}

		currentSum = 0;
		for (int h = 0; h < height - 1; h++)
		{
			for (int w = 0; w < width; w++)
			{
				for (int d = 0; d < depth; d++)
				{
					currentSum = currentSum + cube[w, h, d];
				}
			}
			if (currentSum * 2 == totalSum)
			{
				sum++;
			}
		}

		currentSum = 0;
		for (int d = 0; d < depth - 1; d++)
		{
			for (int w = 0; w < width; w++)
			{
				for (int h = 0; h < height; h++)
				{
					currentSum = currentSum + cube[w, h, d];
				}
			}
			if (currentSum * 2 == totalSum)
			{
				sum++;
			}
		}

		Console.WriteLine(sum);
	}
}

