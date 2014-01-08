using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01.PriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue<int> priorityOueue = new PriorityQueue<int>(2);
            priorityOueue.Enqueue(6);
            priorityOueue.Enqueue(7);
            priorityOueue.Dequeue();
            priorityOueue.Enqueue(2);
            priorityOueue.Enqueue(1);
           
            priorityOueue.Enqueue(10);
            priorityOueue.Enqueue(3);
            Console.WriteLine(priorityOueue.Dequeue());
            priorityOueue.Print();
            priorityOueue.Enqueue(7);
            priorityOueue.Print();
        }
    }
}
