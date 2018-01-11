namespace BTLversion1
{
    partial class fTable
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
            this.flpanel_table = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_Chuyen = new System.Windows.Forms.Button();
            this.bt_quaylai = new System.Windows.Forms.Button();
            this.bt_thongtin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpanel_table
            // 
            this.flpanel_table.Location = new System.Drawing.Point(12, 12);
            this.flpanel_table.Name = "flpanel_table";
            this.flpanel_table.Size = new System.Drawing.Size(834, 332);
            this.flpanel_table.TabIndex = 0;
            // 
            // bt_Chuyen
            // 
            this.bt_Chuyen.BackColor = System.Drawing.Color.Gray;
            this.bt_Chuyen.Location = new System.Drawing.Point(388, 392);
            this.bt_Chuyen.Name = "bt_Chuyen";
            this.bt_Chuyen.Size = new System.Drawing.Size(115, 41);
            this.bt_Chuyen.TabIndex = 10;
            this.bt_Chuyen.Text = "Chuyển bàn";
            this.bt_Chuyen.UseVisualStyleBackColor = false;
            this.bt_Chuyen.Click += new System.EventHandler(this.bt_Chuyen_Click);
            // 
            // bt_quaylai
            // 
            this.bt_quaylai.BackColor = System.Drawing.Color.Gray;
            this.bt_quaylai.Location = new System.Drawing.Point(241, 392);
            this.bt_quaylai.Name = "bt_quaylai";
            this.bt_quaylai.Size = new System.Drawing.Size(115, 41);
            this.bt_quaylai.TabIndex = 13;
            this.bt_quaylai.Text = "Quay lại";
            this.bt_quaylai.UseVisualStyleBackColor = false;
            // 
            // bt_thongtin
            // 
            this.bt_thongtin.BackColor = System.Drawing.Color.Gray;
            this.bt_thongtin.Location = new System.Drawing.Point(532, 392);
            this.bt_thongtin.Name = "bt_thongtin";
            this.bt_thongtin.Size = new System.Drawing.Size(115, 41);
            this.bt_thongtin.TabIndex = 14;
            this.bt_thongtin.Text = "Thông Tin";
            this.bt_thongtin.UseVisualStyleBackColor = false;
            this.bt_thongtin.Click += new System.EventHandler(this.bt_thongtin_Click);
            // 
            // fTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(858, 462);
            this.Controls.Add(this.bt_thongtin);
            this.Controls.Add(this.bt_quaylai);
            this.Controls.Add(this.bt_Chuyen);
            this.Controls.Add(this.flpanel_table);
            this.Name = "fTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bàn";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpanel_table;
        private System.Windows.Forms.Button bt_Chuyen;
        private System.Windows.Forms.Button bt_quaylai;
        private System.Windows.Forms.Button bt_thongtin;
    }
}