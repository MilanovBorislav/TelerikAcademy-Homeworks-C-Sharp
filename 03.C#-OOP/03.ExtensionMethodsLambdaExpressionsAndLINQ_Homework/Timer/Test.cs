using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class Test
    {
        static void Main(string[] args)
        {
            TimerCl.TimerDel Task = SayHello;
            TimerCl.measure.Start();
            while( true )
            {
                TimerCl.MakeSomething( 5, Task );
            }
        }

        public static void SayHello()
        {
            Console.WriteLine( "Hello" );
        }
       
    }
}
