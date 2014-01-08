using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy.Common
{
    public  class Tomcat:Cat
    {

        public Tomcat(string name, byte age):base(name,age)
        {
            this.Sex = "male";
        }

                                   

        public override void MakeSoud()
        {
            Console.WriteLine( "Miay,Miay,Miay,Miay" );
        }
    }
}
