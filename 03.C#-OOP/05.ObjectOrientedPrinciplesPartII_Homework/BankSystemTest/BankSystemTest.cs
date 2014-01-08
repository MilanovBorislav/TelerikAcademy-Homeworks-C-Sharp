using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankModelSystem.Common.Accounts;
using BankModelSystem.Common;

namespace BankSystemTest
{
    class BankSystemTest
    {
        static void Main(string[] args)
        {
            DepositAccount depositAccout = new DepositAccount( Customer.Individual, 0, 7 );
            depositAccout.DepositMoney( 8400 );
            Console.WriteLine("Money in deposit account {0}",depositAccout.Balance);
            depositAccout.DrowMoney( 2000 );
            Console.WriteLine( "Money in deposit account {0}", depositAccout.Balance );
            depositAccout.Balance = 10000;
            Console.WriteLine("Interest amout for 6 months {0}",depositAccout.CalculateInterestAmount(6));
            LoanAccount loanAccount = new LoanAccount( Customer.Companie, -5600, 14 );
            Console.WriteLine("Loan account balanse {0}",loanAccount.Balance);
            loanAccount.DepositMoney( 780 );
            Console.WriteLine("Loan account after deposit  {0}",loanAccount.Balance);
            Console.WriteLine("Intrest amount for 26 loan accout {0:0.00}", loanAccount.CalculateInterestAmount(26));
            MortgageAccount mortgageAccount = new MortgageAccount(Customer.Individual,-8900,14);
            Console.WriteLine("Mortgage account balance {0}",mortgageAccount.Balance);
            mortgageAccount.DepositMoney( 1600 );
            Console.WriteLine( "Mortgage  account after deposit  {0}", mortgageAccount.Balance );
            Console.WriteLine( "Intrest amount for 56 loan accout {0:0.00}", mortgageAccount.CalculateInterestAmount( 56 ) );
        }

    }             
}
