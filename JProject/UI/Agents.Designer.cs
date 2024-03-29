﻿
namespace JProject.UI
{
    partial class Agents
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvAgents = new System.Windows.Forms.DataGridView();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.lblAgentNo = new System.Windows.Forms.Label();
            this.txtCreditL = new System.Windows.Forms.TextBox();
            this.lblCreditL = new System.Windows.Forms.Label();
            this.txtAname = new System.Windows.Forms.TextBox();
            this.lblAgentName = new System.Windows.Forms.Label();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.lblDes = new System.Windows.Forms.Label();
            this.lblHeader1 = new System.Windows.Forms.Label();
            this.lblHeader2 = new System.Windows.Forms.Label();
            this.txtAId = new System.Windows.Forms.TextBox();
            this.lblAgentId = new System.Windows.Forms.Label();
            this.txtAaddress = new System.Windows.Forms.TextBox();
            this.lblAgentAddress = new System.Windows.Forms.Label();
            this.txtCreditBalance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightPink;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(147, 696);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(187, 50);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(269, 577);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(187, 50);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(35, 577);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(187, 50);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(690, 125);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(548, 28);
            this.txtSearch.TabIndex = 24;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(608, 128);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(76, 24);
            this.lblSearch.TabIndex = 23;
            this.lblSearch.Text = "Search";
            // 
            // dgvAgents
            // 
            this.dgvAgents.AllowUserToAddRows = false;
            this.dgvAgents.AllowUserToDeleteRows = false;
            this.dgvAgents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgents.Location = new System.Drawing.Point(536, 212);
            this.dgvAgents.Name = "dgvAgents";
            this.dgvAgents.ReadOnly = true;
            this.dgvAgents.RowHeadersWidth = 51;
            this.dgvAgents.RowTemplate.Height = 24;
            this.dgvAgents.Size = new System.Drawing.Size(796, 497);
            this.dgvAgents.TabIndex = 22;
            this.dgvAgents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgents_CellContentClick);
            this.dgvAgents.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAgents_RowHeaderMouseDoubleClick);
            this.dgvAgents.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvAgents_MouseDoubleClick);
            // 
            // txtAno
            // 
            this.txtAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAno.Location = new System.Drawing.Point(167, 245);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(309, 28);
            this.txtAno.TabIndex = 19;
            // 
            // lblAgentNo
            // 
            this.lblAgentNo.AutoSize = true;
            this.lblAgentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentNo.Location = new System.Drawing.Point(12, 248);
            this.lblAgentNo.Name = "lblAgentNo";
            this.lblAgentNo.Size = new System.Drawing.Size(87, 24);
            this.lblAgentNo.TabIndex = 18;
            this.lblAgentNo.Text = "Agent no";
            this.lblAgentNo.Click += new System.EventHandler(this.lblPhone_Click);
            // 
            // txtCreditL
            // 
            this.txtCreditL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditL.Location = new System.Drawing.Point(166, 367);
            this.txtCreditL.Name = "txtCreditL";
            this.txtCreditL.Size = new System.Drawing.Size(309, 28);
            this.txtCreditL.TabIndex = 17;
            this.txtCreditL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreditL_KeyPress);
            // 
            // lblCreditL
            // 
            this.lblCreditL.AutoSize = true;
            this.lblCreditL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditL.Location = new System.Drawing.Point(12, 367);
            this.lblCreditL.Name = "lblCreditL";
            this.lblCreditL.Size = new System.Drawing.Size(96, 24);
            this.lblCreditL.TabIndex = 16;
            this.lblCreditL.Text = "Credit limit";
            // 
            // txtAname
            // 
            this.txtAname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAname.Location = new System.Drawing.Point(167, 184);
            this.txtAname.Name = "txtAname";
            this.txtAname.Size = new System.Drawing.Size(309, 28);
            this.txtAname.TabIndex = 15;
            // 
            // lblAgentName
            // 
            this.lblAgentName.AutoSize = true;
            this.lblAgentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentName.Location = new System.Drawing.Point(12, 187);
            this.lblAgentName.Name = "lblAgentName";
            this.lblAgentName.Size = new System.Drawing.Size(113, 24);
            this.lblAgentName.TabIndex = 14;
            this.lblAgentName.Text = "Agent name";
            // 
            // txtDescrip
            // 
            this.txtDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescrip.Location = new System.Drawing.Point(166, 493);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(309, 28);
            this.txtDescrip.TabIndex = 29;
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.Location = new System.Drawing.Point(12, 493);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(104, 24);
            this.lblDes.TabIndex = 28;
            this.lblDes.Text = "Description";
            // 
            // lblHeader1
            // 
            this.lblHeader1.AutoSize = true;
            this.lblHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader1.ForeColor = System.Drawing.Color.Teal;
            this.lblHeader1.Location = new System.Drawing.Point(561, 9);
            this.lblHeader1.Name = "lblHeader1";
            this.lblHeader1.Size = new System.Drawing.Size(217, 32);
            this.lblHeader1.TabIndex = 30;
            this.lblHeader1.Text = "Agent Register";
            // 
            // lblHeader2
            // 
            this.lblHeader2.AutoSize = true;
            this.lblHeader2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader2.Location = new System.Drawing.Point(541, 175);
            this.lblHeader2.Name = "lblHeader2";
            this.lblHeader2.Size = new System.Drawing.Size(102, 24);
            this.lblHeader2.TabIndex = 32;
            this.lblHeader2.Text = "Agent List";
            // 
            // txtAId
            // 
            this.txtAId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAId.Location = new System.Drawing.Point(167, 124);
            this.txtAId.Name = "txtAId";
            this.txtAId.Size = new System.Drawing.Size(309, 28);
            this.txtAId.TabIndex = 34;
            this.txtAId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAId_KeyPress);
            // 
            // lblAgentId
            // 
            this.lblAgentId.AutoSize = true;
            this.lblAgentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentId.Location = new System.Drawing.Point(12, 124);
            this.lblAgentId.Name = "lblAgentId";
            this.lblAgentId.Size = new System.Drawing.Size(80, 24);
            this.lblAgentId.TabIndex = 33;
            this.lblAgentId.Text = "Agent Id";
            this.lblAgentId.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAaddress
            // 
            this.txtAaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAaddress.Location = new System.Drawing.Point(167, 305);
            this.txtAaddress.Name = "txtAaddress";
            this.txtAaddress.Size = new System.Drawing.Size(309, 28);
            this.txtAaddress.TabIndex = 36;
            // 
            // lblAgentAddress
            // 
            this.lblAgentAddress.AutoSize = true;
            this.lblAgentAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentAddress.Location = new System.Drawing.Point(12, 308);
            this.lblAgentAddress.Name = "lblAgentAddress";
            this.lblAgentAddress.Size = new System.Drawing.Size(80, 24);
            this.lblAgentAddress.TabIndex = 35;
            this.lblAgentAddress.Text = "Address";
            // 
            // txtCreditBalance
            // 
            this.txtCreditBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditBalance.Location = new System.Drawing.Point(166, 432);
            this.txtCreditBalance.Name = "txtCreditBalance";
            this.txtCreditBalance.Size = new System.Drawing.Size(309, 28);
            this.txtCreditBalance.TabIndex = 38;
            this.txtCreditBalance.TextChanged += new System.EventHandler(this.txtCreditBalance_TextChanged);
            this.txtCreditBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreditBalance_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "Credit Balance";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Agents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1353, 775);
            this.Controls.Add(this.txtCreditBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAaddress);
            this.Controls.Add(this.lblAgentAddress);
            this.Controls.Add(this.txtAId);
            this.Controls.Add(this.lblAgentId);
            this.Controls.Add(this.lblHeader2);
            this.Controls.Add(this.lblHeader1);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvAgents);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.lblAgentNo);
            this.Controls.Add(this.txtCreditL);
            this.Controls.Add(this.lblCreditL);
            this.Controls.Add(this.txtAname);
            this.Controls.Add(this.lblAgentName);
            this.Name = "Agents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agents";
            this.Load += new System.EventHandler(this.Agents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvAgents;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label lblAgentNo;
        private System.Windows.Forms.TextBox txtCreditL;
        private System.Windows.Forms.Label lblCreditL;
        private System.Windows.Forms.TextBox txtAname;
        private System.Windows.Forms.Label lblAgentName;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label lblHeader1;
        private System.Windows.Forms.Label lblHeader2;
        private System.Windows.Forms.TextBox txtAId;
        private System.Windows.Forms.Label lblAgentId;
        private System.Windows.Forms.TextBox txtAaddress;
        private System.Windows.Forms.Label lblAgentAddress;
        private System.Windows.Forms.TextBox txtCreditBalance;
        private System.Windows.Forms.Label label1;
    }
}