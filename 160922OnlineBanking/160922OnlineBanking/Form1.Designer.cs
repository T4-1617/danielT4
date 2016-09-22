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
            this.btnViewAccount = new System.Windows.Forms.Button();
            this.btnViewDeposit = new System.Windows.Forms.Button();
            this.btnViewWithdraw = new System.Windows.Forms.Button();
            this.btnViewBalance = new System.Windows.Forms.Button();
            this.btnViewTransactions = new System.Windows.Forms.Button();
            this.lbxCustomer = new System.Windows.Forms.ListBox();
            this.lbxAccount = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.btnCancelCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbPersonalID = new System.Windows.Forms.TextBox();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.btnViewCustomer = new System.Windows.Forms.Button();
            this.pnlAccount = new System.Windows.Forms.Panel();
            this.btnCancelAccount = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txbInitialDeposit = new System.Windows.Forms.TextBox();
            this.txbAccountName = new System.Windows.Forms.TextBox();
            this.pnlDeposit = new System.Windows.Forms.Panel();
            this.pnlWithdraw = new System.Windows.Forms.Panel();
            this.pnlBalance = new System.Windows.Forms.Panel();
            this.pnlTransactions = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txbDeposit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbWithdraw = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbxTransactions = new System.Windows.Forms.ListBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.pnlCustomer.SuspendLayout();
            this.pnlAccount.SuspendLayout();
            this.pnlDeposit.SuspendLayout();
            this.pnlWithdraw.SuspendLayout();
            this.pnlBalance.SuspendLayout();
            this.pnlTransactions.SuspendLayout();
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
            // btnViewAccount
            // 
            this.btnViewAccount.Enabled = false;
            this.btnViewAccount.Location = new System.Drawing.Point(13, 168);
            this.btnViewAccount.Name = "btnViewAccount";
            this.btnViewAccount.Size = new System.Drawing.Size(109, 96);
            this.btnViewAccount.TabIndex = 2;
            this.btnViewAccount.Text = "Öppna konto";
            this.btnViewAccount.UseVisualStyleBackColor = true;
            this.btnViewAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnViewDeposit
            // 
            this.btnViewDeposit.Enabled = false;
            this.btnViewDeposit.Location = new System.Drawing.Point(13, 270);
            this.btnViewDeposit.Name = "btnViewDeposit";
            this.btnViewDeposit.Size = new System.Drawing.Size(109, 96);
            this.btnViewDeposit.TabIndex = 3;
            this.btnViewDeposit.Text = "Sätt in pengar";
            this.btnViewDeposit.UseVisualStyleBackColor = true;
            this.btnViewDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnViewWithdraw
            // 
            this.btnViewWithdraw.Enabled = false;
            this.btnViewWithdraw.Location = new System.Drawing.Point(12, 372);
            this.btnViewWithdraw.Name = "btnViewWithdraw";
            this.btnViewWithdraw.Size = new System.Drawing.Size(109, 96);
            this.btnViewWithdraw.TabIndex = 4;
            this.btnViewWithdraw.Text = "Ta ut pengar";
            this.btnViewWithdraw.UseVisualStyleBackColor = true;
            this.btnViewWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnViewBalance
            // 
            this.btnViewBalance.Enabled = false;
            this.btnViewBalance.Location = new System.Drawing.Point(13, 474);
            this.btnViewBalance.Name = "btnViewBalance";
            this.btnViewBalance.Size = new System.Drawing.Size(109, 96);
            this.btnViewBalance.TabIndex = 5;
            this.btnViewBalance.Text = "Saldo";
            this.btnViewBalance.UseVisualStyleBackColor = true;
            this.btnViewBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnViewTransactions
            // 
            this.btnViewTransactions.Enabled = false;
            this.btnViewTransactions.Location = new System.Drawing.Point(12, 576);
            this.btnViewTransactions.Name = "btnViewTransactions";
            this.btnViewTransactions.Size = new System.Drawing.Size(109, 96);
            this.btnViewTransactions.TabIndex = 6;
            this.btnViewTransactions.Text = "Transaktioner";
            this.btnViewTransactions.UseVisualStyleBackColor = true;
            this.btnViewTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
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
            this.pnlCustomer.Visible = false;
            // 
            // btnCancelCustomer
            // 
            this.btnCancelCustomer.Location = new System.Drawing.Point(87, 166);
            this.btnCancelCustomer.Name = "btnCancelCustomer";
            this.btnCancelCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnCancelCustomer.TabIndex = 7;
            this.btnCancelCustomer.Text = "Avbryt";
            this.btnCancelCustomer.UseVisualStyleBackColor = true;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(6, 166);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnAddCustomer.TabIndex = 6;
            this.btnAddCustomer.Text = "Lägg till";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Personnummer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Efternamn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Förnamn";
            // 
            // txbPersonalID
            // 
            this.txbPersonalID.Location = new System.Drawing.Point(147, 73);
            this.txbPersonalID.Name = "txbPersonalID";
            this.txbPersonalID.Size = new System.Drawing.Size(100, 20);
            this.txbPersonalID.TabIndex = 2;
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(147, 47);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(100, 20);
            this.txbLastName.TabIndex = 1;
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(147, 21);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(100, 20);
            this.txbFirstName.TabIndex = 0;
            // 
            // btnViewCustomer
            // 
            this.btnViewCustomer.Enabled = false;
            this.btnViewCustomer.Location = new System.Drawing.Point(13, 66);
            this.btnViewCustomer.Name = "btnViewCustomer";
            this.btnViewCustomer.Size = new System.Drawing.Size(109, 96);
            this.btnViewCustomer.TabIndex = 12;
            this.btnViewCustomer.Text = "Ny kund";
            this.btnViewCustomer.UseVisualStyleBackColor = true;
            this.btnViewCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // pnlAccount
            // 
            this.pnlAccount.Controls.Add(this.btnCancelAccount);
            this.pnlAccount.Controls.Add(this.label8);
            this.pnlAccount.Controls.Add(this.btnAddAccount);
            this.pnlAccount.Controls.Add(this.label7);
            this.pnlAccount.Controls.Add(this.txbInitialDeposit);
            this.pnlAccount.Controls.Add(this.txbAccountName);
            this.pnlAccount.Location = new System.Drawing.Point(384, 67);
            this.pnlAccount.Name = "pnlAccount";
            this.pnlAccount.Size = new System.Drawing.Size(250, 198);
            this.pnlAccount.TabIndex = 12;
            this.pnlAccount.Visible = false;
            // 
            // btnCancelAccount
            // 
            this.btnCancelAccount.Location = new System.Drawing.Point(87, 166);
            this.btnCancelAccount.Name = "btnCancelAccount";
            this.btnCancelAccount.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAccount.TabIndex = 9;
            this.btnCancelAccount.Text = "Avbryt";
            this.btnCancelAccount.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Belopp att sätta in";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(6, 166);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(75, 23);
            this.btnAddAccount.TabIndex = 8;
            this.btnAddAccount.Text = "Lägg till";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kontonamn";
            // 
            // txbInitialDeposit
            // 
            this.txbInitialDeposit.Location = new System.Drawing.Point(147, 47);
            this.txbInitialDeposit.Name = "txbInitialDeposit";
            this.txbInitialDeposit.Size = new System.Drawing.Size(100, 20);
            this.txbInitialDeposit.TabIndex = 7;
            // 
            // txbAccountName
            // 
            this.txbAccountName.Location = new System.Drawing.Point(147, 21);
            this.txbAccountName.Name = "txbAccountName";
            this.txbAccountName.Size = new System.Drawing.Size(100, 20);
            this.txbAccountName.TabIndex = 6;
            // 
            // pnlDeposit
            // 
            this.pnlDeposit.Controls.Add(this.btnDeposit);
            this.pnlDeposit.Controls.Add(this.label9);
            this.pnlDeposit.Controls.Add(this.txbDeposit);
            this.pnlDeposit.Location = new System.Drawing.Point(128, 270);
            this.pnlDeposit.Name = "pnlDeposit";
            this.pnlDeposit.Size = new System.Drawing.Size(250, 198);
            this.pnlDeposit.TabIndex = 13;
            this.pnlDeposit.Visible = false;
            // 
            // pnlWithdraw
            // 
            this.pnlWithdraw.Controls.Add(this.btnWithdraw);
            this.pnlWithdraw.Controls.Add(this.label10);
            this.pnlWithdraw.Controls.Add(this.txbWithdraw);
            this.pnlWithdraw.Location = new System.Drawing.Point(384, 270);
            this.pnlWithdraw.Name = "pnlWithdraw";
            this.pnlWithdraw.Size = new System.Drawing.Size(250, 198);
            this.pnlWithdraw.TabIndex = 13;
            this.pnlWithdraw.Visible = false;
            // 
            // pnlBalance
            // 
            this.pnlBalance.Controls.Add(this.lblSaldo);
            this.pnlBalance.Location = new System.Drawing.Point(128, 474);
            this.pnlBalance.Name = "pnlBalance";
            this.pnlBalance.Size = new System.Drawing.Size(250, 198);
            this.pnlBalance.TabIndex = 13;
            this.pnlBalance.Visible = false;
            // 
            // pnlTransactions
            // 
            this.pnlTransactions.Controls.Add(this.lbxTransactions);
            this.pnlTransactions.Controls.Add(this.label12);
            this.pnlTransactions.Location = new System.Drawing.Point(384, 474);
            this.pnlTransactions.Name = "pnlTransactions";
            this.pnlTransactions.Size = new System.Drawing.Size(250, 198);
            this.pnlTransactions.TabIndex = 13;
            this.pnlTransactions.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Belopp att sätta in";
            // 
            // txbDeposit
            // 
            this.txbDeposit.Location = new System.Drawing.Point(147, 13);
            this.txbDeposit.Name = "txbDeposit";
            this.txbDeposit.Size = new System.Drawing.Size(100, 20);
            this.txbDeposit.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Belopp att ta ut";
            // 
            // txbWithdraw
            // 
            this.txbWithdraw.Location = new System.Drawing.Point(147, 13);
            this.txbWithdraw.Name = "txbWithdraw";
            this.txbWithdraw.Size = new System.Drawing.Size(100, 20);
            this.txbWithdraw.TabIndex = 4;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(3, 17);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(66, 13);
            this.lblSaldo.TabIndex = 7;
            this.lblSaldo.Text = "Ditt saldo är:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Dina transaktioner:";
            // 
            // lbxTransactions
            // 
            this.lbxTransactions.FormattingEnabled = true;
            this.lbxTransactions.Location = new System.Drawing.Point(6, 33);
            this.lbxTransactions.Name = "lbxTransactions";
            this.lbxTransactions.Size = new System.Drawing.Size(241, 160);
            this.lbxTransactions.TabIndex = 10;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(6, 161);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 10;
            this.btnDeposit.Text = "Sätt in";
            this.btnDeposit.UseVisualStyleBackColor = true;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(6, 161);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btnWithdraw.TabIndex = 11;
            this.btnWithdraw.Text = "Ta ut";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 741);
            this.Controls.Add(this.pnlTransactions);
            this.Controls.Add(this.pnlBalance);
            this.Controls.Add(this.pnlWithdraw);
            this.Controls.Add(this.pnlDeposit);
            this.Controls.Add(this.pnlAccount);
            this.Controls.Add(this.btnViewCustomer);
            this.Controls.Add(this.pnlCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxAccount);
            this.Controls.Add(this.lbxCustomer);
            this.Controls.Add(this.btnViewTransactions);
            this.Controls.Add(this.btnViewBalance);
            this.Controls.Add(this.btnViewWithdraw);
            this.Controls.Add(this.btnViewDeposit);
            this.Controls.Add(this.btnViewAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPersonType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            this.pnlAccount.ResumeLayout(false);
            this.pnlAccount.PerformLayout();
            this.pnlDeposit.ResumeLayout(false);
            this.pnlDeposit.PerformLayout();
            this.pnlWithdraw.ResumeLayout(false);
            this.pnlWithdraw.PerformLayout();
            this.pnlBalance.ResumeLayout(false);
            this.pnlBalance.PerformLayout();
            this.pnlTransactions.ResumeLayout(false);
            this.pnlTransactions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPersonType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewAccount;
        private System.Windows.Forms.Button btnViewDeposit;
        private System.Windows.Forms.Button btnViewWithdraw;
        private System.Windows.Forms.Button btnViewBalance;
        private System.Windows.Forms.Button btnViewTransactions;
        private System.Windows.Forms.ListBox lbxCustomer;
        private System.Windows.Forms.ListBox lbxAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Button btnViewCustomer;
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
        private System.Windows.Forms.TextBox txbInitialDeposit;
        private System.Windows.Forms.TextBox txbAccountName;
        private System.Windows.Forms.Panel pnlDeposit;
        private System.Windows.Forms.Panel pnlWithdraw;
        private System.Windows.Forms.Panel pnlBalance;
        private System.Windows.Forms.Panel pnlTransactions;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbDeposit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbWithdraw;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.ListBox lbxTransactions;
        private System.Windows.Forms.Button btnWithdraw;
    }
}

