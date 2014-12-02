namespace Fdm.BankTeller.Main
{
    public class AccountOutput
    {
        private readonly string accountName;
        private readonly string balance;
        private readonly string accountNumber;
        private readonly string accountType;
        private readonly string overdraft;

        public AccountOutput(string accountName, string balance, string accountNumber, string accountType, string overdraft)
        {
            this.accountName = accountName;
            this.overdraft = overdraft;
            this.accountType = accountType;
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public string AccountName
        {
            get { return accountName; }
        }

        public string Balance
        {
            get { return balance; }
        }

        public string AccountNumber
        {
            get { return accountNumber; }
        }

        public string AccountType
        {
            get { return accountType; }
        }

        public string Overdraft
        {
            get { return overdraft; }
        }
    }
}
