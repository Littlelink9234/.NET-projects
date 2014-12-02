using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fdm.BankTeller.Main
{
    public class BankController : IBankController
    {
        public static readonly string ZERO_BALANCE = "Balance must be zero in order to close an account.";
        private AccountManager _aManager;

        public BankController(AccountManager aManager)
        {
            this._aManager = aManager;
        }

        public AccountOutput CreateSavingsAccount(string accountName, decimal openingBalance)
        {
            return _aManager.CreateSavingsAccount(accountName, openingBalance); 
        }

        public AccountOutput CreateCurrentAccount(string accountName, decimal openingBalance, decimal overdraft)
        {
            return _aManager.CreateCurrentAccount(accountName, openingBalance, overdraft);
        }

        public AccountOutput ViewAccount(string accountNumber)
        {
            return _aManager.ViewAccount(accountNumber);
        }

        public IList<AccountOutput> ViewAccounts()
        {
            return _aManager.ViewAccounts();
        }

        public AccountOutput MakeTransactionRequest(TransactionRequest transactionRequest)
        {
            return _aManager.MakeTransactionRequest(transactionRequest);
        }

        public void CloseAccount(string accountNumber)
        {
            _aManager.CloseAccount(accountNumber);
        }
    }
}
