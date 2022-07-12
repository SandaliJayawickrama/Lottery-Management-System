
namespace JProject.UI
{
    partial class Return_Purchase
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
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplier1 = new System.Windows.Forms.Label();
            this.txtSup = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtEdBcode = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtStBcode = new System.Windows.Forms.TextBox();
            this.txtDrno = new System.Windows.Forms.TextBox();
            this.lblEdBcode = new System.Windows.Forms.Label();
            this.lblStBcode = new System.Windows.Forms.Label();
            this.lblDrawNo = new System.Windows.Forms.Label();
            this.lblDrawDate = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblTname = new System.Windows.Forms.Label();
            this.txtLineTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTickName = new System.Windows.Forms.TextBox();
            this.txtDrDate = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvReturn = new System.Windows.Forms.DataGridView();
            this.lblHeader2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTotalQty = new System.Windows.Forms.TextBox();
            this.txtGndTotal = new System.Windows.Forms.TextBox();
            this.lblHeader3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTotalQty = new System.Windows.Forms.Label();
            this.lblGndTotal = new System.Windows.Forms.Label();
            this.lblAgent = new System.Windows.Forms.Label();
            this.txtAgent = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader1
            // 
            this.lblHeader1.AutoSize = true;
            this.lblHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader1.ForeColor = System.Drawing.Color.Teal;
            this.lblHeader1.Location = new System.Drawing.Point(617, 9);
            this.lblHeader1.Name = "lblHeader1";
            this.lblHeader1.Size = new System.Drawing.Size(257, 32);
            this.lblHeader1.TabIndex = 32;
            this.lblHeader1.Text = "Purchases Return";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Items.AddRange(new object[] {
            "NLB",
            "DLB "});
            this.cmbSupplier.Location = new System.Drawing.Point(131, 78);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(128, 28);
            this.cmbSupplier.TabIndex = 42;
            this.cmbSupplier.SelectedIndexChanged += new System.EventHandler(this.cmbSupplier_SelectedIndexChanged);
            // 
            // lblSupplier1
            // 
            this.lblSupplier1.AutoSize = true;
            this.lblSupplier1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier1.Location = new System.Drawing.Point(34, 78);
            this.lblSupplier1.Name = "lblSupplier1";
            this.lblSupplier1.Size = new System.Drawing.Size(78, 20);
            this.lblSupplier1.TabIndex = 41;
            this.lblSupplier1.Text = "Supplier";
            // 
            // txtSup
            // 
            this.txtSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSup.Location = new System.Drawing.Point(245, 67);
            this.txtSup.Name = "txtSup";
            this.txtSup.Size = new System.Drawing.Size(73, 24);
            this.txtSup.TabIndex = 73;
            this.txtSup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSup_KeyPress);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(850, 33);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(71, 20);
            this.lblQty.TabIndex = 72;
            this.lblQty.Text = "Quantity";
            // 
            // txtEdBcode
            // 
            this.txtEdBcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdBcode.Location = new System.Drawing.Point(991, 67);
            this.txtEdBcode.Name = "txtEdBcode";
            this.txtEdBcode.Size = new System.Drawing.Size(218, 24);
            this.txtEdBcode.TabIndex = 71;
            this.txtEdBcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdBcode_KeyPress);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(854, 67);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(116, 24);
            this.txtQty.TabIndex = 70;
            this.txtQty.Text = "0";
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // txtStBcode
            // 
            this.txtStBcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStBcode.Location = new System.Drawing.Point(611, 67);
            this.txtStBcode.Name = "txtStBcode";
            this.txtStBcode.Size = new System.Drawing.Size(221, 24);
            this.txtStBcode.TabIndex = 69;
            this.txtStBcode.Text = "0";
            this.txtStBcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStBcode_KeyPress);
            // 
            // txtDrno
            // 
            this.txtDrno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrno.Location = new System.Drawing.Point(335, 67);
            this.txtDrno.Name = "txtDrno";
            this.txtDrno.Size = new System.Drawing.Size(109, 24);
            this.txtDrno.TabIndex = 68;
            this.txtDrno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDrno_KeyPress);
            // 
            // lblEdBcode
            // 
            this.lblEdBcode.AutoSize = true;
            this.lblEdBcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdBcode.Location = new System.Drawing.Point(987, 33);
            this.lblEdBcode.Name = "lblEdBcode";
            this.lblEdBcode.Size = new System.Drawing.Size(128, 20);
            this.lblEdBcode.TabIndex = 67;
            this.lblEdBcode.Text = "Ending Barcode";
            // 
            // lblStBcode
            // 
            this.lblStBcode.AutoSize = true;
            this.lblStBcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStBcode.Location = new System.Drawing.Point(607, 33);
            this.lblStBcode.Name = "lblStBcode";
            this.lblStBcode.Size = new System.Drawing.Size(130, 20);
            this.lblStBcode.TabIndex = 64;
            this.lblStBcode.Text = "Staring Barcode";
            // 
            // lblDrawNo
            // 
            this.lblDrawNo.AutoSize = true;
            this.lblDrawNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawNo.Location = new System.Drawing.Point(331, 33);
            this.lblDrawNo.Name = "lblDrawNo";
            this.lblDrawNo.Size = new System.Drawing.Size(75, 20);
            this.lblDrawNo.TabIndex = 62;
            this.lblDrawNo.Text = "Draw No";
            // 
            // lblDrawDate
            // 
            this.lblDrawDate.AutoSize = true;
            this.lblDrawDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawDate.Location = new System.Drawing.Point(464, 33);
            this.lblDrawDate.Name = "lblDrawDate";
            this.lblDrawDate.Size = new System.Drawing.Size(90, 20);
            this.lblDrawDate.TabIndex = 61;
            this.lblDrawDate.Text = "Draw Date";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(241, 33);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(70, 20);
            this.lblSupplier.TabIndex = 59;
            this.lblSupplier.Text = "Supplier";
            // 
            // lblTname
            // 
            this.lblTname.AutoSize = true;
            this.lblTname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTname.Location = new System.Drawing.Point(7, 33);
            this.lblTname.Name = "lblTname";
            this.lblTname.Size = new System.Drawing.Size(100, 20);
            this.lblTname.TabIndex = 58;
            this.lblTname.Text = "Ticket name";
            // 
            // txtLineTotal
            // 
            this.txtLineTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLineTotal.Location = new System.Drawing.Point(1229, 67);
            this.txtLineTotal.Name = "txtLineTotal";
            this.txtLineTotal.Size = new System.Drawing.Size(214, 24);
            this.txtLineTotal.TabIndex = 74;
            this.txtLineTotal.Text = "0";
            this.txtLineTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLineTotal_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1225, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 75;
            this.label1.Text = "Line Total";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTickName);
            this.panel1.Controls.Add(this.txtDrDate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblTname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblSupplier);
            this.panel1.Controls.Add(this.txtLineTotal);
            this.panel1.Controls.Add(this.lblDrawDate);
            this.panel1.Controls.Add(this.txtSup);
            this.panel1.Controls.Add(this.lblDrawNo);
            this.panel1.Controls.Add(this.lblQty);
            this.panel1.Controls.Add(this.lblStBcode);
            this.panel1.Controls.Add(this.txtEdBcode);
            this.panel1.Controls.Add(this.txtQty);
            this.panel1.Controls.Add(this.lblEdBcode);
            this.panel1.Controls.Add(this.txtDrno);
            this.panel1.Controls.Add(this.txtStBcode);
            this.panel1.Location = new System.Drawing.Point(12, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1463, 156);
            this.panel1.TabIndex = 76;
            // 
            // txtTickName
            // 
            this.txtTickName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTickName.Location = new System.Drawing.Point(11, 67);
            this.txtTickName.Name = "txtTickName";
            this.txtTickName.Size = new System.Drawing.Size(218, 24);
            this.txtTickName.TabIndex = 79;
            this.txtTickName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTickName_KeyPress);
            // 
            // txtDrDate
            // 
            this.txtDrDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrDate.Location = new System.Drawing.Point(468, 67);
            this.txtDrDate.Name = "txtDrDate";
            this.txtDrDate.Size = new System.Drawing.Size(126, 24);
            this.txtDrDate.TabIndex = 78;
            this.txtDrDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDrDate_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1284, 107);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 35);
            this.btnAdd.TabIndex = 77;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvReturn);
            this.panel3.Controls.Add(this.lblHeader2);
            this.panel3.Location = new System.Drawing.Point(688, 426);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(787, 412);
            this.panel3.TabIndex = 77;
            // 
            // dgvReturn
            // 
            this.dgvReturn.AllowUserToAddRows = false;
            this.dgvReturn.AllowUserToDeleteRows = false;
            this.dgvReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturn.Location = new System.Drawing.Point(16, 45);
            this.dgvReturn.Name = "dgvReturn";
            this.dgvReturn.ReadOnly = true;
            this.dgvReturn.RowHeadersWidth = 51;
            this.dgvReturn.RowTemplate.Height = 24;
            this.dgvReturn.Size = new System.Drawing.Size(751, 356);
            this.dgvReturn.TabIndex = 40;
            // 
            // lblHeader2
            // 
            this.lblHeader2.AutoSize = true;
            this.lblHeader2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader2.Location = new System.Drawing.Point(12, 9);
            this.lblHeader2.Name = "lblHeader2";
            this.lblHeader2.Size = new System.Drawing.Size(212, 24);
            this.lblHeader2.TabIndex = 39;
            this.lblHeader2.Text = "Added Return Tickets";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dgvStock);
            this.panel2.Location = new System.Drawing.Point(12, 426);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 412);
            this.panel2.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "Remaining Tickets on Today";
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(16, 47);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersWidth = 51;
            this.dgvStock.RowTemplate.Height = 24;
            this.dgvStock.Size = new System.Drawing.Size(607, 356);
            this.dgvStock.TabIndex = 40;
            this.dgvStock.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStock_RowHeaderMouseDoubleClick);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.txtTotalQty);
            this.panel4.Controls.Add(this.txtGndTotal);
            this.panel4.Controls.Add(this.lblHeader3);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.lblTotalQty);
            this.panel4.Controls.Add(this.lblGndTotal);
            this.panel4.Location = new System.Drawing.Point(12, 299);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1463, 112);
            this.panel4.TabIndex = 79;
            // 
            // txtTotalQty
            // 
            this.txtTotalQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalQty.Location = new System.Drawing.Point(518, 47);
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.Size = new System.Drawing.Size(139, 27);
            this.txtTotalQty.TabIndex = 59;
            this.txtTotalQty.Text = "0";
            this.txtTotalQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalQty_KeyPress);
            // 
            // txtGndTotal
            // 
            this.txtGndTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGndTotal.Location = new System.Drawing.Point(876, 46);
            this.txtGndTotal.Name = "txtGndTotal";
            this.txtGndTotal.Size = new System.Drawing.Size(346, 27);
            this.txtGndTotal.TabIndex = 55;
            this.txtGndTotal.Text = "0";
            this.txtGndTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGndTotal_KeyPress);
            // 
            // lblHeader3
            // 
            this.lblHeader3.AutoSize = true;
            this.lblHeader3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader3.Location = new System.Drawing.Point(5, 10);
            this.lblHeader3.Name = "lblHeader3";
            this.lblHeader3.Size = new System.Drawing.Size(181, 24);
            this.lblHeader3.TabIndex = 40;
            this.lblHeader3.Text = "Calculation Details";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1269, 35);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 51);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "Save Returns";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.AutoSize = true;
            this.lblTotalQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQty.Location = new System.Drawing.Point(356, 49);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(127, 20);
            this.lblTotalQty.TabIndex = 55;
            this.lblTotalQty.Text = "Total Quantity";
            // 
            // lblGndTotal
            // 
            this.lblGndTotal.AutoSize = true;
            this.lblGndTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGndTotal.Location = new System.Drawing.Point(714, 47);
            this.lblGndTotal.Name = "lblGndTotal";
            this.lblGndTotal.Size = new System.Drawing.Size(134, 24);
            this.lblGndTotal.TabIndex = 56;
            this.lblGndTotal.Text = "Total Amount";
            // 
            // lblAgent
            // 
            this.lblAgent.AutoSize = true;
            this.lblAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgent.Location = new System.Drawing.Point(1198, 81);
            this.lblAgent.Name = "lblAgent";
            this.lblAgent.Size = new System.Drawing.Size(57, 20);
            this.lblAgent.TabIndex = 80;
            this.lblAgent.Text = "Agent";
            // 
            // txtAgent
            // 
            this.txtAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgent.Location = new System.Drawing.Point(1283, 78);
            this.txtAgent.Name = "txtAgent";
            this.txtAgent.Size = new System.Drawing.Size(137, 27);
            this.txtAgent.TabIndex = 80;
            this.txtAgent.Text = "J G Wasantha";
            this.txtAgent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgent_KeyPress);
            // 
            // Return_Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1482, 850);
            this.Controls.Add(this.txtAgent);
            this.Controls.Add(this.lblAgent);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.lblSupplier1);
            this.Controls.Add(this.lblHeader1);
            this.Name = "Return_Purchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return_Purchase";
            this.Load += new System.EventHandler(this.Return_Purchase_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader1;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label lblSupplier1;
        private System.Windows.Forms.TextBox txtSup;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtEdBcode;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtStBcode;
        private System.Windows.Forms.TextBox txtDrno;
        private System.Windows.Forms.Label lblEdBcode;
        private System.Windows.Forms.Label lblStBcode;
        private System.Windows.Forms.Label lblDrawNo;
        private System.Windows.Forms.Label lblDrawDate;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblTname;
        private System.Windows.Forms.TextBox txtLineTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvReturn;
        private System.Windows.Forms.Label lblHeader2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTotalQty;
        private System.Windows.Forms.TextBox txtGndTotal;
        private System.Windows.Forms.Label lblHeader3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTotalQty;
        private System.Windows.Forms.Label lblGndTotal;
        private System.Windows.Forms.TextBox txtDrDate;
        private System.Windows.Forms.TextBox txtTickName;
        private System.Windows.Forms.Label lblAgent;
        private System.Windows.Forms.TextBox txtAgent;
    }
}