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
            this.lbxCarsAvailable = new System.Windows.Forms.ListBox();
            this.btnShowCars = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnReturnCar = new System.Windows.Forms.Button();
            this.lbxAddCars = new System.Windows.Forms.ListBox();
            this.lbCarsForReturn = new System.Windows.Forms.ListBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCarCounter
            // 
            this.lblCarCounter.AutoSize = true;
            this.lblCarCounter.Location = new System.Drawing.Point(12, 9);
            this.lblCarCounter.Name = "lblCarCounter";
            this.lblCarCounter.Size = new System.Drawing.Size(85, 13);
            this.lblCarCounter.TabIndex = 0;
            this.lblCarCounter.Text = "We have x cars.";
            // 
            // lbxCarsAvailable
            // 
            this.lbxCarsAvailable.FormattingEnabled = true;
            this.lbxCarsAvailable.Location = new System.Drawing.Point(15, 85);
            this.lbxCarsAvailable.Name = "lbxCarsAvailable";
            this.lbxCarsAvailable.Size = new System.Drawing.Size(213, 95);
            this.lbxCarsAvailable.TabIndex = 1;
            // 
            // btnShowCars
            // 
            this.btnShowCars.Location = new System.Drawing.Point(15, 46);
            this.btnShowCars.Name = "btnShowCars";
            this.btnShowCars.Size = new System.Drawing.Size(67, 23);
            this.btnShowCars.TabIndex = 2;
            this.btnShowCars.Text = "Show cars";
            this.btnShowCars.UseVisualStyleBackColor = true;
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(88, 46);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(67, 23);
            this.btnAddCar.TabIndex = 3;
            this.btnAddCar.Text = "Add car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            // 
            // btnReturnCar
            // 
            this.btnReturnCar.Location = new System.Drawing.Point(161, 46);
            this.btnReturnCar.Name = "btnReturnCar";
            this.btnReturnCar.Size = new System.Drawing.Size(67, 23);
            this.btnReturnCar.TabIndex = 4;
            this.btnReturnCar.Text = "Return car";
            this.btnReturnCar.UseVisualStyleBackColor = true;
            // 
            // lbxAddCars
            // 
            this.lbxAddCars.FormattingEnabled = true;
            this.lbxAddCars.Location = new System.Drawing.Point(234, 85);
            this.lbxAddCars.Name = "lbxAddCars";
            this.lbxAddCars.Size = new System.Drawing.Size(213, 95);
            this.lbxAddCars.TabIndex = 5;
            // 
            // lbCarsForReturn
            // 
            this.lbCarsForReturn.FormattingEnabled = true;
            this.lbCarsForReturn.Location = new System.Drawing.Point(453, 85);
            this.lbCarsForReturn.Name = "lbCarsForReturn";
            this.lbCarsForReturn.Size = new System.Drawing.Size(213, 95);
            this.lbCarsForReturn.TabIndex = 6;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(15, 186);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(67, 23);
            this.btnBook.TabIndex = 7;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(234, 186);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(453, 186);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(67, 23);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 330);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.lbCarsForReturn);
            this.Controls.Add(this.lbxAddCars);
            this.Controls.Add(this.btnReturnCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.btnShowCars);
            this.Controls.Add(this.lbxCarsAvailable);
            this.Controls.Add(this.lblCarCounter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarCounter;
        private System.Windows.Forms.ListBox lbxCarsAvailable;
        private System.Windows.Forms.Button btnShowCars;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnReturnCar;
        private System.Windows.Forms.ListBox lbxAddCars;
        private System.Windows.Forms.ListBox lbCarsForReturn;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReturn;
    }
}

