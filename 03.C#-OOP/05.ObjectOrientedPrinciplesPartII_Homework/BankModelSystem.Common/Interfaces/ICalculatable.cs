using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModelSystem.Common.Interfaces
{
    public interface  ICalculatable
    {
        decimal CalculateInterestAmount(int numberOfMonths);
    }
}
