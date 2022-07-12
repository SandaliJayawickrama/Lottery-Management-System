
namespace JProject.UI
{
    partial class Agent_List
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
            this.dgvAgentList = new System.Windows.Forms.DataGridView();
            this.lblSearchAgent = new System.Windows.Forms.Label();
            this.txtSearchAgent = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgentList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader1
            // 
            this.lblHeader1.AutoSize = true;
            this.lblHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader1.ForeColor = System.Drawing.Color.Navy;
            this.lblHeader1.Location = new System.Drawing.Point(553, 9);
            this.lblHeader1.Name = "lblHeader1";
            this.lblHeader1.Size = new System.Drawing.Size(167, 32);
            this.lblHeader1.TabIndex = 34;
            this.lblHeader1.Text = "Agents List";
            // 
            // dgvAgentList
            // 
            this.dgvAgentList.AllowUserToAddRows = false;
            this.dgvAgentList.AllowUserToDeleteRows = false;
            this.dgvAgentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgentList.Location = new System.Drawing.Point(37, 135);
            this.dgvAgentList.Name = "dgvAgentList";
            this.dgvAgentList.ReadOnly = true;
            this.dgvAgentList.RowHeadersWidth = 51;
            this.dgvAgentList.RowTemplate.Height = 24;
            this.dgvAgentList.Size = new System.Drawing.Size(1230, 557);
            this.dgvAgentList.TabIndex = 35;
            this.dgvAgentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgentList_CellContentClick);
            // 
            // lblSearchAgent
            // 
            this.lblSearchAgent.AutoSize = true;
            this.lblSearchAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchAgent.Location = new System.Drawing.Point(47, 76);
            this.lblSearchAgent.Name = "lblSearchAgent";
            this.lblSearchAgent.Size = new System.Drawing.Size(122, 20);
            this.lblSearchAgent.TabIndex = 36;
            this.lblSearchAgent.Text = "Search Agent";
            // 
            // txtSearchAgent
            // 
            this.txtSearchAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAgent.Location = new System.Drawing.Point(192, 76);
            this.txtSearchAgent.Name = "txtSearchAgent";
            this.txtSearchAgent.Size = new System.Drawing.Size(295, 27);
            this.txtSearchAgent.TabIndex = 37;
            this.txtSearchAgent.TextChanged += new System.EventHandler(this.txtSearchAgent_TextChanged);
            // 
            // Agent_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1311, 724);
            this.Controls.Add(this.lblSearchAgent);
            this.Controls.Add(this.txtSearchAgent);
            this.Controls.Add(this.dgvAgentList);
            this.Controls.Add(this.lblHeader1);
            this.Name = "Agent_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agent_List";
            this.Load += new System.EventHandler(this.Agent_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader1;
        private System.Windows.Forms.DataGridView dgvAgentList;
        private System.Windows.Forms.Label lblSearchAgent;
        private System.Windows.Forms.TextBox txtSearchAgent;
    }
}