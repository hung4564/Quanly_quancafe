using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTLversion1
{
    public partial class fstaff : Form
    {
        BindingSource nhanvienList = new BindingSource();
        public fstaff()
        {
            InitializeComponent();
            dgv_nhanvien.DataSource = nhanvienList;
            LoadNhanvien(); LoadChucvu();
            AddNhanvienBinding();
        }
        void LoadChucvu()
        {
            cbx_macv.DataSource = DataProvider.Instance.ExecuteReader("Select * from chucvu");
            cbx_macv.DisplayMember = "tencv";
        }
        void AddNhanvienBinding()
        {
            txt_manv.DataBindings.Add(new Binding("Text", dgv_nhanvien.DataSource, "Manv", true, DataSourceUpdateMode.Never));
            txt_tennv.DataBindings.Add(new Binding("Text", dgv_nhanvien.DataSource, "tennv", true, DataSourceUpdateMode.Never));
            txt_sdt.DataBindings.Add(new Binding("Text", dgv_nhanvien.DataSource, "sdt", true, DataSourceUpdateMode.Never));
            txt_diachi.DataBindings.Add(new Binding("Text", dgv_nhanvien.DataSource, "diachi", true, DataSourceUpdateMode.Never));
            //cbx_macv.DataBindings.Add(new Binding("SelectedText", dgv_nhanvien.DataSource, "tencv", true, DataSourceUpdateMode.Never));
            dtp_ngaysinh.DataBindings.Add(new Binding("Value", dgv_nhanvien.DataSource, "ngaysinh", true, DataSourceUpdateMode.Never));
        }
        void LoadNhanvien()
        {
            nhanvienList.DataSource = DataProvider.Instance.ExecuteReader("Select Manv,tennv,sdt,diachi,tencv,ngaysinh from nhanvien,chucvu where nhanvien.macv=chucvu.macv");
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            string ten = txt_tennv.Text;
            DateTime ngaysinh = dtp_ngaysinh.Value;
            string diachi = txt_diachi.Text;
            string sdt = txt_sdt.Text;
            var tencv = this.cbx_macv.GetItemText(this.cbx_macv.SelectedItem);
            string query = string.Format("exec nhanvien_them N'{0}','{1}',N'{2}','{3}',{4}", ten, ngaysinh.ToString(), diachi, sdt, GetIdbytencv(tencv));
            DataProvider.Instance.ExecuteReader(query);
            LoadNhanvien();

        }
        private void btn_xem_Click(object sender, EventArgs e)
        {
            LoadNhanvien();
        }
        int GetIdbytencv(string tencv)
        {
            string test = tencv;
            string query = string.Format("select macv from chucvu where tencv = N'{0}'", test);
            object data = DataProvider.Instance.ExecuteScalar(query);
            return int.Parse(data.ToString());
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(txt_manv.Text);
            string ten = txt_tennv.Text;
            DateTime ngaysinh = dtp_ngaysinh.Value;
            string diachi = txt_diachi.Text;
            string sdt = txt_sdt.Text;
            var tencv = this.cbx_macv.GetItemText(this.cbx_macv.SelectedItem);
            string query = string.Format("exec nhanvien_sua {0},N'{1}','{2}',N'{3}','{4}','{5}'", manv, ten, ngaysinh.ToString(), diachi, sdt, GetIdbytencv(tencv));
            
            if (DataProvider.Instance.ExecuteNonQuery(query) > 0) MessageBox.Show("Sửa thành công"); else MessageBox.Show("Sửa không thành công");

            LoadNhanvien();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(txt_manv.Text);
            string query = string.Format("exec nhanvien_xoa {0}", manv);
            if (DataProvider.Instance.ExecuteNonQuery(query) > 0) MessageBox.Show("Xóa thành công"); else MessageBox.Show("Xóa không thành công");

            LoadNhanvien();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (txt_timkiem_ma.Text == "")
            {
                string name = txt_timkiem_ten.Text;
                string query = string.Format("SELECT * FROM nhanvien WHERE dbo.fuConvertToUnsign1(tennv) LIKE '%'+dbo.fuConvertToUnsign1(N'{0}')+'%'", name);
                DataTable data = DataProvider.Instance.ExecuteReader(query);
                nhanvienList.DataSource = data;
            }
            else
            {
                int manv = int.Parse(txt_timkiem_ma.Text);
                string query = string.Format("SELECT * FROM nhanvien WHERE manv = {0}", manv);
                DataTable data = DataProvider.Instance.ExecuteReader(query);
                nhanvienList.DataSource = data;
            }
        }

        private void txt_manv_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgv_nhanvien.SelectedCells.Count > 0)
                {
                    string tencv = dgv_nhanvien.SelectedCells[0].OwningRow.Cells["tencv"].Value.ToString();
                    DataTable data = DataProvider.Instance.ExecuteReader("select * from chucvu");
                    int index = -1;
                    int i = 0;
                    foreach (DataRow item in data.Rows)
                    {
                        if (item[1].ToString() == tencv)
                        {
                            index = i;
                        }
                        i++;
                    }
                    cbx_macv.SelectedIndex = index;
                }
            }
            catch
            {
            }
        }

        private void btn_luong_Click(object sender, EventArgs e)
        {
            fluong fluo = new fluong(txt_manv.Text);
            this.Hide();
            fluo.ShowDialog();
            this.Show();
        }

        private void btn_chamcong_Click(object sender, EventArgs e)
        {

            fChamcong fcha = new fChamcong(txt_manv.Text);
            this.Hide();
            fcha.ShowDialog();
            this.Show();
        }
    }
}
