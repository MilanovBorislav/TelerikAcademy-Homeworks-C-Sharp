using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelerikAcademy.Data;
using System.Diagnostics;
namespace TelerikAcademy.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new TelerikAcademyEntities())
            {

                //Task 1
                var watch1 = new Stopwatch();
                watch1.Start();
                foreach (var employee in db.Employees)
                {
                    //                     Console.WriteLine(employee.FirstName + ": " +
                    //                         employee.Department.Name + ", " +
                    //                         employee.Address.Town.Name);
                }
                watch1.Stop();
                var withoutInclude = watch1.Elapsed;

                var watch2 = new Stopwatch();
                watch2.Start();
                foreach (var employee in db.Employees.
                    Include("Department").
                    Include("Address"))
                {
                    //                     Console.WriteLine(employee.FirstName + ": " +
                    //                         employee.Department.Name + ", " +
                    //                         employee.Address.Town.Name);
                }
                watch2.Stop();
                var withInclude = watch2.Elapsed;
                Console.WriteLine("Time without Include    {0}", withoutInclude);
                Console.WriteLine("Time with Include       {0}", withInclude);

                //Task 2  

                IEnumerable query = db.Employees.ToList()
               .Select(x => x.Address).ToList()
               .Select(t => t.Town).ToList()
               .Where(t => t.Name == "Sofia");

                foreach (var t in query)
                {
                    Console.WriteLine(t);
                } 

                IEnumerable querySmart = db.Employees
                   .Select(x => x.Address)
                   .Select(t => t.Town)
                   .Where(t => t.Name == "Sofia").ToList();

                foreach (var t in querySmart)
                {
                    Console.WriteLine(t);
                } 
            }
        }
    }
}
