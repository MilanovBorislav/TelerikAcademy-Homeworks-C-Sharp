using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagesInABottle
{
    class Program
    {
        internal static List<KeyValuePair<char, string>> Chiphers =
            new List<KeyValuePair<char, string>>();

        internal static string Message;

        static readonly List<string> solutions = new List<string>();

        private static void Main(string[] args)
        {
            Message = Console.ReadLine();
            string chipher = Console.ReadLine();

            char key = char.MinValue;
            var value = new StringBuilder();

            foreach (char t in chipher)
            {
                if (char.IsLetter(t))
                {
                    if (key != char.MinValue)
                    {
                        Chiphers.Add(new KeyValuePair<char, string>(key, value.ToString()));
                        value.Clear();
                    }
                    key = t;
                }
                else
                {
                    value.Append(t);
                }
            }

            if (key != char.MinValue)
            {
                Chiphers.Add(new KeyValuePair<char, string>(key, value.ToString()));
                value.Clear();
            }
            Solve(0,new StringBuilder());
            Console.WriteLine(solutions.Count);
            solutions.Sort();
            foreach (var item in solutions)
            {
                Console.WriteLine(item);
            }
        }

        static void Solve(int secretMessageIndex,StringBuilder sb)
        {
            if (secretMessageIndex == Message.Length)
            {
                solutions.Add(sb.ToString());
                return;
            }

            foreach (var chipher in Chiphers)
            {
                if (Message.Substring(secretMessageIndex).StartsWith(chipher.Value))
                {
                    sb.Append(chipher.Key);
                    Solve(secretMessageIndex + chipher.Value.Length,sb);
                    sb.Length--;
                }
            }
        }
    }
}
