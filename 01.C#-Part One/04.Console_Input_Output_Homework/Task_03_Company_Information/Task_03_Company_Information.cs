using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_Company_Information
{
    class Task_03_Company_Information
    {
        static void Main()
        {
            //A company has name, address, phone number, fax number, web site and manager.
            //The manager has first name, last name, age and a phone number. Write a program 
            //that reads the information about a company and its manager and prints them on the console.
            string  a = ":";
            Console.Write("Enter company name: ");
            string company = Console.ReadLine();
            Console.Write("Enter the address of the company: ");
            string address = Console.ReadLine();
            Console.Write("Enter the phone number of the company: ");
            string phone = Console.ReadLine();
            Console.Write("Enter the fax number of the company: ");
            string fax = Console.ReadLine();
            Console.Write("Enter the web site of the company: ");
            string website = Console.ReadLine();
            Console.Write("Enter the first name of manager of the company: ");
            string firstname = Console.ReadLine();
            Console.Write("Enter the last name of manager of the company: ");
            string lastname = Console.ReadLine();
            Console.Write("Enter the  age of manager of the company: ");
            sbyte age = sbyte.Parse(Console.ReadLine());
            Console.Write("Enter the phone number of manager of the company: ");
            string managerPhone = Console.ReadLine();
            Console.WriteLine("Company Name  {0,-20}|{1,1} ",a ,company);
            Console.WriteLine("Address       {0,-20}|{1,1} ", a, address);
            Console.WriteLine("Company Phone {0,-20}|{1,1} ", a, phone);
            Console.WriteLine("Company Fax   {0,-20}|{1,1} ", a, fax);
            Console.WriteLine("Website       {0,-20}|{1,1} ", a, website);
            Console.WriteLine("Manager       {0,-20}|{1,1}{2,1} ", a, lastname,firstname);
            Console.WriteLine("Manager Age   {0,-20}|{1,1} ", a, age);
            Console.WriteLine("Manager Phone {0,-20}|{1,1} ", a, managerPhone);
        }
    }
}
