using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07_Labytinth_01
{
    class Labytinth
    {
        static readonly char[,] lab = 
           {
               {'0', '0', '0', '|', '0', '0', '0','0'},
               {'|', '|', '0', '|', '0', '|', '|','|'},
               {'0', '0', '0', '0', '0', '0', '0','|'},
               {'0', '|', '|', '|', '|', '|', '0','|'},
               {'0', '0', '0', '0', '0', '|', '0','e'}
           };

        static Stack<Coordinates> path = new Stack<Coordinates>();

        public static void PrintMatrix(char[,] lab)
        {
            for (int i = 0; i < lab.GetLength(0); i++)
            {
                for (int j = 0; j < lab.GetLength(1); j++)
                {
                    Console.Write(" " + lab[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void PrintPath(Stack<Coordinates> path)
        {
            List<string> cells = new List<string>();
            while (path.Count != 0)
            {
                var cord = path.Pop();
                string cell = cord.Row + ", " + cord.Col;
                cells.Add(cell);
            }
            for (int i = cells.Count - 1; i >= 0; i--)
            {
                Console.Write(cells[i] + " --> ");
            }
            Console.Write(" Exit");
            Console.WriteLine();
        }

        static bool OutOfRage(int row, int col)
        {
            bool outOfRow = row >= 0 && row < lab.GetLength(0);
            bool outOfCol = col >= 0 && col < lab.GetLength(1);
            return outOfRow && outOfCol;
        }

        static void FindPath(int row, int col)
        {
            if (!OutOfRage(row, col))
            {
                return;
            }
            if (lab[row, col] == 'e')
            {
                PrintPath(path);
            }
            if (lab[row, col] != '0')
            {
                return;
            }

            lab[row, col] = 's';
            PrintMatrix(lab);
            path.Push(new Coordinates(row, col));

            FindPath(row, col - 1); //left
            FindPath(row - 1, col); //down
            FindPath(row, col + 1); //right
            FindPath(row + 1, col); //up

            lab[row, col] = '0';
            if (path.Count == 0)
            {
                return;
            }
            path.Pop();
        }

        static void Main(string[] args)
        {


            FindPath(0, 0);
        }
    }
}
