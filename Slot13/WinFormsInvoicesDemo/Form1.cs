using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsInvoicesDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbDiscount.SelectedItem = cbDiscount.Items[0];
            cbCustomerType.SelectedItem = cbCustomerType.Items[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            decimal subtotal = Convert.ToDecimal(txtSubTotal.Text);
            decimal discountPercent = 0;
            string customerType = cbCustomerType.Text;
            switch (cbDiscount.SelectedIndex) {
                case 0:
                    discountPercent = 0.1M;
                    break;
                case 1:
                    discountPercent = 0.15M;
                    break;
                case 2:
                    discountPercent = 0.2M;
                    break;
                case 3:
                    discountPercent = 0.5M;
                    break;
                default:
                    break;
            }
            txtDisAmount.Text = $"{subtotal * discountPercent:C}";
            decimal finalAmount = subtotal - subtotal * discountPercent;
            decimal discountPerMemeber = 0;

            if (customerType == "New Member") {
                discountPerMemeber = 0;
            } else if (customerType == "Silver Member") {
                discountPerMemeber = 1;
            }
            else if (customerType == "Gold Member")
            {
                discountPerMemeber = 2;
            }
            else if (customerType == "Diamond Member")
            {
                discountPerMemeber = 3;
            }
            finalAmount = finalAmount - discountPerMemeber;
            txtTotal.Text = $"{finalAmount:C}";
            txtSubTotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

    }
}
