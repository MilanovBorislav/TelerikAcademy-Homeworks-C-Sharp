using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSystemDomainClasses;

namespace StudentSystemDataLayer
{
   public class StudentSystemContext:DbContext

    {
        public StudentSystemContext()
            : base("StudentSystemDb")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<School> Schools { get; set; }

//        protected override void OnModelCreating(DbModelBuilder modelBuilder)
//        {
//            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
////            .HasOptional(p => p.PreferredLanguage)
////                .WithMany()
////                .HasForeignKey(p => p.LanguageID);
//            modelBuilder.Entity<School>()
//                .HasOptional(p=>p.Students)
//                .WithMany()
//                .WillCascadeOnDelete(true);
//
//            //base.OnModelCreating(modelBuilder);
//        }
    }
}
