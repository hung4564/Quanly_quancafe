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
    public partial class fdouong : Form
    {
        BindingSource sanphamList = new BindingSource();
        public fdouong()
        {
            InitializeComponent();
            dgv_sanpham.DataSource = sanphamList;
            LoadSanpham();
            AddSanphamBinding();
            loadsp_combo();
            
        }
        void loadsp_combo()
        {
            comboBox1.DataSource = DataProvider.Instance.ExecuteReader("Select * from sanpham where masp>0");
            comboBox1.DisplayMember = "tensp";
        }
        void timkiem()
        {
            DataRowView ssp = comboBox1.SelectedItem as DataRowView;
            string querry = "Select * from sanpham where masp = " + ssp[0].ToString();
            dgv_sanpham.DataSource = DataProvider.Instance.ExecuteReader(querry);
        }
        void AddSanphamBinding()
        {
            if (dgv_sanpham.DataSource!=null)
            {
                txtb_masp.DataBindings.Add(new Binding("Text", dgv_sanpham.DataSource, "Masp", true, DataSourceUpdateMode.Never));
                txtb_tensp.DataBindings.Add(new Binding("Text", dgv_sanpham.DataSource, "tensp", true, DataSourceUpdateMode.Never));
                txtb_dongia.DataBindings.Add(new Binding("Text", dgv_sanpham.DataSource, "dongia", true, DataSourceUpdateMode.Never));
            }
        }
        void LoadSanpham()
        {
            sanphamList.DataSource = DataProvider.Instance.ExecuteReader("Select * from sanpham where masp>0");
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            string ten = txtb_tensp.Text;
            double dongia = Convert.ToDouble(txtb_dongia.Text);
            string query = string.Format("exec sanpham_them N'{0}',{1}", ten, dongia);
            if (DataProvider.Instance.ExecuteNonQuery(query) > 0) MessageBox.Show("Thêm thành công"); else MessageBox.Show("Thêm không thành công");

            LoadSanpham();

        }
        private void btn_xem_Click(object sender, EventArgs e)
        {
            LoadSanpham();
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            int masp = int.Parse(txtb_masp.Text);
            string ten = txtb_tensp.Text;
            double dongia = Convert.ToDouble(txtb_dongia.Text);
            string query = string.Format("exec sanpham_sua {0},N'{1}',{2}", masp, ten, dongia);
            if (DataProvider.Instance.ExecuteNonQuery(query) > 0) MessageBox.Show("Sửa thành công"); else MessageBox.Show("Sửa không thành công");

            LoadSanpham();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int masp = int.Parse(txtb_masp.Text);
            string query = string.Format("exec sanpham_xoa {0}", masp);
            if (DataProvider.Instance.ExecuteNonQuery(query) > 0) MessageBox.Show("Xóa thành công"); else MessageBox.Show("Xóa không thành công");

            LoadSanpham();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            timkiem();
            //if (txtb_timkiem_masp.Text == "")
            //{
            //    string name = txtb_timkiem_tensp.Text;
            //    string query = string.Format("SELECT * FROM sanpham WHERE dbo.fuConvertToUnsign1(tensp) LIKE '%'+dbo.fuConvertToUnsign1(N'{0}')+'%'", name);
            //    DataTable data = DataProvider.Instance.ExecuteReader(query);
            //    sanphamList.DataSource = data;
            //}
            //else
            //{
            //    int masp = int.Parse(txtb_timkiem_masp.Text);
            //    string query = string.Format("SELECT * FROM sanpham WHERE masp = {0}", masp);
            //    DataTable data = DataProvider.Instance.ExecuteReader(query);
            //    sanphamList.DataSource = data;
            //}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
