using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fdm.BankTeller.Main
{
    public class StorageCollection : IStorage
    {
        private static IDictionary<int, Account> accountStorage = new Dictionary<int,Account>();
        private static readonly string INVALID_ACCOUNT = "Error - Wrong account number has been entered.";
        private static readonly string NON_EXIST = "Error - account doesn't exist.";

        public void createAccount(Account account)
        {
            accountStorage.Add(account.getAccountNumber, account);
        }

        public Account readAccount(int AccountNumber)
        {
            try
            {
                return accountStorage[AccountNumber];
            }
            catch (KeyNotFoundException)
            {
                throw new BankException(INVALID_ACCOUNT);
            }
        }

        public void updateAccount(int accountNumber, decimal amount)
        {
            Account account = accountStorage[accountNumber];
            account.setBalance(amount);
            accountStorage[accountNumber] = account;
        }

        public void deleteAccount(int AccountNumber)
        {
            try
            {
                accountStorage.Remove(AccountNumber);
            }
            catch (InvalidOperationException)
            {
                throw new BankException(NON_EXIST);
            }
        }

        public IList<AccountOutput> viewAllAccounts()
        {
            IList<AccountOutput> accOutputs = new List<AccountOutput>();
            foreach (KeyValuePair<int, Account> account in accountStorage)
            {
                accOutputs.Add(AccountOutputHelper(account.Value));
            }
            return accOutputs;
        }

        private AccountOutput AccountOutputHelper(Account account)
        {
            decimal overdraft = 0.00m;

            if (account is CurrentAccount)
            {
                CurrentAccount tempAccount = (CurrentAccount)account;
                overdraft = tempAccount.getOverdraft;

                return new AccountOutput(account.getAccountName, account.getBalance.ToString(), account.getAccountNumber.ToString(),
                "Current Account", overdraft.ToString());
            }
            else
            {
                SavingsAccount tempAccount = (SavingsAccount)account;
                return new AccountOutput(account.getAccountName, account.getBalance.ToString(), account.getAccountNumber.ToString(),
                    "Savings Account", overdraft.ToString());
            }
        }
    }
}
