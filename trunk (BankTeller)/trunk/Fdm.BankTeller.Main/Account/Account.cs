using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fdm.BankTeller.Main
{
    public abstract class Account
    {
        private static readonly string INVALID_TEXT = "Invalid deposit amount.";
        private static readonly string INSUFFICIENT_AMOUNT = "Error: Insufficient amount.";
        private static readonly string INSUFFICIENT_FUNDS = "Error: Insufficient funds.";
        private string accountName;
        private decimal balance;
        private int accountNumber;

        public string getAccountName
        {
            get { return accountName; }
        }

        public decimal getBalance
        {
            get { return balance; }
        }

        public int getAccountNumber
        {
            get { return accountNumber; }
        }

        public void setBalance(decimal balance)
        {
            this.balance = balance;
        }

        public void setAccountName(string accountName)
        {
            this.accountName = accountName;
        }

        public void setAccountNumber(int accountNumber)
        {
            this.accountNumber = accountNumber;
        }

        public decimal deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new BankException(INVALID_TEXT);
            }
            else
            {
                this.balance = this.balance + amount;
            }
            return this.balance;
        }

        public virtual decimal withdraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new BankException(INSUFFICIENT_AMOUNT);
            }
            else if (amount > this.balance)
            {
                throw new BankException(INSUFFICIENT_FUNDS);
            }
            else
            {
                balance = balance - amount;
            }
            return balance;
        }
    }
}
