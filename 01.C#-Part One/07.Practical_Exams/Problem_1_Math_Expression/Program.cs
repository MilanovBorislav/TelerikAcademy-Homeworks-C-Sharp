using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;



namespace Problem_1_Math_Expression
{
    class Program
    {    //N, M and P
        static void Main(string[] args)
        {
            decimal N = 1;
            decimal M = 2;
            decimal P = 3;
            int mod =(int)M % 180;
            decimal result = (N * N + (1 / (M * P) + 1337)) /
             (N - 128.523123123M * P) +(decimal)Math.Sin(mod);
            Console.WriteLine("{0:0.000000}",result);
        }
    }
}
