using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using StudentSustemRepository;
using StudentSystemDomainClasses;
using Telerik.JustMock;
//using System.Data.Entity.Infrastructure;

namespace IntegrationTests
{
    [TestClass]
    public class StudentControllerIntegrationTests
    {
        [TestMethod]
        public void GetAll_WhenOneStudent_ShouldReturnStatusCode200AndNotNullContent()
        {
            var mockStudentRepository = Mock.Create<StudentRepository>();
            var studentList = new List<Student>();
            studentList.Add(new Student { FirstName = "Pesho", LastName = "Goshev" });

            Mock.Arrange(() => mockStudentRepository.All()).Returns(() => studentList.AsQueryable());

            var server = new InMemoryHttpServer<Student>("http://localhost/", mockStudentRepository);

            var response = server.CreateGetRequest("api/Student");
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.IsNotNull(response.Content);
        }

        [TestMethod]
        public void PostStudent_WhenNameIsNull_ShouldReturnStatusCode400()
        {
            var mockStudentRepository = Mock.Create<StudentRepository>();
            Mock.Arrange(() => mockStudentRepository
                .Add(Arg.Matches<Student>(stud => stud.FirstName == null)))
                .Throws<NullReferenceException>();

            var server =
            new InMemoryHttpServer<Student>("http://localhost/", mockStudentRepository);

            var response = server.CreatePostRequest("api/Student",
                new Student()
                {
                    FirstName = null
                });

            Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [TestMethod]
        public void PostStudent_WithoutName_ShouldReturnStatusCode400()
        {
            var mockStudentRepository = Mock.Create<StudentRepository>();
            var student = new Student { Age = 20, SchoolId = 1, Grade = "Some Grade" };

            Mock.Arrange(() => mockStudentRepository.Add(Arg.IsAny<Student>()))
                .Throws(new DbUpdateException());


            var server =
            new InMemoryHttpServer<Student>("http://localhost/", mockStudentRepository);

            var response = server.CreatePostRequest("api/Student", JsonConvert.SerializeObject(student));

            Assert.AreEqual(response.StatusCode, HttpStatusCode.BadRequest);
        }
    }
}
