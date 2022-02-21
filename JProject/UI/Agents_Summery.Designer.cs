
namespace JProject.UI
{
    partial class Agents_Summery
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
            this.lblHeader1 = new System.Windows.Forms.Label();
            this.dgvAgentSummery = new System.Windows.Forms.DataGridView();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpSummeryDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotSales = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.txtFreeTotal = new System.Windows.Forms.TextBox();
            this.txtFreeDlb = new System.Windows.Forms.TextBox();
            this.txtfreeNlb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRetTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRetDlb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.txtWinDlb = new System.Windows.Forms.TextBox();
            this.txtRetNlb = new System.Windows.Forms.TextBox();
            this.txtWinNlb = new System.Windows.Forms.TextBox();
            this.txtWinTotal = new System.Windows.Forms.TextBox();
            this.txtTotReceives = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotCredits = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTodayCredits = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotPurchses = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgentSummery)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader1
            // 
            this.lblHeader1.AutoSize = true;
            this.lblHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader1.ForeColor = System.Drawing.Color.Navy;
            this.lblHeader1.Location = new System.Drawing.Point(545, 9);
            this.lblHeader1.Name = "lblHeader1";
            this.lblHeader1.Size = new System.Drawing.Size(320, 32);
            this.lblHeader1.TabIndex = 43;
            this.lblHeader1.Text = "Daily Sales Summery  ";
            // 
            // dgvAgentSummery
            // 
            this.dgvAgentSummery.AllowUserToAddRows = false;
            this.dgvAgentSummery.AllowUserToDeleteRows = false;
            this.dgvAgentSummery.AllowUserToOrderColumns = true;
            this.dgvAgentSummery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgentSummery.Location = new System.Drawing.Point(12, 73);
            this.dgvAgentSummery.Name = "dgvAgentSummery";
            this.dgvAgentSummery.RowHeadersWidth = 51;
            this.dgvAgentSummery.RowTemplate.Height = 24;
            this.dgvAgentSummery.Size = new System.Drawing.Size(1379, 411);
            this.dgvAgentSummery.TabIndex = 44;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(1055, 34);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(108, 20);
            this.lblDate.TabIndex = 45;
            this.lblDate.Text = "Select Date";
            // 
            // dtpSummeryDate
            // 
            this.dtpSummeryDate.CustomFormat = "yyyy-MM-dd ";
            this.dtpSummeryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSummeryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSummeryDate.Location = new System.Drawing.Point(1195, 29);
            this.dtpSummeryDate.Name = "dtpSummeryDate";
            this.dtpSummeryDate.Size = new System.Drawing.Size(136, 27);
            this.dtpSummeryDate.TabIndex = 46;
            this.dtpSummeryDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(789, 564);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Total Sales";
            // 
            // txtTotSales
            // 
            this.txtTotSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotSales.Location = new System.Drawing.Point(1124, 564);
            this.txtTotSales.Name = "txtTotSales";
            this.txtTotSales.Size = new System.Drawing.Size(258, 24);
            this.txtTotSales.TabIndex = 50;
            this.txtTotSales.TextChanged += new System.EventHandler(this.txtTotSales_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblWin);
            this.panel1.Controls.Add(this.txtFreeTotal);
            this.panel1.Controls.Add(this.txtFreeDlb);
            this.panel1.Controls.Add(this.txtfreeNlb);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtRetTotal);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtRetDlb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCash);
            this.panel1.Controls.Add(this.txtWinDlb);
            this.panel1.Controls.Add(this.txtRetNlb);
            this.panel1.Controls.Add(this.txtWinNlb);
            this.panel1.Controls.Add(this.txtWinTotal);
            this.panel1.Location = new System.Drawing.Point(23, 510);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 259);
            this.panel1.TabIndex = 59;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(175, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 17);
            this.label11.TabIndex = 78;
            this.label11.Text = "DLB";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(188, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 17);
            this.label12.TabIndex = 77;
            this.label12.Text = "NLB";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(175, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 76;
            this.label9.Text = "DLB";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(188, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 75;
            this.label10.Text = "NLB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 74;
            this.label4.Text = "DLB";
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Location = new System.Drawing.Point(188, 51);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(35, 17);
            this.lblWin.TabIndex = 64;
            this.lblWin.Text = "NLB";
            // 
            // txtFreeTotal
            // 
            this.txtFreeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFreeTotal.Location = new System.Drawing.Point(440, 193);
            this.txtFreeTotal.Name = "txtFreeTotal";
            this.txtFreeTotal.Size = new System.Drawing.Size(223, 22);
            this.txtFreeTotal.TabIndex = 73;
            // 
            // txtFreeDlb
            // 
            this.txtFreeDlb.Location = new System.Drawing.Point(229, 208);
            this.txtFreeDlb.Name = "txtFreeDlb";
            this.txtFreeDlb.Size = new System.Drawing.Size(190, 22);
            this.txtFreeDlb.TabIndex = 72;
            // 
            // txtfreeNlb
            // 
            this.txtfreeNlb.Location = new System.Drawing.Point(229, 180);
            this.txtfreeNlb.Name = "txtfreeNlb";
            this.txtfreeNlb.Size = new System.Drawing.Size(190, 22);
            this.txtfreeNlb.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 70;
            this.label8.Text = "Free Issues";
            // 
            // txtRetTotal
            // 
            this.txtRetTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetTotal.Location = new System.Drawing.Point(440, 124);
            this.txtRetTotal.Name = "txtRetTotal";
            this.txtRetTotal.Size = new System.Drawing.Size(223, 22);
            this.txtRetTotal.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "Cash And Cheques";
            // 
            // txtRetDlb
            // 
            this.txtRetDlb.Location = new System.Drawing.Point(229, 142);
            this.txtRetDlb.Name = "txtRetDlb";
            this.txtRetDlb.Size = new System.Drawing.Size(190, 22);
            this.txtRetDlb.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 61;
            this.label6.Text = "Win";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 67;
            this.label5.Text = "Returns";
            // 
            // txtCash
            // 
            this.txtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(230, 15);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(223, 22);
            this.txtCash.TabIndex = 62;
            // 
            // txtWinDlb
            // 
            this.txtWinDlb.Location = new System.Drawing.Point(229, 79);
            this.txtWinDlb.Name = "txtWinDlb";
            this.txtWinDlb.Size = new System.Drawing.Size(190, 22);
            this.txtWinDlb.TabIndex = 66;
            // 
            // txtRetNlb
            // 
            this.txtRetNlb.Location = new System.Drawing.Point(229, 114);
            this.txtRetNlb.Name = "txtRetNlb";
            this.txtRetNlb.Size = new System.Drawing.Size(190, 22);
            this.txtRetNlb.TabIndex = 63;
            // 
            // txtWinNlb
            // 
            this.txtWinNlb.Location = new System.Drawing.Point(229, 51);
            this.txtWinNlb.Name = "txtWinNlb";
            this.txtWinNlb.Size = new System.Drawing.Size(190, 22);
            this.txtWinNlb.TabIndex = 65;
            // 
            // txtWinTotal
            // 
            this.txtWinTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWinTotal.Location = new System.Drawing.Point(440, 61);
            this.txtWinTotal.Name = "txtWinTotal";
            this.txtWinTotal.Size = new System.Drawing.Size(223, 22);
            this.txtWinTotal.TabIndex = 64;
            // 
            // txtTotReceives
            // 
            this.txtTotReceives.Location = new System.Drawing.Point(1005, 605);
            this.txtTotReceives.Name = "txtTotReceives";
            this.txtTotReceives.Size = new System.Drawing.Size(234, 22);
            this.txtTotReceives.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(843, 605);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 60;
            this.label2.Text = "Total Receives";
            // 
            // txtTotCredits
            // 
            this.txtTotCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotCredits.ForeColor = System.Drawing.Color.Red;
            this.txtTotCredits.Location = new System.Drawing.Point(929, 749);
            this.txtTotCredits.Name = "txtTotCredits";
            this.txtTotCredits.Size = new System.Drawing.Size(234, 24);
            this.txtTotCredits.TabIndex = 63;
            this.txtTotCredits.TextChanged += new System.EventHandler(this.txtTotCredits_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(843, 644);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 18);
            this.label3.TabIndex = 62;
            this.label3.Text = "Sales - Credits";
            // 
            // txtTodayCredits
            // 
            this.txtTodayCredits.Location = new System.Drawing.Point(1005, 642);
            this.txtTodayCredits.Name = "txtTodayCredits";
            this.txtTodayCredits.Size = new System.Drawing.Size(234, 22);
            this.txtTodayCredits.TabIndex = 65;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(789, 749);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 20);
            this.label13.TabIndex = 64;
            this.label13.Text = "Total Credits";
            // 
            // txtTotPurchses
            // 
            this.txtTotPurchses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotPurchses.Location = new System.Drawing.Point(1124, 510);
            this.txtTotPurchses.Name = "txtTotPurchses";
            this.txtTotPurchses.Size = new System.Drawing.Size(258, 24);
            this.txtTotPurchses.TabIndex = 67;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(789, 510);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 20);
            this.label14.TabIndex = 66;
            this.label14.Text = "Total Purchses";
            // 
            // Agents_Summery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 796);
            this.Controls.Add(this.txtTotPurchses);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTodayCredits);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTotCredits);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotReceives);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTotSales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpSummeryDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dgvAgentSummery);
            this.Controls.Add(this.lblHeader1);
            this.Name = "Agents_Summery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agents_Summery";
            this.Load += new System.EventHandler(this.Agents_Summery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgentSummery)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader1;
        private System.Windows.Forms.DataGridView dgvAgentSummery;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpSummeryDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotSales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRetTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRetDlb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.TextBox txtWinDlb;
        private System.Windows.Forms.TextBox txtRetNlb;
        private System.Windows.Forms.TextBox txtWinNlb;
        private System.Windows.Forms.TextBox txtWinTotal;
        private System.Windows.Forms.TextBox txtFreeTotal;
        private System.Windows.Forms.TextBox txtFreeDlb;
        private System.Windows.Forms.TextBox txtfreeNlb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.TextBox txtTotReceives;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotCredits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTodayCredits;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTotPurchses;
        private System.Windows.Forms.Label label14;
    }
}