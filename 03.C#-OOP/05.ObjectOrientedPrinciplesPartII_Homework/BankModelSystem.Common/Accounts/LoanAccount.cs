using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModelSystem.Common.Accounts
{
    public class LoanAccount:Account,IDepositable
    {
        public LoanAccount(Customer customerType, decimal balance, decimal interestRate):base(customerType,balance,interestRate) { }

        public override decimal CalculateInterestAmount(int numberOfMonths)
        {
            if( this.CustomerType == Customer.Individual )
            {              
                return (this.Balance * (numberOfMonths-3)* this.InterestRate) / (numberOfMonths * 100);                  
            }
            else
            {
                return (this.Balance * (numberOfMonths - 2) * this.InterestRate) / (numberOfMonths * 100);
            }
        }

        public decimal DepositMoney(decimal money)
        {
            this.Balance = this.Balance + money;
            return this.Balance;
        }
    }
}
