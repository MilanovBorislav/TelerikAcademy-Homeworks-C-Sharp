using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.Common
{
    public class Student:Human
    {
        private byte grade;

        public byte Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }

        public Student(string firstName, string lastName, byte grade):base(firstName,lastName)
        {
            this.Grade = grade;
        }

        public override string ToString()
        {
            return string.Format(
@" {0}  {1} {2}  {3} ",this.GetType().Name,this.FirstName,this.LastName,this.Grade);
        }
    }
}
