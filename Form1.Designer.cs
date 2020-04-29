namespace FutureValue
{
    partial class frmFutureValue
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonthlyInvestment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYearlyInterestRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumYears = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFutureValue = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monthly Investment:";
            // 
            // txtMonthlyInvestment
            // 
            this.txtMonthlyInvestment.Location = new System.Drawing.Point(132, 31);
            this.txtMonthlyInvestment.Name = "txtMonthlyInvestment";
            this.txtMonthlyInvestment.Size = new System.Drawing.Size(100, 20);
            this.txtMonthlyInvestment.TabIndex = 1;
            this.txtMonthlyInvestment.TextChanged += new System.EventHandler(this.ClearFutureValue);
            this.txtMonthlyInvestment.MouseHover += new System.EventHandler(this.ClearFutureValue);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yearly Interest Rate:";
            // 
            // txtYearlyInterestRate
            // 
            this.txtYearlyInterestRate.Location = new System.Drawing.Point(132, 57);
            this.txtYearlyInterestRate.Name = "txtYearlyInterestRate";
            this.txtYearlyInterestRate.Size = new System.Drawing.Size(100, 20);
            this.txtYearlyInterestRate.TabIndex = 2;
            this.txtYearlyInterestRate.TextChanged += new System.EventHandler(this.ClearFutureValue);
            this.txtYearlyInterestRate.DoubleClick += new System.EventHandler(this.txtYearlyInterestRate_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number of Years:";
            // 
            // txtNumYears
            // 
            this.txtNumYears.Location = new System.Drawing.Point(132, 83);
            this.txtNumYears.Name = "txtNumYears";
            this.txtNumYears.Size = new System.Drawing.Size(100, 20);
            this.txtNumYears.TabIndex = 3;
            this.txtNumYears.TextChanged += new System.EventHandler(this.ClearFutureValue);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Future Value:";
            // 
            // txtFutureValue
            // 
            this.txtFutureValue.Location = new System.Drawing.Point(132, 109);
            this.txtFutureValue.Name = "txtFutureValue";
            this.txtFutureValue.ReadOnly = true;
            this.txtFutureValue.Size = new System.Drawing.Size(100, 20);
            this.txtFutureValue.TabIndex = 1;
            this.txtFutureValue.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(27, 142);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(132, 142);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmFutureValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 192);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtFutureValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumYears);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYearlyInterestRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMonthlyInvestment);
            this.Controls.Add(this.label1);
            this.Name = "frmFutureValue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Future Value Calculator";
            this.DoubleClick += new System.EventHandler(this.frmFutureValue_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMonthlyInvestment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYearlyInterestRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumYears;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFutureValue;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

