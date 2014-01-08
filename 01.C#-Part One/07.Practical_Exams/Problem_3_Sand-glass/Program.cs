using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3_Sand_glass
{   
    class Program
    {
        static void Main(string[] args)
        {
            int width =int.Parse(Console.ReadLine());
            int counter = 2;
            string top = new string('*',width);
            Console.WriteLine(top);
     
            for(int i = 1; i < width/2+1; i++)
            {
                string dots = new string('.',(width-width)+i);
                Console.Write(dots);
                string stars = new string('*',(width-counter));
                Console.Write(stars);
                Console.Write(dots);
                Console.WriteLine();
                counter = counter + 2;     
            }
            int downcounter = 3;
            for(int i = 1; i < width/2; i++)
            {
                string dots = new string('.', (width/2) - i);
                Console.Write(dots);
                string stars = new string('*', (downcounter));
                Console.Write(stars);
                Console.Write(dots);
                downcounter = downcounter + 2;
                Console.WriteLine();
            }
            string bottom = new string('*', width);
            Console.WriteLine(bottom);
        }
    }
}
