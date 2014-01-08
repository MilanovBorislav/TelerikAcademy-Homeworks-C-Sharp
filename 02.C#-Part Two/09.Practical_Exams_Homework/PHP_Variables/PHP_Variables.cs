using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHP_Variables
{
	class PHP_Variables
	{
		static void Main()
		{
			string phpCode = ReadPHPCode();
			List<string> variables = SearchVariable(phpCode);
			WriteVariables(variables);
		}

		static string ReadPHPCode()
		{
			StringBuilder inputData = new StringBuilder();
			while (true)
			{
				string line = Console.ReadLine().Trim(); 
				inputData.AppendLine(line);
				if (line == "?>")
				{
					break;
				} 
			}
			return inputData.ToString();
		}

		static bool isVariable(char c)
		{
			if (c >= 'a' && c <= 'z')
			{
				return true;
			}
			if (c >= 'A' && c <= 'Z')
			{
				return true;
			}
			if (c >= '0' && c <= '9')
			{
				return true;
			}
			if (c == '_')
			{
				return true;
			}
			return false;
		}

		static List<string> SearchVariable(string phpCode)
		{
			List<string> variables = new List<string>();

			bool inSingleLineComment = false;
			bool inMultiLineCommen = false;
			bool inSingleQuotes = false;
			bool inDoubleQuotes = false;
			bool inVariable = false;
			StringBuilder variableName = new StringBuilder();

			char ch;
			for (int i = 0; i < phpCode.Length; i++)
			{
				ch = phpCode[i];
				if (inMultiLineCommen)
				{
					if (ch == '*' && phpCode[i + 1] == '/')
					{
						inMultiLineCommen = false;
						i++;
						continue;
					}
					else
					{
						continue;
					}
				}
				if (inSingleLineComment)
				{
					if (ch == '\n')
					{
						inSingleLineComment = false;
						continue;
					}
					else
					{
						continue;
					}
				}

				if (inVariable)
				{
					if (isVariable(ch))
					{
						variableName.Append(ch);
					}
					else
					{
						string newVariable = variableName.ToString();
						if (newVariable.Length > 0 && !variables.Contains(newVariable))
						{
							variables.Add(newVariable);
						}
						inVariable = false;
						variableName.Clear();
					}
				}

				if (inSingleQuotes)
				{
					if (ch == '\'')
					{
						inSingleQuotes = false;
						continue;
					}
				}

				if (inDoubleQuotes)
				{
					if (ch == '\"')
					{
						inDoubleQuotes = false;
						continue;
					}
				}

				if (!inDoubleQuotes && !inSingleQuotes)
				{
					if (ch == '#')
					{
						inSingleLineComment = true;
						continue;
					}
					if (ch == '/' && phpCode[i + 1] == '/')
					{
						i++;
						inSingleLineComment = true;
						continue;
					}
					if (ch == '/' && phpCode[i + 1] == '*')
					{
						i++;
						inMultiLineCommen = true;
						continue;
					}
				}
				else 
				{
					if (ch == '\\')
					{
						i++;
						continue;
					}
				}
				if (ch == '\"')
				{
					inDoubleQuotes = true;
					continue;
				}
				if (ch == '\'')
				{
					inSingleQuotes = true;
					continue;
				}
				if (ch == '$')
				{
					inVariable = true;
					continue;
				}
			}

			return variables;
		}

		static void WriteVariables(List<string> variables)
		{
			Console.WriteLine(variables.Count);
			variables.Sort(StringComparer.Ordinal);
			foreach (string variable in variables)
			{
				Console.WriteLine(variable);
			}
		}
	}
}
