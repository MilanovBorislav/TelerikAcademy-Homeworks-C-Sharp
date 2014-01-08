using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClassLibrary
{
    public class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int? age;

        public int? Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            string message = this.Name + " ";

            if (age == null)
            {
                return message + "age is not specified";
            }
            else
	        {
                return message + " " + "age " + this.Age;     
	        }
        }

    }
}
