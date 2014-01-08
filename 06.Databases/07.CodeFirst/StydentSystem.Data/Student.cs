using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace StydentSystem.Data
{
    public class Student
    {
        private ICollection<Course> _courses;
        private ICollection<Homework> _homeworks;

        [Key]
        public int StudentId { get; set; }

        [Required]
        public string StudentName { get; set; }

        public int StudentNumber { get; set; }

        public Student()
        {
            this._courses = new HashSet<Course>();
        }

        public virtual ICollection<Homework> Homeworks
        {
            get { return _homeworks; }
            set { _homeworks = value; }
        }

        public virtual ICollection<Course> Courses
        {
            get { return this._courses; }
            set { this._courses = value; }
        }
    }
}
