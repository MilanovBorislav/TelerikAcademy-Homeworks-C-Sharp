using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Http;
using StudentSustemWebApi.Models;
using StudentSystemDomainClasses;
using StudentSystemDataLayer;
using StudentSustemRepository;

namespace StudentSustemWebApi.Controllers
{
    public class StudentController : ApiController
    {
        private readonly StudentRepository _repository;

        public StudentController(IRepository<Student> studentRepository)
        {
            this._repository = (StudentRepository)studentRepository;
        }

        // GET api/Student
        public IEnumerable<StudentModel> GetStudents()
        {
            var list = _repository.All();
            return list.Select(StudentModel.FromStudent);
        }

        // GET api/Student/5
        public StudentModel GetStudent(int id)
        {
            var student = _repository.Get(id);
            var newStudent = new StudentModel
            {
                StudentId = student.StudentId,
                FirstName = student.FirstName,
                LastName = student.LastName,
                Age = student.Age,
                SchoolId = student.SchoolId,
                Marks = student.Marks
            };
            return newStudent;
        }

        public IEnumerable<Student> GetStudentBySubjectAndMark(string subject, int value)
        {
            var list = _repository.GetStudentsWithMarkGreaterThan(subject, value);
            //return list.Select<IEnumerable<StudentModel>>(StudentModel.FromStudent);
            return list;
        }

        // PUT api/Student/5
        public HttpResponseMessage PutStudent(int id, Student student)
        {
            _repository.Update(id, student);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // POST api/Student
        public HttpResponseMessage PostStudent(Student student)
        {
            if (ModelState.IsValid)
            {

                _repository.Add(student);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, student);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = student.StudentId }));
                return response;
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        // PUT api/Student/5/AddMark
        [ActionName("AddMark")]
        public HttpResponseMessage PutSongToAlbum(int id, Mark mark)
        {
            var db = new StudentSystemContext();
            try
            {
                var searchedStudent = db.Students.Find(id);
                searchedStudent.Marks.Add(mark);
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // DELETE api/Student/5
        public HttpResponseMessage DeleteStudent(int id)
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
    }
}