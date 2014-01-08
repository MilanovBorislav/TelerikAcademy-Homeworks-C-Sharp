using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_08_Labyrinth_02
{
    class Program
    {
        static string[,] lab = new string[100, 100];

        static void Main()
        {
            for (int row = 0; row < 100; row++)
            {
                for (int col = 0; col < 100; col++)
                {
                    lab[row, col] = " ";
                }
            }
            lab[38, 16] = "e";
            Stack<int> stack = new Stack<int>();
            Console.WriteLine(IsPath(6, 9, 0, stack));
        }

        private static bool IsPath(int row, int col, int count, Stack<int> stack)
        {
            if (row < 0 || col < 0 ||
                row >= lab.GetLength(0) || col >= lab.GetLength(1))
            {
                return false;
            }

            if (lab[row, col] == "e")
            {
                return true;
            }

            if (lab[row, col] != " ")
            {
                return false;
            }

            stack.Push(count);
            lab[row, col] = count.ToString();
            count++;
            if (IsPath(row, col - 1, count, stack))
            {
                return true;
            }

            if (IsPath(row - 1, col, count, stack))
            {
                return true;
            }

            if (IsPath(row, col + 1, count, stack))
            {
                return true;
            }

            if (IsPath(row + 1, col, count, stack))
            {
                return true;
            }

            lab[row, col] = " ";
            if (stack.Count > 0)
            {
                stack.Pop();
            }
            return false;
        }
    }
}
