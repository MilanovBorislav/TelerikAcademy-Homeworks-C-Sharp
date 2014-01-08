using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05_GenerateVariations
{
    class Variations
    {
        static void PrintCollection(IEnumerable<int> arr,IList<string> words)
        {
            Console.Write("( ");
            foreach (var i in arr)
            {
                Console.Write(words[i-1]+" ");
            }
            Console.Write(")");
            Console.WriteLine();
        }

        private static void Combinate(int index,
            int nested,int[]arr,string[]words)
        {
            if (index > arr.Length-1)
            {
                PrintCollection(arr,words);
                return;
            }

            for (int i = 1; i <= nested; i++)
            {
                arr[index] = i;
                Combinate(index+1,nested,arr,words);
            }
        }

        static void Main(string[] args)
        {
            string[] words = { "hi", "a", "b" };
            int n = 3;
            int k = 2;
            Combinate(0,n,new int[k],words);
        }
    }
}
