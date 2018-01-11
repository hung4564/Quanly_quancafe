namespace BTLversion1
{
    partial class fFood_bill
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
            this.nd_sl = new System.Windows.Forms.NumericUpDown();
            this.txtb_tensp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nd_sl)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nd_sl);
            this.panel1.Controls.Add(this.txtb_tensp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(11, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 141);
            this.panel1.TabIndex = 0;
            // 
            // nd_sl
            // 
            this.nd_sl.Location = new System.Drawing.Point(94, 89);
            this.nd_sl.Name = "nd_sl";
            this.nd_sl.Size = new System.Drawing.Size(120, 20);
            this.nd_sl.TabIndex = 5;
            // 
            // txtb_tensp
            // 
            this.txtb_tensp.Location = new System.Drawing.Point(94, 44);
            this.txtb_tensp.Name = "txtb_tensp";
            this.txtb_tensp.ReadOnly = true;
            this.txtb_tensp.Size = new System.Drawing.Size(120, 20);
            this.txtb_tensp.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên món";
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.Color.Gray;
            this.bt_sua.Location = new System.Drawing.Point(132, 155);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(115, 41);
            this.bt_sua.TabIndex = 10;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Gray;
            this.btn_xoa.Location = new System.Drawing.Point(11, 155);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(115, 41);
            this.btn_xoa.TabIndex = 11;
            this.btn_xoa.Text = "Xóa món";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // fFood_bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(261, 204);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.panel1);
            this.Name = "fFood_bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fFood_bill";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nd_sl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb_tensp;
        private System.Windows.Forms.NumericUpDown nd_sl;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button btn_xoa;
    }
}