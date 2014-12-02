namespace Fdm.BankTeller.Main
{
    public enum TransactionRequestType
    {
        Deposit,
        Withdrawal
    }

    public class TransactionRequest
    {
        private readonly string accountNumber;
        private readonly decimal amount;
        private readonly TransactionRequestType requestType;

        public TransactionRequest(string accountNumber, decimal amount, TransactionRequestType requestType)
        {
            this.accountNumber = accountNumber;
            this.requestType = requestType;
            this.amount = amount;
        }

        public string AccountNumber
        {
            get { return accountNumber; }
        }

        public decimal Amount
        {
            get { return amount; }
        }

        public TransactionRequestType RequestType
        {
            get { return requestType; }
        }
    }
}
