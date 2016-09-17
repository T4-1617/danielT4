using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _160916CarRental
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList Cars;//Creates ArrayList "Cars".
        int CarsAvailable;//Creates a variable for counting the cars available for booking.
        public Form1()
        {
            InitializeComponent();
            lbxReturnCar.MouseDoubleClick += new MouseEventHandler(lbxReturnCar_MouseDoubleClick);
            Cars = new System.Collections.ArrayList();
            //Adds the three pre-existing cars to the ArrayList
            Cars.Add(new Car { Make = "Volvo", Model = "V70", Colour = "Red", Rented = false});
            Cars.Add(new Car { Make = "Audi", Model = "A6", Colour = "Black", Rented = false });
            Cars.Add(new Car { Make = "Volkswagen", Model = "Golf Mk6", Colour = "Yellow", Rented = false });
        }

        private void btnShowCars_Click(object sender, EventArgs e)
        {
            CarsAvailable = 0;//Resets the car counter to zero

            btnBook.Enabled = false;//Hides the "Book" button.

            //Makes sure only the selected panel is shown
            pnlShowCars.Visible = true;
            pnlAddCar.Visible = false;
            pnlReturnCar.Visible = false;

            lbxShowCars.Items.Clear();//Clears the list.

            foreach (Car item in Cars)//Prints all cars from "Cars" available to be rented.
            {
                if (!item.Rented)
                {
                    lbxShowCars.Items.Add(item);
                    CarsAvailable++;//Adds 1 to the car counter for each car available.
                }
                
            }
            lblCarCounter.Text = String.Format("There are {0} car(s) available", CarsAvailable);//Prints the amount of cars available.
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            //Makes sure only the selected panel is shown
            pnlShowCars.Visible = false;
            pnlAddCar.Visible = true;
            pnlReturnCar.Visible = false;
        }

        private void btnReturnCar_Click(object sender, EventArgs e)
        {
            //Makes sure only the selected panel is shown
            pnlShowCars.Visible = false;
            pnlAddCar.Visible = false;
            pnlReturnCar.Visible = true;

            btnReturn.Visible = false;
            
            //Clears the lists.
            lbxReturnCar.Items.Clear();
            lbxCurrentlyRenting.Items.Clear();

            foreach (Car item in Cars)//Prints all the cars already rented.
            {
                if (item.Rented)
                {
                    lbxReturnCar.Items.Add(item);
                    lbxCurrentlyRenting.Items.Add(item.FullName());
                }

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Adds a "Car" to "Cars" with property values given by the user.
            Cars.Add(new Car { Make = txbMake.Text, Model = txbModel.Text, Colour = txbColour.Text, Rented = false });
            
            //Empties the textboxes and focuses the first one for easier use.
            txbMake.Text = String.Empty;
            txbModel.Text = String.Empty;
            txbColour.Text = String.Empty;
            txbMake.Focus();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (txbFirstName.Text != string.Empty && txbLastName.Text != string.Empty)
            {
                CarsAvailable--;//Subtracts 1 from the car counter.
                btnBook.Enabled = false;//Hides the "Book" button.
                Car x = (Car)lbxShowCars.SelectedItem;//Creates a variable based on the item selected.
                x.Rented = true;//Sets "Rented" value to true.
                x.FirstName = txbFirstName.Text;
                x.LastName = txbLastName.Text;
                x.Email = txbEmail.Text;
                x.PhoneNum = txbPhoneNum.Text;
                x.Address1 = txbAddress1.Text;
                x.Address2 = txbAddress2.Text;
                lbxShowCars.Items.Clear();//Clears the list.
            
                foreach (Car item in Cars)//Prints each car available to be rented.
                {
                    if (!item.Rented)
                    {
                        lbxShowCars.Items.Add(item);
                    }

                }
            }

           else//If a textbox for the names is left empty while trying to rent this will be displayed.
            {
                MessageBox.Show("You have to enter both First name and Last name");
            }

            //Changes the label to display the amount of cars available to rent.
            lblCarCounter.Text = String.Format("There are {0} car(s) available", CarsAvailable);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            CarsAvailable++;//Adds 1 to car counter.
            btnReturn.Visible = false;//Hides the "Return" button.
            Car x = (Car)lbxReturnCar.SelectedItem;//Creates a variable based on the item selected.
            x.Rented = false;//Sets "Rented" value to false.
            x.FirstName = string.Empty;
            x.LastName = string.Empty;
            x.Email = string.Empty;
            x.PhoneNum = string.Empty;
            x.Address1 = string.Empty;
            x.Address2 = string.Empty;
            
            //Clears the lists.
            lbxReturnCar.Items.Clear();
            lbxCurrentlyRenting.Items.Clear();

            foreach (Car item in Cars)//Prints each car already rented.
            {
                if (item.Rented)
                {
                    lbxReturnCar.Items.Add(item);
                    lbxCurrentlyRenting.Items.Add(item.FirstName);
                }

            }
        }

        private void lbxShowCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Makes button "Book" visible if a car is selected.
            if (lbxShowCars.SelectedIndex >= 0)
            {
                btnBook.Enabled = true;
            }
            
            
        }

        private void lbxReturnCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Makes button "Return" visible if a car is selected.
            if (lbxReturnCar.SelectedIndex >= 0)
            {
                btnReturn.Visible = true;
            }
           
        }

        private void lbxReturnCar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Car x = (Car)lbxReturnCar.SelectedItem;
            if (lbxReturnCar.SelectedItem != null)

            {
                MessageBox.Show(x.MoreInfo());
            }
        }


        private void btnMore_Click(object sender, EventArgs e)
        {
            pnlMore.Visible = true;
            btnLess.Visible = true;
            btnMore.Visible = false;
            btnBook.Top += 122;

        }

        private void btnLess_Click(object sender, EventArgs e)
        {
            btnMore.Visible = true;
            btnLess.Visible = false;
            pnlMore.Visible = false;
            btnBook.Top -= 122;
        }
    }
}
