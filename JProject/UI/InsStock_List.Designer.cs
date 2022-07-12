
namespace JProject.UI
{
    partial class InsStock_List
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
            this.txtSearchInsStock = new System.Windows.Forms.TextBox();
            this.dgvInsStockList = new System.Windows.Forms.DataGridView();
            this.lblHeader1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsStockList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchAgent
            // 
            this.lblSearchAgent.AutoSize = true;
            this.lblSearchAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchAgent.Location = new System.Drawing.Point(52, 94);
            this.lblSearchAgent.Name = "lblSearchAgent";
            this.lblSearchAgent.Size = new System.Drawing.Size(68, 20);
            this.lblSearchAgent.TabIndex = 44;
            this.lblSearchAgent.Text = "Search";
            // 
            // txtSearchInsStock
            // 
            this.txtSearchInsStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchInsStock.Location = new System.Drawing.Point(164, 94);
            this.txtSearchInsStock.Name = "txtSearchInsStock";
            this.txtSearchInsStock.Size = new System.Drawing.Size(295, 27);
            this.txtSearchInsStock.TabIndex = 45;
            this.txtSearchInsStock.TextChanged += new System.EventHandler(this.txtSearchInsStock_TextChanged);
            // 
            // dgvInsStockList
            // 
            this.dgvInsStockList.AllowUserToAddRows = false;
            this.dgvInsStockList.AllowUserToDeleteRows = false;
            this.dgvInsStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsStockList.Location = new System.Drawing.Point(42, 153);
            this.dgvInsStockList.Name = "dgvInsStockList";
            this.dgvInsStockList.ReadOnly = true;
            this.dgvInsStockList.RowHeadersWidth = 51;
            this.dgvInsStockList.RowTemplate.Height = 24;
            this.dgvInsStockList.Size = new System.Drawing.Size(621, 424);
            this.dgvInsStockList.TabIndex = 43;
            // 
            // lblHeader1
            // 
            this.lblHeader1.AutoSize = true;
            this.lblHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader1.ForeColor = System.Drawing.Color.Navy;
            this.lblHeader1.Location = new System.Drawing.Point(228, 9);
            this.lblHeader1.Name = "lblHeader1";
            this.lblHeader1.Size = new System.Drawing.Size(281, 32);
            this.lblHeader1.TabIndex = 42;
            this.lblHeader1.Text = "Instant Ticket Stock";
            // 
            // InsStock_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(702, 603);
            this.Controls.Add(this.lblSearchAgent);
            this.Controls.Add(this.txtSearchInsStock);
            this.Controls.Add(this.dgvInsStockList);
            this.Controls.Add(this.lblHeader1);
            this.Name = "InsStock_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsStock_List";
            this.Load += new System.EventHandler(this.InsStock_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsStockList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchAgent;
        private System.Windows.Forms.TextBox txtSearchInsStock;
        private System.Windows.Forms.DataGridView dgvInsStockList;
        private System.Windows.Forms.Label lblHeader1;
    }
}