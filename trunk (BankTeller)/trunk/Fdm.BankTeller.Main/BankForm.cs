using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Fdm.BankTeller.Main.Storage;

namespace Fdm.BankTeller.Main
{
    public partial class BankForm : Form
    {
        private IBankController controller;
        //private DatabaseStorage databaseStore;
        private XMLStorage xmlStorage;
        private string record;
        AccountOutput accOutput = null;


        private static readonly string NON_EXISTENT = "Error: Please enter correct data in all fields";
        private static readonly string CLOSE_ACCOUNT = "Error: Account balance must be zero!";
        private static readonly string ACCOUNT_DELETED = "Account Successfully Deleted!";
        private static readonly string INSUFFICIENT_AMOUNT = "Error: Cannot withdraw more money than you own!";

        public BankForm(IBankController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void BankForm_Load_1(object sender, EventArgs e)
        {
            
            //databaseStore = new DatabaseStorage();
            xmlStorage = new XMLStorage();
            IList<AccountOutput> accList = xmlStorage.viewAllAccounts();
            foreach (AccountOutput x in accList)
            {
                cmb_box_account_numbers.Items.Add(x.AccountNumber).ToString();
            }
        }

        private void btn_create_current_account_Click(object sender, EventArgs e)
        {
            string name = txt_box_name.Text;
            string balance = txt_box_balance.Text;
            string overdraft = txt_box_overdraft.Text;
                                      
            if (name == "" || balance == "" || overdraft == "" || !IsNumeric(balance) || !IsNumeric(overdraft) || !IsAlpha(name))
            {
                list_box_all_accounts.Items.Clear();
                list_box_all_accounts.Items.Add(NON_EXISTENT);
            }   
            else
            {
                list_box_all_accounts.Items.Clear();
                accOutput = controller.CreateCurrentAccount(name, Convert.ToDecimal(balance), Convert.ToDecimal(overdraft));

                record = accOutput.AccountNumber + "\t" + "\t" + name + "\t" + "\t" + balance + "\t" + "\t" + overdraft;
                list_box_all_accounts.Items.Add(record);

                txt_box_name.Clear();
                txt_box_balance.Clear();
                txt_box_overdraft.Clear();
                cmb_box_account_numbers.Items.Add(accOutput.AccountNumber);
            }
        }

        private void btn_close_account_Click(object sender, EventArgs e)
        {
            string accountNum = accOutput.AccountNumber;

            if (Convert.ToDecimal(controller.ViewAccount(accountNum).Balance) == 0.00m)
            {
                controller.CloseAccount(accountNum);
                list_box_all_accounts.Items.Remove(record);
                list_box_single_account.Items.Clear();
                cmb_box_account_numbers.Items.Remove(accountNum);
                list_box_all_accounts.Items.Add(ACCOUNT_DELETED);
            }
            else
            {
                list_box_all_accounts.Items.Clear();
                list_box_all_accounts.Items.Add(CLOSE_ACCOUNT);
            }
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            if (txt_box_transaction.Text == "" || !IsNumeric(txt_box_transaction.Text))
            {
                list_box_all_accounts.Items.Clear();
                list_box_all_accounts.Items.Add(NON_EXISTENT);
            }
            else
            {
                controller.MakeTransactionRequest(new TransactionRequest(accOutput.AccountNumber,
                               Convert.ToDecimal(txt_box_transaction.Text), TransactionRequestType.Deposit));

                printStringInListBox();
            }
        }

        private void btn_withdraw_Click(object sender, EventArgs e)
        {
            string accountNumber = cmb_box_account_numbers.Text;

            if (txt_box_transaction.Text == "" || !IsNumeric(txt_box_transaction.Text))
            {
                list_box_all_accounts.Items.Clear();
                list_box_all_accounts.Items.Add(NON_EXISTENT);
            }
            else if (Convert.ToDecimal(txt_box_transaction.Text) > Convert.ToDecimal(controller.ViewAccount(accountNumber).Balance))
            {
                list_box_all_accounts.Items.Add(INSUFFICIENT_AMOUNT);
            }
            else
            {
                controller.MakeTransactionRequest(new TransactionRequest(accOutput.AccountNumber,
                               Convert.ToDecimal(txt_box_transaction.Text), TransactionRequestType.Withdrawal));

            accOutput = controller.ViewAccount(accountNumber);

                printStringInListBox();
            }
        }

        private void btn_create_savings_account_Click(object sender, EventArgs e)
        {
            string name = txt_box_name_savings.Text;
            string balance = txt_box_balance_savings.Text;

            if (name == "" || balance == "" || !IsNumeric(balance) || !IsAlpha(name))
            {
                list_box_all_accounts.Items.Clear();
                list_box_all_accounts.Items.Add(NON_EXISTENT);
            }
            else
            {
                list_box_all_accounts.Items.Clear();
                accOutput = controller.CreateSavingsAccount(name, Convert.ToDecimal(balance));

                record = accOutput.AccountNumber + "\t" + "\t" + name + "\t" + "\t" + balance;
                list_box_all_accounts.Items.Add(record);

                txt_box_name_savings.Clear();
                txt_box_balance_savings.Clear();
                cmb_box_account_numbers.Items.Add(accOutput.AccountNumber);
            }
        }

        private void btn_list_all_accounts_Click(object sender, EventArgs e)
        {
            IList<AccountOutput> newList = controller.ViewAccounts();
            list_box_all_accounts.Items.Clear();

            for (int i = 0; i < newList.ToArray().Length; i++)
            {
                accOutput = newList.ElementAt(i);
                if (accOutput.AccountType == "Current")
                {
                    record = accOutput.AccountNumber + "\t" + "\t" + accOutput.AccountName + "\t" + "\t" + accOutput.Balance
                                    + "\t" + "\t" + accOutput.Overdraft;
                }
                else
                {
                    record = accOutput.AccountNumber + "\t" + "\t" + accOutput.AccountName + "\t" + "\t" + accOutput.Balance;
                }
                list_box_all_accounts.Items.Add(record);
            }
        }

        private void cmb_box_account_numbers_SelectedIndexChanged(object sender, EventArgs e)
        {
                accOutput = controller.ViewAccount(cmb_box_account_numbers.SelectedItem.ToString());

                if (accOutput.AccountType == "Current")
                {
                    record = accOutput.AccountNumber + "\t" + "\t" + accOutput.AccountName + "\t" + "\t" + accOutput.Balance
                                        + "\t" + "\t" + accOutput.Overdraft;
                    list_box_single_account.Items.Clear();
                    list_box_all_accounts.Items.Clear();
                    list_box_single_account.Items.Add(record);
                }
                else
                {
                    record = accOutput.AccountNumber + "\t" + "\t" + accOutput.AccountName + "\t" + "\t" + accOutput.Balance;
                    list_box_single_account.Items.Clear();
                    list_box_all_accounts.Items.Clear();
                    list_box_single_account.Items.Add(record);
                }
        }

        public bool IsAlpha(string input)
        {
            return Regex.IsMatch(input, "^[a-zA-Z]+$");
        }

        public bool IsNumeric(string input)
        {
            return Regex.IsMatch(input, "^[0-9]+$");
        }

        public void printStringInListBox()
        {
            string accountNumber = cmb_box_account_numbers.Text;
            accOutput = controller.ViewAccount(accountNumber);

            if (accOutput.AccountType == "Current")
            {
                list_box_single_account.Items.Clear();
                list_box_all_accounts.Items.Remove(record);

                record = accOutput.AccountNumber + "\t" + "\t" + accOutput.AccountName + "\t" + "\t" + accOutput.Balance
                                    + "\t" + "\t" + accOutput.Overdraft;

                list_box_single_account.Items.Add(record);
                list_box_all_accounts.Items.Clear();
                list_box_all_accounts.Items.Add(record);
            }
            else
            {
                list_box_single_account.Items.Clear();
                list_box_all_accounts.Items.Remove(record);

                record = accOutput.AccountNumber + "\t" + "\t" + accOutput.AccountName + "\t" + "\t" + accOutput.Balance;

                list_box_single_account.Items.Add(record);
                list_box_all_accounts.Items.Clear();
                list_box_all_accounts.Items.Add(record);
            }
            txt_box_transaction.Clear();
        }
    }
}