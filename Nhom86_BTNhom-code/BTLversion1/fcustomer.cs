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
    public partial class fcustomer : Form
    {
        BindingSource khachhangList = new BindingSource();
        public fcustomer()
        {
            InitializeComponent();
            dgv_khachhang.DataSource = khachhangList;
            LoadKhachhang();
            AddKhachhangBinding(); 
        }

        void AddKhachhangBinding()
        {
            txtb_makh.DataBindings.Add(new Binding("Text", dgv_khachhang.DataSource, "Makh", true, DataSourceUpdateMode.Never));
            txtb_tenkh.DataBindings.Add(new Binding("Text", dgv_khachhang.DataSource, "tenkh", true, DataSourceUpdateMode.Never));
            txtb_sdt.DataBindings.Add(new Binding("Text", dgv_khachhang.DataSource, "sdt", true, DataSourceUpdateMode.Never));
            txtb_diachi.DataBindings.Add(new Binding("Text", dgv_khachhang.DataSource, "diachi", true, DataSourceUpdateMode.Never));
            txtb_loaikh.DataBindings.Add(new Binding("Text", dgv_khachhang.DataSource, "LoaiKH", true, DataSourceUpdateMode.Never));
        }
        void LoadKhachhang()
        {
            khachhangList.DataSource = DataProvider.Instance.ExecuteReader("Select * from khachhang");
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            string ten = txtb_tenkh.Text;
            string diachi = txtb_diachi.Text;
            string sdt = txtb_sdt.Text;
            string loaikh = txtb_loaikh.Text;
            string query = string.Format("exec khachhang_them N'{0}',N'{1}','{2}',N'{3}'", ten, diachi, sdt,loaikh);
            if (DataProvider.Instance.ExecuteNonQuery(query) > 0) MessageBox.Show("Thêm thành công"); else MessageBox.Show("Thêm không thành công");
            LoadKhachhang();

        }
        private void btn_xem_Click(object sender, EventArgs e)
        {
            LoadKhachhang();
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            int makh = int.Parse(txtb_makh.Text);
            string ten = txtb_tenkh.Text;
            string diachi = txtb_diachi.Text;
            string sdt = txtb_sdt.Text;
            string loaikh = txtb_loaikh.Text;
            string query = string.Format("exec khachhang_sua {0},N'{1}',N'{2}',N'{3}',N'{4}'", makh, ten, diachi, sdt, loaikh);
            if (DataProvider.Instance.ExecuteNonQuery(query) > 0) MessageBox.Show("Sửa thành công"); else MessageBox.Show("Sửa không thành công");
            LoadKhachhang();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(txtb_makh.Text);
            string query = string.Format("exec khachhang_xoa {0}", manv);
            if (DataProvider.Instance.ExecuteNonQuery(query) > 0) MessageBox.Show("Xóa thành công"); else MessageBox.Show("Xóa không thành công");

            LoadKhachhang();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (txt_timkiem_ma.Text == "")
            {
                string name = txt_timkiem_ten.Text;
                string query = string.Format("SELECT * FROM khachhang WHERE dbo.fuConvertToUnsign1(tenkh) LIKE '%'+dbo.fuConvertToUnsign1(N'{0}')+'%'", name);
                DataTable data = DataProvider.Instance.ExecuteReader(query);
                khachhangList.DataSource = data;
            }
            else
            {
                int ma = int.Parse(txt_timkiem_ma.Text);
                string query = string.Format("SELECT * FROM khachhang WHERE makh = {0}", ma);
                DataTable data = DataProvider.Instance.ExecuteReader(query);
                khachhangList.DataSource = data;
            }
        }
    }
}
