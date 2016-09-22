namespace _160922OnlineBanking
{
    partial class Form1
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
            this.cbxPersonType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.lbxCustomer = new System.Windows.Forms.ListBox();
            this.lbxAccount = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.pnlAccount = new System.Windows.Forms.Panel();
            this.pnlDeposit = new System.Windows.Forms.Panel();
            this.pnlWithdraw = new System.Windows.Forms.Panel();
            this.pnlBalance = new System.Windows.Forms.Panel();
            this.pnlTransactions = new System.Windows.Forms.Panel();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.txbPersonalID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbAccountName = new System.Windows.Forms.TextBox();
            this.txbDeposit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnCancelCustomer = new System.Windows.Forms.Button();
            this.btnCancelAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.pnlCustomer.SuspendLayout();
            this.pnlAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxPersonType
            // 
            this.cbxPersonType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPersonType.FormattingEnabled = true;
            this.cbxPersonType.Items.AddRange(new object[] {
            "Kund",
            "Personal"});
            this.cbxPersonType.Location = new System.Drawing.Point(175, 32);
            this.cbxPersonType.Name = "cbxPersonType";
            this.cbxPersonType.Size = new System.Drawing.Size(284, 21);
            this.cbxPersonType.TabIndex = 0;
            this.cbxPersonType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Välj användarroll";
            // 
            // btnAccount
            // 
            this.btnAccount.Enabled = false;
            this.btnAccount.Location = new System.Drawing.Point(13, 168);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(109, 96);
            this.btnAccount.TabIndex = 2;
            this.btnAccount.Text = "Öppna konto";
            this.btnAccount.UseVisualStyleBackColor = true;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Enabled = false;
            this.btnDeposit.Location = new System.Drawing.Point(13, 270);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(109, 96);
            this.btnDeposit.TabIndex = 3;
            this.btnDeposit.Text = "Sätt in pengar";
            this.btnDeposit.UseVisualStyleBackColor = true;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Enabled = false;
            this.btnWithdraw.Location = new System.Drawing.Point(12, 372);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(109, 96);
            this.btnWithdraw.TabIndex = 4;
            this.btnWithdraw.Text = "Ta ut pengar";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            // 
            // btnBalance
            // 
            this.btnBalance.Enabled = false;
            this.btnBalance.Location = new System.Drawing.Point(13, 474);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(109, 96);
            this.btnBalance.TabIndex = 5;
            this.btnBalance.Text = "Saldo";
            this.btnBalance.UseVisualStyleBackColor = true;
            // 
            // btnTransactions
            // 
            this.btnTransactions.Enabled = false;
            this.btnTransactions.Location = new System.Drawing.Point(12, 576);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(109, 96);
            this.btnTransactions.TabIndex = 6;
            this.btnTransactions.Text = "Transaktioner";
            this.btnTransactions.UseVisualStyleBackColor = true;
            // 
            // lbxCustomer
            // 
            this.lbxCustomer.FormattingEnabled = true;
            this.lbxCustomer.Location = new System.Drawing.Point(640, 87);
            this.lbxCustomer.Name = "lbxCustomer";
            this.lbxCustomer.Size = new System.Drawing.Size(119, 134);
            this.lbxCustomer.TabIndex = 7;
            // 
            // lbxAccount
            // 
            this.lbxAccount.FormattingEnabled = true;
            this.lbxAccount.Location = new System.Drawing.Point(640, 261);
            this.lbxAccount.Name = "lbxAccount";
            this.lbxAccount.Size = new System.Drawing.Size(119, 134);
            this.lbxAccount.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Välj kund";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(640, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Välj konto";
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.Controls.Add(this.btnCancelCustomer);
            this.pnlCustomer.Controls.Add(this.btnAddCustomer);
            this.pnlCustomer.Controls.Add(this.label6);
            this.pnlCustomer.Controls.Add(this.label5);
            this.pnlCustomer.Controls.Add(this.label4);
            this.pnlCustomer.Controls.Add(this.txbPersonalID);
            this.pnlCustomer.Controls.Add(this.txbLastName);
            this.pnlCustomer.Controls.Add(this.txbFirstName);
            this.pnlCustomer.Location = new System.Drawing.Point(128, 66);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(250, 198);
            this.pnlCustomer.TabIndex = 11;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Enabled = false;
            this.btnCustomer.Location = new System.Drawing.Point(13, 66);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(109, 96);
            this.btnCustomer.TabIndex = 12;
            this.btnCustomer.Text = "Ny kund";
            this.btnCustomer.UseVisualStyleBackColor = true;
            // 
            // pnlAccount
            // 
            this.pnlAccount.Controls.Add(this.btnCancelAccount);
            this.pnlAccount.Controls.Add(this.label8);
            this.pnlAccount.Controls.Add(this.btnAddAccount);
            this.pnlAccount.Controls.Add(this.label7);
            this.pnlAccount.Controls.Add(this.txbDeposit);
            this.pnlAccount.Controls.Add(this.txbAccountName);
            this.pnlAccount.Location = new System.Drawing.Point(384, 66);
            this.pnlAccount.Name = "pnlAccount";
            this.pnlAccount.Size = new System.Drawing.Size(250, 198);
            this.pnlAccount.TabIndex = 12;
            // 
            // pnlDeposit
            // 
            this.pnlDeposit.Location = new System.Drawing.Point(128, 270);
            this.pnlDeposit.Name = "pnlDeposit";
            this.pnlDeposit.Size = new System.Drawing.Size(250, 198);
            this.pnlDeposit.TabIndex = 13;
            // 
            // pnlWithdraw
            // 
            this.pnlWithdraw.Location = new System.Drawing.Point(384, 270);
            this.pnlWithdraw.Name = "pnlWithdraw";
            this.pnlWithdraw.Size = new System.Drawing.Size(250, 198);
            this.pnlWithdraw.TabIndex = 13;
            // 
            // pnlBalance
            // 
            this.pnlBalance.Location = new System.Drawing.Point(128, 474);
            this.pnlBalance.Name = "pnlBalance";
            this.pnlBalance.Size = new System.Drawing.Size(250, 198);
            this.pnlBalance.TabIndex = 13;
            // 
            // pnlTransactions
            // 
            this.pnlTransactions.Location = new System.Drawing.Point(384, 474);
            this.pnlTransactions.Name = "pnlTransactions";
            this.pnlTransactions.Size = new System.Drawing.Size(250, 198);
            this.pnlTransactions.TabIndex = 13;
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(147, 21);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(100, 20);
            this.txbFirstName.TabIndex = 0;
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(147, 47);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(100, 20);
            this.txbLastName.TabIndex = 1;
            // 
            // txbPersonalID
            // 
            this.txbPersonalID.Location = new System.Drawing.Point(147, 73);
            this.txbPersonalID.Name = "txbPersonalID";
            this.txbPersonalID.Size = new System.Drawing.Size(100, 20);
            this.txbPersonalID.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Last Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Personal ID:";
            // 
            // txbAccountName
            // 
            this.txbAccountName.Location = new System.Drawing.Point(147, 21);
            this.txbAccountName.Name = "txbAccountName";
            this.txbAccountName.Size = new System.Drawing.Size(100, 20);
            this.txbAccountName.TabIndex = 6;
            // 
            // txbDeposit
            // 
            this.txbDeposit.Location = new System.Drawing.Point(147, 47);
            this.txbDeposit.Name = "txbDeposit";
            this.txbDeposit.Size = new System.Drawing.Size(100, 20);
            this.txbDeposit.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Account Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Amount to deposit:";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(6, 166);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnAddCustomer.TabIndex = 6;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // btnCancelCustomer
            // 
            this.btnCancelCustomer.Location = new System.Drawing.Point(87, 166);
            this.btnCancelCustomer.Name = "btnCancelCustomer";
            this.btnCancelCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnCancelCustomer.TabIndex = 7;
            this.btnCancelCustomer.Text = "Cancel";
            this.btnCancelCustomer.UseVisualStyleBackColor = true;
            // 
            // btnCancelAccount
            // 
            this.btnCancelAccount.Location = new System.Drawing.Point(87, 166);
            this.btnCancelAccount.Name = "btnCancelAccount";
            this.btnCancelAccount.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAccount.TabIndex = 9;
            this.btnCancelAccount.Text = "Cancel";
            this.btnCancelAccount.UseVisualStyleBackColor = true;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(6, 166);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(75, 23);
            this.btnAddAccount.TabIndex = 8;
            this.btnAddAccount.Text = "Add";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 854);
            this.Controls.Add(this.pnlTransactions);
            this.Controls.Add(this.pnlBalance);
            this.Controls.Add(this.pnlWithdraw);
            this.Controls.Add(this.pnlDeposit);
            this.Controls.Add(this.pnlAccount);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.pnlCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxAccount);
            this.Controls.Add(this.lbxCustomer);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPersonType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            this.pnlAccount.ResumeLayout(false);
            this.pnlAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPersonType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.ListBox lbxCustomer;
        private System.Windows.Forms.ListBox lbxAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Panel pnlAccount;
        private System.Windows.Forms.Button btnCancelCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbPersonalID;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.Button btnCancelAccount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbDeposit;
        private System.Windows.Forms.TextBox txbAccountName;
        private System.Windows.Forms.Panel pnlDeposit;
        private System.Windows.Forms.Panel pnlWithdraw;
        private System.Windows.Forms.Panel pnlBalance;
        private System.Windows.Forms.Panel pnlTransactions;
    }
}

