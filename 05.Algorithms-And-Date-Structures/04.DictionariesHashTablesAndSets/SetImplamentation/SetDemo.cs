using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetImplamentation
{
    class SetDemo
    {
        static void PrintSet(MySet<int> set)
        {
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("First set");
            MySet<int> first = new MySet<int>();
            first.Add(1);
            first.Add(2);
            first.Add(3);
            first.Add(4);
            PrintSet(first);

            Console.WriteLine("Second set");
            MySet<int> second = new MySet<int>();
            second.Add(3);
            second.Add(4);
            second.Add(5);
            second.Add(6);
            PrintSet(second);

            MySet<int> third = first.Union(second);
            Console.WriteLine("Union");
            PrintSet(third);

            MySet<int> fourth = first.Difference(second);
            Console.WriteLine("Diference");
            PrintSet(fourth);

            MySet<int> someSet = first.SymmetricDifference(second);
            Console.WriteLine("Symmetric Difference");
            PrintSet(someSet);

            MySet<int> anotherSet = first.Intersection(second);
            Console.WriteLine("Intersection");
            PrintSet(anotherSet);
        }
    }
}