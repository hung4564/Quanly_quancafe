namespace BTLversion1
{
    partial class fChamcong
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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xem = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dtp_giovao = new System.Windows.Forms.DateTimePicker();
            this.dtp_giora = new System.Windows.Forms.DateTimePicker();
            this.txtb_manv = new System.Windows.Forms.TextBox();
            this.dtp_ngay = new System.Windows.Forms.DateTimePicker();
            this.txtb_tennv = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.dgv_chamcong = new System.Windows.Forms.DataGridView();
            this.ngaylam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giobatdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chamcong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.dtp_to);
            this.panel1.Controls.Add(this.dtp_from);
            this.panel1.Controls.Add(this.btn_timkiem);
            this.panel1.Controls.Add(this.dgv_chamcong);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 462);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.btn_them, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_xem, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_xoa, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(541, 78);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(235, 44);
            this.tableLayoutPanel4.TabIndex = 46;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Gray;
            this.btn_them.Location = new System.Drawing.Point(3, 3);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(72, 38);
            this.btn_them.TabIndex = 25;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xem
            // 
            this.btn_xem.BackColor = System.Drawing.Color.Gray;
            this.btn_xem.Location = new System.Drawing.Point(81, 3);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(72, 38);
            this.btn_xem.TabIndex = 33;
            this.btn_xem.Text = "Xem";
            this.btn_xem.UseVisualStyleBackColor = false;
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Gray;
            this.btn_xoa.Location = new System.Drawing.Point(159, 3);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(73, 38);
            this.btn_xoa.TabIndex = 27;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(535, 331);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(87, 119);
            this.tableLayoutPanel3.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Ngày từ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Đến ngày";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.dtp_giovao, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.dtp_giora, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtb_manv, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtp_ngay, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtb_tennv, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(121, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(395, 119);
            this.tableLayoutPanel2.TabIndex = 44;
            // 
            // dtp_giovao
            // 
            this.dtp_giovao.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_giovao.Location = new System.Drawing.Point(3, 72);
            this.dtp_giovao.Name = "dtp_giovao";
            this.dtp_giovao.ShowUpDown = true;
            this.dtp_giovao.Size = new System.Drawing.Size(389, 20);
            this.dtp_giovao.TabIndex = 34;
            // 
            // dtp_giora
            // 
            this.dtp_giora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_giora.Location = new System.Drawing.Point(3, 95);
            this.dtp_giora.Name = "dtp_giora";
            this.dtp_giora.ShowUpDown = true;
            this.dtp_giora.Size = new System.Drawing.Size(389, 20);
            this.dtp_giora.TabIndex = 35;
            // 
            // txtb_manv
            // 
            this.txtb_manv.Location = new System.Drawing.Point(3, 3);
            this.txtb_manv.Name = "txtb_manv";
            this.txtb_manv.Size = new System.Drawing.Size(389, 20);
            this.txtb_manv.TabIndex = 31;
            // 
            // dtp_ngay
            // 
            this.dtp_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngay.Location = new System.Drawing.Point(3, 49);
            this.dtp_ngay.Name = "dtp_ngay";
            this.dtp_ngay.Size = new System.Drawing.Size(389, 20);
            this.dtp_ngay.TabIndex = 30;
            // 
            // txtb_tennv
            // 
            this.txtb_tennv.Location = new System.Drawing.Point(3, 26);
            this.txtb_tennv.Name = "txtb_tennv";
            this.txtb_tennv.Size = new System.Drawing.Size(389, 20);
            this.txtb_tennv.TabIndex = 37;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(87, 119);
            this.tableLayoutPanel1.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Giờ Bắt Đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Ngày Làm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Tên Nhân Viên ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Giờ Kết Thúc";
            // 
            // dtp_to
            // 
            this.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_to.Location = new System.Drawing.Point(646, 390);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(200, 20);
            this.dtp_to.TabIndex = 40;
            // 
            // dtp_from
            // 
            this.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_from.Location = new System.Drawing.Point(646, 331);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(200, 20);
            this.dtp_from.TabIndex = 39;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.Color.Gray;
            this.btn_timkiem.Location = new System.Drawing.Point(535, 266);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(87, 41);
            this.btn_timkiem.TabIndex = 38;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // dgv_chamcong
            // 
            this.dgv_chamcong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_chamcong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chamcong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ngaylam,
            this.Column1,
            this.giobatdau,
            this.Gioketthuc});
            this.dgv_chamcong.Location = new System.Drawing.Point(12, 148);
            this.dgv_chamcong.Name = "dgv_chamcong";
            this.dgv_chamcong.Size = new System.Drawing.Size(504, 302);
            this.dgv_chamcong.TabIndex = 32;
            // 
            // ngaylam
            // 
            this.ngaylam.DataPropertyName = "ngay";
            this.ngaylam.HeaderText = "Ngày làm";
            this.ngaylam.Name = "ngaylam";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "manv";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // giobatdau
            // 
            this.giobatdau.DataPropertyName = "giobd";
            this.giobatdau.HeaderText = "GIờ bắt đầu";
            this.giobatdau.Name = "giobatdau";
            // 
            // Gioketthuc
            // 
            this.Gioketthuc.DataPropertyName = "giokt";
            this.Gioketthuc.HeaderText = "Giờ kết thúc";
            this.Gioketthuc.Name = "Gioketthuc";
            // 
            // fChamcong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 462);
            this.Controls.Add(this.panel1);
            this.Name = "fChamcong";
            this.Text = "Chấm Công";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chamcong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txtb_tennv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_xem;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_giora;
        private System.Windows.Forms.DateTimePicker dtp_giovao;
        private System.Windows.Forms.DataGridView dgv_chamcong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn giobatdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioketthuc;
        private System.Windows.Forms.TextBox txtb_manv;
        private System.Windows.Forms.DateTimePicker dtp_ngay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label7;
    }
}