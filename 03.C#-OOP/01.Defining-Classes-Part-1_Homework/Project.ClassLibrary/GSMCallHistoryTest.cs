using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ClassLibrary
{
    public class GSMCallHistoryTest
    {
        private const double priceCallPerMinute = 0.37;

        public static void TestCallHistory()
        {
            GSM myGSM = new GSM( "3310", "Nokia" );

            Call someGsmCall1 = new Call( "15.02.2003", "18:30", 898789, 123 );
            Call someGsmCall2 = new Call( "18.12.2004", "8:30", 544564, 73 );
            Call someGsmCall3 = new Call( "05.02.2007", "10:30", 6546, 54 );
            Call someGsmCall4 = new Call( "05.02.2007", "10:30", 6546, 145);
            Call someGsmCall5 = new Call( "05.02.2007", "10:30", 6546, 201);
            Call someGsmCall6 = new Call( "05.02.2007", "10:30", 6546, 12 );

            myGSM.CallHistory.Add( someGsmCall1 );
            myGSM.CallHistory.Add( someGsmCall2 );
            myGSM.CallHistory.Add( someGsmCall3 );
            myGSM.CallHistory.Add( someGsmCall4 );
            myGSM.CallHistory.Add( someGsmCall5);
            myGSM.CallHistory.Add( someGsmCall6 );

            

            myGSM.RemoveCall();
            
            myGSM.ShowCallHistory();

            Console.WriteLine( "Total price of calls is {0:0.00} $", myGSM.ShowTotalPrice( priceCallPerMinute ) );

            myGSM.RemoveMostExpensiveCall();

            Console.WriteLine( "Total price of calls without longest call {0:0.00} $", myGSM.ShowTotalPrice( priceCallPerMinute ) );

            myGSM.ClearCallHistory();

            myGSM.ShowCallHistory();
        }
    }
}
