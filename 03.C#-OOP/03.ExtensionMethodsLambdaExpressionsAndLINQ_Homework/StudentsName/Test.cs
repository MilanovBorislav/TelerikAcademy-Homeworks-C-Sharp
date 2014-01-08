using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsNameAge
{

    class Test
    {
        public static void ShowResult(dynamic elementList)
        {
            foreach( var item in elementList )
            {
                Console.WriteLine( item );
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Student[] studentsArray = {

                 new Student("Pesho","Ivanov",22),
                 new Student("Ivan","Angelov",19),
                 new Student("Angel","Penchev",25),
                 new Student("Grigor","Georgiev",17),
                 new Student("Georgi","Nikolov",20),
                new Student ("Angel","Marinov",26)
                                     };

            var sudentsNameFirsNameBeforeLastName =
                from student in studentsArray
                where student.FirstName.CompareTo( student.LastName ) == -1
                select student;

            Console.WriteLine( "First name before last name" );
            Console.WriteLine();
       
            ShowResult( sudentsNameFirsNameBeforeLastName );

            var sudentAgeBetween_18_24 =
                from student in studentsArray
                where student.Age > 17
                where student.Age < 25
                select student;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine( "Student between 18 and 24 years old" );
            Console.WriteLine();

            ShowResult( sudentAgeBetween_18_24 );


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var sortedStudentsName = 
                studentsArray.OrderByDescending( x => x.FirstName ).ThenByDescending(x=>x.LastName);

            Console.WriteLine("Sorted names");
            Console.WriteLine();

            Console.WriteLine("Lambda");
            ShowResult( sortedStudentsName );

            Console.WriteLine();
            Console.WriteLine();

            var sortedStudentsNameLINQ =
                from student in studentsArray
                orderby student.FirstName descending, student.LastName descending
                select student;

            Console.WriteLine( "LINQ" );
            ShowResult( sortedStudentsNameLINQ );

        }
    }
}
