using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05_RemoveNegativeNumbers
{
    class RemoveNegativeNumbers
    {
        public static LinkedList<int> RemoveNegative(LinkedList<int> list)
        {
            var current = list.First;

            while (current != null)
            {
                var next = current.Next;
                if (current.Value < 0)
                {
                    list.Remove(current);
                }
                current = next;
            }

            return list;
        }

        static void Main(string[] args)
        {

            LinkedList<int> numbers = new LinkedList<int>();
            numbers.AddFirst(1);
            numbers.AddFirst(-2);
            numbers.AddFirst(2);
            numbers.AddFirst(3);
            numbers.AddFirst(-18);
            numbers.AddFirst(4);
            numbers.AddFirst(5);

            LinkedList<int> positiveNumbers = RemoveNegative(numbers);

            var item = numbers.First;
            while (item  != null)
            {
                Console.WriteLine(item.Value);
                item = item.Next;
            }
        }
    }
}