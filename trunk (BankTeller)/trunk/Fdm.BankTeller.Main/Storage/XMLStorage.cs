using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.IO;

namespace Fdm.BankTeller.Main.Storage
{
    public class XMLStorage : IStorage
    {
        private XmlDocument xmlDocument = new XmlDocument();
        private IList<AccountOutput> accountList = new List<AccountOutput>();

        public XMLStorage()
        {
            xmlDocument.Load("C:\\Users\\Jason\\Documents\\FDM Group\\trunk (BankTeller)\\trunk\\XMLData.xml");
        }

        public void createAccount(Account account)
        {
            XmlNode newAccount = xmlDocument["NewDataSet"].AppendChild(xmlDocument.CreateElement("Account"));
            newAccount.AppendChild(xmlDocument.CreateElement("AccountNumber")).AppendChild(xmlDocument.CreateTextNode(account.getAccountNumber.ToString()));
            newAccount.AppendChild(xmlDocument.CreateElement("Name")).AppendChild(xmlDocument.CreateTextNode(account.getAccountName));
            newAccount.AppendChild(xmlDocument.CreateElement("Balance")).AppendChild(xmlDocument.CreateTextNode(account.getBalance.ToString()));
            if (account is CurrentAccount)
            {
                newAccount.AppendChild(xmlDocument.CreateElement("AccountType")).AppendChild(xmlDocument.CreateTextNode("Current"));
                newAccount.AppendChild(xmlDocument.CreateElement("Overdraft")).AppendChild(xmlDocument.CreateTextNode(((CurrentAccount)account).getOverdraft.ToString()));
            }
            else
            {
                newAccount.AppendChild(xmlDocument.CreateElement("AccountType")).AppendChild(xmlDocument.CreateTextNode("Savings"));
                newAccount.AppendChild(xmlDocument.CreateElement("Overdraft")).AppendChild(xmlDocument.CreateTextNode("0.00"));
            }
            xmlDocument.Save("C:\\Users\\Jason\\Documents\\FDM Group\\trunk (BankTeller)\\trunk\\XMLData.xml");
        }

        public void deleteAccount(int AccountNumber)
        {
            XmlNode accountNode = xmlDocument.SelectSingleNode("/NewDataSet/Account/AccountNumber[.=" + AccountNumber + "]");
            accountNode = accountNode.ParentNode;

            xmlDocument["NewDataSet"].RemoveChild(accountNode);
            xmlDocument.Save("C:\\Users\\Jason\\Documents\\FDM Group\\trunk (BankTeller)\\trunk\\XMLData.xml");
        }

        public Account readAccount(int AccountNumber)
        {
            XmlNode accountNode = xmlDocument.SelectSingleNode("/NewDataSet/Account/AccountNumber[.=" + AccountNumber + "]");
            accountNode = accountNode.ParentNode;
            Account account = null;

            int accountNum = Convert.ToInt32(accountNode["AccountNumber"].InnerText.ToString());
            String accountName = accountNode["Name"].InnerText.ToString();
            String accountType = accountNode["AccountType"].InnerText.ToString();
            decimal balance = Convert.ToDecimal(accountNode["Balance"].InnerText.ToString());
            decimal overdraft = Convert.ToDecimal(accountNode["Overdraft"].InnerText.ToString());

            if (accountType == "Current")
            {
                account = new CurrentAccount();
                ((CurrentAccount)account).load(accountName, balance, accountNum, overdraft);
                return account;
            }
            else if (accountType == "Savings")
            {
                account = new SavingsAccount();
                ((SavingsAccount)account).load(accountName, balance, accountNum);
                return account;
            }
            else
                throw new InvalidOperationException("Error: This account doesn't exist.");
        }

        public IList<AccountOutput> viewAllAccounts()
        {
            IList<AccountOutput> accountList = new List<AccountOutput>();
            XmlNode accountNode = xmlDocument.SelectSingleNode("/NewDataSet/Account[last()]/AccountNumber");

            int maxAccountNumber = Convert.ToInt32(accountNode.InnerText);
            int i = 1;

            while (i <= maxAccountNumber)
            {
                Account account = readAccount(i);
                accountList.Add(AccountOutputHelper(account));
                i++;
            }
            return accountList;
        }

        public void updateAccount(int accountNumber, decimal amount)
        {
            Account account = readAccount(accountNumber);
            String newBalance = Convert.ToString(amount);

            XmlNode accountNode = xmlDocument.SelectSingleNode("/NewDataSet/Account/AccountNumber[.=" + accountNumber + "]");
            accountNode = accountNode.ParentNode;

            accountNode["Balance"].InnerText = newBalance;

            xmlDocument.Save("C:\\Users\\Jason\\Documents\\FDM Group\\trunk (BankTeller)\\trunk\\XMLData.xml");
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

        public int getMaxAccountNum()
        {
            XmlNode accountNode = xmlDocument.SelectSingleNode("/NewDataSet/Account[last()]/AccountNumber");

            int maxAccountNumber = Convert.ToInt32(accountNode.InnerText);
            return maxAccountNumber;
        }
    }
}
