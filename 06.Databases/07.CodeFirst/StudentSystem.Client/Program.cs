using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSustem.DataAccess;
using StudentSustem.DataAccess.Migrations;
using StydentSystem.Data;
using System.Data.Entity;



namespace StudentSystem.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSustemContext, Configuration>());

            using (var db = new StudentSustemContext())
            {
                var student1 = new Student()
                {
                    StudentName = "Mitko Peshev",
                    StudentNumber = 289323
                };
                var student2 = new Student()
                {
                    StudentName = "Student Name 2",
                    StudentNumber = 289323
                };
                var course = new Course()
                    {
                        Name = "Some Course",
                        Description = "Some Discription",
                    };

                course.Students.Add(student1);
                course.Students.Add(student2);


                db.Courses.Add(course);
                db.SaveChanges();

                foreach (var item in db.Courses)
                {
                    Console.WriteLine("Name: {0}, \nDescription: {1}, \nMaterials: {2}\n\n",
                        item.Name, item.Description, item.Materials);
                }

                foreach (var item in db.Students)
                {
                    Console.WriteLine("ID: {0}, Name: {1}", item.StudentId, item.StudentName);
                }
            }
        }
    }
}
