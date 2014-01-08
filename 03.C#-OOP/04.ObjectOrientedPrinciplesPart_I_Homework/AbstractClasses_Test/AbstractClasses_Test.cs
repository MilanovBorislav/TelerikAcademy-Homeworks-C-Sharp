using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractClasses.Common;
namespace AbstractClasses_Test
{
    class AbstractClasses_Test
    {
        public static void PrintInConsole(dynamic varCollection)
        {
            foreach (var variable in varCollection)
            {
                Console.WriteLine(variable);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>()
            {
                new Student ("Pesho","Stefanov",4),
                new Student ("Mincho","Pashov",6),
                new Student ("Yanko","Nikolov",3),
                new Student ("Dimitar","Geshev",2),
                new Student ("Mitko","Sotirov",4),
                new Student ("Ivo","Kalinov",5),
                new Student ("Atanas","Radev",3),
                new Student ("Gergi","Ivanov",3),
                new Student ("Ivan","Georgiev",6),
                new Student ("Valentin","Minchev",4),
            };

            var sortedStudent = studentList.OrderBy(student => student.Grade);
            //             var sortedStudent =
            //                 from student in studentArr
            //                 orderby student.Grade ascending
            //                 select student;
            PrintInConsole(sortedStudent);

            List<Worker> workerList = new List<Worker>()
            {
                new Worker ("Doncho","Stefanov",400,8),
                new Worker ("Petko","Kolev",520,4),
                new Worker ("Ilko","Hristov",150,4),
                new Worker ("Viktor","Peshev",440,8),
                new Worker ("Mitko","Sotirov",350,4),
                new Worker ("Kamen","Vodenicharov",420,6),
                new Worker ("Slavi","Trifonov",450,8),
                new Worker ("Dinko","Velev",390,6),
                new Worker ("Vladimir","Gerasimov",120,4),
                new Worker ("Dimitar","Iliev",130,4),
            };

            var sortedWorkers =
                from worker in workerList
                orderby worker.WorkHoursPerDay descending
                select worker;
            //var sortedWorkers = workerList.OrderByDescending(worker => worker.WorkHoursPerDay);

            PrintInConsole(sortedWorkers);

            Worker someWorker = new Worker("Pavel", "Dimov", 560, 8);
    
            Console.WriteLine("{0} money per hour {1}", someWorker, someWorker.MoneyPerHour());

            Console.WriteLine();

            List<Human> humanList = studentList.Concat<Human>(workerList).ToList();

            var sortedHumanList = humanList.OrderBy(human => human.FirstName).ThenBy(human => human.LastName);
            
            PrintInConsole(sortedHumanList);

        }
    }
}
