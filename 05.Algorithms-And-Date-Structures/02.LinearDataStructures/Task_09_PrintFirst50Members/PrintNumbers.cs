using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9_PrintFirst50Members
{
    class PrintNumbers
    {
        static void Main(string[] args)
        {
            int n = 2;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);

            int index = 0;
            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
                Console.Write(" {0}", current);
                index++;
                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current);
                if (index == 50)
                {
                    Console.WriteLine("");
                    return;
                }
            }
        }
    }
}