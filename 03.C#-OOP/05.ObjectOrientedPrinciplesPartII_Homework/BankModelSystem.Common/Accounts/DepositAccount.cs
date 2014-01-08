using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankModelSystem.Common;
using BankModelSystem.Common.Interfaces;

namespace BankModelSystem.Common.Accounts
{
    public class DepositAccount:Account, IDrawable, IDepositable
    {
   
        public DepositAccount(Customer customerType, decimal balance, decimal interestRate) : base(customerType, balance, interestRate ) { }

        public override decimal CalculateInterestAmount(int numberOfMonths)
        {
            if( this.Balance <= 1000 )
            {
                return 0;
            }
            else
            {
               decimal sum = 0;

                for( int i = 0; i < numberOfMonths; i++ )
                {
                    sum = sum + ((this.InterestRate));
                }
                return sum;

            }     
        }

        public decimal DrowMoney(decimal money)
        {
            this.Balance = this.Balance - money;
            return this.Balance;
        }

        public decimal DepositMoney(decimal money)
        {
            this.Balance = this.Balance + money;
            return this.Balance;
        }
    }
}
