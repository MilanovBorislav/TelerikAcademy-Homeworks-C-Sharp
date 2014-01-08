using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using _School;

namespace SchoolTest
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void AddStudentTest_AddOneStudent()
        {
            Student pesho = new Student("Petar Kolev", 45000);
            IList<Student> students = new List<Student>();
            Course php = new Course("PHP", students);
            php.AddStudent(pesho);
            int count = php.Students.Count;
            Assert.IsTrue(count == 1);
        }

        [TestMethod]
        public void RemoveStudentTest_RemoveOneStudent()
        {
            Student pesho = new Student("Petar Kolev", 45000);
            IList<Student> students = new List<Student>();
            Course php = new Course("PHP", students);
            php.AddStudent(pesho);

            php.RemoveStudent(pesho);
            int count = php.Students.Count;
            Assert.IsTrue(count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddStudentTest_AddStudentTwoTimes()
        {
            IList<Student> students = new List<Student>();
            Course php = new Course("PHP", students);
            Student pesho = new Student("Petar Kolev", 45000);
            php.AddStudent(pesho);
            php.AddStudent(pesho);
        }

        [TestMethod]
        public void AddStudentTest_AddTwoStudents()
        {
            IList<Student> students = new List<Student>();
            Course course = new Course("PHP", students);
            Student pesho = new Student("Pesho Goshev", 45000);
            Student gosho = new Student("Ghosho Peshev", 55000);
            course.AddStudent(pesho);
            course.AddStudent(gosho);
            Assert.IsTrue(course.Students.Count == 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveNonExistingStudentTest()
        {
            IList<Student> students = new List<Student>();
            Course php = new Course("PHP", students);
            Student ivan = new Student("Ivan Genchev", 98000);
            php.RemoveStudent(ivan);
        }
    }
}
