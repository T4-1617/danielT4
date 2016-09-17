namespace _160916CarRental
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
            this.lblCarCounter = new System.Windows.Forms.Label();
            this.btnShowCars = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnReturnCar = new System.Windows.Forms.Button();
            this.pnlShowCars = new System.Windows.Forms.Panel();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.lbxShowCars = new System.Windows.Forms.ListBox();
            this.pnlAddCar = new System.Windows.Forms.Panel();
            this.lblColour = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.txbColour = new System.Windows.Forms.TextBox();
            this.txbModel = new System.Windows.Forms.TextBox();
            this.txbMake = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlReturnCar = new System.Windows.Forms.Panel();
            this.lblCarRented = new System.Windows.Forms.Label();
            this.lblCurrentlyRenting = new System.Windows.Forms.Label();
            this.lbxCurrentlyRenting = new System.Windows.Forms.ListBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lbxReturnCar = new System.Windows.Forms.ListBox();
            this.pnlMore = new System.Windows.Forms.Panel();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbPhoneNum = new System.Windows.Forms.TextBox();
            this.txbAddress1 = new System.Windows.Forms.TextBox();
            this.txbAddress2 = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.btnMore = new System.Windows.Forms.Button();
            this.btnLess = new System.Windows.Forms.Button();
            this.pnlShowCars.SuspendLayout();
            this.pnlAddCar.SuspendLayout();
            this.pnlReturnCar.SuspendLayout();
            this.pnlMore.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCarCounter
            // 
            this.lblCarCounter.AutoSize = true;
            this.lblCarCounter.Location = new System.Drawing.Point(3, 4);
            this.lblCarCounter.Name = "lblCarCounter";
            this.lblCarCounter.Size = new System.Drawing.Size(10, 13);
            this.lblCarCounter.TabIndex = 0;
            this.lblCarCounter.Text = " ";
            // 
            // btnShowCars
            // 
            this.btnShowCars.Location = new System.Drawing.Point(15, 34);
            this.btnShowCars.Name = "btnShowCars";
            this.btnShowCars.Size = new System.Drawing.Size(67, 23);
            this.btnShowCars.TabIndex = 2;
            this.btnShowCars.Text = "Show cars";
            this.btnShowCars.UseVisualStyleBackColor = true;
            this.btnShowCars.Click += new System.EventHandler(this.btnShowCars_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(88, 34);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(67, 23);
            this.btnAddCar.TabIndex = 3;
            this.btnAddCar.Text = "Add car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnReturnCar
            // 
            this.btnReturnCar.Location = new System.Drawing.Point(161, 34);
            this.btnReturnCar.Name = "btnReturnCar";
            this.btnReturnCar.Size = new System.Drawing.Size(67, 23);
            this.btnReturnCar.TabIndex = 4;
            this.btnReturnCar.Text = "Return car";
            this.btnReturnCar.UseVisualStyleBackColor = true;
            this.btnReturnCar.Click += new System.EventHandler(this.btnReturnCar_Click);
            // 
            // pnlShowCars
            // 
            this.pnlShowCars.Controls.Add(this.btnLess);
            this.pnlShowCars.Controls.Add(this.btnMore);
            this.pnlShowCars.Controls.Add(this.pnlMore);
            this.pnlShowCars.Controls.Add(this.lblLastName);
            this.pnlShowCars.Controls.Add(this.lblFirstName);
            this.pnlShowCars.Controls.Add(this.txbLastName);
            this.pnlShowCars.Controls.Add(this.txbFirstName);
            this.pnlShowCars.Controls.Add(this.lblCarCounter);
            this.pnlShowCars.Controls.Add(this.btnBook);
            this.pnlShowCars.Controls.Add(this.lbxShowCars);
            this.pnlShowCars.Location = new System.Drawing.Point(15, 58);
            this.pnlShowCars.Name = "pnlShowCars";
            this.pnlShowCars.Size = new System.Drawing.Size(213, 322);
            this.pnlShowCars.TabIndex = 5;
            this.pnlShowCars.Visible = false;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(3, 148);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(65, 13);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "*Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(3, 122);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(64, 13);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "*First Name:";
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(73, 145);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(137, 20);
            this.txbLastName.TabIndex = 3;
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(73, 119);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(137, 20);
            this.txbFirstName.TabIndex = 2;
            // 
            // btnBook
            // 
            this.btnBook.Enabled = false;
            this.btnBook.Location = new System.Drawing.Point(135, 174);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 23);
            this.btnBook.TabIndex = 1;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // lbxShowCars
            // 
            this.lbxShowCars.FormattingEnabled = true;
            this.lbxShowCars.Location = new System.Drawing.Point(3, 20);
            this.lbxShowCars.Name = "lbxShowCars";
            this.lbxShowCars.Size = new System.Drawing.Size(207, 95);
            this.lbxShowCars.TabIndex = 0;
            this.lbxShowCars.SelectedIndexChanged += new System.EventHandler(this.lbxShowCars_SelectedIndexChanged);
            // 
            // pnlAddCar
            // 
            this.pnlAddCar.Controls.Add(this.lblColour);
            this.pnlAddCar.Controls.Add(this.lblModel);
            this.pnlAddCar.Controls.Add(this.lblMake);
            this.pnlAddCar.Controls.Add(this.txbColour);
            this.pnlAddCar.Controls.Add(this.txbModel);
            this.pnlAddCar.Controls.Add(this.txbMake);
            this.pnlAddCar.Controls.Add(this.btnAdd);
            this.pnlAddCar.Location = new System.Drawing.Point(15, 58);
            this.pnlAddCar.Name = "pnlAddCar";
            this.pnlAddCar.Size = new System.Drawing.Size(213, 183);
            this.pnlAddCar.TabIndex = 6;
            this.pnlAddCar.Visible = false;
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(3, 68);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(40, 13);
            this.lblColour.TabIndex = 8;
            this.lblColour.Text = "Colour:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(3, 42);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 7;
            this.lblModel.Text = "Model:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(3, 16);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(37, 13);
            this.lblMake.TabIndex = 6;
            this.lblMake.Text = "Make:";
            // 
            // txbColour
            // 
            this.txbColour.Location = new System.Drawing.Point(110, 65);
            this.txbColour.Name = "txbColour";
            this.txbColour.Size = new System.Drawing.Size(100, 20);
            this.txbColour.TabIndex = 5;
            // 
            // txbModel
            // 
            this.txbModel.Location = new System.Drawing.Point(110, 39);
            this.txbModel.Name = "txbModel";
            this.txbModel.Size = new System.Drawing.Size(100, 20);
            this.txbModel.TabIndex = 4;
            // 
            // txbMake
            // 
            this.txbMake.Location = new System.Drawing.Point(110, 13);
            this.txbMake.Name = "txbMake";
            this.txbMake.Size = new System.Drawing.Size(100, 20);
            this.txbMake.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(135, 104);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlReturnCar
            // 
            this.pnlReturnCar.Controls.Add(this.lblCarRented);
            this.pnlReturnCar.Controls.Add(this.lblCurrentlyRenting);
            this.pnlReturnCar.Controls.Add(this.lbxCurrentlyRenting);
            this.pnlReturnCar.Controls.Add(this.btnReturn);
            this.pnlReturnCar.Controls.Add(this.lbxReturnCar);
            this.pnlReturnCar.Location = new System.Drawing.Point(15, 58);
            this.pnlReturnCar.Name = "pnlReturnCar";
            this.pnlReturnCar.Size = new System.Drawing.Size(278, 190);
            this.pnlReturnCar.TabIndex = 6;
            this.pnlReturnCar.Visible = false;
            // 
            // lblCarRented
            // 
            this.lblCarRented.AutoSize = true;
            this.lblCarRented.Location = new System.Drawing.Point(132, 13);
            this.lblCarRented.Name = "lblCarRented";
            this.lblCarRented.Size = new System.Drawing.Size(59, 13);
            this.lblCarRented.TabIndex = 7;
            this.lblCarRented.Text = "Car rented:";
            // 
            // lblCurrentlyRenting
            // 
            this.lblCurrentlyRenting.AutoSize = true;
            this.lblCurrentlyRenting.Location = new System.Drawing.Point(3, 13);
            this.lblCurrentlyRenting.Name = "lblCurrentlyRenting";
            this.lblCurrentlyRenting.Size = new System.Drawing.Size(86, 13);
            this.lblCurrentlyRenting.TabIndex = 6;
            this.lblCurrentlyRenting.Text = "Currently renting:";
            // 
            // lbxCurrentlyRenting
            // 
            this.lbxCurrentlyRenting.FormattingEnabled = true;
            this.lbxCurrentlyRenting.Location = new System.Drawing.Point(3, 32);
            this.lbxCurrentlyRenting.Name = "lbxCurrentlyRenting";
            this.lbxCurrentlyRenting.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbxCurrentlyRenting.Size = new System.Drawing.Size(126, 121);
            this.lbxCurrentlyRenting.TabIndex = 4;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(200, 160);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lbxReturnCar
            // 
            this.lbxReturnCar.FormattingEnabled = true;
            this.lbxReturnCar.HorizontalScrollbar = true;
            this.lbxReturnCar.Location = new System.Drawing.Point(133, 32);
            this.lbxReturnCar.Name = "lbxReturnCar";
            this.lbxReturnCar.Size = new System.Drawing.Size(142, 121);
            this.lbxReturnCar.TabIndex = 1;
            this.lbxReturnCar.SelectedIndexChanged += new System.EventHandler(this.lbxReturnCar_SelectedIndexChanged);
            // 
            // pnlMore
            // 
            this.pnlMore.Controls.Add(this.lblAddress2);
            this.pnlMore.Controls.Add(this.lblAddress1);
            this.pnlMore.Controls.Add(this.lblPhoneNum);
            this.pnlMore.Controls.Add(this.lblEmail);
            this.pnlMore.Controls.Add(this.txbAddress2);
            this.pnlMore.Controls.Add(this.txbAddress1);
            this.pnlMore.Controls.Add(this.txbPhoneNum);
            this.pnlMore.Controls.Add(this.txbEmail);
            this.pnlMore.Location = new System.Drawing.Point(4, 171);
            this.pnlMore.Name = "pnlMore";
            this.pnlMore.Size = new System.Drawing.Size(206, 107);
            this.pnlMore.TabIndex = 6;
            this.pnlMore.Visible = false;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(69, 3);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(137, 20);
            this.txbEmail.TabIndex = 0;
            // 
            // txbPhoneNum
            // 
            this.txbPhoneNum.Location = new System.Drawing.Point(69, 29);
            this.txbPhoneNum.Name = "txbPhoneNum";
            this.txbPhoneNum.Size = new System.Drawing.Size(137, 20);
            this.txbPhoneNum.TabIndex = 1;
            // 
            // txbAddress1
            // 
            this.txbAddress1.Location = new System.Drawing.Point(69, 55);
            this.txbAddress1.Name = "txbAddress1";
            this.txbAddress1.Size = new System.Drawing.Size(137, 20);
            this.txbAddress1.TabIndex = 2;
            // 
            // txbAddress2
            // 
            this.txbAddress2.Location = new System.Drawing.Point(69, 81);
            this.txbAddress2.Name = "txbAddress2";
            this.txbAddress2.Size = new System.Drawing.Size(137, 20);
            this.txbAddress2.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(3, 6);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Location = new System.Drawing.Point(3, 32);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(66, 13);
            this.lblPhoneNum.TabIndex = 5;
            this.lblPhoneNum.Text = "Phone Num:";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(3, 58);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(57, 13);
            this.lblAddress1.TabIndex = 6;
            this.lblAddress1.Text = "Address 1:";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(3, 84);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(63, 13);
            this.lblAddress2.TabIndex = 7;
            this.lblAddress2.Text = "(Address 2):";
            // 
            // btnMore
            // 
            this.btnMore.Location = new System.Drawing.Point(6, 174);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(75, 23);
            this.btnMore.TabIndex = 7;
            this.btnMore.Text = "More";
            this.btnMore.UseVisualStyleBackColor = true;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // btnLess
            // 
            this.btnLess.Location = new System.Drawing.Point(6, 296);
            this.btnLess.Name = "btnLess";
            this.btnLess.Size = new System.Drawing.Size(75, 23);
            this.btnLess.TabIndex = 8;
            this.btnLess.Text = "Less";
            this.btnLess.UseVisualStyleBackColor = true;
            this.btnLess.Visible = false;
            this.btnLess.Click += new System.EventHandler(this.btnLess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 382);
            this.Controls.Add(this.pnlReturnCar);
            this.Controls.Add(this.pnlAddCar);
            this.Controls.Add(this.pnlShowCars);
            this.Controls.Add(this.btnReturnCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.btnShowCars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlShowCars.ResumeLayout(false);
            this.pnlShowCars.PerformLayout();
            this.pnlAddCar.ResumeLayout(false);
            this.pnlAddCar.PerformLayout();
            this.pnlReturnCar.ResumeLayout(false);
            this.pnlReturnCar.PerformLayout();
            this.pnlMore.ResumeLayout(false);
            this.pnlMore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCarCounter;
        private System.Windows.Forms.Button btnShowCars;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnReturnCar;
        private System.Windows.Forms.Panel pnlShowCars;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.ListBox lbxShowCars;
        private System.Windows.Forms.Panel pnlAddCar;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.TextBox txbColour;
        private System.Windows.Forms.TextBox txbModel;
        private System.Windows.Forms.TextBox txbMake;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlReturnCar;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListBox lbxReturnCar;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.ListBox lbxCurrentlyRenting;
        private System.Windows.Forms.Label lblCarRented;
        private System.Windows.Forms.Label lblCurrentlyRenting;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.Panel pnlMore;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txbAddress2;
        private System.Windows.Forms.TextBox txbAddress1;
        private System.Windows.Forms.TextBox txbPhoneNum;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Button btnLess;
    }
}

