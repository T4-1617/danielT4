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

        System.Collections.ArrayList MyCustomers = new System.Collections.ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.FirstName = txbFirstName.Text;
            c.LastName = txbLastName.Text;
            MyCustomers.Add(c);
            lbxList.Items.Clear();

            foreach (Customer item in MyCustomers)
            {
                lbxList.Items.Add(item.FullName());

            }
            
        }
    }
}
