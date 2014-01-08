using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentClassLibrary.Enumerations;

namespace StudentClassLibrary
{//– first, middle and last name, SSN, permanent address,
    //  mobile phone e-mail, course, specialty, university, faculty. 
    public class Student : ICloneable,IComparable<Student>
    {
        public string FirstName { get; private set; } //{ get;  set; }//test Clone  without private set
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public string Phone { get; private set; }
        public string Address { get; private set; }
        public string E_Mail { get; private set; }
        public int SSN { get; private set; }
        public Faculty Faculty = new Faculty();
        public University University = new University();
        public Specialty Specialty = new Specialty();


        public Student(string firstName, string middleName, string lastName, string phone, string adderess,
            string eMail, int ssn, University someUniversity, Faculty someFaculty, Specialty someSpecialty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Phone = phone;
            this.Address = adderess;
            this.E_Mail = eMail;
            this.SSN = ssn;
            this.University = someUniversity;
            this.Faculty = someFaculty;
            this.Specialty = someSpecialty;
        }

        public Student(string firstName, string middleName, string lastName, int ssn)
            : this(firstName, middleName, lastName,
         null,null,null,ssn,University.NotSpecified,Faculty.NotSpecified,Specialty.NotSpecified)
        {
        
        }

        public override bool Equals(object param)
        {
            // If the cast is invalid, the result will be null
            Student student = param as Student;

            // Check if we have valid not null Student object
            if (student == null)
            {
                return false;
            }

            // Compare the reference type member fields
            if (!Object.Equals(this.FirstName, student.FirstName))
            {
                return false;
            }
            if (!Object.Equals(this.MiddleName, student.MiddleName))
            {
                return false;
            }
            if (!Object.Equals(this.LastName, student.LastName))
            {
                return false;
            }
            if (!Object.Equals(this.Phone, student.Phone))
            {
                return false;
            }
            if (!Object.Equals(this.Phone, student.Phone))
            {
                return false;
            }
            if (!Object.Equals(this.Address, student.Address))
            {
                return false;
            }
            if (!Object.Equals(this.E_Mail, student.E_Mail))
            {
                return false;
            }
            if (!Object.Equals(this.SSN, student.SSN))
            {
                return false;
            }
            if (!Object.Equals(this.University, student.University))
            {
                return false;
            }
            if (!Object.Equals(this.Faculty, student.Faculty))
            {
                return false;
            }
            if (!Object.Equals(this.Specialty, student.Specialty))
            {
                return false;
            }
            //return true if all fields are equals
            return true;
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ MiddleName.GetHashCode() ^ LastName.GetHashCode()
                ^ Phone.GetHashCode() ^ Address.GetHashCode() ^ E_Mail.GetHashCode() ^ SSN.GetHashCode()
                ^ University.GetHashCode() ^ Faculty.GetHashCode() ^ Specialty.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format(
@"
First Name:     {0}
Middle Name     {1}
Last Name:      {2}
Phone:          {3}
Address:        {4}
E-Mail:         {5}
SSN:            {6}
University:     {7}
Faculty:        {8}
Special:        {9}
",
this.FirstName,
this.MiddleName,
this.LastName,
this.Phone,
this.Address,
this.E_Mail,
this.SSN,
this.University,
this.Faculty,
this.Specialty
                );
        }

        public Student Clone()
        {
            Student original = this;
            Student clonedStudent = new Student(this.FirstName, this.MiddleName, this.LastName, this.Phone, this.Address,
            this.E_Mail, this.SSN, this.University, this.Faculty, this.Specialty);
            return clonedStudent;
        }

        Object ICloneable.Clone()
        {
            return this.Clone();
        }

        public int CompareTo(Student student)
        {
            if (this.FirstName != student.FirstName)
            {
                return (this.FirstName.CompareTo(student.FirstName));
            }
            if (this.MiddleName != student.MiddleName)
            {
                return (this.MiddleName.CompareTo(student.MiddleName));
            }
            if (this.LastName != student.LastName)
            {
                return (this.LastName.CompareTo(student.LastName));
            }
            if (this.SSN != student.SSN)
            {
                return (this.SSN - student.SSN);
            }
            return 0;
        }
    }
}
