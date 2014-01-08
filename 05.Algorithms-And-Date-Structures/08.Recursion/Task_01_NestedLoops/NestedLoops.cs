using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_NestedLoops
{
    class NestedLoops
    {
        static void PrintCollection(IEnumerable<int> arr)
        {
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
        }

        static void ImitateNestedLoops(int index, IList<int> arr, int nested)
        {
            if (arr == null) throw new ArgumentNullException("arr");
            if (index > arr.Count - 1)
            {
                PrintCollection(arr);
                return;
            }

            for (int i = 1; i <= nested; i++)
            {
                arr[index] = i;
                ImitateNestedLoops(index + 1, arr, nested);
            }

        }

        static void Main(string[] args)
        {
            // const int nested = 4;
             const int nested = 3;
            //  const int nested = 2;
            var arr = new int[nested];

            ImitateNestedLoops(0, arr, nested);
        }
    }
}
