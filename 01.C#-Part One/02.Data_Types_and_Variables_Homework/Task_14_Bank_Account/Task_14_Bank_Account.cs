
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_Bank_Account
    {
    class Task_14_Bank_Account
        {
        static void Main ()
            {
            //A bank account has a holder name (first name, middle name and last name), available
            //amount of money (balance), bank name, IBAN, BIC code and 3 credit card numbers associated
            //with the account. Declare the variables needed to keep the information for a single bank 
            //account using the appropriate data types and descriptive names.
            
            string holderName = "Ivan Petrov Angelov";
            decimal moneyBalnce = 78987m;
            string bankName = "First Investmant Bank";
            string numberIBAN = "39 FINV 9150 1003 5487 97";
            string codeBIC = "IORTBGSF";
            long firstCardNumber = 3088000000000009;
            ulong secondCardNumber = 3088000000000015;
            ulong thirdCardNumber = 3088000000000048;
            Console.WriteLine("Holder Name:          {0}",holderName );
            Console.WriteLine("Balance:              {0}",moneyBalnce);
            Console.WriteLine("Bank Name:            {0}",bankName);
            Console.WriteLine("IBAN:                 {0}",numberIBAN);
            Console.WriteLine("BIC:                  {0}",codeBIC );
            Console.WriteLine("Credit Card 1:        {0}", firstCardNumber );
            Console.WriteLine("Credit Card 2:        {0}", secondCardNumber );
            Console.WriteLine("Credit Card 3:        {0}", thirdCardNumber );
            }
        }
    }
