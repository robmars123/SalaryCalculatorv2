using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void yearlyTxtBx_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(yearlyTxtBx.Text) || yearlyTxtBx.Text == "")
            {
                yearlyTxtBx.Text = "0";
                errorMsg.Text = "Required";
            }

            var regex = new Regex(@"[a-z+\-\/\*\(\)]");
            if (regex.IsMatch(yearlyTxtBx.Text))
            {
                yearlyTxtBx.Text = "";
            }
        }


        private void btnCalc(object sender, EventArgs e)
        {
            try
            {
                //annualy input
                decimal originalInput = 0;
                errorMsg.Text = "";

                if (string.IsNullOrEmpty(yearlyTxtBx.Text) || yearlyTxtBx.Text == "")
                {
                    yearlyTxtBx.Text = "0";
                }
                else if (yearlyTxtBx.Text == "0")
                    errorMsg.Text = "Required";

                originalInput = Convert.ToDecimal(yearlyTxtBx.Text);
                decimal tax = 0;
                decimal monthly = 0, weekly = 0;
                decimal hourly = 0;
                decimal yearly = 0;

                //total deductions in tax %
                decimal totalDeducation = 0;
                if (!string.IsNullOrEmpty(taxTxtBx.Text))
                {
                    tax = Convert.ToDecimal(taxTxtBx.Text) / 100;
                    totalDeducation = originalInput * tax;
                };
                yearly = originalInput - totalDeducation;

                //monthly
                monthlyTxtBx.Text = String.Format("{0:C}", (yearly / 12));
                //biweekly
                biWeeklyTxtBx.Text = String.Format("{0:C}", (yearly / 26)); 
                //hourly
                hourlyTxtbx.Text = String.Format("{0:C}", (originalInput / (52 * 40))); 
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        private void btnCalc(object sender, KeyEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void taxTxtBx_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(taxTxtBx.Text) || taxTxtBx.Text == "")
            {
                taxTxtBx.Text = "0";
                errorMsg.Text = "Required";
            }

            var regex = new Regex(@"[a-z+\-\/\*\(\)]");
            if (regex.IsMatch(taxTxtBx.Text))
            {
                taxTxtBx.Text = "";
            }
        }

        private void weeklyTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthlyTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
