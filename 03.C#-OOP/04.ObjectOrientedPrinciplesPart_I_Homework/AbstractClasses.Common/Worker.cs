using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.Common
{
     public class Worker:Human
    {
        private decimal weekSalary;

        public decimal WeekSalary
        {
            get { return weekSalary; }
            set { weekSalary = value; }
        }


        private byte workHoursPerDay;

        public byte WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set { workHoursPerDay = value; }
        }


        public Worker(string firstName, string lastName, decimal weekSalary, byte workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public decimal MoneyPerHour()
        {
            return (this.WeekSalary / this.WorkHoursPerDay)/5;
        }
        public override string ToString()
        {
            return string.Format(" {0}  {1}   {2}         work hours {3} selary {4} ", this.GetType().Name, this.FirstName, this.LastName, this.workHoursPerDay, this.WeekSalary);
        }
    }
}
