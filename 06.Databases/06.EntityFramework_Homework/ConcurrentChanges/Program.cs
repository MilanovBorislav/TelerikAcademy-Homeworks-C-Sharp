using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northtwind.Data;


namespace ConcurrentChanges
{
    class Program
    {
        static void Main(string[] args)
        {
            using (NortwindEntities dbFirst = new NortwindEntities())
            {
                using (NortwindEntities dbSecond = new NortwindEntities())
                {
                    var reg1 = dbFirst.Regions.Find(4);
                    reg1.RegionDescription = "FirstChange";

                    var reg2 = dbSecond.Regions.Find(4);
                    reg2.RegionDescription = "SecondChange";


                    dbFirst.SaveChanges();
                    dbSecond.SaveChanges();
                }
            }
        }
    }
}
