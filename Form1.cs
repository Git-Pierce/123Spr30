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
            /* this is a test */
            decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
            decimal yearlyInterestRate = Convert.ToDecimal(txtYearlyInterestRate.Text);
            while (yearlyInterestRate < 0 || yearlyInterestRate >= 20)
            {
                MessageBox.Show("Yearly Interest Rate should be = 0 and <= 20%");
            } 
              
            int years = Convert.ToInt32(txtNumYears.Text);

            int months = years * 12;
            decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;

            

            txtFutureValue.Text = CalcFV(monthlyInvestment, monthlyInterestRate, months).ToString("c");
            txtMonthlyInvestment.Focus();
        }

        private decimal CalcFV(decimal monthlyInvestment, decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
            return futureValue;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ClearFutureValue(object sender, EventArgs e)
        {
            txtFutureValue.Text = "";
        }

        private void frmFutureValue_DoubleClick(object sender, EventArgs e)
        {
            txtMonthlyInvestment.Text = "";
            txtNumYears.Text = "";
            txtYearlyInterestRate.Text = "";
            txtFutureValue.Text = "";
        }

        private void txtYearlyInterestRate_DoubleClick(object sender, EventArgs e)
        {
            txtYearlyInterestRate.Text = "12";
        }
    }
}
