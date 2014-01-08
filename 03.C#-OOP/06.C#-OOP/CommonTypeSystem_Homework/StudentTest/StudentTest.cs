using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentClassLibrary;
using StudentClassLibrary.Enumerations;

namespace StudentTest
{
    class StudentTest
    {
        static void Main(string[] args)
        {
            Student someStudent1 = new Student("Ivo", "Minchev", "Penchev", "0888-988-547", "4 Main street", "IvoMinchev@gmail.com", 
                78154, University.Oxford,Faculty.Chemistry, Specialty.OrganicChemistry);

            Student someStudent2 = new Student("Ivo", "Minchev", "Penchev", "0888-988-547", "4 Main street", "IvoMinchev@gmail.com",
                78154, University.Oxford, Faculty.Chemistry, Specialty.OrganicChemistry);

            Student someStudent3 = new Student("Ivailo", "Minchev", "Penchev", "0888-988-547", "4 Main street", "IvoMinchev@gmail.com",
               78154, University.Oxford, Faculty.Chemistry, Specialty.OrganicChemistry);


            Console.WriteLine("First student Equals(second student)   :   {0}", someStudent1.Equals(someStudent2));
            Console.WriteLine("First student == second student  :   {0}", someStudent1 == someStudent2);
            Console.WriteLine("First student != third student  :   {0}", someStudent1 != someStudent3);
            Console.WriteLine("Student1 GetHashCode() : {0}", someStudent1.GetHashCode());
            Console.WriteLine("Student2 GetHashCode() : {0}", someStudent2.GetHashCode());
            Console.WriteLine("Student3 GetHashCode() : {0}", someStudent3.GetHashCode());

            Student strudent = someStudent1.Clone();
            Console.WriteLine(strudent);

//             someStudent1.FirstName = "Pencho";
//             Console.WriteLine(someStudent1.FirstName);//Clone test 

            List<Student> studentList = new List<Student>()
            {
                 new Student("Ivo", "Minchev", "Penchev",23455),   
                 new Student("Petar", "Genchev", "Ivanov",13455),   
                 new Student("Nedko", "Geshev", "Iliev",13955),   
                 new Student("Pesho", "Ivanov", "Geshev",29455),   
                 new Student("Nencho", "Minchev", "Kolev",73455),   
                 new Student("Atanas", "Mitkov", "Ionkov",63455),   
                 new Student("Atanas", "Mitkov", "Ionkov",12455),   
            };

            studentList.Sort();

            foreach (var student in studentList)
            {
                Console.WriteLine(student);
            }
        }
    }
}
