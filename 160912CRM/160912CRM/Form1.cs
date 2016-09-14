using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _160912CRM
{
    public partial class Form1 : Form
    {

        List<Customer> MyCustomers = new List<Customer>();
        int ID = 100;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            Customer c = new Customer();
            c.FirstName = txbFirstName.Text;
            c.LastName = txbLastName.Text;
            c.CustomerID = ID;
            c.Status = cbxStatus.Checked;
            c.StatusString = c.Status.ToString();
            if(c.Status == true)
            {
                c.StatusString = "Aktiv";
            }
            else
            {
                c.StatusString = "Inaktiv";
            }
            ID++;
            MyCustomers.Add(c);
            lblCustomerCounter.Text = string.Format("Du har {0} kunder.", MyCustomers.Count);
            lbxList.Items.Clear();

            foreach (Customer item in MyCustomers)
            {
                lbxList.Items.Add(item.FullName());

            }
            
        }

        private void lbxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer c = MyCustomers[lbxList.SelectedIndex];

            MessageBox.Show(string.Format("ID: {0}\nFirst name: {1}\nLast name: {2}\nStatus: {3}", c.CustomerID, c.FirstName, c.LastName, c.StatusString));
        }

        private void cbxStatus_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
