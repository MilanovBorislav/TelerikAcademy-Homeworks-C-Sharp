using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using _School;

namespace SchoolTest
{
    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void AddCourseTest()
        {
            List<Course> courses = new List<Course>();
            Course php = new Course("PHP");
            School school = new School(courses);
            school.AddCourse(php);
            Assert.AreEqual(php.Name, school.Courses[0].Name);
        }


        [TestMethod]
        public void RemoveCourseTest_TestCourse()
        {
            List<Course> courses = new List<Course>();
            School school = new School(courses);
            Course php = new Course("PHP");
            school.AddCourse(php);
            school.RemoveCourse(php);
            Assert.IsTrue(school.Courses.Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveNonExisting_TestCourse()
        {
            List<Course> courses = new List<Course>();
            School school = new School(courses);
            Course php = new Course("PHP");
            school.RemoveCourse(php);
        }
    }
}
