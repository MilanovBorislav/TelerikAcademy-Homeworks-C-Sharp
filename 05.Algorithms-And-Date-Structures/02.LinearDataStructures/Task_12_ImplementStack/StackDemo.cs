using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_ImplementStack
{
    class StackDemo
    {
        static void Main(string[] args)
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            int peak1 = stack.Peek();
            Console.WriteLine("Peak " + peak1);
            Console.WriteLine("Stack Values (Pushed Elements)");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("");
            int popped = stack.Pop();
            Console.WriteLine("Pop last added element  " + popped);
            Console.WriteLine("Stack Values");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("");
            int peak2 = stack.Peek();
            Console.WriteLine("Peak " + peak2);
            Console.WriteLine("Stack Values");
            while (stack.Count > 0)
            {
                int i = stack.Pop();
                Console.WriteLine(i);
            }
        }
    }
}