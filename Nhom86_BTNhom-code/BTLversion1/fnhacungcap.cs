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
    public partial class fnhacungcap : Form
    {
        BindingSource NhaccList = new BindingSource();
        public fnhacungcap()
        {
            InitializeComponent();
            dgv_nhacc.DataSource = NhaccList;
            LoadNhaCC();
            AddNhaCCBinding();
        }
        void AddNhaCCBinding()
        {
            if (dgv_nhacc.DataSource != null)
            {
                txtb_mancc.DataBindings.Add(new Binding("Text", dgv_nhacc.DataSource, "Mancc", true, DataSourceUpdateMode.Never));
                txtb_tenncc.DataBindings.Add(new Binding("Text", dgv_nhacc.DataSource, "tenncc", true, DataSourceUpdateMode.Never));
                txtb_diachi.DataBindings.Add(new Binding("Text", dgv_nhacc.DataSource, "diachi", true, DataSourceUpdateMode.Never));
                txtb_sdt.DataBindings.Add(new Binding("Text", dgv_nhacc.DataSource, "sdt", true, DataSourceUpdateMode.Never));

            }
        }
        void LoadNhaCC()
        {
            NhaccList.DataSource = DataProvider.Instance.ExecuteReader("Select * from nhacungcap");
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            string ten = txtb_tenncc.Text;
            string diachi = txtb_diachi.Text;
            string sdt = txtb_diachi.Text; 
            string query = string.Format("exec nhacc_them N'{0}',N{1},{2}", ten, diachi, sdt);
            if (DataProvider.Instance.ExecuteNonQuery(query) > 0) MessageBox.Show("Thêm thành công"); else MessageBox.Show("Thêm không thành công");
            LoadNhaCC();

        }
        private void btn_xem_Click(object sender, EventArgs e)
        {
            LoadNhaCC();
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            int mancc= int.Parse(txtb_mancc.Text);
            string ten = txtb_tenncc.Text;
            string diachi = txtb_diachi.Text;
            string sdt = txtb_diachi.Text;
            string query = string.Format("exec nhacc_sua {0}, N'{1}',N{2},{3}",mancc,  ten, diachi, sdt);
            if (DataProvider.Instance.ExecuteNonQuery(query) > 0) MessageBox.Show("Sửa thành công"); else MessageBox.Show("Sửa không thành công");
            LoadNhaCC();

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int mancc = int.Parse(txtb_mancc.Text);
            string query = string.Format("exec nhacc_xoa {0}", mancc);
            if (DataProvider.Instance.ExecuteNonQuery(query) > 0) MessageBox.Show("Xóa thành công"); else MessageBox.Show("Xóa không thành công");

            LoadNhaCC();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (txtb_timkiem_mancc.Text == "")
            {
                string name = txtb_timkiem_mancc.Text;
                string query = string.Format("SELECT * FROM nhacungcap WHERE dbo.fuConvertToUnsign1(tenncc) LIKE '%'+dbo.fuConvertToUnsign1(N'{0}')+'%'", name);
                DataTable data = DataProvider.Instance.ExecuteReader(query);
                NhaccList.DataSource = data;
            }
            else
            {
                int mancc = int.Parse(txtb_mancc.Text);
                string query = string.Format("SELECT * FROM nhacungcap WHERE mancc = {0}", mancc);
                DataTable data = DataProvider.Instance.ExecuteReader(query);
                NhaccList.DataSource = data;
            }
        }

    }
}
