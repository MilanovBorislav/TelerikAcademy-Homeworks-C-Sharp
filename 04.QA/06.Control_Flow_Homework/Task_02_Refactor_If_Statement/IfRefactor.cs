using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_Refactor_If_Statement
{
    class IfRefactor
    {
        static void Main(string[] args)
        {
            if (potato != null)
            {
                if (!(potato.NotPeeled) && !(potato.IsRotten))
                {
                    Cook(potato);
                }
            }

            bool isYBetweenMaxMin = MAX_Y >= y && MIN_Y <= y;
            bool isXBetweenMaxMin = MAX_X >= x && MIN_X <= x;
            bool shouldVisitCell = true;

            if ( isXBetweenMaxMin && isYBetweenMaxMin && shouldVisitCell)
            {
                VisitCell();
            }
        }
    }
}
