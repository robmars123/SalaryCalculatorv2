namespace WindowsFormsApp1
{
    partial class App
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.yearlyAmount = new System.Windows.Forms.TextBox();
            this.monthlyTxtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.biWeeklyTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.taxTxtBx = new System.Windows.Forms.TextBox();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.percentIncrease = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hourlyTxtbx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.totalIncreaseYearly = new System.Windows.Forms.Label();
            this.differenceAmount = new System.Windows.Forms.Label();
            this.errorMsg = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.TotalCompoundYearly = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.compoundNumberOfYears = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.compoundFreq = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxcompIncreasePercent = new System.Windows.Forms.TextBox();
            this.compIncreasePercent = new System.Windows.Forms.Label();
            this.compoundYearlyInitial = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.credit = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // yearlyAmount
            // 
            this.yearlyAmount.Location = new System.Drawing.Point(21, 34);
            this.yearlyAmount.Name = "yearlyAmount";
            this.yearlyAmount.Size = new System.Drawing.Size(189, 20);
            this.yearlyAmount.TabIndex = 0;
            this.yearlyAmount.Text = "0";
            this.yearlyAmount.AcceptsTabChanged += new System.EventHandler(this.btnCalc);
            this.yearlyAmount.Click += new System.EventHandler(this.yearlyAmount_Click);
            this.yearlyAmount.TextChanged += new System.EventHandler(this.yearlyTxtBx_TextChanged);
            // 
            // monthlyTxtBx
            // 
            this.monthlyTxtBx.Location = new System.Drawing.Point(90, 191);
            this.monthlyTxtBx.Name = "monthlyTxtBx";
            this.monthlyTxtBx.Size = new System.Drawing.Size(120, 20);
            this.monthlyTxtBx.TabIndex = 4;
            this.monthlyTxtBx.Text = "0";
            this.monthlyTxtBx.TextChanged += new System.EventHandler(this.monthlyTxtBx_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Monthly";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yearly Amount";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Biweekly";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // biWeeklyTxtBx
            // 
            this.biWeeklyTxtBx.Location = new System.Drawing.Point(90, 217);
            this.biWeeklyTxtBx.Name = "biWeeklyTxtBx";
            this.biWeeklyTxtBx.Size = new System.Drawing.Size(120, 20);
            this.biWeeklyTxtBx.TabIndex = 5;
            this.biWeeklyTxtBx.Text = "0";
            this.biWeeklyTxtBx.TextChanged += new System.EventHandler(this.weeklyTxtBx_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tax/Total Deductions in %";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // taxTxtBx
            // 
            this.taxTxtBx.Location = new System.Drawing.Point(157, 159);
            this.taxTxtBx.Name = "taxTxtBx";
            this.taxTxtBx.Size = new System.Drawing.Size(35, 20);
            this.taxTxtBx.TabIndex = 3;
            this.taxTxtBx.Text = "0";
            this.taxTxtBx.TextChanged += new System.EventHandler(this.taxTxtBx_TextChanged);
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(71, 278);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(95, 26);
            this.CalcBtn.TabIndex = 11;
            this.CalcBtn.Text = "Calculate";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.btnCalc);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Add % Increase:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // percentIncrease
            // 
            this.percentIncrease.Location = new System.Drawing.Point(125, 126);
            this.percentIncrease.Name = "percentIncrease";
            this.percentIncrease.Size = new System.Drawing.Size(85, 20);
            this.percentIncrease.TabIndex = 2;
            this.percentIncrease.Text = "0";
            this.percentIncrease.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hourly";
            // 
            // hourlyTxtbx
            // 
            this.hourlyTxtbx.Location = new System.Drawing.Point(90, 243);
            this.hourlyTxtbx.Name = "hourlyTxtbx";
            this.hourlyTxtbx.Size = new System.Drawing.Size(120, 20);
            this.hourlyTxtbx.TabIndex = 6;
            this.hourlyTxtbx.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "40";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "-- Standard hours per week.";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(24, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(240, 351);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.totalIncreaseYearly);
            this.tabPage1.Controls.Add(this.differenceAmount);
            this.tabPage1.Controls.Add(this.errorMsg);
            this.tabPage1.Controls.Add(this.yearlyAmount);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.biWeeklyTxtBx);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.percentIncrease);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.taxTxtBx);
            this.tabPage1.Controls.Add(this.hourlyTxtbx);
            this.tabPage1.Controls.Add(this.CalcBtn);
            this.tabPage1.Controls.Add(this.monthlyTxtBx);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(232, 325);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Yearly";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // totalIncreaseYearly
            // 
            this.totalIncreaseYearly.AutoSize = true;
            this.totalIncreaseYearly.Location = new System.Drawing.Point(19, 62);
            this.totalIncreaseYearly.Name = "totalIncreaseYearly";
            this.totalIncreaseYearly.Size = new System.Drawing.Size(0, 13);
            this.totalIncreaseYearly.TabIndex = 16;
            this.totalIncreaseYearly.Click += new System.EventHandler(this.totalIncreaseYearly_Click);
            // 
            // differenceAmount
            // 
            this.differenceAmount.AutoSize = true;
            this.differenceAmount.Location = new System.Drawing.Point(82, 102);
            this.differenceAmount.Name = "differenceAmount";
            this.differenceAmount.Size = new System.Drawing.Size(0, 13);
            this.differenceAmount.TabIndex = 16;
            this.differenceAmount.Click += new System.EventHandler(this.differenceAmount_Click);
            // 
            // errorMsg
            // 
            this.errorMsg.AutoSize = true;
            this.errorMsg.ForeColor = System.Drawing.Color.Red;
            this.errorMsg.Location = new System.Drawing.Point(20, 75);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(0, 13);
            this.errorMsg.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Difference: ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.TotalCompoundYearly);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.compoundNumberOfYears);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.compoundFreq);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.textBoxcompIncreasePercent);
            this.tabPage2.Controls.Add(this.compIncreasePercent);
            this.tabPage2.Controls.Add(this.compoundYearlyInitial);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(232, 320);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compound";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TotalCompoundYearly
            // 
            this.TotalCompoundYearly.AutoSize = true;
            this.TotalCompoundYearly.Location = new System.Drawing.Point(6, 173);
            this.TotalCompoundYearly.Name = "TotalCompoundYearly";
            this.TotalCompoundYearly.Size = new System.Drawing.Size(0, 13);
            this.TotalCompoundYearly.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(162, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Total Compound Amount Yearly: ";
            // 
            // compoundNumberOfYears
            // 
            this.compoundNumberOfYears.Location = new System.Drawing.Point(104, 97);
            this.compoundNumberOfYears.Name = "compoundNumberOfYears";
            this.compoundNumberOfYears.Size = new System.Drawing.Size(122, 20);
            this.compoundNumberOfYears.TabIndex = 7;
            this.compoundNumberOfYears.TextChanged += new System.EventHandler(this.compoundNumberOfYears_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Number of Years:";
            // 
            // compoundFreq
            // 
            this.compoundFreq.Location = new System.Drawing.Point(104, 71);
            this.compoundFreq.Name = "compoundFreq";
            this.compoundFreq.Size = new System.Drawing.Size(122, 20);
            this.compoundFreq.TabIndex = 5;
            this.compoundFreq.TextChanged += new System.EventHandler(this.compoundFreq_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Frequency / Year:";
            // 
            // textBoxcompIncreasePercent
            // 
            this.textBoxcompIncreasePercent.Location = new System.Drawing.Point(104, 45);
            this.textBoxcompIncreasePercent.Name = "textBoxcompIncreasePercent";
            this.textBoxcompIncreasePercent.Size = new System.Drawing.Size(122, 20);
            this.textBoxcompIncreasePercent.TabIndex = 3;
            this.textBoxcompIncreasePercent.TextChanged += new System.EventHandler(this.textBoxcompIncreasePercent_TextChanged);
            // 
            // compIncreasePercent
            // 
            this.compIncreasePercent.AutoSize = true;
            this.compIncreasePercent.Location = new System.Drawing.Point(4, 48);
            this.compIncreasePercent.Name = "compIncreasePercent";
            this.compIncreasePercent.Size = new System.Drawing.Size(94, 13);
            this.compIncreasePercent.TabIndex = 2;
            this.compIncreasePercent.Text = "Increase Yearly %:";
            this.compIncreasePercent.Click += new System.EventHandler(this.compIncreasePercent_Click);
            // 
            // compoundYearlyInitial
            // 
            this.compoundYearlyInitial.Location = new System.Drawing.Point(104, 19);
            this.compoundYearlyInitial.Name = "compoundYearlyInitial";
            this.compoundYearlyInitial.Size = new System.Drawing.Size(122, 20);
            this.compoundYearlyInitial.TabIndex = 1;
            this.compoundYearlyInitial.TextChanged += new System.EventHandler(this.compoundYearlyInitial_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Yearly: ";
            // 
            // credit
            // 
            this.credit.AutoSize = true;
            this.credit.Location = new System.Drawing.Point(164, 434);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(100, 13);
            this.credit.TabIndex = 17;
            this.credit.Text = "Created By: Robten";
            this.credit.Click += new System.EventHandler(this.credit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(197, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "label14";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(202, 28);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "1990-12-12";
            this.label15.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(24, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 18);
            this.label16.TabIndex = 20;
            this.label16.Text = "Calculator";
            // 
            // App
            // 
            this.AcceptButton = this.CalcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 460);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary Calculator";
            this.Load += new System.EventHandler(this.App_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox yearlyAmount;
        private System.Windows.Forms.TextBox monthlyTxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox biWeeklyTxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox taxTxtBx;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hourlyTxtbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox percentIncrease;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label errorMsg;
        private System.Windows.Forms.Label totalIncreaseYearly;
        private System.Windows.Forms.Label differenceAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TotalCompoundYearly;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox compoundNumberOfYears;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox compoundFreq;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxcompIncreasePercent;
        private System.Windows.Forms.Label compIncreasePercent;
        private System.Windows.Forms.TextBox compoundYearlyInitial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label credit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}

