using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace _160922OnlineBanking
{
    public partial class Form1 : Form
    {
        ArrayList Customers;
        ArrayList Transactions;

        public Form1()
        {
            InitializeComponent();
            Customers = new ArrayList();
            Transactions = new ArrayList();

            Customer c = new Customer() { FirstName = "abc", LastName = "123", PersonalID = 971118 };
            c.CreateAccount(123, "TestAcc");
            Customers.Add(c);
            foreach (Customer item in Customers)
            {
                lbxCustomer.Items.Add(item);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxPersonType.SelectedIndex)
            {
                case 0:
                    ToggleButtons(true, true, true, true, false);
                    break;

                case 1:
                    ToggleButtons(true, false, false, false, true);
                    break;
            }
        }
        private void ToggleButtons(bool ToggleButtonAccount, bool ToggleButtonDeposit, bool ToggleButtonWithdraw, bool ToggleButtonBalance, bool ToggleButtonTransactions)
        {
            btnViewAccount.Enabled = ToggleButtonAccount;
            btnViewDeposit.Enabled = ToggleButtonDeposit;
            btnViewWithdraw.Enabled = ToggleButtonWithdraw;
            btnViewBalance.Enabled = ToggleButtonBalance;
            btnViewTransactions.Enabled = ToggleButtonTransactions;
        }

        private void TogglePanels(bool TogglePanelAccount, bool TogglePanelDeposit, bool TogglePanelWithdraw, bool TogglePanelBalance, bool TogglePanelTransactions)
        {
            pnlOpenAccount.Visible = TogglePanelAccount;
            pnlDeposit.Visible = TogglePanelDeposit;
            pnlWithdraw.Visible = TogglePanelWithdraw;
            pnlBalance.Visible = TogglePanelBalance;
            pnlTransactions.Visible = TogglePanelTransactions;
        }

        private void ClearTextboxes()
        {
            txbAccountName.Clear();
            txbInitialDeposit.Clear();
            txbFirstName.Clear();
            txbLastName.Clear();
            txbPersonalID.Clear();
            rdbAccount.Checked = false;
            rdbCustomer.Checked = false;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            TogglePanels(true, false, false, false, false);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            TogglePanels(false, true, false, false, false);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            TogglePanels(false, false, true, false, false);
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            TogglePanels(false, false, false, true, false);
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            TogglePanels(false, false, false, false, true);
        }

        private void DisplayCustomers()
        {
            lbxCustomer.Items.Clear();
                foreach (Customer item in Customers)
                {
                    lbxCustomer.Items.Add(item);
                }
        }

        private void DisplayAccounts(Customer c)
        {
            lbxAccount.Items.Clear();
            if (lbxCustomer.SelectedIndex != -1)
            {
                foreach (Account item in c.GetAccounts())
                {
                    lbxAccount.Items.Add(item);
                }
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            Customer c = (Customer)lbxCustomer.SelectedItem;

            if (rdbCustomer.Checked)
            {
                Customers.Add(new Customer() { FirstName = txbFirstName.Text, LastName = txbLastName.Text, PersonalID = decimal.Parse(txbPersonalID.Text) });
            }

            if (rdbAccount.Checked && lbxCustomer.SelectedItem == null)
            {
                MessageBox.Show("För att skapa ett nytt konto måste du välja en kund i kundlistan.");
                return;
            }

            if(rdbAccount.Checked)
            {
                c.CreateAccount(decimal.Parse(txbInitialDeposit.Text), txbAccountName.Text);
            }

            DisplayCustomers();
            DisplayAccounts(c);
            ClearTextboxes();
        }

        private void lbxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer c = (Customer)lbxCustomer.SelectedItem;
            lbxAccount.Items.Clear();

            if (lbxCustomer.SelectedItem != null)
            {
                foreach (Account item in c.GetAccounts())
                {
                        lbxAccount.Items.Add(item);
                }
            }
            
        }

        private void rdbCustomer_CheckedChanged(object sender, EventArgs e)
        {
            pnlCustomer.Visible = !pnlCustomer.Visible;
            pnlAccount.Visible = !pnlAccount.Visible;
        }

        private void rdbAccount_CheckedChanged(object sender, EventArgs e)
        {
            //pnlCustomer.Visible = !pnlCustomer.Visible;
            //pnlAccount.Visible = !pnlAccount.Visible;
        }
    }
}
