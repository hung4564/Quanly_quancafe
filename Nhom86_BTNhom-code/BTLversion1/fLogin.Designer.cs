namespace BTLversion1
{
    partial class fLogin
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
            this.panelusername = new System.Windows.Forms.Panel();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.panelpassword = new System.Windows.Forms.Panel();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.panelbutton = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.panelusername.SuspendLayout();
            this.panelpassword.SuspendLayout();
            this.panelbutton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelusername
            // 
            this.panelusername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelusername.Controls.Add(this.txt_username);
            this.panelusername.Controls.Add(this.lbl_username);
            this.panelusername.Location = new System.Drawing.Point(2, 12);
            this.panelusername.Name = "panelusername";
            this.panelusername.Size = new System.Drawing.Size(495, 61);
            this.panelusername.TabIndex = 0;
            // 
            // txt_username
            // 
            this.txt_username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_username.Location = new System.Drawing.Point(200, 34);
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(270, 23);
            this.txt_username.TabIndex = 1;
            this.txt_username.Text = "admin";
            // 
            // lbl_username
            // 
            this.lbl_username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(3, 30);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(158, 31);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "User Name ";
            // 
            // panelpassword
            // 
            this.panelpassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelpassword.Controls.Add(this.txt_password);
            this.panelpassword.Controls.Add(this.lbl_password);
            this.panelpassword.Location = new System.Drawing.Point(2, 89);
            this.panelpassword.Name = "panelpassword";
            this.panelpassword.Size = new System.Drawing.Size(495, 59);
            this.panelpassword.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_password.Location = new System.Drawing.Point(200, 34);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(270, 21);
            this.txt_password.TabIndex = 1;
            this.txt_password.Text = "1";
            // 
            // lbl_password
            // 
            this.lbl_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(3, 28);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(146, 31);
            this.lbl_password.TabIndex = 0;
            this.lbl_password.Text = "Pass Word";
            // 
            // panelbutton
            // 
            this.panelbutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelbutton.Controls.Add(this.btn_exit);
            this.panelbutton.Controls.Add(this.btn_login);
            this.panelbutton.Location = new System.Drawing.Point(37, 186);
            this.panelbutton.Name = "panelbutton";
            this.panelbutton.Size = new System.Drawing.Size(421, 41);
            this.panelbutton.TabIndex = 2;
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.Location = new System.Drawing.Point(285, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(136, 38);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_login
            // 
            this.btn_login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_login.Location = new System.Drawing.Point(0, 3);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(145, 38);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(499, 255);
            this.Controls.Add(this.panelbutton);
            this.Controls.Add(this.panelpassword);
            this.Controls.Add(this.panelusername);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.flogin_FormClosing);
            this.panelusername.ResumeLayout(false);
            this.panelusername.PerformLayout();
            this.panelpassword.ResumeLayout(false);
            this.panelpassword.PerformLayout();
            this.panelbutton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelusername;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Panel panelpassword;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Panel panelbutton;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_login;
    }
}