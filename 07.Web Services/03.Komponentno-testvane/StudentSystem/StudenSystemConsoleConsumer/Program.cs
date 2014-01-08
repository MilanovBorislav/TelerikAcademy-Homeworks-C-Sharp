using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSystemDataLayer;
using StudentSystemDomainClasses;
using StudentSystemDataLayer.Migrations;

namespace StudenSystemConsoleConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemContext,StudentSystemDataLayer.Migrations.Configuration>());

            var db = new StudentSystemContext();
            #region school seed
            var student1 = new Student
            {
                FirstName = "Fists Name 1",
                LastName = "Last Name 1"
            };
            var student2 = new Student
            {
                FirstName = "Fists Name 2",
                LastName = "Last Name 2"
            };
            var student3= new Student
            {
                FirstName = "Fists Name 3",
                LastName = "Last Name 3"
            };
            var student4 = new Student
            {
                FirstName = "Fists Name 4",
                LastName = "Last Name 4"
            };
            var student5 = new Student
            {
                FirstName = "Fists Name 5",
                LastName = "Last Name 5"
            };
            student5.Marks.Add(new Mark{Subject = "ocenka",Value = 4});



            var school1 = new School
            {
                Name = "School Name 1",
            };



            school1.Students.Add(student1);
            school1.Students.Add(student2);
            school1.Students.Add(student3);
            school1.Students.Add(student4);
            school1.Students.Add(student5);


            db.Schools.Add(school1);
            db.SaveChanges();
            #endregion

            foreach (var school in db.Schools)
            {
                Console.WriteLine(school.Name);
                Console.WriteLine(school.Location);
            }

        }
    }
}
