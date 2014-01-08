using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_Extract_palindrome
{
	class Task_20_Extract_palindrome
	{
		static bool IsPalindrome(string word)
		{
			for (int i = 0; i < word.Length/2; i++)
			{
				if (word[i] != word[word.Length - 1 - i])
				{
					return false;
				}
			}
			return true;
		}

		static void Main(string[] args)
		{
			string str = "Lorem ABBA ipsum dolor sit amet, consectetur adipisicing elit, alala sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim eve exe veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est nanan laborum.";
			str = str.Replace(",", "");
			str = str.Replace(".", "");
			string[] arr = str.Split(' ');
			foreach (var item in arr)
			{
			    bool palindrome = IsPalindrome(item);
				if (palindrome == true)
				{
					Console.WriteLine(item);
				}
			}
		}
	}
}
