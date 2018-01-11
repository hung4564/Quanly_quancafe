namespace BTLversion1
{
    partial class fPhaChe
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
            this.bt_chinh = new System.Windows.Forms.Button();
            this.bt_xacnhan = new System.Windows.Forms.Button();
            this.cb_sp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lv_nguyenlieu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cd_nguyenlieu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nd_soluong = new System.Windows.Forms.NumericUpDown();
            this.bt_nhap = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nd_soluong)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_chinh
            // 
            this.bt_chinh.Location = new System.Drawing.Point(110, 94);
            this.bt_chinh.Name = "bt_chinh";
            this.bt_chinh.Size = new System.Drawing.Size(121, 29);
            this.bt_chinh.TabIndex = 29;
            this.bt_chinh.Text = "Chỉnh sửa";
            this.bt_chinh.UseVisualStyleBackColor = true;
            this.bt_chinh.Click += new System.EventHandler(this.bt_chinh_Click);
            // 
            // bt_xacnhan
            // 
            this.bt_xacnhan.Location = new System.Drawing.Point(468, 317);
            this.bt_xacnhan.Name = "bt_xacnhan";
            this.bt_xacnhan.Size = new System.Drawing.Size(111, 28);
            this.bt_xacnhan.TabIndex = 28;
            this.bt_xacnhan.Text = "Xác nhận";
            this.bt_xacnhan.UseVisualStyleBackColor = true;
            this.bt_xacnhan.Click += new System.EventHandler(this.bt_xacnhan_Click);
            // 
            // cb_sp
            // 
            this.cb_sp.FormattingEnabled = true;
            this.cb_sp.Location = new System.Drawing.Point(110, 67);
            this.cb_sp.Name = "cb_sp";
            this.cb_sp.Size = new System.Drawing.Size(121, 21);
            this.cb_sp.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Sản phẩm";
            // 
            // lv_nguyenlieu
            // 
            this.lv_nguyenlieu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lv_nguyenlieu.Location = new System.Drawing.Point(301, 53);
            this.lv_nguyenlieu.Name = "lv_nguyenlieu";
            this.lv_nguyenlieu.Size = new System.Drawing.Size(278, 242);
            this.lv_nguyenlieu.TabIndex = 25;
            this.lv_nguyenlieu.UseCompatibleStateImageBehavior = false;
            this.lv_nguyenlieu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên nguyên liệu";
            this.columnHeader1.Width = 204;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 68;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cd_nguyenlieu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nd_soluong);
            this.groupBox1.Controls.Add(this.bt_nhap);
            this.groupBox1.Location = new System.Drawing.Point(12, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 121);
            this.groupBox1.TabIndex = 24;
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
            // cd_nguyenlieu
            // 
            this.cd_nguyenlieu.FormattingEnabled = true;
            this.cd_nguyenlieu.Location = new System.Drawing.Point(98, 19);
            this.cd_nguyenlieu.Name = "cd_nguyenlieu";
            this.cd_nguyenlieu.Size = new System.Drawing.Size(121, 21);
            this.cd_nguyenlieu.TabIndex = 7;
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
            this.bt_nhap.Location = new System.Drawing.Point(98, 76);
            this.bt_nhap.Name = "bt_nhap";
            this.bt_nhap.Size = new System.Drawing.Size(121, 31);
            this.bt_nhap.TabIndex = 11;
            this.bt_nhap.Text = "Nhập nguyên liệu";
            this.bt_nhap.UseVisualStyleBackColor = true;
            this.bt_nhap.Click += new System.EventHandler(this.bt_nhap_Click);
            // 
            // fPhaChe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(593, 390);
            this.Controls.Add(this.bt_chinh);
            this.Controls.Add(this.bt_xacnhan);
            this.Controls.Add(this.cb_sp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_nguyenlieu);
            this.Controls.Add(this.groupBox1);
            this.Name = "fPhaChe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pha Chế";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nd_soluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_chinh;
        private System.Windows.Forms.Button bt_xacnhan;
        private System.Windows.Forms.ComboBox cb_sp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_nguyenlieu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cd_nguyenlieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nd_soluong;
        private System.Windows.Forms.Button bt_nhap;
    }
}