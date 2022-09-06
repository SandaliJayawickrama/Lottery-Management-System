
namespace JProject.UI
{
    partial class Balances_Management
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
            this.txtCash = new System.Windows.Forms.TextBox();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblHeader1 = new System.Windows.Forms.Label();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWinNLB = new System.Windows.Forms.TextBox();
            this.txtWinDLB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRetRecNLB = new System.Windows.Forms.TextBox();
            this.txtRetRecDLB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRetPayDLB = new System.Windows.Forms.TextBox();
            this.txtCredPayNlb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCredPayDlb = new System.Windows.Forms.TextBox();
            this.txtRetPayNLB = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.btnDeduct = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCash
            // 
            this.txtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(107, 82);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(285, 24);
            this.txtCash.TabIndex = 65;
            this.txtCash.Text = "0";
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            this.txtCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCash_KeyPress);
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.Location = new System.Drawing.Point(35, 85);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(52, 18);
            this.lblCash.TabIndex = 64;
            this.lblCash.Text = "Cash ";
            // 
            // lblHeader1
            // 
            this.lblHeader1.AutoSize = true;
            this.lblHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader1.ForeColor = System.Drawing.Color.Navy;
            this.lblHeader1.Location = new System.Drawing.Point(372, 9);
            this.lblHeader1.Name = "lblHeader1";
            this.lblHeader1.Size = new System.Drawing.Size(277, 29);
            this.lblHeader1.TabIndex = 66;
            this.lblHeader1.Text = "Balances Management";
            // 
            // txtBank
            // 
            this.txtBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBank.Location = new System.Drawing.Point(107, 131);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(285, 24);
            this.txtBank.TabIndex = 68;
            this.txtBank.Text = "0";
            this.txtBank.TextChanged += new System.EventHandler(this.txtBank_TextChanged);
            this.txtBank.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBank_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 67;
            this.label1.Text = "Bank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 69;
            this.label2.Text = "Return Payables";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(403, 602);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(162, 49);
            this.btnSave.TabIndex = 76;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(16, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 77;
            this.label3.Text = "Assets";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 18);
            this.label5.TabIndex = 78;
            this.label5.Text = "Win";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 79;
            this.label6.Text = "Win NLB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 80;
            this.label7.Text = "Win DLB";
            // 
            // txtWinNLB
            // 
            this.txtWinNLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWinNLB.Location = new System.Drawing.Point(153, 219);
            this.txtWinNLB.Name = "txtWinNLB";
            this.txtWinNLB.Size = new System.Drawing.Size(239, 24);
            this.txtWinNLB.TabIndex = 81;
            this.txtWinNLB.Text = "0";
            this.txtWinNLB.TextChanged += new System.EventHandler(this.txtWinNLB_TextChanged);
            this.txtWinNLB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWinNLB_KeyPress);
            // 
            // txtWinDLB
            // 
            this.txtWinDLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWinDLB.Location = new System.Drawing.Point(153, 259);
            this.txtWinDLB.Name = "txtWinDLB";
            this.txtWinDLB.Size = new System.Drawing.Size(239, 24);
            this.txtWinDLB.TabIndex = 82;
            this.txtWinDLB.Text = "0";
            this.txtWinDLB.TextChanged += new System.EventHandler(this.txtWinDLB_TextChanged);
            this.txtWinDLB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWinDLB_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 18);
            this.label8.TabIndex = 83;
            this.label8.Text = "Return Recievables";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(64, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 18);
            this.label9.TabIndex = 84;
            this.label9.Text = "NLB";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(64, 402);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 18);
            this.label10.TabIndex = 85;
            this.label10.Text = "DLB";
            // 
            // txtRetRecNLB
            // 
            this.txtRetRecNLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetRecNLB.Location = new System.Drawing.Point(153, 362);
            this.txtRetRecNLB.Name = "txtRetRecNLB";
            this.txtRetRecNLB.Size = new System.Drawing.Size(239, 24);
            this.txtRetRecNLB.TabIndex = 86;
            this.txtRetRecNLB.Text = "0";
            this.txtRetRecNLB.TextChanged += new System.EventHandler(this.txtRetRecNLB_TextChanged);
            this.txtRetRecNLB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRetRecNLB_KeyPress);
            // 
            // txtRetRecDLB
            // 
            this.txtRetRecDLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetRecDLB.Location = new System.Drawing.Point(153, 396);
            this.txtRetRecDLB.Name = "txtRetRecDLB";
            this.txtRetRecDLB.Size = new System.Drawing.Size(239, 24);
            this.txtRetRecDLB.TabIndex = 87;
            this.txtRetRecDLB.Text = "0";
            this.txtRetRecDLB.TextChanged += new System.EventHandler(this.txtRetRecDLB_TextChanged);
            this.txtRetRecDLB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRetRecDLB_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(30, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 24);
            this.label11.TabIndex = 88;
            this.label11.Text = "Liabilities";
            // 
            // txtRetPayDLB
            // 
            this.txtRetPayDLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetPayDLB.Location = new System.Drawing.Point(201, 148);
            this.txtRetPayDLB.Name = "txtRetPayDLB";
            this.txtRetPayDLB.Size = new System.Drawing.Size(239, 24);
            this.txtRetPayDLB.TabIndex = 92;
            this.txtRetPayDLB.Text = "0";
            this.txtRetPayDLB.TextChanged += new System.EventHandler(this.txtRetPayDLB_TextChanged);
            this.txtRetPayDLB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRetPayDLB_KeyPress);
            // 
            // txtCredPayNlb
            // 
            this.txtCredPayNlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredPayNlb.Location = new System.Drawing.Point(201, 240);
            this.txtCredPayNlb.Name = "txtCredPayNlb";
            this.txtCredPayNlb.Size = new System.Drawing.Size(239, 24);
            this.txtCredPayNlb.TabIndex = 91;
            this.txtCredPayNlb.Text = "0";
            this.txtCredPayNlb.TextChanged += new System.EventHandler(this.txtCredPayNlb_TextChanged);
            this.txtCredPayNlb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCredPayNlb_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(112, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 18);
            this.label12.TabIndex = 90;
            this.label12.Text = "DLB";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(112, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 18);
            this.label13.TabIndex = 89;
            this.label13.Text = "NLB";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(77, 211);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 18);
            this.label14.TabIndex = 93;
            this.label14.Text = "Credit Payables";
            // 
            // txtCredPayDlb
            // 
            this.txtCredPayDlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredPayDlb.Location = new System.Drawing.Point(201, 274);
            this.txtCredPayDlb.Name = "txtCredPayDlb";
            this.txtCredPayDlb.Size = new System.Drawing.Size(239, 24);
            this.txtCredPayDlb.TabIndex = 97;
            this.txtCredPayDlb.Text = "0";
            this.txtCredPayDlb.TextChanged += new System.EventHandler(this.txtCredPayDlb_TextChanged);
            this.txtCredPayDlb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCredPayDlb_KeyPress);
            // 
            // txtRetPayNLB
            // 
            this.txtRetPayNLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetPayNLB.Location = new System.Drawing.Point(201, 114);
            this.txtRetPayNLB.Name = "txtRetPayNLB";
            this.txtRetPayNLB.Size = new System.Drawing.Size(239, 24);
            this.txtRetPayNLB.TabIndex = 96;
            this.txtRetPayNLB.Text = "0";
            this.txtRetPayNLB.TextChanged += new System.EventHandler(this.txtRetPayNLB_TextChanged);
            this.txtRetPayNLB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRetPayNLB_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(112, 280);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 18);
            this.label15.TabIndex = 95;
            this.label15.Text = "DLB";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(112, 243);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 18);
            this.label16.TabIndex = 94;
            this.label16.Text = "NLB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(30, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 98;
            this.label4.Text = "Capital";
            // 
            // txtCapital
            // 
            this.txtCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapital.Location = new System.Drawing.Point(201, 61);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(239, 24);
            this.txtCapital.TabIndex = 99;
            this.txtCapital.Text = "0";
            this.txtCapital.TextChanged += new System.EventHandler(this.txtCapital_TextChanged);
            this.txtCapital.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapital_KeyPress);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.lblCash);
            this.panel6.Controls.Add(this.txtCash);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.txtBank);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.txtWinNLB);
            this.panel6.Controls.Add(this.txtWinDLB);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.txtRetRecDLB);
            this.panel6.Controls.Add(this.txtRetRecNLB);
            this.panel6.Location = new System.Drawing.Point(12, 86);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(444, 467);
            this.panel6.TabIndex = 100;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtCredPayDlb);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtRetPayNLB);
            this.panel1.Controls.Add(this.txtCredPayNlb);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtRetPayDLB);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(516, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 331);
            this.panel1.TabIndex = 101;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtCapital);
            this.panel2.Location = new System.Drawing.Point(516, 437);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 116);
            this.panel2.TabIndex = 102;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(112, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 18);
            this.label17.TabIndex = 98;
            this.label17.Text = "Capital";
            // 
            // btnDeduct
            // 
            this.btnDeduct.BackColor = System.Drawing.Color.Red;
            this.btnDeduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeduct.Location = new System.Drawing.Point(876, 648);
            this.btnDeduct.Name = "btnDeduct";
            this.btnDeduct.Size = new System.Drawing.Size(99, 37);
            this.btnDeduct.TabIndex = 104;
            this.btnDeduct.Text = "Deduct";
            this.btnDeduct.UseVisualStyleBackColor = false;
            this.btnDeduct.Click += new System.EventHandler(this.btnDeduct_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(856, 39);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(59, 20);
            this.lblDate.TabIndex = 98;
            this.lblDate.Text = "Today";
            // 
            // Balances_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1016, 697);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnDeduct);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblHeader1);
            this.Name = "Balances_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blances_Management";
            this.Load += new System.EventHandler(this.Balances_Management_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblHeader1;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWinNLB;
        private System.Windows.Forms.TextBox txtWinDLB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRetRecNLB;
        private System.Windows.Forms.TextBox txtRetRecDLB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRetPayDLB;
        private System.Windows.Forms.TextBox txtCredPayNlb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCredPayDlb;
        private System.Windows.Forms.TextBox txtRetPayNLB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnDeduct;
        private System.Windows.Forms.Label lblDate;
    }
}