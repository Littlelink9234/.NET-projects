using System.Collections.Generic;

namespace Fdm.BankTeller.Main
{
    public interface IBankController
    {
        AccountOutput CreateSavingsAccount(string accountName, decimal openingBalance);
        AccountOutput CreateCurrentAccount(string accountName, decimal openingBalance, decimal overdraft);
        AccountOutput ViewAccount(string accountNumber);
        IList<AccountOutput> ViewAccounts();
        AccountOutput MakeTransactionRequest(TransactionRequest transactionRequest);
        void CloseAccount(string accountNumber);
    }
}
