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
                    btn
                    break;

                case 1:
                    break;
            }
        }
        private void ToggleButtons(bool ToggleButtonCustomer, bool ToggleButtonAccount, bool ToggleButtonDeposit, bool ToggleButtonWithdraw, bool ToggleButtonBalance, bool ToggleButtonTransactions)
        {
            btnCustomer.Visible = ToggleButtonCustomer;
            btnAccount.Visible = ToggleButtonAccount;
            btnDeposit.Visible = ToggleButtonDeposit;
            btnWithdraw.Visible = ToggleButtonWithdraw;
            btnBalance.Visible = ToggleButtonBalance;
            btnTransactions.Visible = ToggleButtonTransactions;
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
    }
}
