using System;
using System.Globalization;
using System.Threading;

namespace Methods
{
    internal class Student
    {
        public Student(string firstName, string lastName, string otherInfo, string birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.OtherInfo = otherInfo;
            this.BirthDate = DateTime.Parse(birthDate);
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string OtherInfo { get; private set; }

        public DateTime BirthDate { get; private set; }

        public bool IsOlderThan(Student other)
        {
            DateTime firstBirthDate = this.BirthDate;
            DateTime secondBirthDate = other.BirthDate;

            bool isOlder = firstBirthDate < secondBirthDate;
            return isOlder;
        }
    }
}