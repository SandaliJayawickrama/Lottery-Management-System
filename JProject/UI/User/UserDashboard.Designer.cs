
namespace JProject.UI
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuAdmin = new System.Windows.Forms.MenuStrip();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAgentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditSettleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewDrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewInstantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseStockInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawInstantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseReturnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.winToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesSummeryDailyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stockDrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockInstantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picDashboard = new System.Windows.Forms.PictureBox();
            this.lblloggedIn = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.labelFooter = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDashboard)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1318, 156);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(664, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(787, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wasantha Enterprises";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(790, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(449, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "NLB &  DLB Lottery Distributors - Colombo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(804, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "(NO.44/237, World Market, Colombo-11)";
            // 
            // menuAdmin
            // 
            this.menuAdmin.Dock = System.Windows.Forms.DockStyle.None;
            this.menuAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAdmin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.purchasesToolStripMenuItem,
            this.returnToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.winToolStripMenuItem,
            this.stockToolStripMenuItem1});
            this.menuAdmin.Location = new System.Drawing.Point(0, 159);
            this.menuAdmin.Name = "menuAdmin";
            this.menuAdmin.Size = new System.Drawing.Size(698, 31);
            this.menuAdmin.TabIndex = 7;
            this.menuAdmin.Text = "menuUser";
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAgentsToolStripMenuItem,
            this.creditSettleToolStripMenuItem,
            this.agentListToolStripMenuItem});
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(77, 27);
            this.itemsToolStripMenuItem.Text = "Agents";
            this.itemsToolStripMenuItem.Click += new System.EventHandler(this.itemsToolStripMenuItem_Click);
            // 
            // addAgentsToolStripMenuItem
            // 
            this.addAgentsToolStripMenuItem.Name = "addAgentsToolStripMenuItem";
            this.addAgentsToolStripMenuItem.Size = new System.Drawing.Size(188, 28);
            this.addAgentsToolStripMenuItem.Text = "Add Agents";
            this.addAgentsToolStripMenuItem.Click += new System.EventHandler(this.addAgentsToolStripMenuItem_Click);
            // 
            // creditSettleToolStripMenuItem
            // 
            this.creditSettleToolStripMenuItem.Name = "creditSettleToolStripMenuItem";
            this.creditSettleToolStripMenuItem.Size = new System.Drawing.Size(188, 28);
            this.creditSettleToolStripMenuItem.Text = "Credit Settle";
            this.creditSettleToolStripMenuItem.Click += new System.EventHandler(this.creditSettleToolStripMenuItem_Click);
            // 
            // agentListToolStripMenuItem
            // 
            this.agentListToolStripMenuItem.Name = "agentListToolStripMenuItem";
            this.agentListToolStripMenuItem.Size = new System.Drawing.Size(188, 28);
            this.agentListToolStripMenuItem.Text = "Agent List";
            this.agentListToolStripMenuItem.Click += new System.EventHandler(this.agentListToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticketToolStripMenuItem,
            this.ticketListToolStripMenuItem});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(76, 27);
            this.salesToolStripMenuItem.Text = "Tickets";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // ticketToolStripMenuItem
            // 
            this.ticketToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewTicketToolStripMenuItem,
            this.updateTicketsToolStripMenuItem});
            this.ticketToolStripMenuItem.Name = "ticketToolStripMenuItem";
            this.ticketToolStripMenuItem.Size = new System.Drawing.Size(169, 28);
            this.ticketToolStripMenuItem.Text = "Ticket";
            // 
            // addNewTicketToolStripMenuItem
            // 
            this.addNewTicketToolStripMenuItem.Name = "addNewTicketToolStripMenuItem";
            this.addNewTicketToolStripMenuItem.Size = new System.Drawing.Size(215, 28);
            this.addNewTicketToolStripMenuItem.Text = "Add New Ticket";
            this.addNewTicketToolStripMenuItem.Click += new System.EventHandler(this.addNewTicketToolStripMenuItem_Click);
            // 
            // updateTicketsToolStripMenuItem
            // 
            this.updateTicketsToolStripMenuItem.Name = "updateTicketsToolStripMenuItem";
            this.updateTicketsToolStripMenuItem.Size = new System.Drawing.Size(215, 28);
            this.updateTicketsToolStripMenuItem.Text = "Update Tickets";
            this.updateTicketsToolStripMenuItem.Click += new System.EventHandler(this.updateTicketsToolStripMenuItem_Click);
            // 
            // ticketListToolStripMenuItem
            // 
            this.ticketListToolStripMenuItem.Name = "ticketListToolStripMenuItem";
            this.ticketListToolStripMenuItem.Size = new System.Drawing.Size(169, 28);
            this.ticketListToolStripMenuItem.Text = "Ticket List";
            this.ticketListToolStripMenuItem.Click += new System.EventHandler(this.ticketListToolStripMenuItem_Click);
            // 
            // purchasesToolStripMenuItem
            // 
            this.purchasesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseOrdersToolStripMenuItem,
            this.purchaseStockInToolStripMenuItem,
            this.purchaseListToolStripMenuItem});
            this.purchasesToolStripMenuItem.Name = "purchasesToolStripMenuItem";
            this.purchasesToolStripMenuItem.Size = new System.Drawing.Size(100, 27);
            this.purchasesToolStripMenuItem.Text = "Purchases";
            // 
            // purchaseOrdersToolStripMenuItem
            // 
            this.purchaseOrdersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewDrawToolStripMenuItem,
            this.createNewInstantToolStripMenuItem});
            this.purchaseOrdersToolStripMenuItem.Name = "purchaseOrdersToolStripMenuItem";
            this.purchaseOrdersToolStripMenuItem.Size = new System.Drawing.Size(242, 28);
            this.purchaseOrdersToolStripMenuItem.Text = "Purchase Orders";
            // 
            // createNewDrawToolStripMenuItem
            // 
            this.createNewDrawToolStripMenuItem.Name = "createNewDrawToolStripMenuItem";
            this.createNewDrawToolStripMenuItem.Size = new System.Drawing.Size(254, 28);
            this.createNewDrawToolStripMenuItem.Text = "Create New - Draw";
            this.createNewDrawToolStripMenuItem.Click += new System.EventHandler(this.createNewDrawToolStripMenuItem_Click);
            // 
            // createNewInstantToolStripMenuItem
            // 
            this.createNewInstantToolStripMenuItem.Name = "createNewInstantToolStripMenuItem";
            this.createNewInstantToolStripMenuItem.Size = new System.Drawing.Size(254, 28);
            this.createNewInstantToolStripMenuItem.Text = "Create New - Instant";
            this.createNewInstantToolStripMenuItem.Click += new System.EventHandler(this.createNewInstantToolStripMenuItem_Click);
            // 
            // purchaseStockInToolStripMenuItem
            // 
            this.purchaseStockInToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawInstantToolStripMenuItem});
            this.purchaseStockInToolStripMenuItem.Name = "purchaseStockInToolStripMenuItem";
            this.purchaseStockInToolStripMenuItem.Size = new System.Drawing.Size(242, 28);
            this.purchaseStockInToolStripMenuItem.Text = "Purchase - Stock In";
            // 
            // drawInstantToolStripMenuItem
            // 
            this.drawInstantToolStripMenuItem.Name = "drawInstantToolStripMenuItem";
            this.drawInstantToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.drawInstantToolStripMenuItem.Text = "Draw / Instant";
            this.drawInstantToolStripMenuItem.Click += new System.EventHandler(this.drawInstantToolStripMenuItem_Click);
            // 
            // purchaseListToolStripMenuItem
            // 
            this.purchaseListToolStripMenuItem.Name = "purchaseListToolStripMenuItem";
            this.purchaseListToolStripMenuItem.Size = new System.Drawing.Size(242, 28);
            this.purchaseListToolStripMenuItem.Text = "Purchase List";
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesToolStripMenuItem1,
            this.salesListToolStripMenuItem});
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(62, 27);
            this.returnToolStripMenuItem.Text = "Sales";
            // 
            // salesToolStripMenuItem1
            // 
            this.salesToolStripMenuItem1.Name = "salesToolStripMenuItem1";
            this.salesToolStripMenuItem1.Size = new System.Drawing.Size(162, 28);
            this.salesToolStripMenuItem1.Text = "Sales";
            this.salesToolStripMenuItem1.Click += new System.EventHandler(this.salesToolStripMenuItem1_Click);
            // 
            // salesListToolStripMenuItem
            // 
            this.salesListToolStripMenuItem.Name = "salesListToolStripMenuItem";
            this.salesListToolStripMenuItem.Size = new System.Drawing.Size(162, 28);
            this.salesListToolStripMenuItem.Text = "Sales List";
            this.salesListToolStripMenuItem.Click += new System.EventHandler(this.salesListToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseReturnsToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(76, 27);
            this.stockToolStripMenuItem.Text = "Return";
            // 
            // purchaseReturnsToolStripMenuItem
            // 
            this.purchaseReturnsToolStripMenuItem.Name = "purchaseReturnsToolStripMenuItem";
            this.purchaseReturnsToolStripMenuItem.Size = new System.Drawing.Size(227, 28);
            this.purchaseReturnsToolStripMenuItem.Text = "Purchase Returns";
            this.purchaseReturnsToolStripMenuItem.Click += new System.EventHandler(this.purchaseReturnsToolStripMenuItem_Click);
            // 
            // winToolStripMenuItem
            // 
            this.winToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesSummeryDailyToolStripMenuItem});
            this.winToolStripMenuItem.Name = "winToolStripMenuItem";
            this.winToolStripMenuItem.Size = new System.Drawing.Size(83, 27);
            this.winToolStripMenuItem.Text = "Reports";
            // 
            // salesSummeryDailyToolStripMenuItem
            // 
            this.salesSummeryDailyToolStripMenuItem.Name = "salesSummeryDailyToolStripMenuItem";
            this.salesSummeryDailyToolStripMenuItem.Size = new System.Drawing.Size(266, 28);
            this.salesSummeryDailyToolStripMenuItem.Text = "Sales Summery - Daily";
            this.salesSummeryDailyToolStripMenuItem.Click += new System.EventHandler(this.salesSummeryDailyToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem1
            // 
            this.stockToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockDrawToolStripMenuItem,
            this.stockInstantToolStripMenuItem});
            this.stockToolStripMenuItem1.Name = "stockToolStripMenuItem1";
            this.stockToolStripMenuItem1.Size = new System.Drawing.Size(66, 27);
            this.stockToolStripMenuItem1.Text = "Stock";
            // 
            // stockDrawToolStripMenuItem
            // 
            this.stockDrawToolStripMenuItem.Name = "stockDrawToolStripMenuItem";
            this.stockDrawToolStripMenuItem.Size = new System.Drawing.Size(206, 28);
            this.stockDrawToolStripMenuItem.Text = "Stock - Draw";
            this.stockDrawToolStripMenuItem.Click += new System.EventHandler(this.stockDrawToolStripMenuItem_Click);
            // 
            // stockInstantToolStripMenuItem
            // 
            this.stockInstantToolStripMenuItem.Name = "stockInstantToolStripMenuItem";
            this.stockInstantToolStripMenuItem.Size = new System.Drawing.Size(206, 28);
            this.stockInstantToolStripMenuItem.Text = "Stock - Instant";
            this.stockInstantToolStripMenuItem.Click += new System.EventHandler(this.stockInstantToolStripMenuItem_Click);
            // 
            // picDashboard
            // 
            this.picDashboard.Image = ((System.Drawing.Image)(resources.GetObject("picDashboard.Image")));
            this.picDashboard.Location = new System.Drawing.Point(580, 355);
            this.picDashboard.Name = "picDashboard";
            this.picDashboard.Size = new System.Drawing.Size(726, 409);
            this.picDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDashboard.TabIndex = 9;
            this.picDashboard.TabStop = false;
            // 
            // lblloggedIn
            // 
            this.lblloggedIn.AutoSize = true;
            this.lblloggedIn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloggedIn.Location = new System.Drawing.Point(61, 878);
            this.lblloggedIn.Name = "lblloggedIn";
            this.lblloggedIn.Size = new System.Drawing.Size(67, 19);
            this.lblloggedIn.TabIndex = 11;
            this.lblloggedIn.Text = "Admin1";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(8, 878);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(47, 19);
            this.labelUser.TabIndex = 10;
            this.labelUser.Text = "User:";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.Teal;
            this.panelFooter.Controls.Add(this.labelFooter);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 931);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1318, 49);
            this.panelFooter.TabIndex = 12;
            // 
            // labelFooter
            // 
            this.labelFooter.AutoSize = true;
            this.labelFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFooter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelFooter.Location = new System.Drawing.Point(894, 22);
            this.labelFooter.Name = "labelFooter";
            this.labelFooter.Size = new System.Drawing.Size(153, 18);
            this.labelFooter.TabIndex = 0;
            this.labelFooter.Text = "Developed By: SRJ";
            this.labelFooter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 980);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.lblloggedIn);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.picDashboard);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuAdmin);
            this.Name = "UserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuAdmin.ResumeLayout(false);
            this.menuAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDashboard)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuAdmin;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem winToolStripMenuItem;
        private System.Windows.Forms.PictureBox picDashboard;
        private System.Windows.Forms.Label lblloggedIn;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label labelFooter;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addAgentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditSettleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salesListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseReturnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesSummeryDailyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockDrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockInstantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewDrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewInstantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseStockInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawInstantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseListToolStripMenuItem;
    }
}