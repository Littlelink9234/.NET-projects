using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Fdm.BankTeller.Main.Storage
{
    public class DatabaseStorage : IStorage
    {
        private IDbConnection conn;
        private IDbCommand cmd;
        SqlConnection sqlConn;

        public DatabaseStorage()
        {
            AppSettingsReader appReader = new AppSettingsReader();
            string connString = (string)appReader.GetValue("connOperations.connectionString", typeof(string));
            sqlConn = new SqlConnection(connString);
            conn = sqlConn;
            cmd = conn.CreateCommand();
        }

        public void createAccount(Account account)
        {
            string insertSQL = "INSERT into Accounts (Name, Balance, AccountNumber, AccountType, Overdraft) VALUES (@name, @balance, @number, @type, @overdraft)";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(insertSQL, sqlConn);
                cmd.Parameters.AddWithValue("@name", account.getAccountName);
                cmd.Parameters.AddWithValue("@balance", account.getBalance);
                cmd.Parameters.AddWithValue("@number", account.getAccountNumber);
                if (account is CurrentAccount)
                {
                    cmd.Parameters.AddWithValue("@type", "Current");
                    cmd.Parameters.AddWithValue("@overdraft", ((CurrentAccount)account).getOverdraft);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@type", "Savings");
                    cmd.Parameters.AddWithValue("@overdraft", "0");
                }
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();             
            }
        }

        public void deleteAccount(int AccountNumber)
        {
            String delete = "DELETE FROM Accounts WHERE AccountNumber = " + AccountNumber;
            SqlCommand command = new SqlCommand(delete, sqlConn);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
            }
            finally
            {           
                conn.Close();
            }
        }

        public Account readAccount(int AccountNumber)
        {
            Account account = null;
            SqlDataReader reader = null;
            String readRecord = "SELECT Name, Balance, AccountNumber, AccountType, Overdraft FROM Accounts WHERE AccountNumber = " + AccountNumber;

            conn.Close();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(readRecord, sqlConn);
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    if (reader.GetString(reader.GetOrdinal("AccountType")) == "Savings")
                    {
                        account = new SavingsAccount();
                        ((SavingsAccount)account).load((string)reader["name"], ((decimal)reader["balance"]),
                                                        ((int)reader["AccountNumber"]));
                    }
                    else
                    {
                        account = new CurrentAccount();
                        ((CurrentAccount)account).load((string)reader["name"], ((decimal)reader["balance"]),
                                           ((int)reader["AccountNumber"]), ((decimal)reader["overdraft"]));
                    }
                }
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
                return account;
        }

        public IList<AccountOutput> viewAllAccounts()
        {
            conn.Open();
            SqlDataReader reader = null;
            IList<AccountOutput> accountList = new List<AccountOutput>();
            String viewAccounts = "SELECT Name, Balance, AccountNumber, AccountType, Overdraft FROM Accounts";
            SqlCommand command = new SqlCommand(viewAccounts, sqlConn);
            reader = command.ExecuteReader();
            AccountOutput output;
            while (reader.Read())
            {                       
                    output = new AccountOutput((string)reader["Name"], (reader["Balance"]).ToString(), (reader["AccountNumber"]).ToString(), 
                                        (string)reader["AccountType"], reader["Overdraft"].ToString());
                accountList.Add(output);
            }       
            reader.Close();
            conn.Close();
            return accountList;
        }

        public void updateAccount(int accountNumber, decimal amount)
        {
            try
            {
                conn.Open();
                String update = "UPDATE Accounts SET Balance = " + amount + " WHERE AccountNumber = " + accountNumber;
                SqlCommand command = new SqlCommand(update, sqlConn);
                command.ExecuteNonQuery();
            }
            catch (BankException e)
            {
                e.getText();
            }
            finally
            {            
                conn.Close();          
            }
        }

        public int getMaxAccountNumber()
        {
            string maxAccount = "SELECT MAX(AccountNumber) FROM Accounts";
            try
            {
                conn.Open();
                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand(maxAccount, sqlConn);
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return reader.GetInt32(0);
                }
                reader.Close();
            }
            finally
            {
                conn.Close();
            }
            return 0;
        }
    }
}
