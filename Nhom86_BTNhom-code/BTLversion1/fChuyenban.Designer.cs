namespace BTLversion1
{
    partial class fChuyenban
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
            this.bt_quaylai = new System.Windows.Forms.Button();
            this.bt_chuyen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_goc = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_chuyen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_quaylai
            // 
            this.bt_quaylai.BackColor = System.Drawing.Color.Gray;
            this.bt_quaylai.Location = new System.Drawing.Point(76, 142);
            this.bt_quaylai.Name = "bt_quaylai";
            this.bt_quaylai.Size = new System.Drawing.Size(115, 41);
            this.bt_quaylai.TabIndex = 10;
            this.bt_quaylai.Text = "Quay lại";
            this.bt_quaylai.UseVisualStyleBackColor = false;
            this.bt_quaylai.Click += new System.EventHandler(this.bt_quaylai_Click);
            // 
            // bt_chuyen
            // 
            this.bt_chuyen.BackColor = System.Drawing.Color.Gray;
            this.bt_chuyen.Location = new System.Drawing.Point(231, 142);
            this.bt_chuyen.Name = "bt_chuyen";
            this.bt_chuyen.Size = new System.Drawing.Size(115, 41);
            this.bt_chuyen.TabIndex = 11;
            this.bt_chuyen.Text = "Xác nhận chuyển";
            this.bt_chuyen.UseVisualStyleBackColor = false;
            this.bt_chuyen.Click += new System.EventHandler(this.bt_chuyen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bàn gốc";
            // 
            // cb_goc
            // 
            this.cb_goc.FormattingEnabled = true;
            this.cb_goc.Location = new System.Drawing.Point(23, 51);
            this.cb_goc.Name = "cb_goc";
            this.cb_goc.Size = new System.Drawing.Size(121, 21);
            this.cb_goc.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_goc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 100);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cb_chuyen);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(231, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 100);
            this.panel2.TabIndex = 14;
            // 
            // cb_chuyen
            // 
            this.cb_chuyen.FormattingEnabled = true;
            this.cb_chuyen.Location = new System.Drawing.Point(23, 51);
            this.cb_chuyen.Name = "cb_chuyen";
            this.cb_chuyen.Size = new System.Drawing.Size(121, 21);
            this.cb_chuyen.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bàn chuyển";
            // 
            // fChuyenban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(423, 215);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_chuyen);
            this.Controls.Add(this.bt_quaylai);
            this.Name = "fChuyenban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chuyển Bàn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_quaylai;
        private System.Windows.Forms.Button bt_chuyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_goc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_chuyen;
        private System.Windows.Forms.Label label2;
    }
}