
namespace JProject.UI
{
    partial class Monthly_Summery
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
            this.dtpMonthSummery = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMonthName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblReturnTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSalesTot = new System.Windows.Forms.Label();
            this.lblPurchaseTot = new System.Windows.Forms.Label();
            this.lblCreditBalance = new System.Windows.Forms.Label();
            this.lblBankBalance = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.lblBankCashWinPur = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCreditPurchases = new System.Windows.Forms.Label();
            this.lblReturnPur = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblSalesCashWin = new System.Windows.Forms.Label();
            this.lblCreditSales = new System.Windows.Forms.Label();
            this.lblReturnSales = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpMonthSummery
            // 
            this.dtpMonthSummery.CustomFormat = "MM-yyyy";
            this.dtpMonthSummery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMonthSummery.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonthSummery.Location = new System.Drawing.Point(891, 13);
            this.dtpMonthSummery.Name = "dtpMonthSummery";
            this.dtpMonthSummery.Size = new System.Drawing.Size(145, 28);
            this.dtpMonthSummery.TabIndex = 3;
            this.dtpMonthSummery.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(741, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select Month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total Sales Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total Purchase Amount";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total Return Amount";
            // 
            // lblMonthName
            // 
            this.lblMonthName.AutoSize = true;
            this.lblMonthName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthName.Location = new System.Drawing.Point(667, 84);
            this.lblMonthName.Name = "lblMonthName";
            this.lblMonthName.Size = new System.Drawing.Size(68, 24);
            this.lblMonthName.TabIndex = 13;
            this.lblMonthName.Text = "Month";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(418, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Month end balance for  ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(789, 84);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(53, 24);
            this.lblYear.TabIndex = 15;
            this.lblYear.Text = "Year";
            // 
            // lblReturnTotal
            // 
            this.lblReturnTotal.AutoSize = true;
            this.lblReturnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnTotal.Location = new System.Drawing.Point(21, 292);
            this.lblReturnTotal.Name = "lblReturnTotal";
            this.lblReturnTotal.Size = new System.Drawing.Size(44, 20);
            this.lblReturnTotal.TabIndex = 19;
            this.lblReturnTotal.Text = "0.00";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(226, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 602);
            this.panel1.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(17, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Total Payable";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(19, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Bank Balance";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lblSalesCashWin);
            this.panel2.Controls.Add(this.lblCreditSales);
            this.panel2.Controls.Add(this.lblReturnSales);
            this.panel2.Controls.Add(this.lblReturnPur);
            this.panel2.Controls.Add(this.lblCreditPurchases);
            this.panel2.Controls.Add(this.lblBankCashWinPur);
            this.panel2.Location = new System.Drawing.Point(543, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 602);
            this.panel2.TabIndex = 21;
            // 
            // lblSalesTot
            // 
            this.lblSalesTot.AutoSize = true;
            this.lblSalesTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesTot.Location = new System.Drawing.Point(21, 242);
            this.lblSalesTot.Name = "lblSalesTot";
            this.lblSalesTot.Size = new System.Drawing.Size(44, 20);
            this.lblSalesTot.TabIndex = 20;
            this.lblSalesTot.Text = "0.00";
            // 
            // lblPurchaseTot
            // 
            this.lblPurchaseTot.AutoSize = true;
            this.lblPurchaseTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseTot.Location = new System.Drawing.Point(21, 114);
            this.lblPurchaseTot.Name = "lblPurchaseTot";
            this.lblPurchaseTot.Size = new System.Drawing.Size(44, 20);
            this.lblPurchaseTot.TabIndex = 21;
            this.lblPurchaseTot.Text = "0.00";
            // 
            // lblCreditBalance
            // 
            this.lblCreditBalance.AutoSize = true;
            this.lblCreditBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditBalance.ForeColor = System.Drawing.Color.Red;
            this.lblCreditBalance.Location = new System.Drawing.Point(31, 46);
            this.lblCreditBalance.Name = "lblCreditBalance";
            this.lblCreditBalance.Size = new System.Drawing.Size(40, 20);
            this.lblCreditBalance.TabIndex = 22;
            this.lblCreditBalance.Text = "0.00";
            // 
            // lblBankBalance
            // 
            this.lblBankBalance.AutoSize = true;
            this.lblBankBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankBalance.ForeColor = System.Drawing.Color.Blue;
            this.lblBankBalance.Location = new System.Drawing.Point(31, 127);
            this.lblBankBalance.Name = "lblBankBalance";
            this.lblBankBalance.Size = new System.Drawing.Size(40, 20);
            this.lblBankBalance.TabIndex = 24;
            this.lblBankBalance.Text = "0.00";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblPurchaseTot);
            this.panel5.Controls.Add(this.lblSalesTot);
            this.panel5.Controls.Add(this.lblReturnTotal);
            this.panel5.Location = new System.Drawing.Point(800, 121);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(278, 602);
            this.panel5.TabIndex = 26;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Red;
            this.label26.Location = new System.Drawing.Point(31, 84);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(40, 20);
            this.label26.TabIndex = 22;
            this.label26.Text = "0.00";
            // 
            // lblBankCashWinPur
            // 
            this.lblBankCashWinPur.AutoSize = true;
            this.lblBankCashWinPur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankCashWinPur.Location = new System.Drawing.Point(17, 48);
            this.lblBankCashWinPur.Name = "lblBankCashWinPur";
            this.lblBankCashWinPur.Size = new System.Drawing.Size(40, 20);
            this.lblBankCashWinPur.TabIndex = 21;
            this.lblBankCashWinPur.Text = "0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Purchases - Credit ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(229, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Purchases - Bank, Cash, Win";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Purchases - Returns";
            // 
            // lblCreditPurchases
            // 
            this.lblCreditPurchases.AutoSize = true;
            this.lblCreditPurchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditPurchases.Location = new System.Drawing.Point(17, 19);
            this.lblCreditPurchases.Name = "lblCreditPurchases";
            this.lblCreditPurchases.Size = new System.Drawing.Size(40, 20);
            this.lblCreditPurchases.TabIndex = 25;
            this.lblCreditPurchases.Text = "0.00";
            // 
            // lblReturnPur
            // 
            this.lblReturnPur.AutoSize = true;
            this.lblReturnPur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnPur.Location = new System.Drawing.Point(17, 78);
            this.lblReturnPur.Name = "lblReturnPur";
            this.lblReturnPur.Size = new System.Drawing.Size(40, 20);
            this.lblReturnPur.TabIndex = 26;
            this.lblReturnPur.Text = "0.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Sales - Credit";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 184);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "Sales - Returns";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 213);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(144, 20);
            this.label15.TabIndex = 30;
            this.label15.Text = "Sales - Cash, Win";
            // 
            // lblSalesCashWin
            // 
            this.lblSalesCashWin.AutoSize = true;
            this.lblSalesCashWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesCashWin.Location = new System.Drawing.Point(17, 213);
            this.lblSalesCashWin.Name = "lblSalesCashWin";
            this.lblSalesCashWin.Size = new System.Drawing.Size(40, 20);
            this.lblSalesCashWin.TabIndex = 29;
            this.lblSalesCashWin.Text = "0.00";
            // 
            // lblCreditSales
            // 
            this.lblCreditSales.AutoSize = true;
            this.lblCreditSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditSales.Location = new System.Drawing.Point(17, 154);
            this.lblCreditSales.Name = "lblCreditSales";
            this.lblCreditSales.Size = new System.Drawing.Size(40, 20);
            this.lblCreditSales.TabIndex = 28;
            this.lblCreditSales.Text = "0.00";
            // 
            // lblReturnSales
            // 
            this.lblReturnSales.AutoSize = true;
            this.lblReturnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnSales.Location = new System.Drawing.Point(17, 183);
            this.lblReturnSales.Name = "lblReturnSales";
            this.lblReturnSales.Size = new System.Drawing.Size(40, 20);
            this.lblReturnSales.TabIndex = 27;
            this.lblReturnSales.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(15, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Creditors Balance";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(20, 381);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 198);
            this.panel3.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label26);
            this.panel4.Controls.Add(this.lblBankBalance);
            this.panel4.Controls.Add(this.lblCreditBalance);
            this.panel4.Location = new System.Drawing.Point(21, 381);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(216, 198);
            this.panel4.TabIndex = 32;
            // 
            // Monthly_Summery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1278, 735);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMonthName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpMonthSummery);
            this.Name = "Monthly_Summery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monthly_Summery";
            this.Load += new System.EventHandler(this.Monthly_Summery_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpMonthSummery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMonthName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblReturnTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBankBalance;
        private System.Windows.Forms.Label lblCreditBalance;
        private System.Windows.Forms.Label lblPurchaseTot;
        private System.Windows.Forms.Label lblSalesTot;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblBankCashWinPur;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblReturnPur;
        private System.Windows.Forms.Label lblCreditPurchases;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblSalesCashWin;
        private System.Windows.Forms.Label lblCreditSales;
        private System.Windows.Forms.Label lblReturnSales;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}