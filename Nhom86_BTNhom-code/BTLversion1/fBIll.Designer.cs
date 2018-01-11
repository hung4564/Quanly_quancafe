namespace BTLversion1
{
    partial class fBIll
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
            this.flp_food = new System.Windows.Forms.FlowLayoutPanel();
            this.lv_bill = new System.Windows.Forms.ListView();
            this.Tensp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dongia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtb_MaPT = new System.Windows.Forms.TextBox();
            this.txt_Giovao = new System.Windows.Forms.TextBox();
            this.txtb_NV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.txt_phantram = new System.Windows.Forms.GroupBox();
            this.nd_phantram = new System.Windows.Forms.NumericUpDown();
            this.txtb_thanhtien = new System.Windows.Forms.TextBox();
            this.txtb_sum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bt_gọi = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.txt_phantram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nd_phantram)).BeginInit();
            this.SuspendLayout();
            // 
            // flp_food
            // 
            this.flp_food.Location = new System.Drawing.Point(281, 118);
            this.flp_food.Name = "flp_food";
            this.flp_food.Size = new System.Drawing.Size(574, 332);
            this.flp_food.TabIndex = 0;
            // 
            // lv_bill
            // 
            this.lv_bill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tensp,
            this.Soluong,
            this.dongia});
            this.lv_bill.Location = new System.Drawing.Point(12, 157);
            this.lv_bill.MultiSelect = false;
            this.lv_bill.Name = "lv_bill";
            this.lv_bill.Size = new System.Drawing.Size(263, 293);
            this.lv_bill.TabIndex = 0;
            this.lv_bill.UseCompatibleStateImageBehavior = false;
            this.lv_bill.View = System.Windows.Forms.View.Details;
            this.lv_bill.Click += new System.EventHandler(this.lv_bill_Click);
            // 
            // Tensp
            // 
            this.Tensp.Text = "Tên sản phẩm";
            this.Tensp.Width = 132;
            // 
            // Soluong
            // 
            this.Soluong.Text = "Số Lượng";
            this.Soluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dongia
            // 
            this.dongia.Text = "Đơn Giá";
            this.dongia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtb_MaPT);
            this.groupBox1.Controls.Add(this.txt_Giovao);
            this.groupBox1.Controls.Add(this.txtb_NV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(281, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtb_MaPT
            // 
            this.txtb_MaPT.Location = new System.Drawing.Point(258, 50);
            this.txtb_MaPT.Name = "txtb_MaPT";
            this.txtb_MaPT.ReadOnly = true;
            this.txtb_MaPT.Size = new System.Drawing.Size(100, 20);
            this.txtb_MaPT.TabIndex = 7;
            // 
            // txt_Giovao
            // 
            this.txt_Giovao.Location = new System.Drawing.Point(87, 50);
            this.txt_Giovao.Name = "txt_Giovao";
            this.txt_Giovao.ReadOnly = true;
            this.txt_Giovao.Size = new System.Drawing.Size(100, 20);
            this.txt_Giovao.TabIndex = 6;
            // 
            // txtb_NV
            // 
            this.txtb_NV.Location = new System.Drawing.Point(258, 21);
            this.txtb_NV.Name = "txtb_NV";
            this.txtb_NV.ReadOnly = true;
            this.txtb_NV.Size = new System.Drawing.Size(100, 20);
            this.txtb_NV.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã hóa đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giờ vào:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khách Hàng:";
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.BackColor = System.Drawing.Color.Gray;
            this.btn_thanhtoan.Location = new System.Drawing.Point(657, 70);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(115, 41);
            this.btn_thanhtoan.TabIndex = 8;
            this.btn_thanhtoan.Text = "Thanh toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = false;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // txt_phantram
            // 
            this.txt_phantram.Controls.Add(this.nd_phantram);
            this.txt_phantram.Controls.Add(this.txtb_thanhtien);
            this.txt_phantram.Controls.Add(this.txtb_sum);
            this.txt_phantram.Controls.Add(this.label6);
            this.txt_phantram.Controls.Add(this.label7);
            this.txt_phantram.Controls.Add(this.label9);
            this.txt_phantram.Location = new System.Drawing.Point(15, 46);
            this.txt_phantram.Name = "txt_phantram";
            this.txt_phantram.Size = new System.Drawing.Size(260, 105);
            this.txt_phantram.TabIndex = 8;
            this.txt_phantram.TabStop = false;
            // 
            // nd_phantram
            // 
            this.nd_phantram.Location = new System.Drawing.Point(117, 45);
            this.nd_phantram.Name = "nd_phantram";
            this.nd_phantram.Size = new System.Drawing.Size(100, 20);
            this.nd_phantram.TabIndex = 8;
            this.nd_phantram.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nd_phantram.ValueChanged += new System.EventHandler(this.nd_phantram_ValueChanged);
            // 
            // txtb_thanhtien
            // 
            this.txtb_thanhtien.Location = new System.Drawing.Point(117, 72);
            this.txtb_thanhtien.Name = "txtb_thanhtien";
            this.txtb_thanhtien.ReadOnly = true;
            this.txtb_thanhtien.Size = new System.Drawing.Size(100, 20);
            this.txtb_thanhtien.TabIndex = 7;
            this.txtb_thanhtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtb_sum
            // 
            this.txtb_sum.Location = new System.Drawing.Point(117, 21);
            this.txtb_sum.Name = "txtb_sum";
            this.txtb_sum.ReadOnly = true;
            this.txtb_sum.Size = new System.Drawing.Size(100, 20);
            this.txtb_sum.TabIndex = 6;
            this.txtb_sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Giảm giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Thành tiền";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tổng cộng:";
            // 
            // bt_gọi
            // 
            this.bt_gọi.BackColor = System.Drawing.Color.Gray;
            this.bt_gọi.Location = new System.Drawing.Point(657, 19);
            this.bt_gọi.Name = "bt_gọi";
            this.bt_gọi.Size = new System.Drawing.Size(115, 41);
            this.bt_gọi.TabIndex = 9;
            this.bt_gọi.Text = "Xác nhận gọi";
            this.bt_gọi.UseVisualStyleBackColor = false;
            this.bt_gọi.Click += new System.EventHandler(this.bt_gọi_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(87, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // fBIll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(858, 462);
            this.Controls.Add(this.bt_gọi);
            this.Controls.Add(this.txt_phantram);
            this.Controls.Add(this.btn_thanhtoan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_bill);
            this.Controls.Add(this.flp_food);
            this.Name = "fBIll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.txt_phantram.ResumeLayout(false);
            this.txt_phantram.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nd_phantram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_food;
        private System.Windows.Forms.ListView lv_bill;
        private System.Windows.Forms.ColumnHeader Tensp;
        private System.Windows.Forms.ColumnHeader Soluong;
        private System.Windows.Forms.ColumnHeader dongia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_MaPT;
        private System.Windows.Forms.TextBox txt_Giovao;
        private System.Windows.Forms.TextBox txtb_NV;
        private System.Windows.Forms.Button btn_thanhtoan;
        private System.Windows.Forms.GroupBox txt_phantram;
        private System.Windows.Forms.TextBox txtb_thanhtien;
        private System.Windows.Forms.TextBox txtb_sum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_gọi;
        private System.Windows.Forms.NumericUpDown nd_phantram;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}