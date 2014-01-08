using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Nakov.IO
{
	using System;
	using System.Text;
	using System.Globalization;

	/// <summary>
	/// Console input helper for C# and .NET. Allows simplified reading of numbers and string
	/// tokens from the console in a way similar to "cin" in C++ and java.util.Scanner in Java.
	/// </summary>
	/// 
	/// <copyright>
	/// (c) Svetlin Nakov, 2011 - http://www.nakov.com
	/// </copyright>
	/// 
	/// <example>
	/// // In C++ we will use "cin >> x >> y;". Using Nakov.IO.Cin we can do the same as follows:
	/// int x = Cin.NextInt();
	/// double y = Cin.NextDouble();
	/// </example>
	/// 
	public static class Cin
	{
		/// <summary>
		/// Reads a string token from the console
		/// skipping any leading and trailing whitespace.
		/// </summary>
		public static string NextToken()
		{
			StringBuilder tokenChars = new StringBuilder();
			bool tokenFinished = false;
			bool skipWhiteSpaceMode = true;
			while (!tokenFinished)
			{
				int nextChar = Console.Read();
				if (nextChar == -1)
				{
					// End of stream reached
					tokenFinished = true;
				}
				else
				{
					char ch = (char)nextChar;
					if (char.IsWhiteSpace(ch))
					{
						// Whitespace reached (' ', '\r', '\n', '\t') -->
						// skip it if it is a leading whitespace
						// or stop reading anymore if it is trailing
						if (!skipWhiteSpaceMode)
						{
							tokenFinished = true;
							if (ch == '\r' && (Environment.NewLine == "\r\n"))
							{
								// Reached '\r' in Windows --> skip the next '\n'
								Console.Read();
							}
						}
					}
					else
					{
						// Character reached --> append it to the output
						skipWhiteSpaceMode = false;
						tokenChars.Append(ch);
					}
				}
			}

			string token = tokenChars.ToString();
			return token;
		}

		/// <summary>
		/// Reads an integer number from the console
		/// skipping any leading and trailing whitespace.
		/// </summary>
		public static int NextInt()
		{
			string token = Cin.NextToken();
			return int.Parse(token);
		}

		/// <summary>
		/// Reads a floating-point number from the console
		/// skipping any leading and trailing whitespace.
		/// </summary>
		/// <param name="acceptAnyDecimalSeparator">
		/// Specifies whether to accept any decimal separator
		/// ("." and ",") or the system's default separator only.
		/// </param>
		public static double NextDouble(bool acceptAnyDecimalSeparator = true)
		{
			string token = Cin.NextToken();
			if (acceptAnyDecimalSeparator)
			{
				token = token.Replace(',', '.');
				double result = double.Parse(token, CultureInfo.InvariantCulture);
				return result;
			}
			else
			{
				double result = double.Parse(token);
				return result;
			}
		}

		/// <summary>
		/// Reads a decimal number from the console
		/// skipping any leading and trailing whitespace.
		/// </summary>
		/// <param name="acceptAnyDecimalSeparator">
		/// Specifies whether to accept any decimal separator
		/// ("." and ",") or the system's default separator only.
		/// </param>
		public static decimal NextDecimal(bool acceptAnyDecimalSeparator = true)
		{
			string token = Cin.NextToken();
			if (acceptAnyDecimalSeparator)
			{
				token = token.Replace(',', '.');
				decimal result = decimal.Parse(token, CultureInfo.InvariantCulture);
				return result;
			}
			else
			{
				decimal result = decimal.Parse(token);
				return result;
			}
		}
	}
}


namespace Task_24_Sort_words
{

	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("How many words you want to sort  :  ");
			int length = Nakov.IO.Cin.NextInt();
			Console.WriteLine("Write words on the next line separated by space");
			string [] arr = new string [length];
			//Console.WriteLine();
			for (int i = 0; i < length; i++)
			{
				arr[i] = Nakov.IO.Cin.NextToken();
			}
			Array.Sort(arr);
			Console.WriteLine();
			foreach (var item in arr)
			{
				Console.Write(" {0} ",item);
			}
			Console.WriteLine();
		}
	}
}
