namespace BTLversion1
{
    partial class fHoadon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtb_tralai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtb_khachdua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_sum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_huy = new System.Windows.Forms.Button();
            this.flp_banphim = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_tienngan = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtb_tralai);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtb_khachdua);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtb_sum);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(150, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 105);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // txtb_tralai
            // 
            this.txtb_tralai.Location = new System.Drawing.Point(98, 76);
            this.txtb_tralai.Name = "txtb_tralai";
            this.txtb_tralai.ReadOnly = true;
            this.txtb_tralai.Size = new System.Drawing.Size(100, 20);
            this.txtb_tralai.TabIndex = 13;
            this.txtb_tralai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Trả lại";
            // 
            // txtb_khachdua
            // 
            this.txtb_khachdua.Location = new System.Drawing.Point(98, 48);
            this.txtb_khachdua.Name = "txtb_khachdua";
            this.txtb_khachdua.Size = new System.Drawing.Size(100, 20);
            this.txtb_khachdua.TabIndex = 11;
            this.txtb_khachdua.Text = "0";
            this.txtb_khachdua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtb_khachdua.TextChanged += new System.EventHandler(this.txtb_khachdua_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Khách đưa";
            // 
            // txtb_sum
            // 
            this.txtb_sum.Location = new System.Drawing.Point(98, 16);
            this.txtb_sum.Name = "txtb_sum";
            this.txtb_sum.ReadOnly = true;
            this.txtb_sum.Size = new System.Drawing.Size(100, 20);
            this.txtb_sum.TabIndex = 6;
            this.txtb_sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tổng cộng:";
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.BackColor = System.Drawing.Color.Gray;
            this.btn_thanhtoan.Location = new System.Drawing.Point(266, 167);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(109, 41);
            this.btn_thanhtoan.TabIndex = 11;
            this.btn_thanhtoan.Text = "Thanh toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = false;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(1, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Thanh toán hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // bt_huy
            // 
            this.bt_huy.BackColor = System.Drawing.Color.Gray;
            this.bt_huy.Location = new System.Drawing.Point(266, 223);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(109, 41);
            this.bt_huy.TabIndex = 16;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.UseVisualStyleBackColor = false;
            this.bt_huy.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // flp_banphim
            // 
            this.flp_banphim.Location = new System.Drawing.Point(105, 136);
            this.flp_banphim.Name = "flp_banphim";
            this.flp_banphim.Size = new System.Drawing.Size(155, 165);
            this.flp_banphim.TabIndex = 17;
            // 
            // flp_tienngan
            // 
            this.flp_tienngan.Location = new System.Drawing.Point(12, 136);
            this.flp_tienngan.Name = "flp_tienngan";
            this.flp_tienngan.Size = new System.Drawing.Size(87, 165);
            this.flp_tienngan.TabIndex = 18;
            // 
            // fHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(390, 313);
            this.Controls.Add(this.flp_tienngan);
            this.Controls.Add(this.flp_banphim);
            this.Controls.Add(this.bt_huy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_thanhtoan);
            this.Controls.Add(this.groupBox1);
            this.Name = "fHoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fHoadon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtb_sum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtb_tralai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtb_khachdua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_thanhtoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.FlowLayoutPanel flp_banphim;
        private System.Windows.Forms.FlowLayoutPanel flp_tienngan;
    }
}