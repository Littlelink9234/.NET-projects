using System;
using System.Collections.Generic;
using System.Linq;
using Fdm.BankTeller.Main;
using NUnit.Framework;

namespace Fdm.BankTeller.Tests
{
    [TestFixture]
    public class AccountTests
    {
        private readonly decimal INTEREST_RATE = 0.05m;
        private readonly decimal SIX_HUNDRED = 600.0m;
        private readonly decimal NEGATIVE_HUNDRED = -100.0m;
        private readonly decimal FOUR_HUNDRED = 400.0m;
        private readonly decimal THOUSAND_FIFTY = 1050.0m;
        private readonly decimal NEG_FIFTY = -50.0m;
        private readonly decimal FIFTY = 50.0m;
        private readonly decimal TWELVE_HUNDRED = 1200.0m;
        private readonly decimal FIVE_TWENTY_FIVE = 525.0m;
        private readonly decimal ONE_HUNDRED = 100.0m;
        private static readonly String INVALID_TEXT = "Invalid deposit amount.";
        private static readonly String INSUFFICIENT_AMOUNT = "Error: Insufficient amount.";
        private static readonly String INSUFFICIENT_DRAFT = "Error: You have exceeded your overdraft limit.";

        Account cAccount = new CurrentAccount();
        SavingsAccount sAccount = new SavingsAccount();
        AccountOutput currentOutput = new AccountOutput("Jason Carvalho", "1000.00", "1", "Current", "50.00");
        AccountOutput savingsOutput = new AccountOutput("Jon Melo", "500.00", "2", "Savings", "0");

        [Test]
        public void testDepositCurrentAccount()
        {
            init();
            Console.WriteLine("testing deposit");
            decimal myResult = cAccount.deposit(FIFTY);      
            Assert.AreEqual(THOUSAND_FIFTY, myResult);
            Console.WriteLine(myResult);
        }

        [Test]
        public void testNegativeDepositCurrentAccount()
        {
            init();
            Console.WriteLine("testing negative deposit");
            try
            {
                decimal result = cAccount.deposit(NEGATIVE_HUNDRED);
                Assert.Fail();
            }
            catch (BankException e)
            {
                Assert.AreEqual(INVALID_TEXT, e.getText());
                Console.WriteLine(e.getText());
            }
        }

        [Test]
        public void testWithdrawCurrentAccount()
        {
            init();
            Console.WriteLine("testing regular withdraw");
            decimal myResult = cAccount.withdraw(FOUR_HUNDRED);
            Assert.AreEqual(SIX_HUNDRED, myResult);
            Console.WriteLine(myResult);
        }

        [Test]
        public void testNegativeWithdrawCurrentAccount()
        {
            init();
            Console.WriteLine("testing negative withdraw");
            try
            {
                decimal result = cAccount.withdraw(NEGATIVE_HUNDRED);
                Assert.Fail();
            }
            catch (BankException e)
            {
                Assert.AreEqual(INSUFFICIENT_AMOUNT, e.getText());
                Console.WriteLine(e.getText());
            }
        }

        [Test]
        public void testWithdrawOverdraft()
        {
            init();
            Console.WriteLine("testing withdraw overdraft");
            decimal myResult = cAccount.withdraw(THOUSAND_FIFTY);
            Assert.AreEqual(NEG_FIFTY, myResult);
            Console.WriteLine(myResult);
        }

        [Test]
        public void testWithdrawOverdraftLimit()
        {
            init();
            Console.WriteLine("testing withdraw overdraft limit");
            try
            {
                decimal myResult = cAccount.withdraw(TWELVE_HUNDRED);
                Assert.Fail();
            }
            catch (BankException e)
            {
                Assert.AreEqual(INSUFFICIENT_DRAFT, e.getText());
                Console.WriteLine(e.getText());
            }
        }

        [Test]
        public void testSavingsAccountAddInterest()
        {
            init();
            Console.WriteLine("testing add interest to Savings account");
            decimal myResult = sAccount.addInterest(INTEREST_RATE);
            Assert.AreEqual(FIVE_TWENTY_FIVE, myResult);
            Console.WriteLine(myResult);
        }

        [Test]
        public void testDepositSavingsAccount()
        {
            init();
            Console.WriteLine("testing deposit on Savings Account");
            decimal myResult = sAccount.deposit(ONE_HUNDRED);
            Assert.AreEqual(SIX_HUNDRED, myResult);
            Console.WriteLine(myResult);
        }

        [Test]
        public void testNegativeDepositSavingsAccount()
        {
            init();
            Console.WriteLine("testing negative deposit on Savings Account");
            try
            {
                decimal result = sAccount.deposit(NEGATIVE_HUNDRED);
                Assert.Fail();
            }
            catch (BankException e)
            {
                Assert.AreEqual(INVALID_TEXT, e.getText());
                Console.WriteLine(e.getText());
            }
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
