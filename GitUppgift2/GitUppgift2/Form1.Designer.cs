namespace GitUppgift2
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
            this.txbFirst = new System.Windows.Forms.TextBox();
            this.txbLast = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbFirst
            // 
            this.txbFirst.Location = new System.Drawing.Point(93, 62);
            this.txbFirst.Name = "txbFirst";
            this.txbFirst.Size = new System.Drawing.Size(192, 20);
            this.txbFirst.TabIndex = 0;
            this.txbFirst.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txbLast
            // 
            this.txbLast.Location = new System.Drawing.Point(93, 135);
            this.txbLast.Name = "txbLast";
            this.txbLast.Size = new System.Drawing.Size(192, 20);
            this.txbLast.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name:";
            // 
            // btnHello
            // 
            this.btnHello.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnHello.Location = new System.Drawing.Point(126, 189);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(118, 50);
            this.btnHello.TabIndex = 4;
            this.btnHello.Text = "Hello";
            this.btnHello.UseVisualStyleBackColor = false;
            this.btnHello.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 373);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbLast);
            this.Controls.Add(this.txbFirst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbFirst;
        private System.Windows.Forms.TextBox txbLast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHello;
    }
}

