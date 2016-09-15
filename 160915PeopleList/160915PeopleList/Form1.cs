using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _160915PeopleList
{
    public partial class Form1 : Form
    {

        System.Collections.ArrayList People;

        public Form1()
        {
            InitializeComponent();
            People = new System.Collections.ArrayList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(rdbCustomer.Checked == true)
            {
                People.Add(new Customer() { FirstName = txbFirstName.Text, LastName = txbLastName.Text });
            }
            else if(rdbEmployee.Checked == true)
            {
                People.Add(new Employee() { FirstName = txbFirstName.Text, LastName = txbLastName.Text });
            }
            
        }
    }
}
