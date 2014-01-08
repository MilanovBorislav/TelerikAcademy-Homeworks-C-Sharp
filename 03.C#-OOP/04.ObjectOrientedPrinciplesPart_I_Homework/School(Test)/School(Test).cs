using School.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Common;



namespace School_Test_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student's Class
            StudentClass someStudentClass = new StudentClass( "A234RT12" );

            //Teachers
            Teacher teacher1 = new Teacher( "Ivan Petcov" );
            Teacher teacher2 = new Teacher( "Angel Genchev" );
            Teacher teacher3 = new Teacher( "Atanas Georgiev" );

            //Students
            Student student1 = new Student( "Petar Stefanov", 4566544 );
            Student student2 = new Student( "Georgi Iliev", 4566546 );
            Student student3 = new Student( "Dragomir Hristov", 4566546 );
            Student student4 = new Student( "Dimitar Milanov", 4566546 );

            //Disciplines
            Discipline disciplinePHP = new Discipline( "PHP", 12, 23 );
            Discipline disciplineJava = new Discipline( "Java", 8, 18 );
            Discipline disciplineCSharp = new Discipline( "C Sharp", 25, 32 );
            Discipline disciplineJavaScript = new Discipline( "JavaScript", 17, 23 );
            Discipline disciplineCpp = new Discipline( "C++", 17, 23 );
            Discipline disciplineObjectiveC = new Discipline( "Objective C", 17, 23 );

            //Fill list of teachers in the Student Class
            someStudentClass.AddTeacher( teacher1 );
            someStudentClass.AddTeacher( teacher2 );
            someStudentClass.AddTeacher( teacher3 );

            //Fill teacher disciplines
            teacher1.AddDiscipline( disciplineJava );
            teacher1.AddDiscipline( disciplineCpp );
            teacher1.AddDiscipline( disciplineObjectiveC );

            teacher2.AddDiscipline( disciplineCpp );
            teacher2.AddDiscipline( disciplineObjectiveC );
            teacher2.AddDiscipline( disciplinePHP );

            teacher3.AddDiscipline( disciplineCSharp );
            teacher3.AddDiscipline( disciplineJavaScript );


            someStudentClass.ShowTeachers();
            teacher1.ShowTeachersDiscipline();
            teacher2.ShowTeachersDiscipline();
            teacher3.ShowTeachersDiscipline();

            //Add comments for teacher
            teacher1.AddComment( "Comment for teacher" );
            teacher1.AddComment( "Comment for teacher" );
            teacher1.AddComment( "Comment for teacher" );
            teacher1.AddComment( "Comment for teacher" );

            teacher1.ShowComments();

            //Add comments for discipline
            disciplineCSharp.AddComment( "Comment for C Sharp" );
            disciplineCSharp.AddComment( "Comment for C Sharp" );
            disciplineCSharp.AddComment( "Comment for C Sharp" );
            disciplineCSharp.AddComment( "Comment for C Sharp" );
            disciplineCSharp.ShowComments();

        }       
    }
}
