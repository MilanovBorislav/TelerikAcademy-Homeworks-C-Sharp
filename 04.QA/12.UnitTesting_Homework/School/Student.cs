using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _School
{
    public class Student
    {
        private string name;
        private int studentNumber;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value != null && value != string.Empty)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentNullException("Missing name in student");
                }
            }
        }

        public int StudentNumber
        {
            get
            {
                return this.studentNumber;
            }
            set
            {
                if (value >= 10000 && value <= 99999)
                {
                    this.studentNumber = value;
                }
                else
                {
                    throw new ArgumentNullException("The number of " + this.Name+ "  should be between 10000 and 99999");
                }  
            }
        }

        public Student(string name, int studentNumber)
        {
            this.Name = name;
            this.StudentNumber = studentNumber;
        }

        public override string ToString()
        {
            return string.Format("Student {0}, ID {1}; ", this.Name, this.StudentNumber);
        }
    }
}
