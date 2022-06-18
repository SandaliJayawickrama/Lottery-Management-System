
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
            this.txtPayNlb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAgentName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPayDlb = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCash
            // 
            this.txtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(244, 95);
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
            this.lblCash.Location = new System.Drawing.Point(74, 101);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(85, 18);
            this.lblCash.TabIndex = 64;
            this.lblCash.Text = "Add Cash ";
            this.lblCash.Click += new System.EventHandler(this.lblCash_Click);
            // 
            // lblHeader1
            // 
            this.lblHeader1.AutoSize = true;
            this.lblHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader1.ForeColor = System.Drawing.Color.Navy;
            this.lblHeader1.Location = new System.Drawing.Point(274, 9);
            this.lblHeader1.Name = "lblHeader1";
            this.lblHeader1.Size = new System.Drawing.Size(277, 29);
            this.lblHeader1.TabIndex = 66;
            this.lblHeader1.Text = "Balances Management";
            // 
            // txtBank
            // 
            this.txtBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBank.Location = new System.Drawing.Point(244, 147);
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
            this.label1.Location = new System.Drawing.Point(74, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 67;
            this.label1.Text = "Add Bank";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPayNlb
            // 
            this.txtPayNlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayNlb.Location = new System.Drawing.Point(244, 316);
            this.txtPayNlb.Name = "txtPayNlb";
            this.txtPayNlb.Size = new System.Drawing.Size(285, 24);
            this.txtPayNlb.TabIndex = 70;
            this.txtPayNlb.Text = "0";
            this.txtPayNlb.TextChanged += new System.EventHandler(this.txtPayNlb_TextChanged);
            this.txtPayNlb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPayNlb_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 69;
            this.label2.Text = "Payable Balance";
            // 
            // lblAgentName
            // 
            this.lblAgentName.AutoSize = true;
            this.lblAgentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentName.Location = new System.Drawing.Point(152, 316);
            this.lblAgentName.Name = "lblAgentName";
            this.lblAgentName.Size = new System.Drawing.Size(43, 20);
            this.lblAgentName.TabIndex = 73;
            this.lblAgentName.Text = "NLB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 75;
            this.label4.Text = "DLB";
            // 
            // txtPayDlb
            // 
            this.txtPayDlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayDlb.Location = new System.Drawing.Point(244, 355);
            this.txtPayDlb.Name = "txtPayDlb";
            this.txtPayDlb.Size = new System.Drawing.Size(285, 24);
            this.txtPayDlb.TabIndex = 74;
            this.txtPayDlb.Text = "0";
            this.txtPayDlb.TextChanged += new System.EventHandler(this.txtPayDlb_TextChanged);
            this.txtPayDlb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPayDlb_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(308, 504);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 38);
            this.btnSave.TabIndex = 76;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Balances_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(759, 587);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPayDlb);
            this.Controls.Add(this.lblAgentName);
            this.Controls.Add(this.txtPayNlb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBank);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHeader1);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.lblCash);
            this.Name = "Balances_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blances_Management";
            this.Load += new System.EventHandler(this.Balances_Management_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblHeader1;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPayNlb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAgentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPayDlb;
        private System.Windows.Forms.Button btnSave;
    }
}