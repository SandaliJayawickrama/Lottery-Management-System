
namespace JProject.UI
{
    partial class Ticket_List
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
            this.txtSearchTicket = new System.Windows.Forms.TextBox();
            this.dgvTicketList = new System.Windows.Forms.DataGridView();
            this.lblHeader1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchAgent
            // 
            this.lblSearchAgent.AutoSize = true;
            this.lblSearchAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchAgent.Location = new System.Drawing.Point(50, 88);
            this.lblSearchAgent.Name = "lblSearchAgent";
            this.lblSearchAgent.Size = new System.Drawing.Size(125, 20);
            this.lblSearchAgent.TabIndex = 40;
            this.lblSearchAgent.Text = "Search Ticket";
            // 
            // txtSearchTicket
            // 
            this.txtSearchTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTicket.Location = new System.Drawing.Point(195, 88);
            this.txtSearchTicket.Name = "txtSearchTicket";
            this.txtSearchTicket.Size = new System.Drawing.Size(295, 27);
            this.txtSearchTicket.TabIndex = 41;
            this.txtSearchTicket.TextChanged += new System.EventHandler(this.txtSearchTicket_TextChanged);
            // 
            // dgvTicketList
            // 
            this.dgvTicketList.AllowUserToAddRows = false;
            this.dgvTicketList.AllowUserToDeleteRows = false;
            this.dgvTicketList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicketList.Location = new System.Drawing.Point(40, 147);
            this.dgvTicketList.Name = "dgvTicketList";
            this.dgvTicketList.RowHeadersWidth = 51;
            this.dgvTicketList.RowTemplate.Height = 24;
            this.dgvTicketList.Size = new System.Drawing.Size(958, 557);
            this.dgvTicketList.TabIndex = 39;
            // 
            // lblHeader1
            // 
            this.lblHeader1.AutoSize = true;
            this.lblHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader1.ForeColor = System.Drawing.Color.Navy;
            this.lblHeader1.Location = new System.Drawing.Point(438, 9);
            this.lblHeader1.Name = "lblHeader1";
            this.lblHeader1.Size = new System.Drawing.Size(154, 32);
            this.lblHeader1.TabIndex = 38;
            this.lblHeader1.Text = "Ticket List";
            // 
            // Ticket_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1043, 724);
            this.Controls.Add(this.lblSearchAgent);
            this.Controls.Add(this.txtSearchTicket);
            this.Controls.Add(this.dgvTicketList);
            this.Controls.Add(this.lblHeader1);
            this.Name = "Ticket_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket_List";
            this.Load += new System.EventHandler(this.Ticket_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchAgent;
        private System.Windows.Forms.TextBox txtSearchTicket;
        private System.Windows.Forms.DataGridView dgvTicketList;
        private System.Windows.Forms.Label lblHeader1;
    }
}