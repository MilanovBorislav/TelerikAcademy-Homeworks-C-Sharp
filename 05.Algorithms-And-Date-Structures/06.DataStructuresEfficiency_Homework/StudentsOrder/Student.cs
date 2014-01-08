using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsOrder
{
   public class Student : IComparable<Student>
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int CompareTo(Student other)
        {
            return string.Compare(this.LastName, other.LastName) * 2 +
                string.Compare(this.FirstName, other.LastName);
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, ", this.FirstName, this.LastName);
        }
    }
}
