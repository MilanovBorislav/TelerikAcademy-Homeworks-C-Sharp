using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*using System.Web.Http.Dependencies;*/
using System.Web.Mvc;
using StudentSustemRepository;
using StudentSustemWebApi.Controllers;
using System.Web.Http.Dependencies;
using IDependencyResolver = System.Web.Http.Dependencies.IDependencyResolver;


namespace IntegrationTests
{
    class TestStudentDependencyResolver<T> : IDependencyResolver
    {

        private StudentRepository repository;

        public StudentRepository Repository
        {
            get
            {
                return this.repository;
            }
            set
            {
                this.repository = value;
            }
        }


        public void Dispose()
        {
           
        }

        public object GetService(Type serviceType)
        {
            if (serviceType == typeof(StudentController))
            {
                return new StudentController(this.repository);
            }
            return null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return new List<object>();
        }

        public IDependencyScope BeginScope()
        {
            return this;
        }
    }
}
