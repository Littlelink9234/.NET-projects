using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fdm.BankTeller.Main
{
    public interface IStorage
    {
        void createAccount(Account account);
        void deleteAccount(int AccountNumber);
        Account readAccount(int AccountNumber);
        IList<AccountOutput> viewAllAccounts();
        void updateAccount(int accountNumber, decimal amount);
    }
}
