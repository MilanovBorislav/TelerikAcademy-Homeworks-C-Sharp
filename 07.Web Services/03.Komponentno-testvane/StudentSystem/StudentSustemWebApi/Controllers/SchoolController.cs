using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using StudentSustemRepository;
using StudentSystemDomainClasses;
using StudentSystemDataLayer;

namespace StudentSustemWebApi.Controllers
{
    public class SchoolController : ApiController
    {
        private StudentSystemContext db = new StudentSystemContext();

        private readonly SchoolRepository _repository;

        public SchoolController(IRepository<School> schoolRepository)
        {
            this._repository = (SchoolRepository)schoolRepository;
        }

        // GET api/School
        public IEnumerable<School> GetSchools()
        {
            return _repository.All();
        }

        // GET api/School/5
        public School GetSchool(int id)
        {
            var school = _repository.Get(id);
            return school;
        }

        // PUT api/School/5
        public HttpResponseMessage PutSchool(int id, School school)
        {
            _repository.Update(id, school);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // POST api/School
        public HttpResponseMessage PostSchool(School school)
        {
            if (ModelState.IsValid)
            {
                _repository.Add(school);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, school);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = school.SchoolId }));
                return response;
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        // DELETE api/School/5
        public HttpResponseMessage DeleteSchool(int id)
        {
            try
            {
                _repository.Delete(id);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}