using System;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Transactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentSustemRepository;
using StudentSystemDataLayer;
using StudentSystemDomainClasses;
using System.Data.Entity;

namespace RepsitoryTests
{
    [TestClass]
    public class RepositoryTest
    {
        private static TransactionScope _tranScope;
        private static readonly StudentSystemContext DbContext = new StudentSystemContext();
        private readonly IRepository<Student> _studentRepository = new StudentRepository(DbContext);
        private readonly IRepository<School> _schoolRepository = new SchoolRepository(DbContext);

        [TestInitialize]
        public void TestInit()
        {
            _tranScope = new TransactionScope();
        }

        [TestCleanup]
        public void TestTearDown()
        {
            _tranScope.Dispose();
        }

        [TestMethod]
        public void GetAllStudents()
        {
            using (_tranScope)
            {
                var student1 = new Student
                {
                    FirstName = "Fists Name 1",
                    LastName = "Last Name 1"
                };
                var student2 = new Student
                {
                    FirstName = "Fists Name 2",
                    LastName = "Last Name 2"
                };

                var school1 = new School
                {
                    Name = "School Name 1",
                };

                school1.Students.Add(student1);
                school1.Students.Add(student2);
                _schoolRepository.Add(school1);

                var studentList = _studentRepository.All();
                var studentCount = studentList.Count();
                Assert.IsTrue(studentCount == 2);
            }
        }

        [TestMethod]
        public void DeleteStudent()
        {
            using (_tranScope)
            {
                var student1 = new Student
                {
                    FirstName = "Fists Name 1",
                    LastName = "Last Name 1"
                };
                var student2 = new Student
                {
                    FirstName = "Fists Name 2",
                    LastName = "Last Name 2"
                };

                var school1 = new School
                {
                    Name = "School Name 1",
                };

                school1.Students.Add(student1);
                school1.Students.Add(student2);
                _schoolRepository.Add(school1);
                var studentList = _studentRepository.All();
                var studentCount = studentList.Count();
                Assert.IsTrue(studentCount == 2);
                _studentRepository.Delete(student1.StudentId);
                var newStudentList = _studentRepository.All();
                var newStudentsCount = newStudentList.Count();
                Assert.IsTrue(newStudentsCount == 1);
            }
        }

        [TestMethod]
        public void UpdateStudent()
        {
            using (_tranScope)
            {
                var student1 = new Student
                {
                    FirstName = "Fists Name 1",
                    LastName = "Last Name 1"
                };

                var school1 = new School
                {
                    Name = "School Name 1",
                };

                school1.Students.Add(student1);
                _schoolRepository.Add(school1);
                var updatedStudent = new Student
                {
                    FirstName = "Pesho",
                    LastName = "Peshev",
                    Age = 22,
                    SchoolId = school1.SchoolId
                };
                _studentRepository.Update(student1.StudentId, updatedStudent);
                Assert.IsTrue(student1.FirstName == updatedStudent.FirstName);
                Assert.IsTrue(student1.LastName == updatedStudent.LastName);
            }
        }

        [TestMethod]
        public void GetStudentById()
        {
            var student1 = new Student
            {
                FirstName = "Fists Name 1",
                LastName = "Last Name 1"
            };
            var student2 = new Student
            {
                FirstName = "Fists Name 2",
                LastName = "Last Name 2"
            };

            var school1 = new School
            {
                Name = "School Name 1",
            };

            school1.Students.Add(student1);
            school1.Students.Add(student2);
            _schoolRepository.Add(school1);
            var searchedStudent = _studentRepository.Get(student1.StudentId);
            Assert.IsTrue(student1.FirstName == searchedStudent.FirstName);
            Assert.IsTrue(student1.LastName == searchedStudent.LastName);
        }

        [TestMethod]
        public void AddStudent()
        {
            using (_tranScope)
            {
                var school1 = new School
                {
                    Name = "School Name 1",
                };

                _schoolRepository.Add(school1);

                var student1 = new Student
                {
                    FirstName = "Fists Name 1",
                    LastName = "Last Name 1",
                    SchoolId = school1.SchoolId
                };
                var student2 = new Student
                {
                    FirstName = "Fists Name 2",
                    LastName = "Last Name 2",
                    SchoolId = school1.SchoolId
                };
                var countWitoutStudent = _studentRepository.All().Count();
                Assert.IsTrue(countWitoutStudent == 0);
                _studentRepository.Add(student1);
                _studentRepository.Add(student2);
                var countWithAddedStudents = _studentRepository.All().Count();
                Assert.IsTrue(countWithAddedStudents == 2);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(DbUpdateException))]
        public void AddStudent_WithoutSchoolId()
        {
            using (_tranScope)
            {
                var school1 = new School
                {
                    Name = "School Name 1",
                };

                _schoolRepository.Add(school1);

                var student1 = new Student
                {
                    FirstName = "Fists Name 1",
                    LastName = "Last Name 1",
                };
                _studentRepository.Add(student1);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(DbUpdateException))]
        public void AddStudent_WithWrongSchoolId()
        {
            using (_tranScope)
            {
                var school1 = new School
                {
                    Name = "School Name 1",
                };

                _schoolRepository.Add(school1);

                var student1 = new Student
                {
                    FirstName = "Fists Name 1",
                    LastName = "Last Name 1",
                    SchoolId = 100000
                };
                _studentRepository.Add(student1);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(DbUpdateException))]
        public void AddStudent_WithoutName()
        {
            using (_tranScope)
            {
                var school1 = new School
                {
                    Name = "School Name 1",
                };

                _schoolRepository.Add(school1);

                var student1 = new Student
                {
                    SchoolId = school1.SchoolId,
                    Age = 20
                };
                _studentRepository.Add(student1);
            }
        }

        [TestMethod]
        public void SearchStudent_WithWrongStudentId()
        {
            var dbContext = new StudentSystemContext();
            IRepository<Student> studentRepository = new StudentRepository(dbContext);
            IRepository<School> schoolRepository = new SchoolRepository(dbContext);

            using (_tranScope)
            {
                var school1 = new School
                {
                    Name = "School Name 1",
                };

                schoolRepository.Add(school1);

                var student1 = new Student
                {
                    FirstName = "Fists Name 1",
                    LastName = "Last Name 1",
                    SchoolId = school1.SchoolId
                };
                studentRepository.Add(student1);

                var searchedStudent = studentRepository.Get(student1.StudentId + 1);
                Assert.IsTrue(searchedStudent == null);
            }
        }
    }
}
