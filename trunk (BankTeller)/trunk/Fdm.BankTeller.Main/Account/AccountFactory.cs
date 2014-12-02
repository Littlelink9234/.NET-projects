using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fdm.BankTeller.Main
{
    public class AccountFactory
    {
        public static readonly String ACCOUNT_ERROR = "Error: Invalid Account Type";

        public Account createAccount(String accountType)
        {
            if (accountType == "Current")
            {
                return new CurrentAccount();
            }

            if (accountType == "Savings")
            {
                return new SavingsAccount();
            }
            else
                throw new BankException(ACCOUNT_ERROR);
        }
    }
}
