using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_CountWords
{
    class CountWords
    {
        static void Main(string[] args)
        {
            StreamReader fileReader = new StreamReader("../../word.txt");
            string str = string.Empty;
            while (true)
            {
                string line = fileReader.ReadLine();
                if (line == string.Empty)
                {
                    break;
                }
                str += line;
            }
        
            Console.WriteLine();
            IDictionary<string, int> readedWords =
                new SortedDictionary<string, int>();

            CountWordsInTextFile(str, readedWords);
        }

        private static void CountWordsInTextFile(string str, IDictionary<string, int> wordsCount)
        {
            string strToLower = str.ToLower();
            string[] words = strToLower.Split(new char[] { ' ', '?', '–', ',', '!', '.' },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                int count = 1;
                if (wordsCount.ContainsKey(word))
                {
                    count = wordsCount[word] + 1;
                }
                wordsCount[word] = count;
            }

            foreach (var i in wordsCount.OrderBy(key => key.Value))
            {
                Console.WriteLine("{0}---->{1}", i.Key, i.Value);
            }
        }
    }
}