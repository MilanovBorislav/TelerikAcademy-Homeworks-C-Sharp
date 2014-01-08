using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salaries
{
    class Program
    {
        private static long[] cache;
        
        static void Main(string[] args)
        {
            int C = int.Parse(Console.ReadLine());
            bool[,] matrix = new bool[C,C];
            long[] arr = new long[C];
            cache = arr;

            for (int i = 0; i < C; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < C; j++)
                {
                    matrix[i, j] = (line[j] == 'Y');
                }
            }

            long sumOfSelaries = 0;

            for (int i = 0; i < C; i++)
            {
                sumOfSelaries += FindSalary(i,matrix);
            }
            Console.WriteLine(sumOfSelaries);
            Console.WriteLine(counter);
        }

        public static int counter = 0;
        private static long FindSalary(int employee, bool[,] matrix)
        {
            counter++;
            if (cache[employee] >  0)
            {
                return cache[employee];
            }

            long salary = 0;
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if (matrix[employee,j])
                {
                    salary += FindSalary(j, matrix);
                }
            }
            if (salary == 0)
            {
                salary = 1;
            }
            cache[employee] = salary;
            return salary;
        }
    }
}
