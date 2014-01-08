using System;
using System.IO;
using System.Linq;
using Wintellect.PowerCollections;

namespace StudentsOrder
{
    class Program
    {
        static OrderedMultiDictionary<string, Student> courses =
            new OrderedMultiDictionary<string, Student>(true);

        static string ShowStudents(string course)
        {
            var students = courses[course];
            return course +" : " +  string.Join("", students);
        }

        static void Main(string[] args)
        {
            var file = new StreamReader("../../students.txt");
            string line;

            while ((line = file.ReadLine()) != null)
            {
                string[]wordsOnCurrentLine = line.Split('|').Select(m => m.Trim()).ToArray();
                courses[wordsOnCurrentLine[2]].Add(new Student(wordsOnCurrentLine[0],
                    wordsOnCurrentLine[1]));
            }

            var cSharp = ShowStudents("C#");
            var sql = ShowStudents("SQL");
            var java = ShowStudents("Java");
            Console.WriteLine(cSharp);
            Console.WriteLine(sql);
            Console.WriteLine(java);
            Console.WriteLine();
            Console.WriteLine("Order Of OrderedMultiDictionary");
            Console.WriteLine();

            foreach (var course in courses)
            {
                Console.Write(course.Key+" : ");
                foreach (var student in course.Value)
                {
                    Console.Write(student.ToString());
                }
                Console.WriteLine();
            }
        }
       

    }
}