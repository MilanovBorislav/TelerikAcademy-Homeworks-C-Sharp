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
    public class Course
    {

        private ICollection<Student> _students;
        private ICollection<Homework> _homeworks;

        [Key]
        public int CourseId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Materials { get; set; }

        public Course()
        {
            this._students = new HashSet<Student>();
            this._homeworks = new Collection<Homework>();
        }

        public virtual ICollection<Student> Students
        {
            get { return _students; }
            set { _students = value; }
        }

        public virtual ICollection<Homework> Homeworks
        {
            get { return _homeworks; }
            set { _homeworks = value; }
        }
    }
}
