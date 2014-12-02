using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fdm.BankTeller.Main;
using NUnit.Framework;

namespace Fdm.BankTeller.Tests
{
    [TestFixture]
    public class AccountManagerTests
    {
        AccountManager _aManager;
        IStorage storage;
        AccountOutput Savings_Test = new AccountOutput("Jason Carvalho", "100.00", "1", "Savings", "0");
        AccountOutput Current_Test = new AccountOutput("Jon Melo", "200.00", "0", "Current", "100.00");

        [Test]
        public void TestCreateSavingsAccount()
        {
            Console.WriteLine("Test - creating savings account");

            init(out _aManager, out storage);
            AccountOutput output = _aManager.CreateSavingsAccount("Jason Carvalho", 100.00m);
            Console.WriteLine("account number: " + output.AccountNumber);
            Assert.AreEqual(Savings_Test.AccountName, output.AccountName);
            Console.WriteLine(output.AccountName + "\n" + output.Balance + "\n" + output.Overdraft + "\n" + output.AccountNumber 
                    + "\n" + output.AccountType);
        }

        [Test]
        public void TestCreateCurrentAccount()
        {
            Console.WriteLine("Test - creating current account");

            init(out _aManager, out storage);
            AccountOutput output = _aManager.CreateCurrentAccount("Jon Melo", 200.00m, 100.00m);
            Console.WriteLine("account number: " + output.AccountNumber);
            Assert.AreEqual(Current_Test.AccountName, output.AccountName);
            Console.WriteLine(output.AccountName + "\n" + output.Balance + "\n" + output.Overdraft + "\n" + output.AccountNumber
                    + "\n" + output.AccountType);
        }

        [Test]
        public void TestViewAccount()
        {
           
            Console.WriteLine("Test - viewing an account");

            init(out _aManager, out storage);
            AccountOutput output = _aManager.CreateSavingsAccount("Jon Melo", 200.00m);
            output = _aManager.ViewAccount("0");
            Assert.AreEqual("0", output.AccountNumber);
            Console.WriteLine(output.AccountName + "\n" + output.Balance + "\n" + output.Overdraft + "\n" + output.AccountNumber
                    + "\n" + output.AccountType);
        }

        [Test]
        [ExpectedException(typeof(BankException))]
        public void TestMakeTransactionRequest()
        {
            Console.WriteLine("Test - make transaction request");

            init(out _aManager, out storage);
            AccountOutput output = _aManager.CreateCurrentAccount("Jason Carvalho", 500.00m, 100.00m);
            TransactionRequest request = new TransactionRequest(output.AccountNumber, 650.00m, TransactionRequestType.Withdrawal);
            output = _aManager.MakeTransactionRequest(request);
        }

        private void init(out AccountManager _aManager, out IStorage storage)
        {
            _aManager = new AccountManager(new AccountFactory(), new StorageCollection());
            storage = new StorageCollection();
        }
    }
}
