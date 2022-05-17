using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsFirstDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnAverage_Click(object sender, EventArgs e)
        {
            decimal firstIncome = decimal.Parse(txtIncome01.Text);
            decimal secondIncome = decimal.Parse(txtIncome02.Text);
            decimal month = decimal.Parse(txtMonth.Text);
            // calculate the average value per months
            decimal average = (firstIncome + secondIncome) / month;
            label3.Text = $"Average Salary: {average:C}";
        }
    }
}
