using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonClassLibrary;


namespace PersonTest
{
    class PersonTest
    {
        static void Main(string[] args)
        {
            Person some = new Person("Pesho Ivanov");
            Person someP = new Person("Ivan Peshev", 45);

            Console.WriteLine(some);
            Console.WriteLine(someP);

        }
    }
}
