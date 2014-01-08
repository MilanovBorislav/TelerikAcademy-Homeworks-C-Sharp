using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06_RemoveNumbers
{
    class RemoveNumbers
    {
        static void Main(string[] args)
        {
            int[] arr = {0, 0, 1, 2, 7, 7, 7, 9, 3, 4, 5, 9, 9, 1, 2, 3, 4, 5 };
            Array.Sort(arr);
            List<int> container = new List<int>();
            List<int> currentContainer = new List<int>();
            bool isOddTime = currentContainer.Count % 2 == 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int current = arr[i];
                currentContainer.Add(current);

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (current == arr[j])
                    {
                        currentContainer.Add(arr[j]);
                        i++;
                        if (j == arr.Length - 1 && currentContainer.Count % 2 == 0)
                        {
                            container.AddRange(currentContainer);
                            currentContainer.Clear();
                            break;
                        }
                    }
                    else
                    {
                        if (currentContainer.Count % 2 == 0)
                        {
                            container.AddRange(currentContainer);
                            currentContainer.Clear();
                            break;
                        }
                        else
                        {
                            currentContainer.Clear();
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < container.Count; i++)
            {
                Console.WriteLine(container[i]);
            }
        }
    }
}