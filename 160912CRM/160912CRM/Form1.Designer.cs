namespace _160912CRM
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblList = new System.Windows.Forms.Label();
            this.lbxList = new System.Windows.Forms.ListBox();
            this.lblCustomerCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 19);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(48, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Förnamn";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 48);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(55, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Efternamn";
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(73, 16);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(199, 20);
            this.txbFirstName.TabIndex = 2;
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(73, 45);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(199, 20);
            this.txbLastName.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 71);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Lägg till";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(12, 113);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(66, 13);
            this.lblList.TabIndex = 5;
            this.lblList.Text = "Mina kunder";
            // 
            // lbxList
            // 
            this.lbxList.FormattingEnabled = true;
            this.lbxList.Location = new System.Drawing.Point(15, 129);
            this.lbxList.Name = "lbxList";
            this.lbxList.Size = new System.Drawing.Size(257, 95);
            this.lbxList.TabIndex = 6;
            // 
            // lblCustomerCounter
            // 
            this.lblCustomerCounter.AutoSize = true;
            this.lblCustomerCounter.Location = new System.Drawing.Point(12, 239);
            this.lblCustomerCounter.Name = "lblCustomerCounter";
            this.lblCustomerCounter.Size = new System.Drawing.Size(97, 13);
            this.lblCustomerCounter.TabIndex = 7;
            this.lblCustomerCounter.Text = "Du har x st kunder.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblCustomerCounter);
            this.Controls.Add(this.lbxList);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbLastName);
            this.Controls.Add(this.txbFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.ListBox lbxList;
        private System.Windows.Forms.Label lblCustomerCounter;
    }
}

