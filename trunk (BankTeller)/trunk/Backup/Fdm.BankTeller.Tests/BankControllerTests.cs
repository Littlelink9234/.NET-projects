using System;
using Fdm.BankTeller.Main;
using NUnit.Framework;

namespace Fdm.BankTeller.Tests
{
    [TestFixture]
    public class BankControllerTests
    {
        [Test]
        public void BankController_CreateNewSavingsAccount_ValidAccountData_AccountCanBeRetrieved()
        {
            IBankController bankController = CreateNewBankController();
            AccountOutput output = bankController.CreateSavingsAccount("Test", 100.00m);
            Assert.AreEqual("Test", output.AccountName);
            Assert.AreEqual("£100.00", output.Balance);
            Assert.AreEqual("£0.00", output.Overdraft);
            Assert.AreNotEqual("", output.AccountNumber);
        }

        [Test]
        public void BankController_PerformWithdrawalTransaction_FundsAreAvailable_CorrectBalanceReturned()
        {
            IBankController bankController = CreateNewBankController();
            AccountOutput output = bankController.CreateCurrentAccount("Test", 100.00m, 200.00m);
            TransactionRequest request = new TransactionRequest(output.AccountNumber, 50.00m, TransactionRequestType.Withdrawal);
            output = bankController.MakeTransactionRequest(request);
            Assert.AreEqual("£50.00", output.Balance);
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void BankController_PerformWithdrawalTransaction_FundsNotAvailable_ThrowsInvalidOperationException()
        {
            IBankController bankController = CreateNewBankController();
            AccountOutput output = bankController.CreateCurrentAccount("Test", 100.00m, 200.00m);
            TransactionRequest request = new TransactionRequest(output.AccountNumber, 350.00m, TransactionRequestType.Withdrawal);
            output = bankController.MakeTransactionRequest(request);
        }

        private IBankController CreateNewBankController()
        {
            throw new NotImplementedException();
        }
    }
}
