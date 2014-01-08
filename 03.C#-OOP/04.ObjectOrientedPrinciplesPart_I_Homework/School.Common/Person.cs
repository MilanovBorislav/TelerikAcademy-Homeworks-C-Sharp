using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Common
{
    public class Person
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if( value == null )
                {
                    throw new NullReferenceException( "Name can not be empty" );
                }

                this.name = value;
            }
        }

        public Person(string name)
        {
            this.Name = name;
        }

    }
}
