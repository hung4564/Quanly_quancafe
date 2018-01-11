using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BTLversion1
{
    public partial class fHoadon : Form
    {
        string tenban;
        string tongtien;
        public bool thanhtoan;
        public fHoadon(string tenban, string tongtien)
        {
            InitializeComponent();
            this.tenban = tenban;
            this.thanhtoan = false;
            this.tongtien = tongtien;
            label1.Text = tenban;
            txtb_sum.Text = tongtien;
            Loadbutton();
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            thanhtoan = true;
            this.Close();
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Loadbutton()
        {
            string[] money = new string[] { "50.000", "100.000", "200.000", "500.000" };
            foreach (string item in money)
            {
                Button bt = new Button();
                bt.Size = new Size(75, 35);
                bt.Text = item;
                bt.Click += Bt_Click1;
                flp_tienngan.Controls.Add(bt);
            }
            string[] banphim = new string[] { "7", "8", "9", "4", "5", "6", "1", "2", "3", "0", "000", "Xóa" };
            foreach (string item in banphim)
            {
                Button bt = new Button();
                bt.Size = new Size(45, 35);
                bt.Text = item;
                bt.Click += Bt_Click2;
                flp_banphim.Controls.Add(bt);
            }
        }

        private void Bt_Click1(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            txtb_khachdua.Text = (float.Parse(bt.Text) + float.Parse(txtb_khachdua.Text)).ToString();
        }
        private void Bt_Click2(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            if (bt.Text == "Xóa") txtb_khachdua.Text = "0";
            else
                try
                {
                    txtb_khachdua.Text = float.Parse(txtb_khachdua.Text + bt.Text).ToString();
                }
                catch (Exception)
                { }
        }

        private void txtb_khachdua_TextChanged(object sender, EventArgs e)
        {
            float khachdua = float.Parse(txtb_khachdua.Text);
            float sum = float.Parse(txtb_sum.Text);
            txtb_tralai.Text = (khachdua - sum).ToString();

        }
    }
}
