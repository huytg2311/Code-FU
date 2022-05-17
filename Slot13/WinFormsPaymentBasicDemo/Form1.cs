using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPaymentBasicDemo
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            cboNames.Items.Add("Nguyen van A");
            cboNames.Items.Add("Nguyen van B");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnSelectPayment_Click(object sender, EventArgs e)
        {
            Form paymentForm = new frmPayment();
            DialogResult selectedButton = paymentForm.ShowDialog();
            if (selectedButton == DialogResult.OK) {
                lblPayment.Text = (string)paymentForm.Tag;
            }
        }
    }
}
