namespace BTLversion1
{
    partial class fnguyenlieu
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
            this.dgv_nl = new System.Windows.Forms.DataGridView();
            this.manl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtb_timkiem_tennl = new System.Windows.Forms.TextBox();
            this.txtb_timkiem_manl = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtb_manl = new System.Windows.Forms.TextBox();
            this.txtb_tennl = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nl)).BeginInit();
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
            this.panel1.Controls.Add(this.dgv_nl);
            this.panel1.Controls.Add(this.tableLayoutPanel5);
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 462);
            this.panel1.TabIndex = 3;
            // 
            // dgv_nl
            // 
            this.dgv_nl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_nl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manl,
            this.tennl});
            this.dgv_nl.Location = new System.Drawing.Point(12, 94);
            this.dgv_nl.Name = "dgv_nl";
            this.dgv_nl.Size = new System.Drawing.Size(436, 356);
            this.dgv_nl.TabIndex = 0;
            // 
            // manl
            // 
            this.manl.DataPropertyName = "manl";
            this.manl.HeaderText = "Mã Nguyên Liệu";
            this.manl.Name = "manl";
            // 
            // tennl
            // 
            this.tennl.DataPropertyName = "tennl";
            this.tennl.HeaderText = "Tên Nguyên Liệu";
            this.tennl.Name = "tennl";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.txtb_timkiem_tennl, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.txtb_timkiem_manl, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(561, 294);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(282, 156);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // txtb_timkiem_tennl
            // 
            this.txtb_timkiem_tennl.Location = new System.Drawing.Point(3, 81);
            this.txtb_timkiem_tennl.Name = "txtb_timkiem_tennl";
            this.txtb_timkiem_tennl.Size = new System.Drawing.Size(276, 20);
            this.txtb_timkiem_tennl.TabIndex = 6;
            // 
            // txtb_timkiem_manl
            // 
            this.txtb_timkiem_manl.Location = new System.Drawing.Point(3, 3);
            this.txtb_timkiem_manl.Name = "txtb_timkiem_manl";
            this.txtb_timkiem_manl.Size = new System.Drawing.Size(276, 20);
            this.txtb_timkiem_manl.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.btn_timkiem, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(463, 217);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(95, 233);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên Nguyên Liệu";
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.Color.Gray;
            this.btn_timkiem.Location = new System.Drawing.Point(3, 3);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(89, 71);
            this.btn_timkiem.TabIndex = 1;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Mã Nguyên Liệu";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_xoa, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_sua, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_them, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(463, 12);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(383, 73);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(98, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 67);
            this.button1.TabIndex = 8;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_xem_click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Gray;
            this.btn_xoa.Location = new System.Drawing.Point(288, 3);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(92, 67);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Gray;
            this.btn_sua.Location = new System.Drawing.Point(193, 3);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(89, 67);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_click);
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
            this.btn_them.Click += new System.EventHandler(this.btn_them_click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.txtb_manl, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtb_tennl, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(146, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(302, 73);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // txtb_manl
            // 
            this.txtb_manl.Location = new System.Drawing.Point(3, 3);
            this.txtb_manl.Multiline = true;
            this.txtb_manl.Name = "txtb_manl";
            this.txtb_manl.ReadOnly = true;
            this.txtb_manl.Size = new System.Drawing.Size(296, 25);
            this.txtb_manl.TabIndex = 0;
            // 
            // txtb_tennl
            // 
            this.txtb_tennl.Location = new System.Drawing.Point(3, 39);
            this.txtb_tennl.Multiline = true;
            this.txtb_tennl.Name = "txtb_tennl";
            this.txtb_tennl.Size = new System.Drawing.Size(296, 26);
            this.txtb_tennl.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(118, 73);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Nguyên Liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Nguyên Liệu ";
            // 
            // fnguyenlieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 462);
            this.Controls.Add(this.panel1);
            this.Name = "fnguyenlieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nguyên Liệu";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nl)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_nl;
        private System.Windows.Forms.DataGridViewTextBoxColumn manl;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox txtb_timkiem_tennl;
        private System.Windows.Forms.TextBox txtb_timkiem_manl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtb_manl;
        private System.Windows.Forms.TextBox txtb_tennl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}