using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Timer
{
   public static class TimerCl
    {
        public static Stopwatch measure = new Stopwatch();

        public static void MakeSomething(int t, TimerDel Method)
        {
            if( measure.ElapsedTicks > t * 1000000 )
            {
                Method();
                measure.Restart();
            }
        }

        public delegate void TimerDel();


    }
}
