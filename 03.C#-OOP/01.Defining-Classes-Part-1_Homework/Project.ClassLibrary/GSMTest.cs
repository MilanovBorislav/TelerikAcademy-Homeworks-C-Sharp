
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ClassLibrary
{
    public class GSMTest
    {
        public static void ShowInfo()
        {

            GSM[] gsm = new GSM[3]
            {
              new GSM("Samsung", "7878G", 123, "Pesho",23.6,3.2,65536,2.6,BatteryType.NiCd),
              new GSM("Nokia", "1532", 200, "Gosho",12.6,2.1,65536,4.1,BatteryType.LiIon),
              new GSM("Alcatel", "6732", 200, "Gosho",13,3.4,65536,3.2,BatteryType.NiMH), 
         
            };


            foreach( var item in gsm )
            {
                Console.WriteLine( item.ToString() );
            }

            GSM someIphone = GSM.IPhone4S;
            someIphone.Owner = "Misho";
            Console.WriteLine( someIphone.ToString() );    
        }
    }
}
