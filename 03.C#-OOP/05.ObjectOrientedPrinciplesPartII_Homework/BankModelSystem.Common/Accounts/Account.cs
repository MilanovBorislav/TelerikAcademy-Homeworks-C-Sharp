using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankModelSystem.Common;
using BankModelSystem.Common.Interfaces;

namespace BankModelSystem.Common.Accounts
{
    public abstract class Account: ICalculatable
    { 
      // private string customer;
       private decimal balance=0;
       private decimal interestRate;
      


        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            private  set
            {
                this.interestRate = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public Customer CustomerType { get; set; }

   
        public Account(Customer customerType, decimal balance, decimal interestRate)
        {
            this.CustomerType = customerType;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public abstract decimal CalculateInterestAmount(int numberOfMonths);
    }
}
