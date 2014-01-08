using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy.Common
{
    public  class Dog:Animal
    {
        public Dog(string name , byte age, string sex):base(name,age,sex)
        {
        }

        public override  void MakeSoud()
        {
            Console.WriteLine("Bay Bay");
        }
    }
}
