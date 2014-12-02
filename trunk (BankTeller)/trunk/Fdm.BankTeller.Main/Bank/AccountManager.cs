using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fdm.BankTeller.Main.Storage;

namespace Fdm.BankTeller.Main
{
    public class AccountManager
    {
        decimal emptyAccount = 0.00m;
        public static readonly string ZERO_BALANCE = "Balance must be zero in order to close the account.";
        public static readonly string TRANSACTION_ERROR = "Not a valid transaction.";
        private int accountNumber = 1;
        private IStorage vault;
        private AccountFactory factory; 

        public AccountManager(AccountFactory factory, IStorage vault)
        {
            this.factory = factory;
            this.vault = vault;
        }

        public AccountOutput CreateSavingsAccount(string accountName, decimal openingBalance)
        {

            Account account = factory.createAccount("Savings");

            SavingsAccount tempAccount = (SavingsAccount)account;
            tempAccount.load(accountName, openingBalance, accountGenerator());

            vault.createAccount(tempAccount);
            return AccountOutputHelper(tempAccount);
        }

        public AccountOutput CreateCurrentAccount(string accountName, decimal openingBalance, decimal overdraft)
        {
            Account account = factory.createAccount("Current");
            CurrentAccount tempAccount = (CurrentAccount)account;
            tempAccount.load(accountName, openingBalance, accountGenerator(), overdraft);

            vault.createAccount(tempAccount);
            return AccountOutputHelper(tempAccount);
        }

        public AccountOutput ViewAccount(string accountNumber)
        {
            int tempAccountNumber = Convert.ToInt32(accountNumber);
            Account account = vault.readAccount(tempAccountNumber);
            return AccountOutputHelper(account);
        }

        public IList<AccountOutput> ViewAccounts()
        {
            return vault.viewAllAccounts();
        }

        public AccountOutput MakeTransactionRequest(TransactionRequest transactionRequest)
        {
            int tempAccountNumber = System.Convert.ToInt32(transactionRequest.AccountNumber);
            decimal tempTransAmount = System.Convert.ToDecimal(transactionRequest.Amount);
            decimal newBalance;
            Account account = vault.readAccount(tempAccountNumber);

            if (transactionRequest.RequestType.ToString() == "Deposit")
            {
               newBalance = account.deposit(tempTransAmount);
            }
            else
            {
                newBalance = account.withdraw(tempTransAmount);
            }
                vault.updateAccount(account.getAccountNumber, newBalance);
                return AccountOutputHelper(account);
        }

        public AccountOutput CloseAccount(string accountNumber)
        {
            int tempAccountNumber = System.Convert.ToInt32(accountNumber);
            Account account = vault.readAccount(tempAccountNumber);

            if (account.getBalance == emptyAccount)
            {
                vault.deleteAccount(tempAccountNumber);
            }
            else
            {
                throw new BankException(ZERO_BALANCE);
            }
            return AccountOutputHelper(account);
        }

        private int accountGenerator()
        {
            if (vault is DatabaseStorage)
            {
                accountNumber = ((DatabaseStorage)vault).getMaxAccountNumber();
            }
            if (vault is XMLStorage)
            {
                accountNumber = ((XMLStorage)vault).getMaxAccountNum();
            }
            return ++accountNumber;

        }

        private AccountOutput AccountOutputHelper(Account account)
        {
            decimal overdraft = 0.00m;

            if (account is CurrentAccount)
            {
                CurrentAccount tempAccount = (CurrentAccount)account;
                overdraft = tempAccount.getOverdraft;

                return new AccountOutput(tempAccount.getAccountName, tempAccount.getBalance.ToString(), tempAccount.getAccountNumber.ToString(), "Current", overdraft.ToString());
            }
            else
            {
                SavingsAccount tempAccount = (SavingsAccount)account;
                return new AccountOutput(tempAccount.getAccountName, tempAccount.getBalance.ToString(), tempAccount.getAccountNumber.ToString(), "Savings", "0.00");
            }
        }
    }
}
