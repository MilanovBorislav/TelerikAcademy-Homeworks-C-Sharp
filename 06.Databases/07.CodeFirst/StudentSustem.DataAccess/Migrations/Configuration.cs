namespace StudentSustem.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using StydentSystem.Data;

    public sealed class Configuration : DbMigrationsConfiguration<StudentSustem.DataAccess.StudentSustemContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(StudentSustemContext context)
        {

            context.Courses.AddOrUpdate(
                       new Course
                       {
                           Name = "PHP",
                           Description = "Agile Design Patterns in PHP",
                           Materials = "XAMPP instalation"
                       },
                       new Course
                       {
                           Name = "CSharp",
                           Description = "Object-Orinted-Programming",
                           Materials = "MSDN"
                       },
                       new Course
                       {
                           Name = "JavaScript",
                           Description = "Intro to Node JS",
                           Materials = "Node instalation"
                       }
                     );

            context.Homeworks.AddOrUpdate(
                new Homework
                {
                    Content = "Some Content for C# homework :-)",
                    TimeSent = DateTime.Now
                },
                new Homework
                {
                    Content = "Working with MongoBD",
                    TimeSent = DateTime.Now
                },
                new Homework
                {
                    Content = "Web forms validation",
                    TimeSent = DateTime.Now
                }
                );

            Random rng = new Random();
            for (int i = 0; i < 3; i++)
            {
                context.Students.AddOrUpdate(new Student
                {
                    StudentId = i,
                    StudentName = "Student Name " + (i.ToString()),
                    Homeworks = context.Homeworks.Take(rng.Next(0, 4)).ToList(),
                });
            }

            context.SaveChanges();

        }
    }
}
