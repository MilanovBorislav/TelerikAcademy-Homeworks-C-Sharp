  using System;
   using System.Collections.Generic;
   using System.Data.Entity;
   using System.Linq;
   using System.Web;
   using System.Web.Http.Dependencies;
   using StudentSustemRepository;
   using StudentSustemWebApi.Controllers;
   using StudentSystemDataLayer;
   using StudentSystemDomainClasses;
   
   namespace StudentSustemWebApi.Resolvers
   {
       public class DbDependencyResolver:IDependencyResolver
       {
           private static readonly DbContext StudentContext = new StudentSystemContext();

           private static readonly IRepository<Student> StudentRepository = new StudentRepository(StudentContext); 
           private static readonly IRepository<School> SchoolRepository = new SchoolRepository(StudentContext); 
   
           public object GetService(Type serviceType)
           {
               if (serviceType == typeof(StudentController))
               {
                   return new StudentController(StudentRepository);
               }
               else if (serviceType == typeof(SchoolController))
               {
                   return new SchoolController(SchoolRepository);
               }
               else
               {
                   return null;
               }
           }
   
           public IEnumerable<object> GetServices(Type serviceType)
           {
               return new List<object>();
           }
   
           public IDependencyScope BeginScope()
           {
               return this;
           }
           
           public void Dispose()
           {
              
           }
       }
   }