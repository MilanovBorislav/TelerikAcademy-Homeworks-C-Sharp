using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentSystemDomainClasses
{
    public class School
    {
        [Key]
        public  int SchoolId { get; set; }
        
        [Required]
        public string Name { get; set; }

        public string Location { get; set; }

        public virtual ICollection<Student> Students { get; set; }

        public School()
        {
           this.Students = new HashSet<Student>();
        }
    }
}