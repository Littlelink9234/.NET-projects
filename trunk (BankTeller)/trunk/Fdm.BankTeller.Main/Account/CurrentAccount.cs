using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fdm.BankTeller.Main
{
    public class CurrentAccount : Account
    {
        private decimal overdraft;
        private static readonly String INSUFFICIENT_AMOUNT = "Error: Insufficient amount.";
        private static readonly String INSUFFICIENT_DRAFT = "Error: You have exceeded your overdraft limit.";


        public void load(string accountName, decimal balance, int accountNumber, decimal overdraft)
        {
            setAccountName(accountName);
            setBalance(balance);
            setAccountNumber(accountNumber);
            setOverdraft(overdraft);
        }

        public decimal getOverdraft
        {
            get { return overdraft; }
        }

        public void setOverdraft(decimal overdraft)
        {
            this.overdraft = overdraft;
        }

        public override decimal withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new BankException(INSUFFICIENT_AMOUNT);
            }
            else if (amount > (overdraft + base.getBalance))
            {
                throw new BankException(INSUFFICIENT_DRAFT);
            }
            else if (base.getBalance + overdraft >= amount)
            {
                base.setBalance(base.getBalance - amount);
            }
            return base.getBalance;
        }
    }
}
