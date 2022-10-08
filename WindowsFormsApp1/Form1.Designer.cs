namespace WindowsFormsApp1
{
    partial class Form1
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
            this.yearlyTxtBx = new System.Windows.Forms.TextBox();
            this.monthlyTxtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.biWeeklyTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.taxTxtBx = new System.Windows.Forms.TextBox();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hourlyTxtbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // yearlyTxtBx
            // 
            this.yearlyTxtBx.Location = new System.Drawing.Point(25, 61);
            this.yearlyTxtBx.Name = "yearlyTxtBx";
            this.yearlyTxtBx.Size = new System.Drawing.Size(169, 20);
            this.yearlyTxtBx.TabIndex = 0;
            this.yearlyTxtBx.AcceptsTabChanged += new System.EventHandler(this.btnCalc);
            this.yearlyTxtBx.TextChanged += new System.EventHandler(this.yearlyTxtBx_TextChanged);
            // 
            // monthlyTxtBx
            // 
            this.monthlyTxtBx.Location = new System.Drawing.Point(94, 134);
            this.monthlyTxtBx.Name = "monthlyTxtBx";
            this.monthlyTxtBx.Size = new System.Drawing.Size(100, 20);
            this.monthlyTxtBx.TabIndex = 2;
            this.monthlyTxtBx.TextChanged += new System.EventHandler(this.monthlyTxtBx_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Monthly";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Yearly Amount";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Biweekly";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // biWeeklyTxtBx
            // 
            this.biWeeklyTxtBx.Location = new System.Drawing.Point(94, 160);
            this.biWeeklyTxtBx.Name = "biWeeklyTxtBx";
            this.biWeeklyTxtBx.Size = new System.Drawing.Size(100, 20);
            this.biWeeklyTxtBx.TabIndex = 6;
            this.biWeeklyTxtBx.TextChanged += new System.EventHandler(this.weeklyTxtBx_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tax/Total Deductions in %";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // taxTxtBx
            // 
            this.taxTxtBx.Location = new System.Drawing.Point(25, 107);
            this.taxTxtBx.Name = "taxTxtBx";
            this.taxTxtBx.Size = new System.Drawing.Size(69, 20);
            this.taxTxtBx.TabIndex = 8;
            this.taxTxtBx.TextChanged += new System.EventHandler(this.taxTxtBx_TextChanged);
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(94, 223);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(75, 26);
            this.CalcBtn.TabIndex = 11;
            this.CalcBtn.Text = "Calculate";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.btnCalc);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.hourlyTxtbx);
            this.groupBox1.Controls.Add(this.monthlyTxtBx);
            this.groupBox1.Controls.Add(this.CalcBtn);
            this.groupBox1.Controls.Add(this.yearlyTxtBx);
            this.groupBox1.Controls.Add(this.taxTxtBx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.biWeeklyTxtBx);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(28, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 266);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Calculator";
            // 
            // hourlyTxtbx
            // 
            this.hourlyTxtbx.Location = new System.Drawing.Point(94, 186);
            this.hourlyTxtbx.Name = "hourlyTxtbx";
            this.hourlyTxtbx.Size = new System.Drawing.Size(100, 20);
            this.hourlyTxtbx.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hourly";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "40";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "- hours per week.";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.CalcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 444);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Salary Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox yearlyTxtBx;
        private System.Windows.Forms.TextBox monthlyTxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox biWeeklyTxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox taxTxtBx;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hourlyTxtbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

