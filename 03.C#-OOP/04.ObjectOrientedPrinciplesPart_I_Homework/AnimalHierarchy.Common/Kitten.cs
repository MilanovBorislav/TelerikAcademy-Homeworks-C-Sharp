using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy.Common
{
    public  class Kitten:Cat
    {
         public Kitten(string name, byte age):base(name,age)
        {
            this.Sex = "male";
        }

                                   

        public override void MakeSoud()
        {
            Console.WriteLine( "Miaayyyyyyyyyyyy" );
        }
    }
}
