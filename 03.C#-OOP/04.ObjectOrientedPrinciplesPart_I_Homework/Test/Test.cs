using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHierarchy.Common;

namespace Test
{
    class Test
    {
        private static double GetAverage(List<Animal> group)
        {
            int age = 0;
            int animals = 0;
            foreach( var animal in group )
            {
                age += animal.Age;
                animals++;
            }
            return (double)age / animals;
        }


        static void Main(string[] args)
        {
            Animal[] animalArray = new Animal[15]
            {
                new Cat("John",2,"male"),
                new Dog("Rex",1,"male"),
                new Dog("Liza",2,"female"),
                new Cat("Sara",1,"female"),
                new Cat("Gogo",1,"male"),
                new Frog("Ron",1,"male"),
                new Frog("Jill",1,"female"),
                new Dog("Sharo",4,"male"),
                new Frog("Jim",1,"male"),
                new Tomcat( "Tom", 2 ),
                new Tomcat( "Marbel",4 ),
                new Kitten("Lili",1),
                new Kitten("Jakie",1),
                new Tomcat( "Jake", 1 ),
                new Kitten("Sali",1),
            };

            foreach( var item in animalArray )
            {
                item.MakeSoud(); 
            }


           var animalGroups =
           from animal in animalArray
           group animal by animal.GetType().Name into groups
           select new { groupName = groups.Key, animals = groups.ToList() };

           foreach( var group in animalGroups )
           {
               Console.WriteLine( "Group: {0, 10}   average age {1:0.00}", group.groupName.ToString(), GetAverage( group.animals ) );
           }
           Console.WriteLine();
        }
    }
}
