
namespace JProject.UI
{
    partial class Purchases
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtInvNo = new System.Windows.Forms.TextBox();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.lblTname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplier1 = new System.Windows.Forms.Label();
            this.dtpInvDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSup = new System.Windows.Forms.TextBox();
            this.txtStBcode = new System.Windows.Forms.TextBox();
            this.txtLineTotal = new System.Windows.Forms.TextBox();
            this.lblLineTotal = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtEdBcode = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.dtpDrdate = new System.Windows.Forms.DateTimePicker();
            this.txtDrno = new System.Windows.Forms.TextBox();
            this.lblEdBcode = new System.Windows.Forms.Label();
            this.txtUprice = new System.Windows.Forms.TextBox();
            this.txtTickName = new System.Windows.Forms.TextBox();
            this.lblStBcode = new System.Windows.Forms.Label();
            this.lblUprice = new System.Windows.Forms.Label();
            this.lblDrawNo = new System.Windows.Forms.Label();
            this.lblDrawDate = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvPurchases = new System.Windows.Forms.DataGridView();
            this.lblHeader2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRetNlb = new System.Windows.Forms.TextBox();
            this.txtRetDlb = new System.Windows.Forms.TextBox();
            this.txtScanNlb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtScanDlb = new System.Windows.Forms.TextBox();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTotalQty = new System.Windows.Forms.TextBox();
            this.txtGndTotal = new System.Windows.Forms.TextBox();
            this.lblGndTotal = new System.Windows.Forms.Label();
            this.lblTotalQty = new System.Windows.Forms.Label();
            this.lblHeader3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchases)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader1
            // 
            this.lblHeader1.AutoSize = true;
            this.lblHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader1.ForeColor = System.Drawing.Color.Teal;
            this.lblHeader1.Location = new System.Drawing.Point(643, 9);
            this.lblHeader1.Name = "lblHeader1";
            this.lblHeader1.Size = new System.Drawing.Size(253, 32);
            this.lblHeader1.TabIndex = 31;
            this.lblHeader1.Text = "Purchases - Draw";
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
            // txtInvNo
            // 
            this.txtInvNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvNo.Location = new System.Drawing.Point(118, 18);
            this.txtInvNo.Name = "txtInvNo";
            this.txtInvNo.Size = new System.Drawing.Size(309, 27);
            this.txtInvNo.TabIndex = 36;
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNo.Location = new System.Drawing.Point(12, 15);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(100, 24);
            this.lblInvoiceNo.TabIndex = 35;
            this.lblInvoiceNo.Text = "Invoice No";
            // 
            // lblTname
            // 
            this.lblTname.AutoSize = true;
            this.lblTname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTname.Location = new System.Drawing.Point(3, 86);
            this.lblTname.Name = "lblTname";
            this.lblTname.Size = new System.Drawing.Size(100, 20);
            this.lblTname.TabIndex = 37;
            this.lblTname.Text = "Ticket name";
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
            this.panel1.Location = new System.Drawing.Point(12, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1458, 66);
            this.panel1.TabIndex = 40;
            // 
            // txtCat
            // 
            this.txtCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCat.Location = new System.Drawing.Point(1295, 25);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(79, 27);
            this.txtCat.TabIndex = 60;
            this.txtCat.Text = "Draw";
            this.txtCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCat_KeyPress);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(1187, 25);
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
            this.lblSupplier1.Click += new System.EventHandler(this.lblSupplier1_Click);
            // 
            // dtpInvDate
            // 
            this.dtpInvDate.CustomFormat = "yyyy-MM-dd";
            this.dtpInvDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInvDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvDate.Location = new System.Drawing.Point(569, 16);
            this.dtpInvDate.Name = "dtpInvDate";
            this.dtpInvDate.Size = new System.Drawing.Size(154, 27);
            this.dtpInvDate.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(450, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "Invoice Date";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtSup);
            this.panel2.Controls.Add(this.txtStBcode);
            this.panel2.Controls.Add(this.txtLineTotal);
            this.panel2.Controls.Add(this.lblLineTotal);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.lblQty);
            this.panel2.Controls.Add(this.txtEdBcode);
            this.panel2.Controls.Add(this.txtQty);
            this.panel2.Controls.Add(this.dtpDrdate);
            this.panel2.Controls.Add(this.txtDrno);
            this.panel2.Controls.Add(this.lblEdBcode);
            this.panel2.Controls.Add(this.txtUprice);
            this.panel2.Controls.Add(this.txtTickName);
            this.panel2.Controls.Add(this.lblStBcode);
            this.panel2.Controls.Add(this.lblUprice);
            this.panel2.Controls.Add(this.lblDrawNo);
            this.panel2.Controls.Add(this.lblDrawDate);
            this.panel2.Controls.Add(this.lblSupplier);
            this.panel2.Controls.Add(this.lblSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.lblTname);
            this.panel2.Location = new System.Drawing.Point(12, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1458, 237);
            this.panel2.TabIndex = 41;
            // 
            // txtSup
            // 
            this.txtSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSup.Location = new System.Drawing.Point(212, 122);
            this.txtSup.Name = "txtSup";
            this.txtSup.Size = new System.Drawing.Size(117, 24);
            this.txtSup.TabIndex = 59;
            // 
            // txtStBcode
            // 
            this.txtStBcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStBcode.Location = new System.Drawing.Point(773, 122);
            this.txtStBcode.Name = "txtStBcode";
            this.txtStBcode.Size = new System.Drawing.Size(234, 24);
            this.txtStBcode.TabIndex = 58;
            this.txtStBcode.Text = "0";
            // 
            // txtLineTotal
            // 
            this.txtLineTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLineTotal.Location = new System.Drawing.Point(668, 186);
            this.txtLineTotal.Name = "txtLineTotal";
            this.txtLineTotal.Size = new System.Drawing.Size(234, 24);
            this.txtLineTotal.TabIndex = 56;
            this.txtLineTotal.Text = "0";
            this.txtLineTotal.TextChanged += new System.EventHandler(this.txtLineTotal_TextChanged);
            this.txtLineTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLineTotal_KeyPress);
            // 
            // lblLineTotal
            // 
            this.lblLineTotal.AutoSize = true;
            this.lblLineTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLineTotal.Location = new System.Drawing.Point(552, 190);
            this.lblLineTotal.Name = "lblLineTotal";
            this.lblLineTotal.Size = new System.Drawing.Size(93, 20);
            this.lblLineTotal.TabIndex = 55;
            this.lblLineTotal.Text = "Line Total";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1265, 173);
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
            this.lblQty.Location = new System.Drawing.Point(1023, 86);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(71, 20);
            this.lblQty.TabIndex = 53;
            this.lblQty.Text = "Quantity";
            // 
            // txtEdBcode
            // 
            this.txtEdBcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdBcode.Location = new System.Drawing.Point(1208, 122);
            this.txtEdBcode.Name = "txtEdBcode";
            this.txtEdBcode.Size = new System.Drawing.Size(234, 24);
            this.txtEdBcode.TabIndex = 52;
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(1027, 122);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(159, 24);
            this.txtQty.TabIndex = 51;
            this.txtQty.Text = "0";
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // dtpDrdate
            // 
            this.dtpDrdate.CustomFormat = "yyyy-MM-dd";
            this.dtpDrdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDrdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDrdate.Location = new System.Drawing.Point(622, 120);
            this.dtpDrdate.Name = "dtpDrdate";
            this.dtpDrdate.Size = new System.Drawing.Size(126, 24);
            this.dtpDrdate.TabIndex = 39;
            // 
            // txtDrno
            // 
            this.txtDrno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrno.Location = new System.Drawing.Point(482, 120);
            this.txtDrno.Name = "txtDrno";
            this.txtDrno.Size = new System.Drawing.Size(117, 24);
            this.txtDrno.TabIndex = 49;
            // 
            // lblEdBcode
            // 
            this.lblEdBcode.AutoSize = true;
            this.lblEdBcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdBcode.Location = new System.Drawing.Point(1204, 86);
            this.lblEdBcode.Name = "lblEdBcode";
            this.lblEdBcode.Size = new System.Drawing.Size(128, 20);
            this.lblEdBcode.TabIndex = 48;
            this.lblEdBcode.Text = "Ending Barcode";
            // 
            // txtUprice
            // 
            this.txtUprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUprice.Location = new System.Drawing.Point(347, 120);
            this.txtUprice.Name = "txtUprice";
            this.txtUprice.Size = new System.Drawing.Size(106, 24);
            this.txtUprice.TabIndex = 47;
            this.txtUprice.Text = "0";
            this.txtUprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUprice_KeyPress);
            // 
            // txtTickName
            // 
            this.txtTickName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTickName.Location = new System.Drawing.Point(7, 120);
            this.txtTickName.Name = "txtTickName";
            this.txtTickName.Size = new System.Drawing.Size(186, 24);
            this.txtTickName.TabIndex = 46;
            this.txtTickName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTname_KeyPress);
            // 
            // lblStBcode
            // 
            this.lblStBcode.AutoSize = true;
            this.lblStBcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStBcode.Location = new System.Drawing.Point(769, 86);
            this.lblStBcode.Name = "lblStBcode";
            this.lblStBcode.Size = new System.Drawing.Size(130, 20);
            this.lblStBcode.TabIndex = 44;
            this.lblStBcode.Text = "Staring Barcode";
            // 
            // lblUprice
            // 
            this.lblUprice.AutoSize = true;
            this.lblUprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUprice.Location = new System.Drawing.Point(343, 86);
            this.lblUprice.Name = "lblUprice";
            this.lblUprice.Size = new System.Drawing.Size(83, 20);
            this.lblUprice.TabIndex = 42;
            this.lblUprice.Text = "Unit Price";
            // 
            // lblDrawNo
            // 
            this.lblDrawNo.AutoSize = true;
            this.lblDrawNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawNo.Location = new System.Drawing.Point(484, 86);
            this.lblDrawNo.Name = "lblDrawNo";
            this.lblDrawNo.Size = new System.Drawing.Size(75, 20);
            this.lblDrawNo.TabIndex = 41;
            this.lblDrawNo.Text = "Draw No";
            // 
            // lblDrawDate
            // 
            this.lblDrawDate.AutoSize = true;
            this.lblDrawDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawDate.Location = new System.Drawing.Point(632, 86);
            this.lblDrawDate.Name = "lblDrawDate";
            this.lblDrawDate.Size = new System.Drawing.Size(90, 20);
            this.lblDrawDate.TabIndex = 40;
            this.lblDrawDate.Text = "Draw Date";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(223, 86);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(70, 20);
            this.lblSupplier.TabIndex = 38;
            this.lblSupplier.Text = "Supplier";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvPurchases);
            this.panel3.Controls.Add(this.lblHeader2);
            this.panel3.Location = new System.Drawing.Point(12, 396);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(813, 442);
            this.panel3.TabIndex = 42;
            // 
            // dgvPurchases
            // 
            this.dgvPurchases.AllowUserToAddRows = false;
            this.dgvPurchases.AllowUserToDeleteRows = false;
            this.dgvPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchases.Location = new System.Drawing.Point(16, 47);
            this.dgvPurchases.Name = "dgvPurchases";
            this.dgvPurchases.ReadOnly = true;
            this.dgvPurchases.RowHeadersWidth = 51;
            this.dgvPurchases.RowTemplate.Height = 24;
            this.dgvPurchases.Size = new System.Drawing.Size(778, 377);
            this.dgvPurchases.TabIndex = 40;
            this.dgvPurchases.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchases_CellContentClick);
            // 
            // lblHeader2
            // 
            this.lblHeader2.AutoSize = true;
            this.lblHeader2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader2.Location = new System.Drawing.Point(12, 9);
            this.lblHeader2.Name = "lblHeader2";
            this.lblHeader2.Size = new System.Drawing.Size(144, 24);
            this.lblHeader2.TabIndex = 39;
            this.lblHeader2.Text = "Added Tickets";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnCalc);
            this.panel4.Controls.Add(this.txtCredit);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtBalance);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtRetNlb);
            this.panel4.Controls.Add(this.txtRetDlb);
            this.panel4.Controls.Add(this.txtScanNlb);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtScanDlb);
            this.panel4.Controls.Add(this.txtBank);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtCash);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.txtTotalQty);
            this.panel4.Controls.Add(this.txtGndTotal);
            this.panel4.Controls.Add(this.lblGndTotal);
            this.panel4.Controls.Add(this.lblTotalQty);
            this.panel4.Controls.Add(this.lblHeader3);
            this.panel4.Location = new System.Drawing.Point(851, 396);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(619, 442);
            this.panel4.TabIndex = 43;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.LightCoral;
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(152, 385);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(102, 37);
            this.btnCalc.TabIndex = 79;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtCredit
            // 
            this.txtCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredit.Location = new System.Drawing.Point(212, 295);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(205, 24);
            this.txtCredit.TabIndex = 78;
            this.txtCredit.Text = "0";
            this.txtCredit.TextChanged += new System.EventHandler(this.txtCredit_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 77;
            this.label9.Text = "Credit";
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.ForeColor = System.Drawing.Color.Red;
            this.txtBalance.Location = new System.Drawing.Point(113, 340);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(177, 24);
            this.txtBalance.TabIndex = 76;
            this.txtBalance.Text = "0";
            this.txtBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBalance_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 75;
            this.label8.Text = "Balance";
            // 
            // txtRetNlb
            // 
            this.txtRetNlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetNlb.Location = new System.Drawing.Point(212, 259);
            this.txtRetNlb.Name = "txtRetNlb";
            this.txtRetNlb.Size = new System.Drawing.Size(177, 24);
            this.txtRetNlb.TabIndex = 74;
            this.txtRetNlb.Text = "0";
            // 
            // txtRetDlb
            // 
            this.txtRetDlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetDlb.Location = new System.Drawing.Point(421, 259);
            this.txtRetDlb.Name = "txtRetDlb";
            this.txtRetDlb.Size = new System.Drawing.Size(177, 24);
            this.txtRetDlb.TabIndex = 72;
            this.txtRetDlb.Text = "0";
            // 
            // txtScanNlb
            // 
            this.txtScanNlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScanNlb.Location = new System.Drawing.Point(212, 220);
            this.txtScanNlb.Name = "txtScanNlb";
            this.txtScanNlb.Size = new System.Drawing.Size(177, 24);
            this.txtScanNlb.TabIndex = 70;
            this.txtScanNlb.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(474, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 18);
            this.label7.TabIndex = 68;
            this.label7.Text = "DLB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(271, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 18);
            this.label6.TabIndex = 60;
            this.label6.Text = "NLB";
            // 
            // txtScanDlb
            // 
            this.txtScanDlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScanDlb.Location = new System.Drawing.Point(421, 220);
            this.txtScanDlb.Name = "txtScanDlb";
            this.txtScanDlb.Size = new System.Drawing.Size(177, 24);
            this.txtScanDlb.TabIndex = 67;
            this.txtScanDlb.Text = "0";
            // 
            // txtBank
            // 
            this.txtBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBank.Location = new System.Drawing.Point(212, 162);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(205, 24);
            this.txtBank.TabIndex = 65;
            this.txtBank.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 64;
            this.label5.Text = "Returns";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 20);
            this.label4.TabIndex = 63;
            this.label4.Text = "Scan tickets (Email)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "Bank Slip";
            // 
            // txtCash
            // 
            this.txtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(212, 126);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(205, 24);
            this.txtCash.TabIndex = 61;
            this.txtCash.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Cash";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(350, 374);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(159, 48);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTotalQty
            // 
            this.txtTotalQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalQty.Location = new System.Drawing.Point(83, 72);
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.Size = new System.Drawing.Size(141, 27);
            this.txtTotalQty.TabIndex = 59;
            this.txtTotalQty.Text = "0";
            this.txtTotalQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalQty_KeyPress);
            // 
            // txtGndTotal
            // 
            this.txtGndTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGndTotal.Location = new System.Drawing.Point(359, 72);
            this.txtGndTotal.Name = "txtGndTotal";
            this.txtGndTotal.Size = new System.Drawing.Size(177, 27);
            this.txtGndTotal.TabIndex = 55;
            this.txtGndTotal.Text = "0";
            this.txtGndTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGndTotal_KeyPress);
            // 
            // lblGndTotal
            // 
            this.lblGndTotal.AutoSize = true;
            this.lblGndTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGndTotal.Location = new System.Drawing.Point(379, 45);
            this.lblGndTotal.Name = "lblGndTotal";
            this.lblGndTotal.Size = new System.Drawing.Size(108, 20);
            this.lblGndTotal.TabIndex = 56;
            this.lblGndTotal.Text = "Grand Total";
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.AutoSize = true;
            this.lblTotalQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQty.Location = new System.Drawing.Point(79, 45);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(127, 20);
            this.lblTotalQty.TabIndex = 55;
            this.lblTotalQty.Text = "Total Quantity";
            // 
            // lblHeader3
            // 
            this.lblHeader3.AutoSize = true;
            this.lblHeader3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader3.Location = new System.Drawing.Point(8, 7);
            this.lblHeader3.Name = "lblHeader3";
            this.lblHeader3.Size = new System.Drawing.Size(181, 24);
            this.lblHeader3.TabIndex = 40;
            this.lblHeader3.Text = "Calculation Details";
            // 
            // Purchase
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
            this.Name = "Purchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.Purchase_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchases)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtInvNo;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Label lblTname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpInvDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTickName;
        private System.Windows.Forms.Label lblStBcode;
        private System.Windows.Forms.Label lblUprice;
        private System.Windows.Forms.Label lblDrawNo;
        private System.Windows.Forms.Label lblDrawDate;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.TextBox txtUprice;
        private System.Windows.Forms.TextBox txtEdBcode;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.DateTimePicker dtpDrdate;
        private System.Windows.Forms.TextBox txtDrno;
        private System.Windows.Forms.Label lblEdBcode;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblHeader2;
        private System.Windows.Forms.Label lblHeader3;
        private System.Windows.Forms.DataGridView dgvPurchases;
        private System.Windows.Forms.Label lblGndTotal;
        private System.Windows.Forms.Label lblTotalQty;
        private System.Windows.Forms.TextBox txtGndTotal;
        private System.Windows.Forms.TextBox txtTotalQty;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtLineTotal;
        private System.Windows.Forms.Label lblLineTotal;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label lblSupplier1;
        private System.Windows.Forms.TextBox txtStBcode;
        private System.Windows.Forms.TextBox txtSup;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtScanNlb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtScanDlb;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRetNlb;
        private System.Windows.Forms.TextBox txtRetDlb;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCalc;
    }
}