using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationAppPractice1
{
    public partial class AccountOperationUi : Form
    {
        public AccountOperationUi()
        {
            InitializeComponent();
        }
        CreateAccount createAccount = new CreateAccount();
        CustomerTransaction ct = new CustomerTransaction();
        private void CreateButton_Click(object sender, EventArgs e)
        {
            createAccount.accountNumber = accountNoTextBox.Text;
            createAccount.customerName = customerNameTextBox.Text;
        }

        private void DipositButton_Click(object sender, EventArgs e)
        {
            ct.taka =ct.taka+Convert.ToInt32(amountTextBox.Text);
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            ct.taka = ct.taka - Convert.ToInt32(amountTextBox.Text);
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(createAccount.createCustomerAccount() + " Balance : " + ct.taka +" Taka");
        }
    }
}
