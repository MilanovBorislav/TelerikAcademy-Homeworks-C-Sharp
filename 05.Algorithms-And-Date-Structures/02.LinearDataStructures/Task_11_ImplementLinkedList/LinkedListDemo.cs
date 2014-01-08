using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11_ImplementLinkedList
{
    class LinkedListDemo
    {
        static void Main(string[] args)
        {
            MyLinkedList<int> linkedlist = new MyLinkedList<int>();
            linkedlist.AddFirst(1);
            linkedlist.Add(2);
            linkedlist.Add(3);
            linkedlist.Add(4);
            linkedlist.Add(5);
            linkedlist.AddLast(29);
            linkedlist.RemoveFirst();
            linkedlist.Add(1);
            linkedlist.Add(13);
            linkedlist.RemoveLast();
            var item = linkedlist.Head;

            while (item.Next != null)
            {
                Console.WriteLine(item.Value);
                item = item.Next;
            }

            LinkedList<int> originalList = new LinkedList<int>();
            originalList.AddFirst(1);
            originalList.AddFirst(2);
            originalList.AddFirst(3);
            originalList.AddFirst(4);
            originalList.AddFirst(5);
            originalList.AddLast(29);
            originalList.RemoveFirst();
            originalList.AddFirst(1);
            originalList.AddFirst(13);
            originalList.RemoveLast();

            var originalItem = originalList.First;
            Console.WriteLine("");
            Console.WriteLine("");
            while (originalItem != null)
            {
                Console.WriteLine(originalItem.Value);
                originalItem = originalItem.Next;
            }
        }
    }
}
