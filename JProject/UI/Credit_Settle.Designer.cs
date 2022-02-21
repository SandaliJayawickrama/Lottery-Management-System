
namespace JProject.UI
{
    partial class Credit_Settle
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCreditAmount = new System.Windows.Forms.TextBox();
            this.lblCreditAmount = new System.Windows.Forms.Label();
            this.txtCreditLimit = new System.Windows.Forms.TextBox();
            this.lblCreditLimit = new System.Windows.Forms.Label();
            this.txtAgentNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAgentNo = new System.Windows.Forms.Label();
            this.lblSearchAgent = new System.Windows.Forms.Label();
            this.txtAgentName = new System.Windows.Forms.TextBox();
            this.lblAgentName = new System.Windows.Forms.Label();
            this.txtSearchAgent = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCreditBalance = new System.Windows.Forms.Label();
            this.txtCreditBalance = new System.Windows.Forms.TextBox();
            this.txtCheque = new System.Windows.Forms.TextBox();
            this.lblCheque = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtWinDlb = new System.Windows.Forms.TextBox();
            this.lblTotAmount = new System.Windows.Forms.Label();
            this.lblDlbW = new System.Windows.Forms.Label();
            this.txtTotSettle = new System.Windows.Forms.TextBox();
            this.lblNlbW = new System.Windows.Forms.Label();
            this.txtWinNlb = new System.Windows.Forms.TextBox();
            this.txtReturnDlb = new System.Windows.Forms.TextBox();
            this.lblDlbR = new System.Windows.Forms.Label();
            this.lblNlbR = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.txtReturnNlb = new System.Windows.Forms.TextBox();
            this.lblReturn = new System.Windows.Forms.Label();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.lblCash = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader1
            // 
            this.lblHeader1.AutoSize = true;
            this.lblHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader1.ForeColor = System.Drawing.Color.Navy;
            this.lblHeader1.Location = new System.Drawing.Point(460, 9);
            this.lblHeader1.Name = "lblHeader1";
            this.lblHeader1.Size = new System.Drawing.Size(185, 32);
            this.lblHeader1.TabIndex = 33;
            this.lblHeader1.Text = "Credit Settle";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCreditAmount);
            this.panel1.Controls.Add(this.lblCreditAmount);
            this.panel1.Controls.Add(this.txtCreditLimit);
            this.panel1.Controls.Add(this.lblCreditLimit);
            this.panel1.Controls.Add(this.txtAgentNo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblAgentNo);
            this.panel1.Controls.Add(this.lblSearchAgent);
            this.panel1.Controls.Add(this.txtAgentName);
            this.panel1.Controls.Add(this.lblAgentName);
            this.panel1.Controls.Add(this.txtSearchAgent);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 126);
            this.panel1.TabIndex = 34;
            // 
            // txtCreditAmount
            // 
            this.txtCreditAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditAmount.ForeColor = System.Drawing.Color.Red;
            this.txtCreditAmount.Location = new System.Drawing.Point(802, 84);
            this.txtCreditAmount.Name = "txtCreditAmount";
            this.txtCreditAmount.Size = new System.Drawing.Size(221, 30);
            this.txtCreditAmount.TabIndex = 53;
            this.txtCreditAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreditAmount_KeyPress);
            // 
            // lblCreditAmount
            // 
            this.lblCreditAmount.AutoSize = true;
            this.lblCreditAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditAmount.Location = new System.Drawing.Point(807, 57);
            this.lblCreditAmount.Name = "lblCreditAmount";
            this.lblCreditAmount.Size = new System.Drawing.Size(130, 24);
            this.lblCreditAmount.TabIndex = 52;
            this.lblCreditAmount.Text = "Credit Amount";
            // 
            // txtCreditLimit
            // 
            this.txtCreditLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditLimit.Location = new System.Drawing.Point(543, 84);
            this.txtCreditLimit.Name = "txtCreditLimit";
            this.txtCreditLimit.Size = new System.Drawing.Size(186, 24);
            this.txtCreditLimit.TabIndex = 51;
            this.txtCreditLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreditLimit_KeyPress);
            // 
            // lblCreditLimit
            // 
            this.lblCreditLimit.AutoSize = true;
            this.lblCreditLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditLimit.Location = new System.Drawing.Point(550, 61);
            this.lblCreditLimit.Name = "lblCreditLimit";
            this.lblCreditLimit.Size = new System.Drawing.Size(96, 20);
            this.lblCreditLimit.TabIndex = 50;
            this.lblCreditLimit.Text = "Credit Limit";
            // 
            // txtAgentNo
            // 
            this.txtAgentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgentNo.Location = new System.Drawing.Point(283, 84);
            this.txtAgentNo.Name = "txtAgentNo";
            this.txtAgentNo.Size = new System.Drawing.Size(186, 24);
            this.txtAgentNo.TabIndex = 48;
            this.txtAgentNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgentNo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 49;
            this.label1.Text = "Agent Details";
            // 
            // lblAgentNo
            // 
            this.lblAgentNo.AutoSize = true;
            this.lblAgentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentNo.Location = new System.Drawing.Point(288, 61);
            this.lblAgentNo.Name = "lblAgentNo";
            this.lblAgentNo.Size = new System.Drawing.Size(75, 20);
            this.lblAgentNo.TabIndex = 47;
            this.lblAgentNo.Text = "Agent no";
            // 
            // lblSearchAgent
            // 
            this.lblSearchAgent.AutoSize = true;
            this.lblSearchAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchAgent.Location = new System.Drawing.Point(210, 10);
            this.lblSearchAgent.Name = "lblSearchAgent";
            this.lblSearchAgent.Size = new System.Drawing.Size(122, 20);
            this.lblSearchAgent.TabIndex = 32;
            this.lblSearchAgent.Text = "Search Agent";
            // 
            // txtAgentName
            // 
            this.txtAgentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgentName.Location = new System.Drawing.Point(24, 84);
            this.txtAgentName.Name = "txtAgentName";
            this.txtAgentName.Size = new System.Drawing.Size(186, 24);
            this.txtAgentName.TabIndex = 46;
            this.txtAgentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgentName_KeyPress);
            // 
            // lblAgentName
            // 
            this.lblAgentName.AutoSize = true;
            this.lblAgentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentName.Location = new System.Drawing.Point(31, 61);
            this.lblAgentName.Name = "lblAgentName";
            this.lblAgentName.Size = new System.Drawing.Size(98, 20);
            this.lblAgentName.TabIndex = 37;
            this.lblAgentName.Text = "Agent name";
            // 
            // txtSearchAgent
            // 
            this.txtSearchAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAgent.Location = new System.Drawing.Point(369, 7);
            this.txtSearchAgent.Name = "txtSearchAgent";
            this.txtSearchAgent.Size = new System.Drawing.Size(295, 27);
            this.txtSearchAgent.TabIndex = 33;
            this.txtSearchAgent.TextChanged += new System.EventHandler(this.txtSearchAgent_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lblCreditBalance);
            this.panel4.Controls.Add(this.txtCreditBalance);
            this.panel4.Controls.Add(this.txtCheque);
            this.panel4.Controls.Add(this.lblCheque);
            this.panel4.Controls.Add(this.btnCalc);
            this.panel4.Controls.Add(this.txtWinDlb);
            this.panel4.Controls.Add(this.lblTotAmount);
            this.panel4.Controls.Add(this.lblDlbW);
            this.panel4.Controls.Add(this.txtTotSettle);
            this.panel4.Controls.Add(this.lblNlbW);
            this.panel4.Controls.Add(this.txtWinNlb);
            this.panel4.Controls.Add(this.txtReturnDlb);
            this.panel4.Controls.Add(this.lblDlbR);
            this.panel4.Controls.Add(this.lblNlbR);
            this.panel4.Controls.Add(this.lblWin);
            this.panel4.Controls.Add(this.txtReturnNlb);
            this.panel4.Controls.Add(this.lblReturn);
            this.panel4.Controls.Add(this.txtCash);
            this.panel4.Controls.Add(this.lblCash);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Location = new System.Drawing.Point(26, 213);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1032, 402);
            this.panel4.TabIndex = 46;
            // 
            // lblCreditBalance
            // 
            this.lblCreditBalance.AutoSize = true;
            this.lblCreditBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditBalance.Location = new System.Drawing.Point(679, 110);
            this.lblCreditBalance.Name = "lblCreditBalance";
            this.lblCreditBalance.Size = new System.Drawing.Size(203, 20);
            this.lblCreditBalance.TabIndex = 80;
            this.lblCreditBalance.Text = "Balance Credit Amount";
            // 
            // txtCreditBalance
            // 
            this.txtCreditBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditBalance.Location = new System.Drawing.Point(665, 147);
            this.txtCreditBalance.Name = "txtCreditBalance";
            this.txtCreditBalance.Size = new System.Drawing.Size(323, 27);
            this.txtCreditBalance.TabIndex = 81;
            this.txtCreditBalance.Text = "0";
            this.txtCreditBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreditBalance_KeyPress);
            // 
            // txtCheque
            // 
            this.txtCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheque.Location = new System.Drawing.Point(174, 104);
            this.txtCheque.Name = "txtCheque";
            this.txtCheque.Size = new System.Drawing.Size(323, 24);
            this.txtCheque.TabIndex = 79;
            this.txtCheque.Text = "0";
            this.txtCheque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCheque_KeyPress);
            // 
            // lblCheque
            // 
            this.lblCheque.AutoSize = true;
            this.lblCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheque.Location = new System.Drawing.Point(4, 110);
            this.lblCheque.Name = "lblCheque";
            this.lblCheque.Size = new System.Drawing.Size(65, 18);
            this.lblCheque.TabIndex = 78;
            this.lblCheque.Text = "Cheque";
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.LightCoral;
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(375, 343);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(114, 35);
            this.btnCalc.TabIndex = 67;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtWinDlb
            // 
            this.txtWinDlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWinDlb.Location = new System.Drawing.Point(429, 156);
            this.txtWinDlb.Name = "txtWinDlb";
            this.txtWinDlb.Size = new System.Drawing.Size(143, 24);
            this.txtWinDlb.TabIndex = 73;
            this.txtWinDlb.Text = "0";
            this.txtWinDlb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWinDlb_KeyPress);
            // 
            // lblTotAmount
            // 
            this.lblTotAmount.AutoSize = true;
            this.lblTotAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotAmount.Location = new System.Drawing.Point(3, 282);
            this.lblTotAmount.Name = "lblTotAmount";
            this.lblTotAmount.Size = new System.Drawing.Size(147, 20);
            this.lblTotAmount.TabIndex = 60;
            this.lblTotAmount.Text = "Total Settlement";
            this.lblTotAmount.Click += new System.EventHandler(this.lblTotAmount_Click);
            // 
            // lblDlbW
            // 
            this.lblDlbW.AutoSize = true;
            this.lblDlbW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDlbW.Location = new System.Drawing.Point(386, 212);
            this.lblDlbW.Name = "lblDlbW";
            this.lblDlbW.Size = new System.Drawing.Size(37, 18);
            this.lblDlbW.TabIndex = 72;
            this.lblDlbW.Text = "DLB";
            // 
            // txtTotSettle
            // 
            this.txtTotSettle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotSettle.Location = new System.Drawing.Point(174, 275);
            this.txtTotSettle.Name = "txtTotSettle";
            this.txtTotSettle.Size = new System.Drawing.Size(323, 27);
            this.txtTotSettle.TabIndex = 61;
            this.txtTotSettle.Text = "0";
            this.txtTotSettle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotSettle_KeyPress);
            // 
            // lblNlbW
            // 
            this.lblNlbW.AutoSize = true;
            this.lblNlbW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNlbW.Location = new System.Drawing.Point(171, 159);
            this.lblNlbW.Name = "lblNlbW";
            this.lblNlbW.Size = new System.Drawing.Size(37, 18);
            this.lblNlbW.TabIndex = 70;
            this.lblNlbW.Text = "NLB";
            // 
            // txtWinNlb
            // 
            this.txtWinNlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWinNlb.Location = new System.Drawing.Point(214, 156);
            this.txtWinNlb.Name = "txtWinNlb";
            this.txtWinNlb.Size = new System.Drawing.Size(142, 24);
            this.txtWinNlb.TabIndex = 71;
            this.txtWinNlb.Text = "0";
            this.txtWinNlb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWinNlb_KeyPress);
            // 
            // txtReturnDlb
            // 
            this.txtReturnDlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnDlb.Location = new System.Drawing.Point(429, 206);
            this.txtReturnDlb.Name = "txtReturnDlb";
            this.txtReturnDlb.Size = new System.Drawing.Size(144, 24);
            this.txtReturnDlb.TabIndex = 69;
            this.txtReturnDlb.Text = "0";
            this.txtReturnDlb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReturnDlb_KeyPress);
            // 
            // lblDlbR
            // 
            this.lblDlbR.AutoSize = true;
            this.lblDlbR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDlbR.Location = new System.Drawing.Point(386, 156);
            this.lblDlbR.Name = "lblDlbR";
            this.lblDlbR.Size = new System.Drawing.Size(37, 18);
            this.lblDlbR.TabIndex = 68;
            this.lblDlbR.Text = "DLB";
            // 
            // lblNlbR
            // 
            this.lblNlbR.AutoSize = true;
            this.lblNlbR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNlbR.Location = new System.Drawing.Point(171, 212);
            this.lblNlbR.Name = "lblNlbR";
            this.lblNlbR.Size = new System.Drawing.Size(37, 18);
            this.lblNlbR.TabIndex = 58;
            this.lblNlbR.Text = "NLB";
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.Location = new System.Drawing.Point(4, 162);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(130, 18);
            this.lblWin.TabIndex = 66;
            this.lblWin.Text = "Winning Amount";
            // 
            // txtReturnNlb
            // 
            this.txtReturnNlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnNlb.Location = new System.Drawing.Point(214, 209);
            this.txtReturnNlb.Name = "txtReturnNlb";
            this.txtReturnNlb.Size = new System.Drawing.Size(144, 24);
            this.txtReturnNlb.TabIndex = 65;
            this.txtReturnNlb.Text = "0";
            this.txtReturnNlb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReturnNlb_KeyPress);
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturn.Location = new System.Drawing.Point(4, 209);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(120, 18);
            this.lblReturn.TabIndex = 64;
            this.lblReturn.Text = "Return Amount";
            // 
            // txtCash
            // 
            this.txtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(174, 59);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(323, 24);
            this.txtCash.TabIndex = 63;
            this.txtCash.Text = "0";
            this.txtCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCash_KeyPress);
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.Location = new System.Drawing.Point(4, 65);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(109, 18);
            this.lblCash.TabIndex = 62;
            this.lblCash.Text = "Cash Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 21);
            this.label4.TabIndex = 59;
            this.label4.Text = "Settlement Details";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(743, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 43);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Credit_Settle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1076, 643);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHeader1);
            this.Name = "Credit_Settle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credit_Settle";
            this.Load += new System.EventHandler(this.Credit_Settle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAgentNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAgentNo;
        private System.Windows.Forms.Label lblSearchAgent;
        private System.Windows.Forms.TextBox txtAgentName;
        private System.Windows.Forms.Label lblAgentName;
        private System.Windows.Forms.TextBox txtSearchAgent;
        private System.Windows.Forms.TextBox txtCreditAmount;
        private System.Windows.Forms.Label lblCreditAmount;
        private System.Windows.Forms.TextBox txtCreditLimit;
        private System.Windows.Forms.Label lblCreditLimit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtWinDlb;
        private System.Windows.Forms.Label lblDlbW;
        private System.Windows.Forms.Label lblNlbW;
        private System.Windows.Forms.TextBox txtWinNlb;
        private System.Windows.Forms.TextBox txtReturnDlb;
        private System.Windows.Forms.Label lblDlbR;
        private System.Windows.Forms.Label lblNlbR;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.TextBox txtReturnNlb;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.TextBox txtTotSettle;
        private System.Windows.Forms.Label lblTotAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCheque;
        private System.Windows.Forms.Label lblCheque;
        private System.Windows.Forms.Label lblCreditBalance;
        private System.Windows.Forms.TextBox txtCreditBalance;
    }
}