
namespace JProject.UI
{
    partial class FrmUsers
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
            this.lblUN = new System.Windows.Forms.Label();
            this.txtUN = new System.Windows.Forms.TextBox();
            this.txtPSWD = new System.Windows.Forms.TextBox();
            this.lblPSWD = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.comboUtype = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblHeader1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUN
            // 
            this.lblUN.AutoSize = true;
            this.lblUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUN.Location = new System.Drawing.Point(12, 174);
            this.lblUN.Name = "lblUN";
            this.lblUN.Size = new System.Drawing.Size(102, 24);
            this.lblUN.TabIndex = 0;
            this.lblUN.Text = "User name";
            // 
            // txtUN
            // 
            this.txtUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUN.Location = new System.Drawing.Point(115, 171);
            this.txtUN.Name = "txtUN";
            this.txtUN.Size = new System.Drawing.Size(309, 28);
            this.txtUN.TabIndex = 1;
            // 
            // txtPSWD
            // 
            this.txtPSWD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPSWD.Location = new System.Drawing.Point(116, 292);
            this.txtPSWD.Name = "txtPSWD";
            this.txtPSWD.Size = new System.Drawing.Size(309, 28);
            this.txtPSWD.TabIndex = 3;
            // 
            // lblPSWD
            // 
            this.lblPSWD.AutoSize = true;
            this.lblPSWD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSWD.Location = new System.Drawing.Point(13, 295);
            this.lblPSWD.Name = "lblPSWD";
            this.lblPSWD.Size = new System.Drawing.Size(92, 24);
            this.lblPSWD.TabIndex = 2;
            this.lblPSWD.Text = "Password";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(115, 232);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(309, 28);
            this.txtPhone.TabIndex = 5;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(12, 235);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(93, 24);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone no";
            // 
            // comboUtype
            // 
            this.comboUtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboUtype.FormattingEnabled = true;
            this.comboUtype.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.comboUtype.Location = new System.Drawing.Point(115, 110);
            this.comboUtype.Name = "comboUtype";
            this.comboUtype.Size = new System.Drawing.Size(309, 30);
            this.comboUtype.TabIndex = 6;
            this.comboUtype.SelectedIndexChanged += new System.EventHandler(this.comboUtype_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(12, 110);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(97, 24);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "User Type";
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(463, 144);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowTemplate.Height = 24;
            this.dgvUser.Size = new System.Drawing.Size(741, 452);
            this.dgvUser.TabIndex = 8;
            this.dgvUser.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUser_RowHeaderMouseDoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(584, 84);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(548, 28);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(508, 88);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(70, 24);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "Search";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(152, 393);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(187, 50);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(352, 654);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 50);
            this.button1.TabIndex = 12;
            this.button1.Text = "Upate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightPink;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(624, 654);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 50);
            this.button2.TabIndex = 13;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblHeader1
            // 
            this.lblHeader1.AutoSize = true;
            this.lblHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader1.ForeColor = System.Drawing.Color.Teal;
            this.lblHeader1.Location = new System.Drawing.Point(566, 9);
            this.lblHeader1.Name = "lblHeader1";
            this.lblHeader1.Size = new System.Drawing.Size(93, 32);
            this.lblHeader1.TabIndex = 31;
            this.lblHeader1.Text = "Users";
            // 
            // FrmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1216, 775);
            this.Controls.Add(this.lblHeader1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.comboUtype);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPSWD);
            this.Controls.Add(this.lblPSWD);
            this.Controls.Add(this.txtUN);
            this.Controls.Add(this.lblUN);
            this.Name = "FrmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.FrmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUN;
        private System.Windows.Forms.TextBox txtUN;
        private System.Windows.Forms.TextBox txtPSWD;
        private System.Windows.Forms.Label lblPSWD;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.ComboBox comboUtype;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblHeader1;
    }
}