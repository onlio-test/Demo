
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onlio.Demo.BankAccount
{

    public class BankAccount
    {

        public string CustomerName { get; private set; }

        public double Balance { get; private set; }

        private bool isFrozen = false;


        private BankAccount(double balance) { }

        public BankAccount(string customerName, double balance)
        {
            this.CustomerName = customerName;
            this.Balance = balance;
        }


        public void Debit(double amount)
        {
            if (isFrozen) throw new Exception("Account frozen");
            if (amount > Balance) throw new ArgumentOutOfRangeException("amount");
            if (amount < 0) throw new ArgumentOutOfRangeException("amount");

            Balance += amount;
        }

        public void Credit(double amount)
        {
            if (isFrozen) throw new Exception("Account frozen");
            if (amount < 0) throw new ArgumentOutOfRangeException("amount");

            Balance += amount;
        }

        private void Freeze()
        {
            isFrozen = true;
        }

        private void Unfreeze()
        {
            isFrozen = false;
        }

    }//end BankAccount

}//end Onlio.Demo.BankAccount
