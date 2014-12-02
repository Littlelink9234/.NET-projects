using System;
using Fdm.BankTeller.Main;
using NUnit.Framework;

namespace Fdm.BankTeller.Tests
{
    [TestFixture]
    public class BankControllerTests
    {
        CurrentAccount cAccount = new CurrentAccount();
        SavingsAccount sAccount = new SavingsAccount();
        private static readonly string ACCOUNT_NUMBER_ZERO = "0";

        [Test]
        public void BankControllerCreateNewSavingsAccount()
        {
            Console.WriteLine("Test - Create new savings account");
            IBankController bankController = CreateNewBankController();
            AccountOutput output = bankController.CreateSavingsAccount("Test", 100.00m);

            Assert.AreEqual("Test", output.AccountName);
            Assert.AreEqual("100.00", output.Balance);
            Assert.AreNotEqual("", output.AccountNumber);
            Console.WriteLine("Name: " + output.AccountName + "\n" + "Balance: " + output.Balance + "\n" + "AcctNumber: "
                     + output.AccountNumber);
        }

        [Test]
        public void BankControllerCreateNewCurrentAccount()
        {
            Console.WriteLine("Test - Create new current account");

            IBankController bankController = CreateNewBankController();
            AccountOutput output = bankController.CreateCurrentAccount("Test", 100.00m, 100.00m);

            Assert.AreEqual("Test", output.AccountName);
            Assert.AreEqual("100.00", output.Balance);
            Assert.AreNotEqual("", output.AccountNumber);
            Console.WriteLine("Name: " + output.AccountName + "\n" + "Balance: " + output.Balance + "\n" + "AcctNumber: "
                     + output.AccountNumber);
        }

        [Test]
        public void BankController_PerformWithdrawalTransaction_FundsAreAvailable_CorrectBalanceReturned()
        {
            Console.WriteLine("Test - Withdrawal Transaction");

            IBankController bankController = CreateNewBankController();
            AccountOutput output = bankController.CreateCurrentAccount("Test", 100.00m, 200.00m);
            TransactionRequest request = new TransactionRequest(output.AccountNumber, 50.00m, TransactionRequestType.Withdrawal);
            output = bankController.MakeTransactionRequest(request);
            Assert.AreEqual("50.00", output.Balance);
        }

        [Test]
        public void TestViewAccount()
        {
            Console.WriteLine("Test - Viewing an account");
            
            IBankController bankController = CreateNewBankController();
            AccountOutput output = bankController.CreateCurrentAccount("Test", 100.00m, 50.00m);
            AccountOutput outputView = bankController.ViewAccount("0");
            Assert.AreEqual(ACCOUNT_NUMBER_ZERO, outputView.AccountNumber);
            Console.WriteLine("Name: " + output.AccountName + "\n" + "Balance: " + output.Balance + "\n" + 
                "Overdraft: " + output.Overdraft + "\n" + "AcctNumber: " + output.AccountNumber);
        }

        private IBankController CreateNewBankController()
        {
            IBankController controller = new BankController(new AccountManager(new AccountFactory(), new StorageCollection()));
            return controller;
        }
    }
}
