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
            this.btnBook = new System.Windows.Forms.Button();
            this.lbxShowCars = new System.Windows.Forms.ListBox();
            this.pnlAddCar = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbColour = new System.Windows.Forms.TextBox();
            this.txbModel = new System.Windows.Forms.TextBox();
            this.txbMake = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlReturnCar = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lbxReturnCar = new System.Windows.Forms.ListBox();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lbxCurrentlyRenting = new System.Windows.Forms.ListBox();
            this.lblCurrentlyRenting = new System.Windows.Forms.Label();
            this.lblCarRented = new System.Windows.Forms.Label();
            this.pnlShowCars.SuspendLayout();
            this.pnlAddCar.SuspendLayout();
            this.pnlReturnCar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCarCounter
            // 
            this.lblCarCounter.AutoSize = true;
            this.lblCarCounter.Location = new System.Drawing.Point(3, 162);
            this.lblCarCounter.Name = "lblCarCounter";
            this.lblCarCounter.Size = new System.Drawing.Size(10, 13);
            this.lblCarCounter.TabIndex = 0;
            this.lblCarCounter.Text = " ";
            // 
            // btnShowCars
            // 
            this.btnShowCars.Location = new System.Drawing.Point(15, 46);
            this.btnShowCars.Name = "btnShowCars";
            this.btnShowCars.Size = new System.Drawing.Size(67, 23);
            this.btnShowCars.TabIndex = 2;
            this.btnShowCars.Text = "Show cars";
            this.btnShowCars.UseVisualStyleBackColor = true;
            this.btnShowCars.Click += new System.EventHandler(this.btnShowCars_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(88, 46);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(67, 23);
            this.btnAddCar.TabIndex = 3;
            this.btnAddCar.Text = "Add car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnReturnCar
            // 
            this.btnReturnCar.Location = new System.Drawing.Point(161, 46);
            this.btnReturnCar.Name = "btnReturnCar";
            this.btnReturnCar.Size = new System.Drawing.Size(67, 23);
            this.btnReturnCar.TabIndex = 4;
            this.btnReturnCar.Text = "Return car";
            this.btnReturnCar.UseVisualStyleBackColor = true;
            this.btnReturnCar.Click += new System.EventHandler(this.btnReturnCar_Click);
            // 
            // pnlShowCars
            // 
            this.pnlShowCars.Controls.Add(this.lblLastName);
            this.pnlShowCars.Controls.Add(this.lblFirstName);
            this.pnlShowCars.Controls.Add(this.txbLastName);
            this.pnlShowCars.Controls.Add(this.txbFirstName);
            this.pnlShowCars.Controls.Add(this.btnBook);
            this.pnlShowCars.Controls.Add(this.lbxShowCars);
            this.pnlShowCars.Controls.Add(this.lblCarCounter);
            this.pnlShowCars.Location = new System.Drawing.Point(15, 75);
            this.pnlShowCars.Name = "pnlShowCars";
            this.pnlShowCars.Size = new System.Drawing.Size(213, 183);
            this.pnlShowCars.TabIndex = 5;
            this.pnlShowCars.Visible = false;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(135, 157);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 23);
            this.btnBook.TabIndex = 1;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Visible = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // lbxShowCars
            // 
            this.lbxShowCars.FormattingEnabled = true;
            this.lbxShowCars.Location = new System.Drawing.Point(3, 3);
            this.lbxShowCars.Name = "lbxShowCars";
            this.lbxShowCars.Size = new System.Drawing.Size(207, 95);
            this.lbxShowCars.TabIndex = 0;
            this.lbxShowCars.SelectedIndexChanged += new System.EventHandler(this.lbxShowCars_SelectedIndexChanged);
            // 
            // pnlAddCar
            // 
            this.pnlAddCar.Controls.Add(this.label3);
            this.pnlAddCar.Controls.Add(this.label2);
            this.pnlAddCar.Controls.Add(this.label1);
            this.pnlAddCar.Controls.Add(this.txbColour);
            this.pnlAddCar.Controls.Add(this.txbModel);
            this.pnlAddCar.Controls.Add(this.txbMake);
            this.pnlAddCar.Controls.Add(this.btnAdd);
            this.pnlAddCar.Location = new System.Drawing.Point(234, 75);
            this.pnlAddCar.Name = "pnlAddCar";
            this.pnlAddCar.Size = new System.Drawing.Size(213, 183);
            this.pnlAddCar.TabIndex = 6;
            this.pnlAddCar.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Colour:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Make:";
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
            this.pnlReturnCar.Location = new System.Drawing.Point(453, 75);
            this.pnlReturnCar.Name = "pnlReturnCar";
            this.pnlReturnCar.Size = new System.Drawing.Size(256, 183);
            this.pnlReturnCar.TabIndex = 6;
            this.pnlReturnCar.Visible = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(174, 152);
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
            this.lbxReturnCar.Location = new System.Drawing.Point(107, 32);
            this.lbxReturnCar.Name = "lbxReturnCar";
            this.lbxReturnCar.Size = new System.Drawing.Size(142, 95);
            this.lbxReturnCar.TabIndex = 1;
            this.lbxReturnCar.SelectedIndexChanged += new System.EventHandler(this.lbxReturnCar_SelectedIndexChanged);
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(73, 102);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(137, 20);
            this.txbFirstName.TabIndex = 2;
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(73, 128);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(137, 20);
            this.txbLastName.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(3, 105);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(3, 131);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name:";
            // 
            // lbxCurrentlyRenting
            // 
            this.lbxCurrentlyRenting.FormattingEnabled = true;
            this.lbxCurrentlyRenting.Location = new System.Drawing.Point(3, 32);
            this.lbxCurrentlyRenting.Name = "lbxCurrentlyRenting";
            this.lbxCurrentlyRenting.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbxCurrentlyRenting.Size = new System.Drawing.Size(102, 95);
            this.lbxCurrentlyRenting.TabIndex = 4;
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
            // lblCarRented
            // 
            this.lblCarRented.AutoSize = true;
            this.lblCarRented.Location = new System.Drawing.Point(104, 13);
            this.lblCarRented.Name = "lblCarRented";
            this.lblCarRented.Size = new System.Drawing.Size(59, 13);
            this.lblCarRented.TabIndex = 7;
            this.lblCarRented.Text = "Car rented:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 330);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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
    }
}

