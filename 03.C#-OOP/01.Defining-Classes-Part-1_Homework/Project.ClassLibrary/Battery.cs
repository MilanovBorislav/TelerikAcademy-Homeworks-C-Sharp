using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ClassLibrary
{
    public enum BatteryType
    {
        LiIon,
        NiMH,
        NiCd
    };

    public class Battery
    {
        private string bateryModel;
        public string BateryModel
        {
            get { return this.bateryModel; }
            set { this.bateryModel = value; }
        }

        private double hoursIdle;
        public double HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }

        private double hoursTalk;
        public double HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }


        public BatteryType BatType { get; set; }




        public Battery(string bateryModel, double hoursIdle, double hoursTalk, BatteryType somebatType)
        {
            this.BateryModel = bateryModel;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatType = somebatType;
        }

        public Battery()
            : this( null, 0, 0, new BatteryType() )
        {

        }

    }
}
