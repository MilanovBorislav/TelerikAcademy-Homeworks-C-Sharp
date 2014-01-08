using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModelSystem.Common.Accounts
{
    public class MortgageAccount:Account, IDepositable
    {
        public MortgageAccount(Customer customerType, decimal balance, decimal interestRate) : base( customerType, balance, interestRate ) { }

        public override decimal CalculateInterestAmount(int numberOfMonths)
        {
            if( this.CustomerType == Customer.Individual )
            {
                if(  numberOfMonths <=6 )
                {
                    return 0;
                }
                else
                {
                    decimal othetSum = 0;

                    for( int i = 0; i < numberOfMonths - 6; i++ )
                    {
                        othetSum = (othetSum + (this.InterestRate / 10));
                    }
                    return (othetSum) * -10;
                } 
            }
            else
            {
                if( numberOfMonths <= 12 )
                {
                    decimal sum = 0;

                    for( int i = 0; i < numberOfMonths; i++ )
                    {
                        sum = sum + ((this.InterestRate / 2) / 10);
                    }
                    return sum * -1;
                }
                else
                {
                    decimal sum = 0;
                    for( int i = 0; i < 12; i++ )
                    {
                        sum = sum + ((this.InterestRate / 2) / 10);
                    }

                    decimal othetSum = 0;

                    for( int i = 0; i < numberOfMonths - 12; i++ )
                    {
                        othetSum = othetSum + (this.InterestRate / 10);
                    }
                    return (sum + othetSum) * -1;
                }
            }
        }


        public decimal DepositMoney(decimal money)
        {
            this.Balance = this.Balance + money;
            return this.Balance;
        }
    }
}
