using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fdm.BankTeller.Main;
using NUnit.Framework;

namespace Fdm.BankTeller.Tests
{
    [TestFixture]
    public class StorageCollectionTests
    {
        private static StorageCollection storage = new StorageCollection();
        Account cAccount = new CurrentAccount();
        Account sAccount = new SavingsAccount();
        AccountOutput currentOutput = new AccountOutput("Jason Carvalho", "1000.00", "0", "Current", "50.00");
        AccountOutput savingsOutput = new AccountOutput("Jon Melo", "500.00", "1", "Savings", "0");

        private static readonly string INVALID_ENTRY = "Error - Account could not be added.";
        private static readonly string INVALID_ACCOUNT = "Error - Wrong account number has been entered.";

        [Test]
        public void TestCreateAndReadAccount()
        {
            Console.WriteLine("Test - storing account");
            try
            {
                storage.createAccount(cAccount);
                storage.createAccount(sAccount);
                init();

                Assert.AreEqual(cAccount, storage.readAccount(0));
                Assert.AreEqual(sAccount, storage.readAccount(1));
                Console.WriteLine(storage.readAccount(0).getAccountName + "\n" + storage.readAccount(0).getAccountNumber +
                                "\n" + storage.readAccount(0).getBalance);
                Console.WriteLine(storage.readAccount(1).getAccountName + "\n" + storage.readAccount(1).getAccountNumber +
                                "\n" + storage.readAccount(1).getBalance);
            }
            catch (BankException)
            {
                Assert.Fail(INVALID_ENTRY);
            }
        }

        [Test]
        public void TestReadAccountInvalid()
        {
            Console.WriteLine("Test - viewing an account");
            try
            {
                storage.readAccount(2);
                Assert.Fail();
            }
            catch (BankException e)
            {
                Assert.AreEqual(INVALID_ACCOUNT, e.getText());
                Console.WriteLine(e.getText());
            }
        }

        [Test]
        public void TestUpdateAccountDeposit()
        {
            Console.WriteLine("Test - updating an account (deposit)");
            try
            {
                storage.createAccount(cAccount);
                //storage.updateAccount(0, "Deposit", 300.00m);
                Assert.AreEqual(300.00m, storage.readAccount(0).getBalance);
               // Console.WriteLine(storage.readAccount(0).getFormat());
            }
            catch (BankException)
            {
                Assert.Fail();
            }
        }

        [Test]
        public void TestUpdateAccountWithdraw()
        {
            Console.WriteLine("Test - updating an account (Withdrawal)");
            try
            {
                storage.createAccount(cAccount);
               // storage.updateAccount(0, "Withdrawal", 100.00m);
                Assert.AreEqual(100.00m, storage.readAccount(0).getBalance);
                Console.WriteLine(storage.readAccount(0).getAccountName + "\n" + storage.readAccount(0).getAccountNumber +
                                "\n" + storage.readAccount(0).getBalance);
            }
            catch (BankException)
            {
                Assert.Fail();
            }
        }

        [Test]
        public void TestViewAllAccounts()
        {
            Console.WriteLine("Test - viewing all accounts");
            storage.createAccount(cAccount);
            storage.createAccount(sAccount);
            init();

            storage.viewAllAccounts();
            Assert.AreEqual(cAccount, storage.readAccount(0));
            Assert.AreEqual(sAccount, storage.readAccount(1));
            Console.WriteLine(storage.viewAllAccounts());
        }

        private void init()
        {
            cAccount.setAccountName(currentOutput.AccountName);
            cAccount.setAccountNumber(Convert.ToInt32(currentOutput.AccountNumber));
            cAccount.setBalance(Convert.ToDecimal(currentOutput.Balance));
            ((CurrentAccount)cAccount).setOverdraft(Convert.ToDecimal(currentOutput.Overdraft));

            sAccount.setAccountName(savingsOutput.AccountName);
            sAccount.setAccountNumber(Convert.ToInt32(savingsOutput.AccountNumber));
            sAccount.setBalance(Convert.ToDecimal(savingsOutput.Balance));
        }
    }
}
