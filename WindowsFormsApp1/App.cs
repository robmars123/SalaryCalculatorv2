﻿using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            compoundFreq.Text = 1.ToString();

            //initialize timer
            timer1.Start();
            label15.Text = DateTime.Now.ToString("yyyy'-'MM'-'dd");
            label14.Text = DateTime.Now.ToLongTimeString();
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
            validateTxtbox(yearlyAmount.Name);
        }


        private void btnCalc(object sender, EventArgs e)
        {
            //annualy input
            decimal originalInput = 0;

            try
            {
                errorMsg.Text = "";

                if (string.IsNullOrEmpty(yearlyAmount.Text) || yearlyAmount.Text == "")
                {
                    yearlyAmount.Text = "0";
                }
                else if (yearlyAmount.Text == "0")
                    errorMsg.Text = "Required " + yearlyAmount.Name;

                originalInput = Convert.ToDecimal(yearlyAmount.Text);

                Calculate(originalInput);
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void Calculate(decimal originalInput)
        {
            decimal tax = 0.0M;
            decimal percentIncreaseAmount = 0.0M;
            decimal monthly = 0.0M, weekly = 0.0M;
            decimal hourly = 0.0M;
            decimal yearly = 0.0M;

            //total deductions in tax %
            decimal totalDeduction = 0;
            if (!string.IsNullOrEmpty(taxTxtBx.Text))
            {
                tax = Convert.ToDecimal(taxTxtBx.Text) / 100;
                totalDeduction = originalInput * tax;
            };
            yearly = originalInput - totalDeduction;

            //percent increase
            decimal totalIncrease = 0;
            if (!string.IsNullOrEmpty(percentIncrease.Text) && percentIncrease.Text != "0")
            {
                percentIncreaseAmount = (originalInput * Convert.ToDecimal(percentIncrease.Text)) / 100;
            }
            totalIncrease = originalInput + percentIncreaseAmount;

            //new increase
            totalIncreaseYearly.Text = String.Format("{0:C}", totalIncrease);
            //monthly
            monthlyTxtBx.Text = CalculateMonthlyWeeklyHourly("monthly", percentIncreaseAmount, yearly);
            //biweekly
            biWeeklyTxtBx.Text = CalculateMonthlyWeeklyHourly("biweekly", percentIncreaseAmount, yearly);
            //biweekly
            weeklyTxtBx.Text = CalculateMonthlyWeeklyHourly("weekly", percentIncreaseAmount, yearly);
            //hourly
            hourlyTxtbx.Text = CalculateMonthlyWeeklyHourly("hourly", percentIncreaseAmount, yearly);
            //difference
            differenceAmount.Text = String.Format("{0:C}", (totalIncrease - originalInput));
        }

        public string CalculateMonthlyWeeklyHourly(string type, decimal percentIncreaseAmount, decimal yearly)
        {
            if (type == "monthly")
            {
                return String.Format("{0:C}", (percentIncreaseAmount + yearly) / 12);
            }
            else if (type == "biweekly")
            {
                return String.Format("{0:C}", (percentIncreaseAmount + yearly) / 26);
            }
            else if (type == "weekly")
            {
                return String.Format("{0:C}", ((percentIncreaseAmount + yearly) / 26) / 2);
            }
            else if (type == "hourly")
            {
                return String.Format("{0:C}", (percentIncreaseAmount + yearly) / (52 * 40));
            }
            else
                return "0";
        }
        private void btnCalc(object sender, KeyEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void validateTxtbox<T>(T item)
        {
            TextBox txtBx = this.Controls.Find(item.ToString(), true).FirstOrDefault() as TextBox;
            //if (string.IsNullOrEmpty(txtBx.Text.Trim()) || txtBx.Text.Trim() == "")
            //{
            //    txtBx.Text = "0";
            //    errorMsg.Text = "Required " + txtBx.Name;
            //}

            var regex = new Regex(@"[a-z+\-\/\*\(\)]");
            if (regex.IsMatch(txtBx.Text))
            {
                txtBx.Text = "";
            }
        }

        private void taxTxtBx_TextChanged(object sender, EventArgs e)
        {
            validateTxtbox(taxTxtBx.Name);
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            validateTxtbox(percentIncrease.Name);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void App_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            if (yearlyAmount.Text == "")
                yearlyAmount.Text = "0";
            //validateTxtbox(yearlyAmount.Name);
            //yearlyAmount.Clear();
        }

        private void differenceAmount_Click(object sender, EventArgs e)
        {
            yearlyAmount.Text = "";
        }

        private void totalIncreaseYearly_Click(object sender, EventArgs e)
        {

        }

        private void yearlyAmount_Click(object sender, EventArgs e)
        {
            yearlyAmount.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // declare variables
            double ci, amount, yearlyInitial, increasePercent;
            int freq, numberOfYears, i;

            // take input of initial principal amount,
            // interest rate, periodicity of payment and year
            yearlyInitial = Convert.ToDouble(compoundYearlyInitial.Text);
            increasePercent = Convert.ToDouble(textBoxcompIncreasePercent.Text);
            freq = Convert.ToInt32(compoundFreq.Text);
            numberOfYears = Convert.ToInt32(compoundNumberOfYears.Text);

            // initialize
            amount = yearlyInitial;

            // calculate compounded value using loop
            for (i = 0; i < freq * numberOfYears; i++)
                //formula = amound + (amount * (percent / (frequency * 100)))
                amount = amount + amount * (increasePercent / (freq * 100));

            //find the compound interest
            ci = Math.Round(amount, 2);

            // display result upto 2 decimal places
            TotalCompoundYearly.Text = String.Format("{0:C}", Convert.ToDouble(ci)).ToString();
        }

        private void compoundNumberOfYears_TextChanged(object sender, EventArgs e)
        {
            validateTxtbox(compoundNumberOfYears.Name);
        }

        private void compIncreasePercent_Click(object sender, EventArgs e)
        {
            validateTxtbox(compIncreasePercent.Name);
        }

        private void compoundYearlyInitial_TextChanged(object sender, EventArgs e)
        {
            validateTxtbox(compoundYearlyInitial.Name);
        }

        private void compoundFreq_TextChanged(object sender, EventArgs e)
        {
            validateTxtbox(compoundFreq.Name);
        }

        private void textBoxcompIncreasePercent_TextChanged(object sender, EventArgs e)
        {
            validateTxtbox(textBoxcompIncreasePercent.Name);
        }

        private void credit_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label14.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void hourlyTxtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
