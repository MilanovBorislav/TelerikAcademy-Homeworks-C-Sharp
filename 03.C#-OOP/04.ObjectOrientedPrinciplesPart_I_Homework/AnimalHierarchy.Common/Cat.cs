using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy.Common
{
  public class Cat:Animal
    {
        public Cat(string name, byte age, string sex)
            : base( name, age, sex )
        {
        }

        public Cat(string name, byte age):base(name,age)
        {
        }

        public override void MakeSoud()
        {
            Console.WriteLine("Miay");
        }
    } 
}
