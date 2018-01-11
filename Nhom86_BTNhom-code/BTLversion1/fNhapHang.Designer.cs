namespace BTLversion1
{
    partial class fNhapHang
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtb_gia = new System.Windows.Forms.TextBox();
            this.cd_nguyenlieu = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nd_soluong = new System.Windows.Forms.NumericUpDown();
            this.bt_nhap = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtb_sum = new System.Windows.Forms.TextBox();
            this.bt_xacnhan = new System.Windows.Forms.Button();
            this.lv_nhap = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtb_nhanvien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_ngaynhap = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_ncc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nd_soluong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtb_gia);
            this.groupBox1.Controls.Add(this.cd_nguyenlieu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nd_soluong);
            this.groupBox1.Controls.Add(this.bt_nhap);
            this.groupBox1.Location = new System.Drawing.Point(34, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 167);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nguyên liệu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nguyên liệu";
            // 
            // txtb_gia
            // 
            this.txtb_gia.Location = new System.Drawing.Point(98, 76);
            this.txtb_gia.Name = "txtb_gia";
            this.txtb_gia.Size = new System.Drawing.Size(121, 20);
            this.txtb_gia.TabIndex = 16;
            // 
            // cd_nguyenlieu
            // 
            this.cd_nguyenlieu.FormattingEnabled = true;
            this.cd_nguyenlieu.Location = new System.Drawing.Point(98, 19);
            this.cd_nguyenlieu.Name = "cd_nguyenlieu";
            this.cd_nguyenlieu.Size = new System.Drawing.Size(121, 21);
            this.cd_nguyenlieu.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Giá/nguyên liệu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số lượng";
            // 
            // nd_soluong
            // 
            this.nd_soluong.Location = new System.Drawing.Point(98, 50);
            this.nd_soluong.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nd_soluong.Name = "nd_soluong";
            this.nd_soluong.Size = new System.Drawing.Size(121, 20);
            this.nd_soluong.TabIndex = 9;
            // 
            // bt_nhap
            // 
            this.bt_nhap.Location = new System.Drawing.Point(98, 112);
            this.bt_nhap.Name = "bt_nhap";
            this.bt_nhap.Size = new System.Drawing.Size(121, 30);
            this.bt_nhap.TabIndex = 11;
            this.bt_nhap.Text = "Nhập nguyên liệu";
            this.bt_nhap.UseVisualStyleBackColor = true;
            this.bt_nhap.Click += new System.EventHandler(this.bt_nhap_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tổng tiền";
            // 
            // txtb_sum
            // 
            this.txtb_sum.Location = new System.Drawing.Point(392, 43);
            this.txtb_sum.Name = "txtb_sum";
            this.txtb_sum.Size = new System.Drawing.Size(100, 20);
            this.txtb_sum.TabIndex = 26;
            // 
            // bt_xacnhan
            // 
            this.bt_xacnhan.Location = new System.Drawing.Point(538, 43);
            this.bt_xacnhan.Name = "bt_xacnhan";
            this.bt_xacnhan.Size = new System.Drawing.Size(75, 23);
            this.bt_xacnhan.TabIndex = 25;
            this.bt_xacnhan.Text = "Xác nhận";
            this.bt_xacnhan.UseVisualStyleBackColor = true;
            this.bt_xacnhan.Click += new System.EventHandler(this.bt_xacnhan_Click);
            // 
            // lv_nhap
            // 
            this.lv_nhap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv_nhap.Location = new System.Drawing.Point(335, 85);
            this.lv_nhap.Name = "lv_nhap";
            this.lv_nhap.Size = new System.Drawing.Size(278, 242);
            this.lv_nhap.TabIndex = 24;
            this.lv_nhap.UseCompatibleStateImageBehavior = false;
            this.lv_nhap.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên nguyên liệu";
            this.columnHeader1.Width = 114;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "GIá tiền";
            this.columnHeader3.Width = 88;
            // 
            // txtb_nhanvien
            // 
            this.txtb_nhanvien.Location = new System.Drawing.Point(138, 122);
            this.txtb_nhanvien.Name = "txtb_nhanvien";
            this.txtb_nhanvien.Size = new System.Drawing.Size(121, 20);
            this.txtb_nhanvien.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nhân viện nhập";
            // 
            // dtp_ngaynhap
            // 
            this.dtp_ngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaynhap.Location = new System.Drawing.Point(136, 79);
            this.dtp_ngaynhap.Name = "dtp_ngaynhap";
            this.dtp_ngaynhap.Size = new System.Drawing.Size(123, 20);
            this.dtp_ngaynhap.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ngày nhập";
            // 
            // cb_ncc
            // 
            this.cb_ncc.FormattingEnabled = true;
            this.cb_ncc.Location = new System.Drawing.Point(138, 43);
            this.cb_ncc.Name = "cb_ncc";
            this.cb_ncc.Size = new System.Drawing.Size(121, 21);
            this.cb_ncc.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nhà cung cấp";
            // 
            // fNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(646, 370);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtb_sum);
            this.Controls.Add(this.bt_xacnhan);
            this.Controls.Add(this.lv_nhap);
            this.Controls.Add(this.txtb_nhanvien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_ngaynhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_ncc);
            this.Controls.Add(this.label1);
            this.Name = "fNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Hàng ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nd_soluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtb_gia;
        private System.Windows.Forms.ComboBox cd_nguyenlieu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nd_soluong;
        private System.Windows.Forms.Button bt_nhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtb_sum;
        private System.Windows.Forms.Button bt_xacnhan;
        private System.Windows.Forms.ListView lv_nhap;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtb_nhanvien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_ngaynhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_ncc;
        private System.Windows.Forms.Label label1;
    }
}