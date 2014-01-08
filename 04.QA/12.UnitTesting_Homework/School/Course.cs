using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _School
{
    public class Course
    {
        private const byte MaxStudentCount = 29;
        private string name;

        public IList<Student> Students { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null && value == string.Empty)
                {
                    throw new ArgumentException("The course name can not be missing");
                }
                else
                {
                    this.name = value;
                }
            }
        }


        public Course(string name, IList<Student> students = null)
        {
            this.Name = name;
            this.Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            bool studentFound = this.IsStudentFound(student);

            if (studentFound)
            {
                throw new ArgumentException("The student has been added");
            }

            if (this.Students.Count + 1 <= MaxStudentCount)
            {
                this.Students.Add(student);
            }
            else
            {
                throw new ArgumentOutOfRangeException("The course is full.It can't be more than 29 people");
            }
        }

        public void RemoveStudent(Student student)
        {
            bool studentFound = this.IsStudentFound(student);

            if (!studentFound)
            {
                throw new ArgumentException("The student does not exist in this course");
            }

            this.Students.Remove(student);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("Course name {0}; ", this.Name));

            for (int i = 0; i < this.Students.Count; i++)
            {
                sb.Append(this.Students[i]);
            }

            return sb.ToString();
        }

        private bool IsStudentFound(Student student)
        {
            bool studentFound = false;
            for (int i = 0; i < this.Students.Count; i++)
            {
                if (this.Students[i].StudentNumber == student.StudentNumber)
                {
                    studentFound = true;
                }
            }

            return studentFound;
        }
    }
}
