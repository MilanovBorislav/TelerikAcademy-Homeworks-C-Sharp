using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09_ConnectedAdjacentCells
{
    class Program
    {
        static readonly string[,] Matrix =
            {
        {"A","A"," "," ","A","A","A","A","A","A","A","A"},
        {"A","A"," "," ","A","A","A","A","A","A","A","A"},
        {"A","A","A","A","A","A","A","A","A","A","A","A"},
        {"A","A","A","A","A","A","A","A","A","A","A","A"},
        {"A","A","A"," "," "," "," "," "," ","A","A","A"},
        {"A","A","A"," "," "," "," "," "," ","A","A","A"},
        {"A","A","A"," "," "," "," "," "," ","A","A","A"},
        {"A","A","A","A"," ","A","A","A","A","A","A","A"},
        {"A","A","A","A"," ","A","A","A","A","A","A","A"},
        {"A","A","A","A"," ","A","A","A","A","A","A","A"},
        {"A","A","A","A"," "," ","A","A","A","A","A","A"},
        {"A","A","A","A","A"," ","A","A","A","A","A","A"},
        {"A","A","A","A","A"," ","A","A","A","A","A","A"},
        {"A","A","A","A","A","A","A","A","A","A","A","A"},
            };

        private static int _sum = 0;
        private static int _counter = 0;

        static void FindAdjacents(int row, int col)
        {
            if (row < 0 || col < 0 ||
                row >= Matrix.GetLength(0) || col >= Matrix.GetLength(1) ||
                Matrix[row, col] != " ")
            {
                return;
            }

            Matrix[row, col] = _counter.ToString();

            _counter++;
            FindAdjacents(row, col - 1);
            FindAdjacents(row - 1, col);
            FindAdjacents(row, col + 1);
            FindAdjacents(row + 1, col);
        }

        static void Main(string[] args)
        {
            for (int row = 0; row < Matrix.GetLength(0); row++)
            {
                for (int col = 0; col < Matrix.GetLength(1); col++)
                {
                    if (Matrix[row, col] == " ")
                    {
                        FindAdjacents(row, col);
                        if (_counter > _sum)
                        {
                            _sum = _counter;
                        }
                        _counter = 0;
                    }
                }
            }
            Console.WriteLine(_sum);
        }
    }
}
