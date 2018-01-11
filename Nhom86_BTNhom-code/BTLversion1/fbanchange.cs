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
    public partial class fbanchange : Form
    {
        BindingSource banList = new BindingSource();
        public fbanchange()
        {
            InitializeComponent();
            dgv_ban.DataSource = banList;
            LoadBan();
            AddBanBinding();
        }

        void AddBanBinding()
        {
            txtb_maban.DataBindings.Add(new Binding("Text", dgv_ban.DataSource, "Maban", true, DataSourceUpdateMode.Never));
            txtb_tenban.DataBindings.Add(new Binding("Text", dgv_ban.DataSource, "tenban", true, DataSourceUpdateMode.Never));
            txtb_trangthai.DataBindings.Add(new Binding("Text", dgv_ban.DataSource, "trangthai", true, DataSourceUpdateMode.Never));
           }
        void LoadBan()
        {
            banList.DataSource = DataProvider.Instance.ExecuteReader("Select * from ban where maban>0");
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            string ten = txtb_tenban.Text;
            
            string query = string.Format("exec ban_them N'{0}'",ten);
            if (DataProvider.Instance.ExecuteNonQuery(query) > 0) MessageBox.Show("Thêm thành công"); else MessageBox.Show("Thêm không thành công");
            LoadBan();

        }
        private void btn_xem_Click(object sender, EventArgs e)
        {
            LoadBan();
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            int maban = int.Parse(txtb_maban.Text);
            string ten = txtb_tenban.Text;
           
            string query = string.Format("exec ban_sua {0},N'{1}'", maban, ten);
            if (DataProvider.Instance.ExecuteNonQuery(query) > 0) MessageBox.Show("Sửa thành công"); else MessageBox.Show("Sửa không thành công");
            LoadBan();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(txtb_maban.Text);
            string query = string.Format("exec ban_xoa {0}", manv);
            if (DataProvider.Instance.ExecuteNonQuery(query) > 0) MessageBox.Show("Xóa thành công"); else MessageBox.Show("Xóa không thành công");

            LoadBan();
        }

       
        
    }
}
