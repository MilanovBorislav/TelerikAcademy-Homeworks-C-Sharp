using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ClassLibrary
{
    public class GSM
    {
        private string gsmModel;
        public string GSMModel
        {
            get { return this.gsmModel; }
            set { this.gsmModel = value; }
        }

        private string manifacturer;
        public string Manifacturer
        {
            get { return manifacturer; }
            set { manifacturer = value; }
        }

        private decimal price;
        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        private string owner;
        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public Battery Battery = new Battery();
        public Display Display = new Display();
        public Call Call = new Call();

        private List<Call> callHistory = new List<Call>();

        public List<Call> CallHistory
        {
            get { return callHistory; }
        }

       

        public List<Call> AddCall(Call someCall) 
        {
            this.CallHistory.Add( someCall );
            return callHistory;
        }

        public List<Call> RemoveCall()
        {
            this.CallHistory.RemoveAt(0);
            return callHistory;
        }

        public List<Call> ClearCallHistory()
        {
            this.CallHistory.Clear();
            return callHistory;
        }


        public List<Call> RemoveMostExpensiveCall()
        {
            List<Call> calllist = this.callHistory;
            int mostExpensive = 0;
            int index = 0;
            for( int i = 0; i < callHistory.Count; i++ )
            {
                if( mostExpensive<=callHistory[i].Duration )
                {
                    mostExpensive = callHistory[i].Duration;
                    index = i;
                }
            }

            callHistory.RemoveAt( index );

            return  calllist;
        }

        public double ShowTotalPrice(double pricePerMinute) 
        {
            double allCallsTime = 0;

            foreach( var item in this.CallHistory )
            {
                allCallsTime = allCallsTime + item.Duration;
            }

            double totalPrice = (allCallsTime / 60) * pricePerMinute;
            return totalPrice;
        }

        public void ShowCallHistory()
        {
            List<Call> calllist = this.callHistory;

            if( calllist.Count == 0 )
            {
                Console.WriteLine();
                Console.WriteLine("Call history is cleared");
            }
            else
            {
                Console.WriteLine( "{0} {1}", this.manifacturer, this.gsmModel );
                Console.WriteLine( "Call History" );
                Console.WriteLine();
                foreach( var item in calllist )
                {
                    Console.WriteLine( item.ShowCall() );
                }
            }
         
        }


        public GSM(string gsmModel, string manifacturer, decimal price, string owner, BatteryType someType)
        {
            this.GSMModel = gsmModel;
            this.Manifacturer = manifacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery.BatType = someType;
            this.callHistory = new List<Call>();
        }


        public GSM(string gsmModel, string manifacturer, decimal price,
            string owner, double hoursidle, double hourstalk, int dispColor, double dispSize, BatteryType someType,
                string calldate, string calltime, int dealedPhone, int callduration
            )
        {
            this.GSMModel = gsmModel;
            this.Manifacturer = manifacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery.HoursIdle = hoursidle;
            this.Battery.HoursTalk = hourstalk;
            this.Display.NumberOfColors = dispColor;
            this.Display.Size = dispSize;
            this.Battery.BatType = someType;
            this.Call.Date = calldate;
            this.Call.Time = calltime;
            this.Call.DealedPhone = dealedPhone;
            this.Call.Duration = callduration;
            this.callHistory = new List<Call>();
        }

        public GSM(string gsmModel, string manifacturer, decimal price,
            string owner, double hoursidle, double hourstalk, int dispColor, double dispSize, BatteryType someType)
        {
            this.GSMModel = gsmModel;
            this.Manifacturer = manifacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery.HoursIdle = hoursidle;
            this.Battery.HoursTalk = hourstalk;
            this.Display.NumberOfColors = dispColor;
            this.Display.Size = dispSize;
            this.Battery.BatType = someType;
            this.callHistory = new List<Call>();
        }

        public GSM(string gsmModel, string manifacturer,string calldate,string calltime,int dealedPhone,int callduration)
        {
            this.GSMModel = gsmModel;
            this.Manifacturer = manifacturer;
            this.Call.Date = calldate;
            this.Call.Time = calltime;
            this.Call.DealedPhone = dealedPhone;
            this.Call.Duration = callduration;
            this.callHistory = new List<Call>();
            
        }

     

        public GSM(string gsmModel, string manifacturer)
        {
            this.GSMModel = gsmModel;
            this.Manifacturer = manifacturer;
            this.callHistory = new List<Call>();
        }

        private static readonly GSM iPhone4S = new GSM( "IPhone 4S", "Apple" )
        {
            Price = 450,
            Display = new Display( 4.7, 787878 ),
            Battery = new Battery( "someModel", 45.2, 3.6, BatteryType.LiIon )
        };
 

    

        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }

        }

        public override string ToString()
        {
            return string.Format(
          @"GSM Mark :          {0}
GSM Model:          {1} 
GSM Price:          {2} $
GSM Owner:          {3}
GSM Battery Type:   {4}
GSM Hours Idle:     {5} h
GSM Hours Talk:     {6} h
GSM Display Size:   {7} inches
GSM Display Colors: {8}
",
                    this.Manifacturer,
                    this.gsmModel,
                    this.Price,
                    this.Owner,
                    this.Battery.BatType,
                    this.Battery.HoursIdle,
                    this.Battery.HoursTalk,
                    this.Display.Size,
                    this.Display.NumberOfColors );
        }
 
    }
}
