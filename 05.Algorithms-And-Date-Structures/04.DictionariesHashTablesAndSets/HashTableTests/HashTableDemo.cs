using HashTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HashTableTests
{
   public class HashTableDemo
    {
        static void Main(string[] args)
        {
        
            HashTable<string, int> digits = new HashTable<string, int>();
            digits.Add("one",1);
            digits.Add("two",2);
            digits.Add("three", 3);
            digits.Add("four", 4);
            digits.Add("five", 5);
            Console.WriteLine();

            Console.WriteLine("Values");
            foreach (var value in digits.Values)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine();
            Console.WriteLine("Key");
            foreach (var key in digits.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine();
            Console.WriteLine("Remove five");
            digits.Remove("five");
            foreach (var value in digits.Values)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine();
            Console.WriteLine("Is table contains value 2");
            Console.WriteLine(digits.ContainsValue(2));

            Console.WriteLine();
            Console.WriteLine("Is table contains key \"two\"");
            Console.WriteLine(digits.ContainsKey("two"));
            Console.WriteLine();
            Console.WriteLine("Table Count");
            Console.WriteLine(digits.Count);
            Console.WriteLine("");
            Console.WriteLine("Foreach");
            foreach (var digit in digits)
            {
                Console.WriteLine("{0} {1}",digit.Key, digit.Value);
            }
            
            digits.Clear();
        }
    }
}
