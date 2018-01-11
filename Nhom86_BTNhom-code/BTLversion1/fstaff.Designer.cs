namespace BTLversion1
{
    partial class fstaff
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
            this.btn_chamcong = new System.Windows.Forms.Button();
            this.dgv_nhanvien = new System.Windows.Forms.DataGridView();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tencv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_luong = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_timkiem_ten = new System.Windows.Forms.TextBox();
            this.txt_timkiem_ma = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_xem = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.cbx_macv = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btn_chamcong);
            this.panel1.Controls.Add(this.dgv_nhanvien);
            this.panel1.Controls.Add(this.btn_luong);
            this.panel1.Controls.Add(this.tableLayoutPanel5);
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 462);
            this.panel1.TabIndex = 1;
            // 
            // btn_chamcong
            // 
            this.btn_chamcong.BackColor = System.Drawing.Color.Gray;
            this.btn_chamcong.Location = new System.Drawing.Point(503, 55);
            this.btn_chamcong.Name = "btn_chamcong";
            this.btn_chamcong.Size = new System.Drawing.Size(81, 41);
            this.btn_chamcong.TabIndex = 11;
            this.btn_chamcong.Text = "Chấm Công ";
            this.btn_chamcong.UseVisualStyleBackColor = false;
            this.btn_chamcong.Click += new System.EventHandler(this.btn_chamcong_Click);
            // 
            // dgv_nhanvien
            // 
            this.dgv_nhanvien.AllowUserToAddRows = false;
            this.dgv_nhanvien.AllowUserToDeleteRows = false;
            this.dgv_nhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.tennv,
            this.ngaysinh,
            this.diachi,
            this.sdt,
            this.tencv});
            this.dgv_nhanvien.Location = new System.Drawing.Point(6, 152);
            this.dgv_nhanvien.Name = "dgv_nhanvien";
            this.dgv_nhanvien.Size = new System.Drawing.Size(481, 297);
            this.dgv_nhanvien.TabIndex = 0;
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã Nhân Viên";
            this.manv.Name = "manv";
            // 
            // tennv
            // 
            this.tennv.DataPropertyName = "tennv";
            this.tennv.HeaderText = "Tên Nhân Viên";
            this.tennv.Name = "tennv";
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày Sinh";
            this.ngaysinh.Name = "ngaysinh";
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.Name = "diachi";
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Số Điện Thoại";
            this.sdt.Name = "sdt";
            // 
            // tencv
            // 
            this.tencv.DataPropertyName = "tencv";
            this.tencv.HeaderText = "Tên Chức Vụ";
            this.tencv.Name = "tencv";
            // 
            // btn_luong
            // 
            this.btn_luong.BackColor = System.Drawing.Color.Gray;
            this.btn_luong.Location = new System.Drawing.Point(590, 55);
            this.btn_luong.Name = "btn_luong";
            this.btn_luong.Size = new System.Drawing.Size(78, 41);
            this.btn_luong.TabIndex = 9;
            this.btn_luong.Text = "Lương";
            this.btn_luong.UseVisualStyleBackColor = false;
            this.btn_luong.Click += new System.EventHandler(this.btn_luong_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.txt_timkiem_ten, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.txt_timkiem_ma, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(606, 315);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(233, 134);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // txt_timkiem_ten
            // 
            this.txt_timkiem_ten.Location = new System.Drawing.Point(3, 70);
            this.txt_timkiem_ten.Name = "txt_timkiem_ten";
            this.txt_timkiem_ten.Size = new System.Drawing.Size(227, 20);
            this.txt_timkiem_ten.TabIndex = 6;
            // 
            // txt_timkiem_ma
            // 
            this.txt_timkiem_ma.Location = new System.Drawing.Point(3, 3);
            this.txt_timkiem_ma.Name = "txt_timkiem_ma";
            this.txt_timkiem_ma.Size = new System.Drawing.Size(227, 20);
            this.txt_timkiem_ma.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.button4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(503, 249);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(81, 200);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.Location = new System.Drawing.Point(3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 42);
            this.button4.TabIndex = 1;
            this.button4.Text = "Tìm Kiếm";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 26);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tên Nhân Viên ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Mã Nhân Viên ";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Controls.Add(this.btn_them, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_xoa, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_xem, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_sua, 3, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(503, 99);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(339, 43);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Gray;
            this.btn_them.Location = new System.Drawing.Point(3, 3);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(78, 37);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Gray;
            this.btn_xoa.Location = new System.Drawing.Point(87, 3);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(78, 37);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_xem
            // 
            this.btn_xem.BackColor = System.Drawing.Color.Gray;
            this.btn_xem.Location = new System.Drawing.Point(171, 3);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(78, 37);
            this.btn_xem.TabIndex = 10;
            this.btn_xem.Text = "Xem";
            this.btn_xem.UseVisualStyleBackColor = false;
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Gray;
            this.btn_sua.Location = new System.Drawing.Point(255, 3);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(81, 37);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.txt_sdt, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.txt_diachi, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txt_tennv, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_manv, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtp_ngaysinh, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbx_macv, 0, 5);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(136, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(351, 143);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(3, 95);
            this.txt_sdt.Multiline = true;
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(345, 17);
            this.txt_sdt.TabIndex = 4;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(3, 72);
            this.txt_diachi.Multiline = true;
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(345, 17);
            this.txt_diachi.TabIndex = 3;
            // 
            // txt_tennv
            // 
            this.txt_tennv.Location = new System.Drawing.Point(3, 26);
            this.txt_tennv.Multiline = true;
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(345, 17);
            this.txt_tennv.TabIndex = 1;
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(3, 3);
            this.txt_manv.Multiline = true;
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.ReadOnly = true;
            this.txt_manv.Size = new System.Drawing.Size(345, 17);
            this.txt_manv.TabIndex = 0;
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Location = new System.Drawing.Point(3, 49);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(200, 20);
            this.dtp_ngaysinh.TabIndex = 6;
            // 
            // cbx_macv
            // 
            this.cbx_macv.FormattingEnabled = true;
            this.cbx_macv.Location = new System.Drawing.Point(3, 118);
            this.cbx_macv.Name = "cbx_macv";
            this.cbx_macv.Size = new System.Drawing.Size(345, 21);
            this.cbx_macv.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(127, 143);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tên Chức Vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa Chỉ ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày Sinh ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Nhân Viên ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Nhân Viên ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số Điện Thoại ";
            // 
            // fstaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 462);
            this.Controls.Add(this.panel1);
            this.Name = "fstaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_nhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencv;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox txt_timkiem_ten;
        private System.Windows.Forms.TextBox txt_timkiem_ma;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_xem;
        private System.Windows.Forms.Button btn_luong;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.ComboBox cbx_macv;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_chamcong;
    }
}