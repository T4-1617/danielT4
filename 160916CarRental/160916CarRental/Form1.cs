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
            Cars.Add(new Car { });
        }

        private void btnShowCars_Click(object sender, EventArgs e)
        {
            pnlShowCars.Visible = true;
            pnlAddCar.Visible = false;
            pnlReturnCar.Visible = false;
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
    }
}
