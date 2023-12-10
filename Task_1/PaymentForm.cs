using ComputerShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShop
{
    public partial class PaymentForm : Form
    {
        public PaymentForm(Product[] products, decimal total_to_pay)
        {
            InitializeComponent();
            OrderListBox.DataSource = products;
            TotalToPayTextBox.Text = $"{total_to_pay} $";
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            if (creditCardRadioButton.Checked ) MessageBox.Show("The Payment by Card was successful! Thank you for shopping!");
            if (cashRadioButton.Checked) MessageBox.Show("The Payment by Cash was successful! Thank you for shopping!");
            this.DialogResult = DialogResult.OK;
        }
    }
}
