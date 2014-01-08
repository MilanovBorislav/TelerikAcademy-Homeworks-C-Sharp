using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_CountOddWords
{
    class CountOddWords
    {
        static void Main(string[] args)
        {
            string[] languages = {"C#", "SQL", "PHP", "PHP", "SQL", "SQL"};
            CountOddWordsInSequence(languages);
        }

        private static void CountOddWordsInSequence(string [] arr)
        {
            IDictionary<string,int> wordsCount = new Dictionary<string, int>();

            foreach(var word  in arr)
            {
                int count = 1;
                if (wordsCount.ContainsKey(word))
                {
                    count = wordsCount[word] + 1;
                }
                wordsCount[word] = count;
            }

            foreach(var odd in wordsCount)
            {
                if (odd.Value %2 != 0)
                {
                    Console.WriteLine(odd.Key);
                }
            }
        }
    }
}
