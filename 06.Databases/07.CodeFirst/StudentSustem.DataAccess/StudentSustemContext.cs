using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using StydentSystem.Data;

namespace StudentSustem.DataAccess
{
    public class StudentSustemContext : DbContext
    {
        public StudentSustemContext()
            : base("SudentSystemDB")
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
