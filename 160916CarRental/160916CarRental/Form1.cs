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
        System.Collections.ArrayList Cars;
        public Form1()
        {
            InitializeComponent();
            Cars = new System.Collections.ArrayList();
            Cars.Add(new Car { Make = "Volvo", Model = "V70", Colour = "Red", Rented = false});
            Cars.Add(new Car { Make = "Audi", Model = "A6", Colour = "Black", Rented = false });
            Cars.Add(new Car { Make = "Volkswagen", Model = "Golf Mk6", Colour = "Yellow", Rented = false });
        }

        private void btnShowCars_Click(object sender, EventArgs e)
        {
            pnlShowCars.Visible = true;
            pnlAddCar.Visible = false;
            pnlReturnCar.Visible = false;

            lbxShowCars.Items.Clear();

            foreach (Car item in Cars)
            {
                if (!item.Rented)
                {
                    lbxShowCars.Items.Add(item);
                    lbxShowCars.DisplayMember = "MakeAndModel";
                }
                
            }
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            pnlShowCars.Visible = false;
            pnlAddCar.Visible = true;
            pnlReturnCar.Visible = false;
        }

        private void btnReturnCar_Click(object sender, EventArgs e)
        {
            pnlShowCars.Visible = false;
            pnlAddCar.Visible = false;
            pnlReturnCar.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Cars.Add(new Car { Make = txbMake.Text, Model = txbModel.Text, Colour = txbColour.Text, Rented = false });
        }
    }
}
