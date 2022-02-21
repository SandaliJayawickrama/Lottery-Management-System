
namespace JProject.UI
{
    partial class Stock_List
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
            this.lblSearchAgent = new System.Windows.Forms.Label();
            this.txtSearchStock = new System.Windows.Forms.TextBox();
            this.dgvStockList = new System.Windows.Forms.DataGridView();
            this.lblHeader1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchAgent
            // 
            this.lblSearchAgent.AutoSize = true;
            this.lblSearchAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchAgent.Location = new System.Drawing.Point(52, 94);
            this.lblSearchAgent.Name = "lblSearchAgent";
            this.lblSearchAgent.Size = new System.Drawing.Size(74, 20);
            this.lblSearchAgent.TabIndex = 44;
            this.lblSearchAgent.Text = "Search ";
            // 
            // txtSearchStock
            // 
            this.txtSearchStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchStock.Location = new System.Drawing.Point(148, 94);
            this.txtSearchStock.Name = "txtSearchStock";
            this.txtSearchStock.Size = new System.Drawing.Size(295, 27);
            this.txtSearchStock.TabIndex = 45;
            this.txtSearchStock.TextChanged += new System.EventHandler(this.txtSearchStock_TextChanged);
            // 
            // dgvStockList
            // 
            this.dgvStockList.AllowUserToAddRows = false;
            this.dgvStockList.AllowUserToDeleteRows = false;
            this.dgvStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockList.Location = new System.Drawing.Point(42, 153);
            this.dgvStockList.Name = "dgvStockList";
            this.dgvStockList.RowHeadersWidth = 51;
            this.dgvStockList.RowTemplate.Height = 24;
            this.dgvStockList.Size = new System.Drawing.Size(1150, 557);
            this.dgvStockList.TabIndex = 43;
            // 
            // lblHeader1
            // 
            this.lblHeader1.AutoSize = true;
            this.lblHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader1.ForeColor = System.Drawing.Color.Navy;
            this.lblHeader1.Location = new System.Drawing.Point(547, 9);
            this.lblHeader1.Name = "lblHeader1";
            this.lblHeader1.Size = new System.Drawing.Size(91, 32);
            this.lblHeader1.TabIndex = 42;
            this.lblHeader1.Text = "Stock";
            // 
            // Stock_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1243, 723);
            this.Controls.Add(this.lblSearchAgent);
            this.Controls.Add(this.txtSearchStock);
            this.Controls.Add(this.dgvStockList);
            this.Controls.Add(this.lblHeader1);
            this.Name = "Stock_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock_List";
            this.Load += new System.EventHandler(this.Stock_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchAgent;
        private System.Windows.Forms.TextBox txtSearchStock;
        private System.Windows.Forms.DataGridView dgvStockList;
        private System.Windows.Forms.Label lblHeader1;
    }
}