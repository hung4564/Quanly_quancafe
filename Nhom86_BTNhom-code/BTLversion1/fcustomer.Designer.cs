namespace BTLversion1
{
    partial class fcustomer
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
            this.dgv_khachhang = new System.Windows.Forms.DataGridView();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_timkiem_ten = new System.Windows.Forms.TextBox();
            this.txt_timkiem_ma = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_xem = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtb_loaikh = new System.Windows.Forms.TextBox();
            this.txtb_sdt = new System.Windows.Forms.TextBox();
            this.txtb_tenkh = new System.Windows.Forms.TextBox();
            this.txtb_makh = new System.Windows.Forms.TextBox();
            this.txtb_diachi = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khachhang)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_khachhang);
            this.panel1.Controls.Add(this.tableLayoutPanel5);
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 749);
            this.panel1.TabIndex = 2;
            // 
            // dgv_khachhang
            // 
            this.dgv_khachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_khachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makh,
            this.tenkh,
            this.diachi,
            this.sdt,
            this.loaiKH});
            this.dgv_khachhang.Location = new System.Drawing.Point(12, 155);
            this.dgv_khachhang.Name = "dgv_khachhang";
            this.dgv_khachhang.Size = new System.Drawing.Size(484, 300);
            this.dgv_khachhang.TabIndex = 0;
            // 
            // makh
            // 
            this.makh.DataPropertyName = "makh";
            this.makh.HeaderText = "Mã";
            this.makh.Name = "makh";
            // 
            // tenkh
            // 
            this.tenkh.DataPropertyName = "tenkh";
            this.tenkh.HeaderText = "Tên khách hàng";
            this.tenkh.Name = "tenkh";
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Số điện loại";
            this.sdt.Name = "sdt";
            // 
            // loaiKH
            // 
            this.loaiKH.DataPropertyName = "loaiKH";
            this.loaiKH.HeaderText = "Loại khách hàng";
            this.loaiKH.Name = "loaiKH";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.txt_timkiem_ten, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.txt_timkiem_ma, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(598, 321);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(256, 134);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // txt_timkiem_ten
            // 
            this.txt_timkiem_ten.Location = new System.Drawing.Point(3, 70);
            this.txt_timkiem_ten.Multiline = true;
            this.txt_timkiem_ten.Name = "txt_timkiem_ten";
            this.txt_timkiem_ten.Size = new System.Drawing.Size(250, 24);
            this.txt_timkiem_ten.TabIndex = 6;
            // 
            // txt_timkiem_ma
            // 
            this.txt_timkiem_ma.Location = new System.Drawing.Point(3, 3);
            this.txt_timkiem_ma.Multiline = true;
            this.txt_timkiem_ma.Name = "txt_timkiem_ma";
            this.txt_timkiem_ma.Size = new System.Drawing.Size(250, 24);
            this.txt_timkiem_ma.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.button4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(505, 255);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(87, 200);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 41);
            this.button4.TabIndex = 1;
            this.button4.Text = "Tìm Kiếm ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 26);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tên Khách Hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 26);
            this.label8.TabIndex = 4;
            this.label8.Text = "Mã Khách Hàng ";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.btn_xem, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_xoa, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_sua, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_them, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(502, 102);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(352, 47);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btn_xem
            // 
            this.btn_xem.Location = new System.Drawing.Point(91, 3);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(82, 41);
            this.btn_xem.TabIndex = 8;
            this.btn_xem.Text = "Xem";
            this.btn_xem.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(267, 3);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(82, 41);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(179, 3);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(82, 41);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(3, 3);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(82, 41);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.txtb_loaikh, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtb_sdt, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtb_tenkh, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtb_makh, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtb_diachi, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(145, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(351, 149);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // txtb_loaikh
            // 
            this.txtb_loaikh.Location = new System.Drawing.Point(3, 119);
            this.txtb_loaikh.Multiline = true;
            this.txtb_loaikh.Name = "txtb_loaikh";
            this.txtb_loaikh.Size = new System.Drawing.Size(345, 25);
            this.txtb_loaikh.TabIndex = 4;
            // 
            // txtb_sdt
            // 
            this.txtb_sdt.Location = new System.Drawing.Point(3, 90);
            this.txtb_sdt.Multiline = true;
            this.txtb_sdt.Name = "txtb_sdt";
            this.txtb_sdt.Size = new System.Drawing.Size(345, 23);
            this.txtb_sdt.TabIndex = 3;
            // 
            // txtb_tenkh
            // 
            this.txtb_tenkh.Location = new System.Drawing.Point(3, 32);
            this.txtb_tenkh.Multiline = true;
            this.txtb_tenkh.Name = "txtb_tenkh";
            this.txtb_tenkh.Size = new System.Drawing.Size(345, 23);
            this.txtb_tenkh.TabIndex = 1;
            // 
            // txtb_makh
            // 
            this.txtb_makh.Location = new System.Drawing.Point(3, 3);
            this.txtb_makh.Multiline = true;
            this.txtb_makh.Name = "txtb_makh";
            this.txtb_makh.ReadOnly = true;
            this.txtb_makh.Size = new System.Drawing.Size(345, 23);
            this.txtb_makh.TabIndex = 0;
            // 
            // txtb_diachi
            // 
            this.txtb_diachi.Location = new System.Drawing.Point(3, 61);
            this.txtb_diachi.Multiline = true;
            this.txtb_diachi.Name = "txtb_diachi";
            this.txtb_diachi.Size = new System.Drawing.Size(345, 23);
            this.txtb_diachi.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(127, 146);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa Chỉ ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Loại Khách Hàng";
            // 
            // fcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(858, 462);
            this.Controls.Add(this.panel1);
            this.Name = "fcustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách Hàng";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khachhang)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox txt_timkiem_ten;
        private System.Windows.Forms.TextBox txt_timkiem_ma;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_khachhang;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtb_sdt;
        private System.Windows.Forms.TextBox txtb_tenkh;
        private System.Windows.Forms.TextBox txtb_makh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtb_loaikh;
        private System.Windows.Forms.TextBox txtb_diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiKH;
        private System.Windows.Forms.Button btn_xem;
    }
}