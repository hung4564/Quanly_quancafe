using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLversion1
{
    public partial class fTable : Form
    {
        string manv;
        public fTable(string manv)
        {
            InitializeComponent();
            this.manv = manv;
            LoadTable();
        }
        int tableWidtht = 100;
        int tableHeight = 100;
        void LoadTable()
        {
            flpanel_table.Controls.Clear();
            DataTable tableList = DataProvider.Instance.ExecuteReader("select * from Ban");
            foreach (DataRow table in tableList.Rows)
            {
                Button bt = new Button()
                {
                    Width = tableWidtht,
                    Height = tableHeight,
                    Tag = table["Maban"].ToString()
                };
                if (table["Tenban"].ToString().Contains("Mang về")) bt.Text = table["Tenban"].ToString();
                else
                    bt.Text = table["Tenban"].ToString() + "\n" + table["Trangthai"].ToString();
                bt.Click += Bt_Click;
                switch (table["Trangthai"])
                {
                    case "Trống":
                        bt.BackColor = Color.Aqua;
                        break;
                    default:
                        bt.BackColor = Color.Red;
                        break;
                }
                flpanel_table.Controls.Add(bt);
            }
        }

        private void Bt_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            fBIll f = new fBIll(bt.Tag.ToString(),manv);
            this.Hide();
            f.ShowDialog();
            LoadTable();
            this.Show();
        }

        private void bt_Chuyen_Click(object sender, EventArgs e)
        {
            fChuyenban f = new fChuyenban();
            f.ShowDialog();
            if(f.mabangoc!=null)
            {
                DataProvider.Instance.ExecuteNonQuery(string.Format("exec chuyenban {0},{1}",f.mabangoc,f.mabanchuyen));
                LoadTable();
            }
        }
      

        private void bt_thongtin_Click(object sender, EventArgs e)
        {
            fbanchange fb = new fbanchange();
            this.Hide();
            fb.ShowDialog();
            this.Show();
            LoadTable();
        }
    }
}
