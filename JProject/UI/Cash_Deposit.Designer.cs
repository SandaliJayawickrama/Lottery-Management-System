
namespace JProject.UI
{
    partial class Cash_Deposit
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
            this.lblDeposit = new System.Windows.Forms.Label();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.lblBlance1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBalance2 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.cmbDescription = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader1
            // 
            this.lblHeader1.AutoSize = true;
            this.lblHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader1.ForeColor = System.Drawing.Color.Indigo;
            this.lblHeader1.Location = new System.Drawing.Point(298, 9);
            this.lblHeader1.Name = "lblHeader1";
            this.lblHeader1.Size = new System.Drawing.Size(205, 32);
            this.lblHeader1.TabIndex = 82;
            this.lblHeader1.Text = "Cash Deposit ";
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.Location = new System.Drawing.Point(175, 206);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(151, 25);
            this.lblDeposit.TabIndex = 86;
            this.lblDeposit.Text = "Deposit Amount";
            // 
            // txtBank
            // 
            this.txtBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBank.Location = new System.Drawing.Point(348, 206);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(253, 27);
            this.txtBank.TabIndex = 85;
            this.txtBank.Text = "0";
            this.txtBank.TextChanged += new System.EventHandler(this.txtBank_TextChanged);
            this.txtBank.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBank_KeyPress);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lblBlance1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(180, 83);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(420, 88);
            this.panel4.TabIndex = 89;
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.Location = new System.Drawing.Point(319, 424);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(171, 51);
            this.btnDeposit.TabIndex = 79;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // lblBlance1
            // 
            this.lblBlance1.AutoSize = true;
            this.lblBlance1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlance1.ForeColor = System.Drawing.Color.Blue;
            this.lblBlance1.Location = new System.Drawing.Point(182, 30);
            this.lblBlance1.Name = "lblBlance1";
            this.lblBlance1.Size = new System.Drawing.Size(54, 25);
            this.lblBlance1.TabIndex = 91;
            this.lblBlance1.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 90;
            this.label3.Text = "Cash In Hand:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 91;
            this.label1.Text = "Cash Balance:";
            // 
            // lblBalance2
            // 
            this.lblBalance2.AutoSize = true;
            this.lblBalance2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance2.ForeColor = System.Drawing.Color.Black;
            this.lblBalance2.Location = new System.Drawing.Point(343, 340);
            this.lblBalance2.Name = "lblBalance2";
            this.lblBalance2.Size = new System.Drawing.Size(50, 25);
            this.lblBalance2.TabIndex = 93;
            this.lblBalance2.Text = "0.00";
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.LightCoral;
            this.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(562, 340);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(102, 37);
            this.btnCalc.TabIndex = 94;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // cmbDescription
            // 
            this.cmbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDescription.FormattingEnabled = true;
            this.cmbDescription.Items.AddRange(new object[] {
            "Deposit - Ordering Tickets",
            "Deposit - Direct "});
            this.cmbDescription.Location = new System.Drawing.Point(348, 255);
            this.cmbDescription.Name = "cmbDescription";
            this.cmbDescription.Size = new System.Drawing.Size(253, 28);
            this.cmbDescription.TabIndex = 96;
            this.cmbDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbDescription_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 97;
            this.label2.Text = "Description";
            // 
            // Cash_Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(772, 502);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDescription);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblBalance2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.txtBank);
            this.Controls.Add(this.lblHeader1);
            this.Name = "Cash_Deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cash_Deposit";
            this.Load += new System.EventHandler(this.Cash_Deposit_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader1;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblBlance1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBalance2;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.ComboBox cmbDescription;
        private System.Windows.Forms.Label label2;
    }
}