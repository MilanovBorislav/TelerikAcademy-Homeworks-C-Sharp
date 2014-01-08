using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using StudentSystemDomainClasses;

namespace StudentSustemWebApi.Models
{
    public class StudentModel
    {
        public static Expression<Func<Student, StudentModel>> FromStudent
        {
            get
            {
                return x => new StudentModel
                {
                    StudentId = x.StudentId,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Age = x.Age, 
                    SchoolId = x.SchoolId,
                    Marks = x.Marks
                };
            }
        }

        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Grade { get; set; }

        public int? SchoolId { get; set; }

        public ICollection<Mark> Marks { get; set; }

    }
}