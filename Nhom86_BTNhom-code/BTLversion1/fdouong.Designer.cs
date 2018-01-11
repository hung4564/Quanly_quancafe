namespace BTLversion1
{
    partial class fdouong
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
            this.dgv_sanpham = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtb_timkiem_tensp = new System.Windows.Forms.TextBox();
            this.txtb_timkiem_masp = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_xem = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtb_dongia = new System.Windows.Forms.TextBox();
            this.txtb_tensp = new System.Windows.Forms.TextBox();
            this.txtb_masp = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).BeginInit();
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
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.dgv_sanpham);
            this.panel1.Controls.Add(this.tableLayoutPanel5);
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 462);
            this.panel1.TabIndex = 2;
            // 
            // dgv_sanpham
            // 
            this.dgv_sanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.dongia});
            this.dgv_sanpham.Location = new System.Drawing.Point(12, 101);
            this.dgv_sanpham.Name = "dgv_sanpham";
            this.dgv_sanpham.Size = new System.Drawing.Size(436, 356);
            this.dgv_sanpham.TabIndex = 0;
            // 
            // masp
            // 
            this.masp.DataPropertyName = "masp";
            this.masp.HeaderText = "Mã Sản Phẩm ";
            this.masp.Name = "masp";
            // 
            // tensp
            // 
            this.tensp.DataPropertyName = "tensp";
            this.tensp.HeaderText = "Tên Sản Phẩm ";
            this.tensp.Name = "tensp";
            // 
            // dongia
            // 
            this.dongia.DataPropertyName = "dongia";
            this.dongia.HeaderText = "Đơn Giá";
            this.dongia.Name = "dongia";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.txtb_timkiem_tensp, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.txtb_timkiem_masp, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(561, 316);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(282, 134);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // txtb_timkiem_tensp
            // 
            this.txtb_timkiem_tensp.Location = new System.Drawing.Point(3, 70);
            this.txtb_timkiem_tensp.Multiline = true;
            this.txtb_timkiem_tensp.Name = "txtb_timkiem_tensp";
            this.txtb_timkiem_tensp.Size = new System.Drawing.Size(276, 24);
            this.txtb_timkiem_tensp.TabIndex = 6;
            // 
            // txtb_timkiem_masp
            // 
            this.txtb_timkiem_masp.Location = new System.Drawing.Point(3, 3);
            this.txtb_timkiem_masp.Multiline = true;
            this.txtb_timkiem_masp.Name = "txtb_timkiem_masp";
            this.txtb_timkiem_masp.Size = new System.Drawing.Size(276, 24);
            this.txtb_timkiem_masp.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.button4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(463, 238);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(92, 219);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.Location = new System.Drawing.Point(3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 67);
            this.button4.TabIndex = 1;
            this.button4.Text = "Tìm Kiếm ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tên Sản Phẩm  ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Mã Sản Phẩm ";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.btn_xem, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_sua, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_them, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_xoa, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(463, 22);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(383, 73);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btn_xem
            // 
            this.btn_xem.BackColor = System.Drawing.Color.Gray;
            this.btn_xem.Location = new System.Drawing.Point(98, 3);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(89, 67);
            this.btn_xem.TabIndex = 9;
            this.btn_xem.Text = "Xem";
            this.btn_xem.UseVisualStyleBackColor = false;
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Gray;
            this.btn_sua.Location = new System.Drawing.Point(288, 3);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(92, 67);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Gray;
            this.btn_them.Location = new System.Drawing.Point(3, 3);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(89, 67);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Gray;
            this.btn_xoa.Location = new System.Drawing.Point(193, 3);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(89, 67);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.txtb_dongia, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtb_tensp, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtb_masp, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(127, 7);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(321, 88);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // txtb_dongia
            // 
            this.txtb_dongia.Location = new System.Drawing.Point(3, 61);
            this.txtb_dongia.Multiline = true;
            this.txtb_dongia.Name = "txtb_dongia";
            this.txtb_dongia.Size = new System.Drawing.Size(315, 24);
            this.txtb_dongia.TabIndex = 2;
            // 
            // txtb_tensp
            // 
            this.txtb_tensp.Location = new System.Drawing.Point(3, 32);
            this.txtb_tensp.Multiline = true;
            this.txtb_tensp.Name = "txtb_tensp";
            this.txtb_tensp.Size = new System.Drawing.Size(315, 23);
            this.txtb_tensp.TabIndex = 1;
            // 
            // txtb_masp
            // 
            this.txtb_masp.Location = new System.Drawing.Point(3, 3);
            this.txtb_masp.Multiline = true;
            this.txtb_masp.Name = "txtb_masp";
            this.txtb_masp.ReadOnly = true;
            this.txtb_masp.Size = new System.Drawing.Size(315, 23);
            this.txtb_masp.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(109, 88);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đơn Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Sản Phẩm ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Sản Phẩm  ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(495, 151);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // fdouong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(858, 462);
            this.Controls.Add(this.panel1);
            this.Name = "fdouong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đồ Uống ";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_sanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox txtb_timkiem_tensp;
        private System.Windows.Forms.TextBox txtb_timkiem_masp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_xem;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtb_dongia;
        private System.Windows.Forms.TextBox txtb_tensp;
        private System.Windows.Forms.TextBox txtb_masp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}