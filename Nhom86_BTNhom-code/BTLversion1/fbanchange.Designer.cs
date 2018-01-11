namespace BTLversion1
{
    partial class fbanchange
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
            this.dgv_ban = new System.Windows.Forms.DataGridView();
            this.maban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtb_trangthai = new System.Windows.Forms.TextBox();
            this.txtb_maban = new System.Windows.Forms.TextBox();
            this.txtb_tenban = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ban)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.dgv_ban);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 462);
            this.panel1.TabIndex = 4;
            // 
            // dgv_ban
            // 
            this.dgv_ban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maban,
            this.tenban,
            this.trangthai});
            this.dgv_ban.Location = new System.Drawing.Point(12, 91);
            this.dgv_ban.Name = "dgv_ban";
            this.dgv_ban.Size = new System.Drawing.Size(436, 359);
            this.dgv_ban.TabIndex = 0;
            // 
            // maban
            // 
            this.maban.DataPropertyName = "maban";
            this.maban.HeaderText = "Mã Bàn ";
            this.maban.Name = "maban";
            // 
            // tenban
            // 
            this.tenban.DataPropertyName = "tenban";
            this.tenban.HeaderText = "Tên Bàn";
            this.tenban.Name = "tenban";
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng Thái";
            this.trangthai.Name = "trangthai";
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
            this.button1.Click += new System.EventHandler(this.btn_xem_Click);
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
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.txtb_trangthai, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtb_maban, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtb_tenban, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(146, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(302, 73);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // txtb_trangthai
            // 
            this.txtb_trangthai.Location = new System.Drawing.Point(3, 51);
            this.txtb_trangthai.Multiline = true;
            this.txtb_trangthai.Name = "txtb_trangthai";
            this.txtb_trangthai.Size = new System.Drawing.Size(296, 19);
            this.txtb_trangthai.TabIndex = 3;
            // 
            // txtb_maban
            // 
            this.txtb_maban.Location = new System.Drawing.Point(3, 3);
            this.txtb_maban.Multiline = true;
            this.txtb_maban.Name = "txtb_maban";
            this.txtb_maban.ReadOnly = true;
            this.txtb_maban.Size = new System.Drawing.Size(296, 18);
            this.txtb_maban.TabIndex = 0;
            // 
            // txtb_tenban
            // 
            this.txtb_tenban.Location = new System.Drawing.Point(3, 27);
            this.txtb_tenban.Multiline = true;
            this.txtb_tenban.Name = "txtb_tenban";
            this.txtb_tenban.Size = new System.Drawing.Size(296, 18);
            this.txtb_tenban.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(118, 73);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Trạng Thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Bàn ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Bàn";
            // 
            // fbanchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 462);
            this.Controls.Add(this.panel1);
            this.Name = "fbanchange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông Tin Bàn ";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ban)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_ban;
        private System.Windows.Forms.DataGridViewTextBoxColumn maban;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenban;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtb_trangthai;
        private System.Windows.Forms.TextBox txtb_maban;
        private System.Windows.Forms.TextBox txtb_tenban;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}