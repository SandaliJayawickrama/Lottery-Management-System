
namespace JProject.UI
{
    partial class Instant_purchases
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
            this.txtCat = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplier1 = new System.Windows.Forms.Label();
            this.dtpInvDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.txtInvNo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSup = new System.Windows.Forms.TextBox();
            this.txtLineTotal = new System.Windows.Forms.TextBox();
            this.lblLineTotal = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtUprice = new System.Windows.Forms.TextBox();
            this.txtTickName = new System.Windows.Forms.TextBox();
            this.lblUprice = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTname = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvInsPurchases = new System.Windows.Forms.DataGridView();
            this.lblHeader2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTotalQty = new System.Windows.Forms.TextBox();
            this.txtGndTotal = new System.Windows.Forms.TextBox();
            this.lblGndTotal = new System.Windows.Forms.Label();
            this.lblTotalQty = new System.Windows.Forms.Label();
            this.lblHeader3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsPurchases)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader1
            // 
            this.lblHeader1.AutoSize = true;
            this.lblHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader1.ForeColor = System.Drawing.Color.Teal;
            this.lblHeader1.Location = new System.Drawing.Point(577, 9);
            this.lblHeader1.Name = "lblHeader1";
            this.lblHeader1.Size = new System.Drawing.Size(258, 32);
            this.lblHeader1.TabIndex = 32;
            this.lblHeader1.Text = "Instant Purchases";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCat);
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.cmbSupplier);
            this.panel1.Controls.Add(this.lblSupplier1);
            this.panel1.Controls.Add(this.dtpInvDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblInvoiceNo);
            this.panel1.Controls.Add(this.txtInvNo);
            this.panel1.Location = new System.Drawing.Point(12, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1458, 66);
            this.panel1.TabIndex = 41;
            // 
            // txtCat
            // 
            this.txtCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCat.Location = new System.Drawing.Point(1297, 21);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(79, 27);
            this.txtCat.TabIndex = 60;
            this.txtCat.Text = "Instant";
            this.txtCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCat_KeyPress);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(1189, 21);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(85, 24);
            this.lblCategory.TabIndex = 41;
            this.lblCategory.Text = "Category";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Items.AddRange(new object[] {
            "NLB",
            "DLB "});
            this.cmbSupplier.Location = new System.Drawing.Point(901, 21);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(115, 28);
            this.cmbSupplier.TabIndex = 40;
            // 
            // lblSupplier1
            // 
            this.lblSupplier1.AutoSize = true;
            this.lblSupplier1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier1.Location = new System.Drawing.Point(804, 21);
            this.lblSupplier1.Name = "lblSupplier1";
            this.lblSupplier1.Size = new System.Drawing.Size(80, 24);
            this.lblSupplier1.TabIndex = 39;
            this.lblSupplier1.Text = "Supplier";
            // 
            // dtpInvDate
            // 
            this.dtpInvDate.CustomFormat = "yyyy-MM-dd";
            this.dtpInvDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInvDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvDate.Location = new System.Drawing.Point(566, 22);
            this.dtpInvDate.Name = "dtpInvDate";
            this.dtpInvDate.Size = new System.Drawing.Size(154, 27);
            this.dtpInvDate.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "Invoice Date";
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNo.Location = new System.Drawing.Point(13, 21);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(100, 24);
            this.lblInvoiceNo.TabIndex = 35;
            this.lblInvoiceNo.Text = "Invoice No";
            // 
            // txtInvNo
            // 
            this.txtInvNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvNo.Location = new System.Drawing.Point(118, 18);
            this.txtInvNo.Name = "txtInvNo";
            this.txtInvNo.Size = new System.Drawing.Size(309, 27);
            this.txtInvNo.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtSup);
            this.panel2.Controls.Add(this.txtLineTotal);
            this.panel2.Controls.Add(this.lblLineTotal);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.lblQty);
            this.panel2.Controls.Add(this.txtQty);
            this.panel2.Controls.Add(this.txtUprice);
            this.panel2.Controls.Add(this.txtTickName);
            this.panel2.Controls.Add(this.lblUprice);
            this.panel2.Controls.Add(this.lblSupplier);
            this.panel2.Controls.Add(this.lblSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.lblTname);
            this.panel2.Location = new System.Drawing.Point(12, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1458, 175);
            this.panel2.TabIndex = 42;
            // 
            // txtSup
            // 
            this.txtSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSup.Location = new System.Drawing.Point(277, 122);
            this.txtSup.Name = "txtSup";
            this.txtSup.Size = new System.Drawing.Size(117, 24);
            this.txtSup.TabIndex = 59;
            // 
            // txtLineTotal
            // 
            this.txtLineTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLineTotal.Location = new System.Drawing.Point(935, 120);
            this.txtLineTotal.Name = "txtLineTotal";
            this.txtLineTotal.Size = new System.Drawing.Size(234, 24);
            this.txtLineTotal.TabIndex = 56;
            this.txtLineTotal.Text = "0";
            this.txtLineTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLineTotal_KeyPress);
            // 
            // lblLineTotal
            // 
            this.lblLineTotal.AutoSize = true;
            this.lblLineTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLineTotal.Location = new System.Drawing.Point(941, 86);
            this.lblLineTotal.Name = "lblLineTotal";
            this.lblLineTotal.Size = new System.Drawing.Size(93, 20);
            this.lblLineTotal.TabIndex = 55;
            this.lblLineTotal.Text = "Line Total";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1248, 111);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 35);
            this.btnAdd.TabIndex = 54;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(618, 86);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(71, 20);
            this.lblQty.TabIndex = 53;
            this.lblQty.Text = "Quantity";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(622, 120);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(159, 24);
            this.txtQty.TabIndex = 51;
            this.txtQty.Text = "0";
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // txtUprice
            // 
            this.txtUprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUprice.Location = new System.Drawing.Point(459, 122);
            this.txtUprice.Name = "txtUprice";
            this.txtUprice.Size = new System.Drawing.Size(106, 24);
            this.txtUprice.TabIndex = 47;
            this.txtUprice.Text = "0";
            this.txtUprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUprice_KeyPress);
            // 
            // txtTickName
            // 
            this.txtTickName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTickName.Location = new System.Drawing.Point(32, 120);
            this.txtTickName.Name = "txtTickName";
            this.txtTickName.Size = new System.Drawing.Size(186, 24);
            this.txtTickName.TabIndex = 46;
            this.txtTickName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTickName_KeyPress);
            // 
            // lblUprice
            // 
            this.lblUprice.AutoSize = true;
            this.lblUprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUprice.Location = new System.Drawing.Point(455, 86);
            this.lblUprice.Name = "lblUprice";
            this.lblUprice.Size = new System.Drawing.Size(83, 20);
            this.lblUprice.TabIndex = 42;
            this.lblUprice.Text = "Unit Price";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(288, 86);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(70, 20);
            this.lblSupplier.TabIndex = 38;
            this.lblSupplier.Text = "Supplier";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(12, 17);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(179, 20);
            this.lblSearch.TabIndex = 32;
            this.lblSearch.Text = "Search Ticket Name";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(227, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(362, 27);
            this.txtSearch.TabIndex = 33;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblTname
            // 
            this.lblTname.AutoSize = true;
            this.lblTname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTname.Location = new System.Drawing.Point(28, 86);
            this.lblTname.Name = "lblTname";
            this.lblTname.Size = new System.Drawing.Size(100, 20);
            this.lblTname.TabIndex = 37;
            this.lblTname.Text = "Ticket name";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvInsPurchases);
            this.panel3.Controls.Add(this.lblHeader2);
            this.panel3.Location = new System.Drawing.Point(12, 358);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(813, 480);
            this.panel3.TabIndex = 43;
            // 
            // dgvInsPurchases
            // 
            this.dgvInsPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsPurchases.Location = new System.Drawing.Point(16, 52);
            this.dgvInsPurchases.Name = "dgvInsPurchases";
            this.dgvInsPurchases.RowHeadersWidth = 51;
            this.dgvInsPurchases.RowTemplate.Height = 24;
            this.dgvInsPurchases.Size = new System.Drawing.Size(778, 409);
            this.dgvInsPurchases.TabIndex = 40;
            // 
            // lblHeader2
            // 
            this.lblHeader2.AutoSize = true;
            this.lblHeader2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader2.Location = new System.Drawing.Point(13, 18);
            this.lblHeader2.Name = "lblHeader2";
            this.lblHeader2.Size = new System.Drawing.Size(144, 24);
            this.lblHeader2.TabIndex = 39;
            this.lblHeader2.Text = "Added Tickets";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.txtTotalQty);
            this.panel4.Controls.Add(this.txtGndTotal);
            this.panel4.Controls.Add(this.lblGndTotal);
            this.panel4.Controls.Add(this.lblTotalQty);
            this.panel4.Controls.Add(this.lblHeader3);
            this.panel4.Location = new System.Drawing.Point(841, 376);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(619, 421);
            this.panel4.TabIndex = 44;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(233, 310);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(174, 63);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTotalQty
            // 
            this.txtTotalQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalQty.Location = new System.Drawing.Point(176, 150);
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.Size = new System.Drawing.Size(346, 27);
            this.txtTotalQty.TabIndex = 59;
            this.txtTotalQty.Text = "0";
            this.txtTotalQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalQty_KeyPress);
            // 
            // txtGndTotal
            // 
            this.txtGndTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGndTotal.Location = new System.Drawing.Point(176, 214);
            this.txtGndTotal.Name = "txtGndTotal";
            this.txtGndTotal.Size = new System.Drawing.Size(346, 27);
            this.txtGndTotal.TabIndex = 55;
            this.txtGndTotal.Text = "0";
            this.txtGndTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGndTotal_KeyPress);
            // 
            // lblGndTotal
            // 
            this.lblGndTotal.AutoSize = true;
            this.lblGndTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGndTotal.Location = new System.Drawing.Point(14, 215);
            this.lblGndTotal.Name = "lblGndTotal";
            this.lblGndTotal.Size = new System.Drawing.Size(119, 24);
            this.lblGndTotal.TabIndex = 56;
            this.lblGndTotal.Text = "Grand Total";
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.AutoSize = true;
            this.lblTotalQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQty.Location = new System.Drawing.Point(14, 150);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(127, 20);
            this.lblTotalQty.TabIndex = 55;
            this.lblTotalQty.Text = "Total Quantity";
            // 
            // lblHeader3
            // 
            this.lblHeader3.AutoSize = true;
            this.lblHeader3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader3.Location = new System.Drawing.Point(13, 61);
            this.lblHeader3.Name = "lblHeader3";
            this.lblHeader3.Size = new System.Drawing.Size(181, 24);
            this.lblHeader3.TabIndex = 40;
            this.lblHeader3.Text = "Calculation Details";
            // 
            // Instant_purchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1482, 850);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHeader1);
            this.Name = "Instant_purchases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instant_purchases";
            this.Load += new System.EventHandler(this.Instant_purchases_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsPurchases)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label lblSupplier1;
        private System.Windows.Forms.DateTimePicker dtpInvDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.TextBox txtInvNo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSup;
        private System.Windows.Forms.TextBox txtLineTotal;
        private System.Windows.Forms.Label lblLineTotal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtUprice;
        private System.Windows.Forms.TextBox txtTickName;
        private System.Windows.Forms.Label lblUprice;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblTname;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvInsPurchases;
        private System.Windows.Forms.Label lblHeader2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTotalQty;
        private System.Windows.Forms.TextBox txtGndTotal;
        private System.Windows.Forms.Label lblGndTotal;
        private System.Windows.Forms.Label lblTotalQty;
        private System.Windows.Forms.Label lblHeader3;
    }
}