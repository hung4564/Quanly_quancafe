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
    public partial class fFood_bill: Form
    {
        public string soluong;
        public bool xoa = false;
        public fFood_bill(string tensp,string soluong)
        {
            InitializeComponent();
            this.soluong = soluong;
            txtb_tensp.Text = tensp;
            nd_sl.Value = int.Parse(soluong);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            xoa = true;
            this.Close();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            this.soluong = nd_sl.Value.ToString();
            xoa = false;
            this.Close();
        }
    }
}
