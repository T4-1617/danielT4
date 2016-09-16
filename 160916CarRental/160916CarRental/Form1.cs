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
            Cars = new System.Collections.ArrayList();
            //Adds the three pre-existing cars to the ArrayList
            Cars.Add(new Car { Make = "Volvo", Model = "V70", Colour = "Red", Rented = false});
            Cars.Add(new Car { Make = "Audi", Model = "A6", Colour = "Black", Rented = false });
            Cars.Add(new Car { Make = "Volkswagen", Model = "Golf Mk6", Colour = "Yellow", Rented = false });
        }

        private void btnShowCars_Click(object sender, EventArgs e)
        {
            CarsAvailable = 0;//Resets the car counter to zero

            btnBook.Visible = false;//Hides the "Book" button.

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
            lblCarCounter.Text = String.Format("We have {0} car(s) available", CarsAvailable);//Prints the amount of cars available.
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

            lbxReturnCar.Items.Clear();//Clears the list.

            foreach (Car item in Cars)//Prints all the cars already rented.
            {
                if (item.Rented)
                {
                    lbxReturnCar.Items.Add(item);
                    lbxCurrentlyRenting.Items.Add(item.FirstName);
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
            CarsAvailable--;//Subtracts 1 from the car counter.
            btnBook.Visible = false;//Hides the "Book" button.
            Car x = (Car)lbxShowCars.SelectedItem;//Creates a variable based on the item selected.
            x.Rented = true;//Sets "Rented" value to true.
            x.FirstName = txbFirstName.Text;
            x.LastName = txbLastName.Text;
            lbxShowCars.Items.Clear();//Clears the list.
            if (txbFirstName.Text == string.Empty || txbLastName.Text == string.Empty)
            {
                MessageBox.Show("You have to enter both First name and Last name");
            }
           
            foreach (Car item in Cars)//Prints each car available to be rented.
            {
                if (!item.Rented)
                {
                    lbxShowCars.Items.Add(item);
                }

            }
            lblCarCounter.Text = String.Format("We have {0} car(s) available", CarsAvailable);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            CarsAvailable++;//Adds 1 to car counter.
            btnReturn.Visible = false;//Hides the "Return" button.
            Car x = (Car)lbxReturnCar.SelectedItem;//Creates a variable based on the item selected.
            x.Rented = false;//Sets "Rented" value to false.
            x.FirstName = string.Empty;
            x.LastName = string.Empty;
            
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
                btnBook.Visible = true;//Makes button "Book" visible.
        }

        private void lbxReturnCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnReturn.Visible = true;//Makes button "Return" visible.
        }
    }
}
