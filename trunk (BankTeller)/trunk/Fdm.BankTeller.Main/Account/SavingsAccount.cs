using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fdm.BankTeller.Main
{
    public class SavingsAccount : Account
    {
        private readonly decimal INTEREST_RATE = 0.05m;

        public void load(string accountName, decimal balance, int accountNumber)
        {
            setAccountName(accountName);
            setBalance(balance);
            setAccountNumber(accountNumber);
        }

        public decimal addInterest(decimal balance)
        {
            base.setBalance(base.getBalance + (base.getBalance * INTEREST_RATE));

            return base.getBalance;
        }
    }
}
