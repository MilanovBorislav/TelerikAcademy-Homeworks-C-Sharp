using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _School;


namespace SchoolTest
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameTest_IsNullValue()
        {
            string name = null;
            int studentNumber = 45000;
            Student student = new Student(name, studentNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameTest_IsEmptyString()
        {
            string name = string.Empty;
            int studentNumber = 45000;
            Student student = new Student(name, studentNumber);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentNumberTest_IsNumberLessThan10000()
        {
            int studentNumber = 1000;
            Student student = new Student("Pesho", studentNumber);
            Assert.IsTrue(studentNumber >= 10000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentNumberTest_IsNumberBiggerThan99999()
        {
            int studentNumber = 100000;
            Student student = new Student("Pesho", studentNumber);
            Assert.IsTrue(studentNumber >= 100000);
        }
    }
}
