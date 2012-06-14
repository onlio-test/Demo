
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onlio.Demo.BankAccount
{

    public static class Program
    {

        internal static void Main(string[] args)
        {
            try
            {
                var creditAccount = GetBankAccount("Mr. Bryan Walton");
                creditAccount.Credit(5.73);
                creditAccount.Debit(11.21);

                var debitAccount = GetBankAccount("Ms. Shelly Smith");
                TransferMoney(debitAccount, creditAccount, 6.51);

                Console.WriteLine("Current balance is ${0}", creditAccount.Balance);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public static BankAccount GetBankAccount(string customerName)
        {
            var result = new BankAccount(customerName);
            result.Balance = GetBalance(customerName);
            return result;
        }

        public static void TransferMoney(BankAccount debitAccount, BankAccount creditAccount, double amount)
        {
            try
            {
                debitAccount.Debit(amount);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                throw new ArgumentException("Insufficient balance.", ex);
            }
            creditAccount.Credit(amount);
        }


        private static double GetBalance(string customerName)
        {
            switch (customerName)
            {
            case "Mr. Bryan Walton": return 11.99;
            case "Ms. Shelly Smith": return 6.50;
            default: return 0.0;
            }
        }
    
    }//end Program

}//end Onlio.Demo.BankAccount
