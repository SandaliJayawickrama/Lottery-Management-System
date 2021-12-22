
namespace JProject.UI
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.combotype = new System.Windows.Forms.ComboBox();
            this.lbltype = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lbltype);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.combotype);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Controls.Add(this.lblpassword);
            this.panel1.Controls.Add(this.txtusername);
            this.panel1.Controls.Add(this.lblusername);
            this.panel1.Location = new System.Drawing.Point(54, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 438);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(203, 13);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(62, 24);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Login";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(43, 109);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(91, 20);
            this.lblusername.TabIndex = 2;
            this.lblusername.Text = "User name";
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(148, 106);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(253, 27);
            this.txtusername.TabIndex = 3;
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(148, 161);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(253, 27);
            this.txtpassword.TabIndex = 5;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(43, 164);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(83, 20);
            this.lblpassword.TabIndex = 4;
            this.lblpassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(148, 303);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(176, 58);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // combotype
            // 
            this.combotype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combotype.FormattingEnabled = true;
            this.combotype.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.combotype.Location = new System.Drawing.Point(148, 214);
            this.combotype.Name = "combotype";
            this.combotype.Size = new System.Drawing.Size(253, 28);
            this.combotype.TabIndex = 7;
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltype.Location = new System.Drawing.Point(40, 217);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(86, 20);
            this.lbltype.TabIndex = 8;
            this.lbltype.Text = "User Type";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(558, 515);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.ComboBox combotype;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblpassword;
    }
}