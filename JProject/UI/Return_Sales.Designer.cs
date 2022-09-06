
namespace JProject.UI
{
    partial class Return_Sales
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
            this.lblStBcode = new System.Windows.Forms.Label();
            this.txtStBcode = new System.Windows.Forms.TextBox();
            this.lblEnBcode = new System.Windows.Forms.Label();
            this.txtEnBcode = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblDrawNo = new System.Windows.Forms.Label();
            this.txtDrNo = new System.Windows.Forms.TextBox();
            this.txtDrDate = new System.Windows.Forms.TextBox();
            this.lblDrawDate = new System.Windows.Forms.Label();
            this.txtInvNo = new System.Windows.Forms.TextBox();
            this.lblInvNo = new System.Windows.Forms.Label();
            this.txtAgentNo = new System.Windows.Forms.TextBox();
            this.lblAgentNo = new System.Windows.Forms.Label();
            this.txtAgentName = new System.Windows.Forms.TextBox();
            this.lblAgentName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.txtOrQty = new System.Windows.Forms.TextBox();
            this.lblOrQty = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblLineTot = new System.Windows.Forms.Label();
            this.txtLineTotal = new System.Windows.Forms.TextBox();
            this.txtTname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHeader3 = new System.Windows.Forms.Label();
            this.dgvSalesReturn = new System.Windows.Forms.DataGridView();
            this.txtTotalQty = new System.Windows.Forms.TextBox();
            this.txtTotAmount = new System.Windows.Forms.TextBox();
            this.lblTotalQty = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtSreturnId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAgentN1 = new System.Windows.Forms.Label();
            this.lblAgentNo1 = new System.Windows.Forms.Label();
            this.lblDrDate1 = new System.Windows.Forms.Label();
            this.lblSup1 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader1
            // 
            this.lblHeader1.AutoSize = true;
            this.lblHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader1.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblHeader1.Location = new System.Drawing.Point(611, 9);
            this.lblHeader1.Name = "lblHeader1";
            this.lblHeader1.Size = new System.Drawing.Size(215, 36);
            this.lblHeader1.TabIndex = 82;
            this.lblHeader1.Text = "Sales Returns";
            // 
            // lblStBcode
            // 
            this.lblStBcode.AutoSize = true;
            this.lblStBcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStBcode.Location = new System.Drawing.Point(27, 30);
            this.lblStBcode.Name = "lblStBcode";
            this.lblStBcode.Size = new System.Drawing.Size(157, 25);
            this.lblStBcode.TabIndex = 90;
            this.lblStBcode.Text = "Starting Barcode";
            // 
            // txtStBcode
            // 
            this.txtStBcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStBcode.Location = new System.Drawing.Point(210, 30);
            this.txtStBcode.Name = "txtStBcode";
            this.txtStBcode.Size = new System.Drawing.Size(312, 27);
            this.txtStBcode.TabIndex = 91;
            this.txtStBcode.Text = "0";
            this.txtStBcode.TextChanged += new System.EventHandler(this.txtStBcode_TextChanged);
            // 
            // lblEnBcode
            // 
            this.lblEnBcode.AutoSize = true;
            this.lblEnBcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnBcode.Location = new System.Drawing.Point(27, 154);
            this.lblEnBcode.Name = "lblEnBcode";
            this.lblEnBcode.Size = new System.Drawing.Size(151, 25);
            this.lblEnBcode.TabIndex = 92;
            this.lblEnBcode.Text = "Ending Barcode";
            // 
            // txtEnBcode
            // 
            this.txtEnBcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnBcode.Location = new System.Drawing.Point(210, 152);
            this.txtEnBcode.Name = "txtEnBcode";
            this.txtEnBcode.Size = new System.Drawing.Size(312, 27);
            this.txtEnBcode.TabIndex = 93;
            this.txtEnBcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnBcode_KeyPress);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(27, 92);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(85, 25);
            this.lblQty.TabIndex = 95;
            this.lblQty.Text = "Quantity";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(210, 90);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(116, 27);
            this.txtQty.TabIndex = 94;
            this.txtQty.Text = "0";
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // lblDrawNo
            // 
            this.lblDrawNo.AutoSize = true;
            this.lblDrawNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawNo.Location = new System.Drawing.Point(908, 181);
            this.lblDrawNo.Name = "lblDrawNo";
            this.lblDrawNo.Size = new System.Drawing.Size(83, 24);
            this.lblDrawNo.TabIndex = 98;
            this.lblDrawNo.Text = "Draw No";
            // 
            // txtDrNo
            // 
            this.txtDrNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrNo.Location = new System.Drawing.Point(912, 208);
            this.txtDrNo.Name = "txtDrNo";
            this.txtDrNo.Size = new System.Drawing.Size(150, 27);
            this.txtDrNo.TabIndex = 99;
            this.txtDrNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDrNo_KeyPress);
            // 
            // txtDrDate
            // 
            this.txtDrDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrDate.Location = new System.Drawing.Point(1120, 208);
            this.txtDrDate.Name = "txtDrDate";
            this.txtDrDate.Size = new System.Drawing.Size(150, 27);
            this.txtDrDate.TabIndex = 101;
            this.txtDrDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDrDate_KeyPress);
            // 
            // lblDrawDate
            // 
            this.lblDrawDate.AutoSize = true;
            this.lblDrawDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawDate.Location = new System.Drawing.Point(1116, 181);
            this.lblDrawDate.Name = "lblDrawDate";
            this.lblDrawDate.Size = new System.Drawing.Size(96, 24);
            this.lblDrawDate.TabIndex = 100;
            this.lblDrawDate.Text = "Draw Date";
            // 
            // txtInvNo
            // 
            this.txtInvNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvNo.Location = new System.Drawing.Point(1041, 20);
            this.txtInvNo.Name = "txtInvNo";
            this.txtInvNo.Size = new System.Drawing.Size(275, 27);
            this.txtInvNo.TabIndex = 103;
            this.txtInvNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvNo_KeyPress);
            // 
            // lblInvNo
            // 
            this.lblInvNo.AutoSize = true;
            this.lblInvNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvNo.Location = new System.Drawing.Point(908, 20);
            this.lblInvNo.Name = "lblInvNo";
            this.lblInvNo.Size = new System.Drawing.Size(100, 24);
            this.lblInvNo.TabIndex = 102;
            this.lblInvNo.Text = "Invoice No";
            // 
            // txtAgentNo
            // 
            this.txtAgentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgentNo.Location = new System.Drawing.Point(1041, 132);
            this.txtAgentNo.Name = "txtAgentNo";
            this.txtAgentNo.Size = new System.Drawing.Size(275, 27);
            this.txtAgentNo.TabIndex = 107;
            this.txtAgentNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgentNo_KeyPress);
            // 
            // lblAgentNo
            // 
            this.lblAgentNo.AutoSize = true;
            this.lblAgentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentNo.Location = new System.Drawing.Point(908, 135);
            this.lblAgentNo.Name = "lblAgentNo";
            this.lblAgentNo.Size = new System.Drawing.Size(87, 24);
            this.lblAgentNo.TabIndex = 106;
            this.lblAgentNo.Text = "Agent no";
            // 
            // txtAgentName
            // 
            this.txtAgentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgentName.Location = new System.Drawing.Point(1041, 75);
            this.txtAgentName.Name = "txtAgentName";
            this.txtAgentName.Size = new System.Drawing.Size(275, 27);
            this.txtAgentName.TabIndex = 105;
            this.txtAgentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgentName_KeyPress);
            // 
            // lblAgentName
            // 
            this.lblAgentName.AutoSize = true;
            this.lblAgentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentName.Location = new System.Drawing.Point(908, 75);
            this.lblAgentName.Name = "lblAgentName";
            this.lblAgentName.Size = new System.Drawing.Size(113, 24);
            this.lblAgentName.TabIndex = 104;
            this.lblAgentName.Text = "Agent name";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(640, 215);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 44);
            this.btnAdd.TabIndex = 108;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1044, 701);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 51);
            this.btnSave.TabIndex = 109;
            this.btnSave.Text = "Save ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.txtSupplier);
            this.panel5.Controls.Add(this.txtOrQty);
            this.panel5.Controls.Add(this.lblOrQty);
            this.panel5.Controls.Add(this.txtUnitPrice);
            this.panel5.Controls.Add(this.lblUnitPrice);
            this.panel5.Controls.Add(this.lblLineTot);
            this.panel5.Controls.Add(this.txtLineTotal);
            this.panel5.Controls.Add(this.txtTname);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.lblStBcode);
            this.panel5.Controls.Add(this.txtStBcode);
            this.panel5.Controls.Add(this.btnAdd);
            this.panel5.Controls.Add(this.txtEnBcode);
            this.panel5.Controls.Add(this.txtAgentNo);
            this.panel5.Controls.Add(this.lblEnBcode);
            this.panel5.Controls.Add(this.lblAgentNo);
            this.panel5.Controls.Add(this.txtQty);
            this.panel5.Controls.Add(this.txtAgentName);
            this.panel5.Controls.Add(this.lblQty);
            this.panel5.Controls.Add(this.lblAgentName);
            this.panel5.Controls.Add(this.lblInvNo);
            this.panel5.Controls.Add(this.txtInvNo);
            this.panel5.Controls.Add(this.txtDrDate);
            this.panel5.Controls.Add(this.txtDrNo);
            this.panel5.Controls.Add(this.lblDrawDate);
            this.panel5.Controls.Add(this.lblDrawNo);
            this.panel5.Location = new System.Drawing.Point(25, 130);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1343, 284);
            this.panel5.TabIndex = 110;
            // 
            // txtSupplier
            // 
            this.txtSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplier.Location = new System.Drawing.Point(590, 119);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(94, 27);
            this.txtSupplier.TabIndex = 117;
            this.txtSupplier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupplier_KeyPress);
            // 
            // txtOrQty
            // 
            this.txtOrQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrQty.Location = new System.Drawing.Point(1026, 248);
            this.txtOrQty.Name = "txtOrQty";
            this.txtOrQty.Size = new System.Drawing.Size(116, 24);
            this.txtOrQty.TabIndex = 115;
            this.txtOrQty.Text = "0";
            this.txtOrQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrQty_KeyPress);
            // 
            // lblOrQty
            // 
            this.lblOrQty.AutoSize = true;
            this.lblOrQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrQty.Location = new System.Drawing.Point(936, 250);
            this.lblOrQty.Name = "lblOrQty";
            this.lblOrQty.Size = new System.Drawing.Size(83, 20);
            this.lblOrQty.TabIndex = 116;
            this.lblOrQty.Text = "Order Qty";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(31, 232);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(81, 24);
            this.txtUnitPrice.TabIndex = 113;
            this.txtUnitPrice.Text = "0";
            this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice_KeyPress);
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.Location = new System.Drawing.Point(27, 204);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(83, 20);
            this.lblUnitPrice.TabIndex = 114;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblLineTot
            // 
            this.lblLineTot.AutoSize = true;
            this.lblLineTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLineTot.Location = new System.Drawing.Point(205, 204);
            this.lblLineTot.Name = "lblLineTot";
            this.lblLineTot.Size = new System.Drawing.Size(98, 25);
            this.lblLineTot.TabIndex = 112;
            this.lblLineTot.Text = "Line Total";
            // 
            // txtLineTotal
            // 
            this.txtLineTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLineTotal.Location = new System.Drawing.Point(210, 232);
            this.txtLineTotal.Name = "txtLineTotal";
            this.txtLineTotal.Size = new System.Drawing.Size(214, 27);
            this.txtLineTotal.TabIndex = 111;
            this.txtLineTotal.Text = "0";
            this.txtLineTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLineTotal_KeyPress);
            // 
            // txtTname
            // 
            this.txtTname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTname.Location = new System.Drawing.Point(590, 77);
            this.txtTname.Name = "txtTname";
            this.txtTname.Size = new System.Drawing.Size(259, 27);
            this.txtTname.TabIndex = 110;
            this.txtTname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTname_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(586, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 109;
            this.label1.Text = "Ticket name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblHeader3);
            this.panel2.Controls.Add(this.dgvSalesReturn);
            this.panel2.Location = new System.Drawing.Point(25, 442);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 394);
            this.panel2.TabIndex = 111;
            // 
            // lblHeader3
            // 
            this.lblHeader3.AutoSize = true;
            this.lblHeader3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader3.Location = new System.Drawing.Point(12, 10);
            this.lblHeader3.Name = "lblHeader3";
            this.lblHeader3.Size = new System.Drawing.Size(139, 24);
            this.lblHeader3.TabIndex = 39;
            this.lblHeader3.Text = "Sales Returns";
            // 
            // dgvSalesReturn
            // 
            this.dgvSalesReturn.AllowUserToAddRows = false;
            this.dgvSalesReturn.AllowUserToDeleteRows = false;
            this.dgvSalesReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesReturn.Location = new System.Drawing.Point(16, 46);
            this.dgvSalesReturn.Name = "dgvSalesReturn";
            this.dgvSalesReturn.ReadOnly = true;
            this.dgvSalesReturn.RowHeadersWidth = 51;
            this.dgvSalesReturn.RowTemplate.Height = 24;
            this.dgvSalesReturn.Size = new System.Drawing.Size(745, 331);
            this.dgvSalesReturn.TabIndex = 40;
            // 
            // txtTotalQty
            // 
            this.txtTotalQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalQty.Location = new System.Drawing.Point(1044, 548);
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.Size = new System.Drawing.Size(139, 27);
            this.txtTotalQty.TabIndex = 115;
            this.txtTotalQty.Text = "0";
            this.txtTotalQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalQty_KeyPress);
            // 
            // txtTotAmount
            // 
            this.txtTotAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotAmount.Location = new System.Drawing.Point(1044, 606);
            this.txtTotAmount.Name = "txtTotAmount";
            this.txtTotAmount.Size = new System.Drawing.Size(267, 27);
            this.txtTotAmount.TabIndex = 112;
            this.txtTotAmount.Text = "0";
            this.txtTotAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotAmount_KeyPress);
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.AutoSize = true;
            this.lblTotalQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQty.Location = new System.Drawing.Point(895, 555);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(127, 20);
            this.lblTotalQty.TabIndex = 113;
            this.lblTotalQty.Text = "Total Quantity";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(895, 609);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(134, 24);
            this.lblTotalAmount.TabIndex = 114;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // txtSreturnId
            // 
            this.txtSreturnId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSreturnId.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtSreturnId.Location = new System.Drawing.Point(202, 91);
            this.txtSreturnId.Name = "txtSreturnId";
            this.txtSreturnId.Size = new System.Drawing.Size(294, 27);
            this.txtSreturnId.TabIndex = 117;
            this.txtSreturnId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSreturnId_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 116;
            this.label2.Text = "Sales Return No";
            // 
            // lblAgentN1
            // 
            this.lblAgentN1.AutoSize = true;
            this.lblAgentN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentN1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAgentN1.Location = new System.Drawing.Point(963, 60);
            this.lblAgentN1.Name = "lblAgentN1";
            this.lblAgentN1.Size = new System.Drawing.Size(0, 20);
            this.lblAgentN1.TabIndex = 118;
            // 
            // lblAgentNo1
            // 
            this.lblAgentNo1.AutoSize = true;
            this.lblAgentNo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentNo1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAgentNo1.Location = new System.Drawing.Point(963, 91);
            this.lblAgentNo1.Name = "lblAgentNo1";
            this.lblAgentNo1.Size = new System.Drawing.Size(13, 20);
            this.lblAgentNo1.TabIndex = 118;
            this.lblAgentNo1.Text = ".";
            // 
            // lblDrDate1
            // 
            this.lblDrDate1.AutoSize = true;
            this.lblDrDate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrDate1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDrDate1.Location = new System.Drawing.Point(37, 46);
            this.lblDrDate1.Name = "lblDrDate1";
            this.lblDrDate1.Size = new System.Drawing.Size(15, 24);
            this.lblDrDate1.TabIndex = 118;
            this.lblDrDate1.Text = ".";
            // 
            // lblSup1
            // 
            this.lblSup1.AutoSize = true;
            this.lblSup1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSup1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSup1.Location = new System.Drawing.Point(1298, 94);
            this.lblSup1.Name = "lblSup1";
            this.lblSup1.Size = new System.Drawing.Size(14, 20);
            this.lblSup1.TabIndex = 119;
            this.lblSup1.Text = ".";
            // 
            // Return_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1393, 848);
            this.Controls.Add(this.lblSup1);
            this.Controls.Add(this.lblDrDate1);
            this.Controls.Add(this.lblAgentNo1);
            this.Controls.Add(this.lblAgentN1);
            this.Controls.Add(this.txtSreturnId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalQty);
            this.Controls.Add(this.txtTotAmount);
            this.Controls.Add(this.lblTotalQty);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblHeader1);
            this.Name = "Return_Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales_Return";
            this.Load += new System.EventHandler(this.Sales_Return_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader1;
        private System.Windows.Forms.Label lblStBcode;
        private System.Windows.Forms.TextBox txtStBcode;
        private System.Windows.Forms.Label lblEnBcode;
        private System.Windows.Forms.TextBox txtEnBcode;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblDrawNo;
        private System.Windows.Forms.TextBox txtDrNo;
        private System.Windows.Forms.TextBox txtDrDate;
        private System.Windows.Forms.Label lblDrawDate;
        private System.Windows.Forms.TextBox txtInvNo;
        private System.Windows.Forms.Label lblInvNo;
        private System.Windows.Forms.TextBox txtAgentNo;
        private System.Windows.Forms.Label lblAgentNo;
        private System.Windows.Forms.TextBox txtAgentName;
        private System.Windows.Forms.Label lblAgentName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtTname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHeader3;
        private System.Windows.Forms.DataGridView dgvSalesReturn;
        private System.Windows.Forms.TextBox txtTotalQty;
        private System.Windows.Forms.TextBox txtTotAmount;
        private System.Windows.Forms.Label lblTotalQty;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblLineTot;
        private System.Windows.Forms.TextBox txtLineTotal;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtOrQty;
        private System.Windows.Forms.Label lblOrQty;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.TextBox txtSreturnId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAgentN1;
        private System.Windows.Forms.Label lblAgentNo1;
        private System.Windows.Forms.Label lblDrDate1;
        private System.Windows.Forms.Label lblSup1;
    }
}