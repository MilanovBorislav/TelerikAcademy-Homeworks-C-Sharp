using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace StudentSystemDomainClasses
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public int Age { get; set; }

        public string Grade { get; set; }

        public int SchoolId { get; set; }

        public virtual School School { get; set; }

        public virtual ICollection<Mark>  Marks { get; set; }

        public Student()
        {
            Marks = new HashSet<Mark>();
        }
    }
}