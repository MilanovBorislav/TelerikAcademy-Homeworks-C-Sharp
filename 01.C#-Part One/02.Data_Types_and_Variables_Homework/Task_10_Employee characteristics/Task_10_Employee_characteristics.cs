using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_Employee_characteristics
    {
    class Task_10_Employee_characteristics
        {
        static void Main ()
            {
            //A marketing firm wants to keep record of its employees. Each record would have the following characteristics –
            //first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999). Declare
            //the variables needed to keep the information for a single employee using appropriate data types and descriptive names.

            string firstName = "Ivan";
            string lastName = "Nikolov";
            byte age = 34;
            char gender = 'm';
            int numberID = 123434334;
            int numberEployee = 27569999;
            Console.WriteLine("First Name        {0}",firstName );
            Console.WriteLine("Last Name         {0}", lastName );
            Console.WriteLine("Age               {0}",age );
            Console.WriteLine("Gender            {0}", gender );
            Console.WriteLine("Id                {0}", numberID);
            Console.WriteLine("Emloyee Number    {0}", numberEployee);

            }
        }
    }
