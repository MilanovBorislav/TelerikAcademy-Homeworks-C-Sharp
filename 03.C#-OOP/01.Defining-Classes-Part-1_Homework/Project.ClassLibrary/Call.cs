using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ClassLibrary
{
    public class Call
    {
        private string date;

        internal string Date
        {
            get { return date; }
            set { date = value; }
        }



        private string time;

        internal string Time
        {
            get { return time; }
            set { time = value; }
        }


        private int dealedPhone;

        internal int DealedPhone
        {
            get { return dealedPhone; }
            set { dealedPhone = value; }
        }


        private int duration;

        internal int Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public Call(string date, string time, int dealedphone, int duration)
        {
            this.Date = date;
            this.Time = time;
            this.DealedPhone = dealedphone;
            this.Duration = duration;
        }

        public Call()
            : this( "", "", 0, 0 )
        {

        }
        internal string ShowCall()
        {
            return string.Format(

@"Date :            {0}
Time:             {1} 
Dealed Phone:    +359 {2} 
Duration:         {3} sec
",
         this.Date.ToString(),
         this.Time,
         this.DealedPhone,
         this.Duration );
        }



    }
}
