using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsNameAge
{
    public class Student
    {

        public string FirstName
        {
            get;
            private set;
        }

        public string LastName
        {
            get;
            private set;
        }

        public byte Age
        {
            get;
            private set;
        }


        public Student(string firstname,string lastname,byte age)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Age = age;
        }

        public override string ToString()
        {
            return string.Format( "Sudent Name : {0} {1}  age {2}", this.FirstName, this.LastName,this.Age );
        }



    }
}
