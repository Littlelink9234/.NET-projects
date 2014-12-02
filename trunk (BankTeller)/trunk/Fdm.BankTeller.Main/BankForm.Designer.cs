namespace Fdm.BankTeller.Main
{
    partial class BankForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab_accounts = new System.Windows.Forms.TabControl();
            this.tab_Current = new System.Windows.Forms.TabPage();
            this.txt_box_overdraft = new System.Windows.Forms.TextBox();
            this.lbl_overdraft = new System.Windows.Forms.Label();
            this.txt_box_balance = new System.Windows.Forms.TextBox();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_box_name = new System.Windows.Forms.TextBox();
            this.btn_create_current_account = new System.Windows.Forms.Button();
            this.tab_Savings = new System.Windows.Forms.TabPage();
            this.txt_box_balance_savings = new System.Windows.Forms.TextBox();
            this.txt_box_name_savings = new System.Windows.Forms.TextBox();
            this.btn_create_savings_account = new System.Windows.Forms.Button();
            this.lbl_balance_savings = new System.Windows.Forms.Label();
            this.lbl_name_savings = new System.Windows.Forms.Label();
            this.tab_current_transaction = new System.Windows.Forms.TabPage();
            this.cmb_box_account_numbers = new System.Windows.Forms.ComboBox();
            this.btn_close_account = new System.Windows.Forms.Button();
            this.list_box_single_account = new System.Windows.Forms.ListBox();
            this.btn_withdraw = new System.Windows.Forms.Button();
            this.btn_deposit = new System.Windows.Forms.Button();
            this.txt_box_transaction = new System.Windows.Forms.TextBox();
            this.list_box_all_accounts = new System.Windows.Forms.ListBox();
            this.lbl_account_numbers = new System.Windows.Forms.Label();
            this.lbl_name_all_accounts = new System.Windows.Forms.Label();
            this.lbl_balance_all_accounts = new System.Windows.Forms.Label();
            this.lbl_overdraft_all_accounts = new System.Windows.Forms.Label();
            this.btn_list_all_accounts = new System.Windows.Forms.Button();
            this.tab_accounts.SuspendLayout();
            this.tab_Current.SuspendLayout();
            this.tab_Savings.SuspendLayout();
            this.tab_current_transaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_accounts
            // 
            this.tab_accounts.Controls.Add(this.tab_Current);
            this.tab_accounts.Controls.Add(this.tab_Savings);
            this.tab_accounts.Controls.Add(this.tab_current_transaction);
            this.tab_accounts.Location = new System.Drawing.Point(25, 23);
            this.tab_accounts.Name = "tab_accounts";
            this.tab_accounts.SelectedIndex = 0;
            this.tab_accounts.Size = new System.Drawing.Size(569, 179);
            this.tab_accounts.TabIndex = 0;
            // 
            // tab_Current
            // 
            this.tab_Current.Controls.Add(this.txt_box_overdraft);
            this.tab_Current.Controls.Add(this.lbl_overdraft);
            this.tab_Current.Controls.Add(this.txt_box_balance);
            this.tab_Current.Controls.Add(this.lbl_balance);
            this.tab_Current.Controls.Add(this.lbl_name);
            this.tab_Current.Controls.Add(this.txt_box_name);
            this.tab_Current.Controls.Add(this.btn_create_current_account);
            this.tab_Current.Location = new System.Drawing.Point(4, 22);
            this.tab_Current.Name = "tab_Current";
            this.tab_Current.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Current.Size = new System.Drawing.Size(561, 153);
            this.tab_Current.TabIndex = 0;
            this.tab_Current.Text = "Current Account";
            this.tab_Current.UseVisualStyleBackColor = true;
            // 
            // txt_box_overdraft
            // 
            this.txt_box_overdraft.Location = new System.Drawing.Point(73, 101);
            this.txt_box_overdraft.Name = "txt_box_overdraft";
            this.txt_box_overdraft.Size = new System.Drawing.Size(143, 20);
            this.txt_box_overdraft.TabIndex = 6;
            // 
            // lbl_overdraft
            // 
            this.lbl_overdraft.AutoSize = true;
            this.lbl_overdraft.Location = new System.Drawing.Point(6, 104);
            this.lbl_overdraft.Name = "lbl_overdraft";
            this.lbl_overdraft.Size = new System.Drawing.Size(54, 13);
            this.lbl_overdraft.TabIndex = 5;
            this.lbl_overdraft.Text = "Overdraft:";
            // 
            // txt_box_balance
            // 
            this.txt_box_balance.Location = new System.Drawing.Point(73, 63);
            this.txt_box_balance.Name = "txt_box_balance";
            this.txt_box_balance.Size = new System.Drawing.Size(143, 20);
            this.txt_box_balance.TabIndex = 4;
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Location = new System.Drawing.Point(6, 66);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(49, 13);
            this.lbl_balance.TabIndex = 3;
            this.lbl_balance.Text = "Balance:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(6, 30);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(38, 13);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name:";
            // 
            // txt_box_name
            // 
            this.txt_box_name.Location = new System.Drawing.Point(73, 27);
            this.txt_box_name.Name = "txt_box_name";
            this.txt_box_name.Size = new System.Drawing.Size(143, 20);
            this.txt_box_name.TabIndex = 1;
            // 
            // btn_create_current_account
            // 
            this.btn_create_current_account.Location = new System.Drawing.Point(331, 54);
            this.btn_create_current_account.Name = "btn_create_current_account";
            this.btn_create_current_account.Size = new System.Drawing.Size(112, 37);
            this.btn_create_current_account.TabIndex = 0;
            this.btn_create_current_account.Text = "Create Current Account";
            this.btn_create_current_account.UseVisualStyleBackColor = true;
            this.btn_create_current_account.Click += new System.EventHandler(this.btn_create_current_account_Click);
            // 
            // tab_Savings
            // 
            this.tab_Savings.Controls.Add(this.txt_box_balance_savings);
            this.tab_Savings.Controls.Add(this.txt_box_name_savings);
            this.tab_Savings.Controls.Add(this.btn_create_savings_account);
            this.tab_Savings.Controls.Add(this.lbl_balance_savings);
            this.tab_Savings.Controls.Add(this.lbl_name_savings);
            this.tab_Savings.Location = new System.Drawing.Point(4, 22);
            this.tab_Savings.Name = "tab_Savings";
            this.tab_Savings.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Savings.Size = new System.Drawing.Size(561, 153);
            this.tab_Savings.TabIndex = 1;
            this.tab_Savings.Text = "Savings Account";
            this.tab_Savings.UseVisualStyleBackColor = true;
            // 
            // txt_box_balance_savings
            // 
            this.txt_box_balance_savings.Location = new System.Drawing.Point(78, 79);
            this.txt_box_balance_savings.Name = "txt_box_balance_savings";
            this.txt_box_balance_savings.Size = new System.Drawing.Size(120, 20);
            this.txt_box_balance_savings.TabIndex = 5;
            // 
            // txt_box_name_savings
            // 
            this.txt_box_name_savings.Location = new System.Drawing.Point(78, 39);
            this.txt_box_name_savings.Name = "txt_box_name_savings";
            this.txt_box_name_savings.Size = new System.Drawing.Size(120, 20);
            this.txt_box_name_savings.TabIndex = 4;
            // 
            // btn_create_savings_account
            // 
            this.btn_create_savings_account.Location = new System.Drawing.Point(324, 55);
            this.btn_create_savings_account.Name = "btn_create_savings_account";
            this.btn_create_savings_account.Size = new System.Drawing.Size(116, 37);
            this.btn_create_savings_account.TabIndex = 3;
            this.btn_create_savings_account.Text = "Create Savings Account";
            this.btn_create_savings_account.UseVisualStyleBackColor = true;
            this.btn_create_savings_account.Click += new System.EventHandler(this.btn_create_savings_account_Click);
            // 
            // lbl_balance_savings
            // 
            this.lbl_balance_savings.AutoSize = true;
            this.lbl_balance_savings.Location = new System.Drawing.Point(25, 79);
            this.lbl_balance_savings.Name = "lbl_balance_savings";
            this.lbl_balance_savings.Size = new System.Drawing.Size(49, 13);
            this.lbl_balance_savings.TabIndex = 1;
            this.lbl_balance_savings.Text = "Balance:";
            // 
            // lbl_name_savings
            // 
            this.lbl_name_savings.AutoSize = true;
            this.lbl_name_savings.Location = new System.Drawing.Point(25, 42);
            this.lbl_name_savings.Name = "lbl_name_savings";
            this.lbl_name_savings.Size = new System.Drawing.Size(38, 13);
            this.lbl_name_savings.TabIndex = 0;
            this.lbl_name_savings.Text = "Name:";
            // 
            // tab_current_transaction
            // 
            this.tab_current_transaction.Controls.Add(this.cmb_box_account_numbers);
            this.tab_current_transaction.Controls.Add(this.btn_close_account);
            this.tab_current_transaction.Controls.Add(this.list_box_single_account);
            this.tab_current_transaction.Controls.Add(this.btn_withdraw);
            this.tab_current_transaction.Controls.Add(this.btn_deposit);
            this.tab_current_transaction.Controls.Add(this.txt_box_transaction);
            this.tab_current_transaction.Location = new System.Drawing.Point(4, 22);
            this.tab_current_transaction.Name = "tab_current_transaction";
            this.tab_current_transaction.Padding = new System.Windows.Forms.Padding(3);
            this.tab_current_transaction.Size = new System.Drawing.Size(561, 153);
            this.tab_current_transaction.TabIndex = 2;
            this.tab_current_transaction.Text = "Current Transaction";
            this.tab_current_transaction.UseVisualStyleBackColor = true;
            // 
            // cmb_box_account_numbers
            // 
            this.cmb_box_account_numbers.FormattingEnabled = true;
            this.cmb_box_account_numbers.Location = new System.Drawing.Point(19, 23);
            this.cmb_box_account_numbers.Name = "cmb_box_account_numbers";
            this.cmb_box_account_numbers.Size = new System.Drawing.Size(121, 21);
            this.cmb_box_account_numbers.TabIndex = 9;
            this.cmb_box_account_numbers.Text = "Account Numbers";
            this.cmb_box_account_numbers.SelectedIndexChanged += new System.EventHandler(this.cmb_box_account_numbers_SelectedIndexChanged);
            // 
            // btn_close_account
            // 
            this.btn_close_account.Location = new System.Drawing.Point(453, 120);
            this.btn_close_account.Name = "btn_close_account";
            this.btn_close_account.Size = new System.Drawing.Size(93, 27);
            this.btn_close_account.TabIndex = 8;
            this.btn_close_account.Text = "Close Account";
            this.btn_close_account.UseVisualStyleBackColor = true;
            this.btn_close_account.Click += new System.EventHandler(this.btn_close_account_Click);
            // 
            // list_box_single_account
            // 
            this.list_box_single_account.FormattingEnabled = true;
            this.list_box_single_account.Location = new System.Drawing.Point(200, 23);
            this.list_box_single_account.Name = "list_box_single_account";
            this.list_box_single_account.Size = new System.Drawing.Size(355, 30);
            this.list_box_single_account.TabIndex = 6;
            // 
            // btn_withdraw
            // 
            this.btn_withdraw.Location = new System.Drawing.Point(275, 124);
            this.btn_withdraw.Name = "btn_withdraw";
            this.btn_withdraw.Size = new System.Drawing.Size(75, 23);
            this.btn_withdraw.TabIndex = 4;
            this.btn_withdraw.Text = "Withdraw";
            this.btn_withdraw.UseVisualStyleBackColor = true;
            this.btn_withdraw.Click += new System.EventHandler(this.btn_withdraw_Click);
            // 
            // btn_deposit
            // 
            this.btn_deposit.Location = new System.Drawing.Point(194, 124);
            this.btn_deposit.Name = "btn_deposit";
            this.btn_deposit.Size = new System.Drawing.Size(75, 23);
            this.btn_deposit.TabIndex = 3;
            this.btn_deposit.Text = "Deposit";
            this.btn_deposit.UseVisualStyleBackColor = true;
            this.btn_deposit.Click += new System.EventHandler(this.btn_deposit_Click);
            // 
            // txt_box_transaction
            // 
            this.txt_box_transaction.Location = new System.Drawing.Point(211, 88);
            this.txt_box_transaction.Name = "txt_box_transaction";
            this.txt_box_transaction.Size = new System.Drawing.Size(127, 20);
            this.txt_box_transaction.TabIndex = 2;
            // 
            // list_box_all_accounts
            // 
            this.list_box_all_accounts.FormattingEnabled = true;
            this.list_box_all_accounts.Location = new System.Drawing.Point(25, 264);
            this.list_box_all_accounts.Name = "list_box_all_accounts";
            this.list_box_all_accounts.Size = new System.Drawing.Size(565, 134);
            this.list_box_all_accounts.TabIndex = 1;
            // 
            // lbl_account_numbers
            // 
            this.lbl_account_numbers.AutoSize = true;
            this.lbl_account_numbers.Location = new System.Drawing.Point(21, 245);
            this.lbl_account_numbers.Name = "lbl_account_numbers";
            this.lbl_account_numbers.Size = new System.Drawing.Size(57, 13);
            this.lbl_account_numbers.TabIndex = 2;
            this.lbl_account_numbers.Text = "Account #";
            // 
            // lbl_name_all_accounts
            // 
            this.lbl_name_all_accounts.AutoSize = true;
            this.lbl_name_all_accounts.Location = new System.Drawing.Point(120, 245);
            this.lbl_name_all_accounts.Name = "lbl_name_all_accounts";
            this.lbl_name_all_accounts.Size = new System.Drawing.Size(35, 13);
            this.lbl_name_all_accounts.TabIndex = 3;
            this.lbl_name_all_accounts.Text = "Name";
            // 
            // lbl_balance_all_accounts
            // 
            this.lbl_balance_all_accounts.AutoSize = true;
            this.lbl_balance_all_accounts.Location = new System.Drawing.Point(209, 245);
            this.lbl_balance_all_accounts.Name = "lbl_balance_all_accounts";
            this.lbl_balance_all_accounts.Size = new System.Drawing.Size(46, 13);
            this.lbl_balance_all_accounts.TabIndex = 4;
            this.lbl_balance_all_accounts.Text = "Balance";
            // 
            // lbl_overdraft_all_accounts
            // 
            this.lbl_overdraft_all_accounts.AutoSize = true;
            this.lbl_overdraft_all_accounts.Location = new System.Drawing.Point(299, 245);
            this.lbl_overdraft_all_accounts.Name = "lbl_overdraft_all_accounts";
            this.lbl_overdraft_all_accounts.Size = new System.Drawing.Size(51, 13);
            this.lbl_overdraft_all_accounts.TabIndex = 5;
            this.lbl_overdraft_all_accounts.Text = "Overdraft";
            // 
            // btn_list_all_accounts
            // 
            this.btn_list_all_accounts.Location = new System.Drawing.Point(439, 222);
            this.btn_list_all_accounts.Name = "btn_list_all_accounts";
            this.btn_list_all_accounts.Size = new System.Drawing.Size(125, 23);
            this.btn_list_all_accounts.TabIndex = 6;
            this.btn_list_all_accounts.Text = "List Accounts";
            this.btn_list_all_accounts.UseVisualStyleBackColor = true;
            this.btn_list_all_accounts.Click += new System.EventHandler(this.btn_list_all_accounts_Click);
            // 
            // BankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(617, 438);
            this.Controls.Add(this.btn_list_all_accounts);
            this.Controls.Add(this.lbl_overdraft_all_accounts);
            this.Controls.Add(this.lbl_balance_all_accounts);
            this.Controls.Add(this.lbl_name_all_accounts);
            this.Controls.Add(this.lbl_account_numbers);
            this.Controls.Add(this.list_box_all_accounts);
            this.Controls.Add(this.tab_accounts);
            this.Name = "BankForm";
            this.Text = "BankForm";
            this.Load += new System.EventHandler(this.BankForm_Load_1);
            this.tab_accounts.ResumeLayout(false);
            this.tab_Current.ResumeLayout(false);
            this.tab_Current.PerformLayout();
            this.tab_Savings.ResumeLayout(false);
            this.tab_Savings.PerformLayout();
            this.tab_current_transaction.ResumeLayout(false);
            this.tab_current_transaction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_accounts;
        private System.Windows.Forms.TabPage tab_Current;
        private System.Windows.Forms.TabPage tab_Savings;
        private System.Windows.Forms.ListBox list_box_all_accounts;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_box_name;
        private System.Windows.Forms.Button btn_create_current_account;
        private System.Windows.Forms.TextBox txt_box_overdraft;
        private System.Windows.Forms.Label lbl_overdraft;
        private System.Windows.Forms.TextBox txt_box_balance;
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.Label lbl_balance_savings;
        private System.Windows.Forms.Label lbl_name_savings;
        private System.Windows.Forms.TextBox txt_box_transaction;
        private System.Windows.Forms.Button btn_deposit;
        private System.Windows.Forms.Button btn_withdraw;
        private System.Windows.Forms.Button btn_create_savings_account;
        private System.Windows.Forms.TextBox txt_box_balance_savings;
        private System.Windows.Forms.TextBox txt_box_name_savings;
        private System.Windows.Forms.TabPage tab_current_transaction;
        private System.Windows.Forms.ListBox list_box_single_account;
        private System.Windows.Forms.Label lbl_account_numbers;
        private System.Windows.Forms.Label lbl_name_all_accounts;
        private System.Windows.Forms.Label lbl_balance_all_accounts;
        private System.Windows.Forms.Label lbl_overdraft_all_accounts;
        private System.Windows.Forms.Button btn_close_account;
        private System.Windows.Forms.Button btn_list_all_accounts;
        private System.Windows.Forms.ComboBox cmb_box_account_numbers;
    }
}