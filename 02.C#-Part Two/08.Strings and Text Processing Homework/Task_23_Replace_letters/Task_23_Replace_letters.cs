using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_23_Replace_letters
{
	class Task_23_Replace_letters
	{
		static void Main(string[] args)
		{
		      string word = "aretweriiitttad";
			//string word = "ggii";
			char[] list = word.ToCharArray();
			StringBuilder bilder = new StringBuilder();
			int counter = 0;
			for (int i = 0; i <= list.Length - 1; i++)
			{
				counter = i + 1;
				if (counter < list.Length)
				{
					while (list[i] == list[counter])
					{
						counter++;
						if (counter == list.Length)
						{
							break;
						}
					}
				}
				bilder.Append(list[i]);
				i = counter - 1;
			}
			string newStr = bilder.ToString();
			Console.WriteLine(newStr);
		}
	}
}
