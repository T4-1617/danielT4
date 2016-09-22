using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _160922OnlineBanking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxPersonType.SelectedIndex)
            {
                case 0:
                    ToggleButtons(true, true, true, true, true, false);
                    break;

                case 1:
                    ToggleButtons(true, true, false, false, false, true);
                    break;
            }
        }
        private void ToggleButtons(bool ToggleButtonCustomer, bool ToggleButtonAccount, bool ToggleButtonDeposit, bool ToggleButtonWithdraw, bool ToggleButtonBalance, bool ToggleButtonTransactions)
        {
            btnViewCustomer.Enabled = ToggleButtonCustomer;
            btnViewAccount.Enabled = ToggleButtonAccount;
            btnViewDeposit.Enabled = ToggleButtonDeposit;
            btnViewWithdraw.Enabled = ToggleButtonWithdraw;
            btnViewBalance.Enabled = ToggleButtonBalance;
            btnViewTransactions.Enabled = ToggleButtonTransactions;
        }

        private void TogglePanels(bool TogglePanelCustomer, bool TogglePanelAccount, bool TogglePanelDeposit, bool TogglePanelWithdraw, bool TogglePanelBalance, bool TogglePanelTransactions)
        {
            pnlCustomer.Visible = TogglePanelCustomer;
            pnlAccount.Visible = TogglePanelAccount;
            pnlDeposit.Visible = TogglePanelDeposit;
            pnlWithdraw.Visible = TogglePanelWithdraw;
            pnlBalance.Visible = TogglePanelBalance;
            pnlTransactions.Visible = TogglePanelTransactions;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            TogglePanels(true, false, false, false, false, false);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            TogglePanels(false, true, false, false, false, false);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            TogglePanels(false, false, true, false, false, false);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            TogglePanels(false, false, false, true, false, false);
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            TogglePanels(false, false, false, false, true, false);
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            TogglePanels(false, false, false, false, false, true);
        }
    }
}
