using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Hosting;
using System.Web.Http.Routing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentSustemRepository;
using StudentSustemWebApi.Controllers;
using StudentSystemDomainClasses;
using Telerik.JustMock;


namespace StudentSustemWebApi.Tests.Controllers
{
    [TestClass]
    public class StudentControllerTest
    {

        private void SetupController(ApiController controller)
        {
            var config = new HttpConfiguration();
            var request = new HttpRequestMessage(HttpMethod.Post, "http://localhost:35335/api/Student");
            var route = config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });

            var routeData = new HttpRouteData(route);
            routeData.Values.Add("id", RouteParameter.Optional);
            routeData.Values.Add("controller", "Student");
            controller.ControllerContext = new HttpControllerContext(config, routeData, request);
            controller.Request = request;
            controller.Request.Properties[HttpPropertyKeys.HttpConfigurationKey] = config;
            controller.Request.Properties[HttpPropertyKeys.HttpRouteDataKey] = routeData;
        }

        [TestMethod]
        public void PostStudent_ViaController()
        {
            bool isItemAdded = false;

            var studentRepository = Mock.Create<StudentRepository>();

            var student1 = new Student
            {
                FirstName = "Fists Name 1",
                LastName = "Last Name 1",
            };

            Mock.Arrange(() => studentRepository.Add(Arg.IsAny<Student>()))
                .DoInstead(() => isItemAdded = true)
                .Returns(student1);

            var controller = new StudentController(studentRepository);
            SetupController(controller);

            controller.PostStudent(student1);

            Assert.IsTrue(isItemAdded);
        }

        [TestMethod]
        public void GetAll_WhenSingleStudentInRepository_ShouldReturnSingleStudent()
        {
            var repository = Mock.Create<StudentRepository>();
            var studentToAdd = new Student
            {
                FirstName = "Pesho",
                LastName = "Goshev"
            };
            IList<Student> studentEntities = new List<Student>();
            studentEntities.Add(studentToAdd);
            Mock.Arrange(() => repository.All()).Returns(() => studentEntities.AsQueryable());

            var controller = new StudentController(repository);
            var students = controller.GetStudents();
            Assert.IsTrue(students.Count() == 1);
        }
    }
}
