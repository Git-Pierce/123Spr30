using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureValue
{
    public partial class frmFutureValue : Form
    {
        public frmFutureValue()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // declare variables to hold the textbox values
            decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
            decimal yearlyInterestRate = Convert.ToDecimal(txtYearlyInterest.Text);
            int years = Convert.ToInt32(txtNumYears.Text);
            int months = years * 12;
            decimal monthlyIntRate = yearlyInterestRate / 12 / 100; 
            decimal futureValue = 0m;

            // calculate the future value
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyIntRate);
            }
            // display the calculated values on the form
            txtFutureValue.Text = futureValue.ToString("c");
            txtMonthlyInvestment.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
