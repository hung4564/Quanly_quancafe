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
    public partial class fChamcong : Form
    {
        string manv;
        BindingSource chamconglist = new BindingSource();
        public fChamcong(string manv)
        {
            InitializeComponent();
            this.manv = manv;
            dgv_chamcong.DataSource = chamconglist;
            txtb_manv.Text = manv;
            txtb_tennv.Text = DataProvider.Instance.ExecuteScalar("Select tennv from nhanvien where manv = " + manv).ToString();
            LoadChamcong();
            AddKhachhangBinding();
        }

        void AddKhachhangBinding()
        {
            dtp_ngay.DataBindings.Add(new Binding("Value", dgv_chamcong.DataSource, "ngay", true, DataSourceUpdateMode.Never));
            dtp_giovao.DataBindings.Add(new Binding("Value", dgv_chamcong.DataSource, "Giobd", true, DataSourceUpdateMode.Never));
            dtp_giora.DataBindings.Add(new Binding("Value", dgv_chamcong.DataSource, "GioKT", true, DataSourceUpdateMode.Never));
        }
        void LoadChamcong()
        {
            chamconglist.DataSource = DataProvider.Instance.ExecuteReader("Select nhanvien.manv,tennv,giobd,giokt,ngay from chamcong,nhanvien where nhanvien.manv=chamcong.manv");
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            DateTime ngay = dtp_ngay.Value;
            string giobd = dtp_giovao.Value.ToShortTimeString();
            string giokt = dtp_giora.Value.ToShortTimeString();
            string query = string.Format("exec chamcong_them {0},'{1}','{2}','{3}'", manv, giobd, giokt, ngay);
            if (DataProvider.Instance.ExecuteNonQuery(query) > 0) MessageBox.Show("Thêm thành công"); else MessageBox.Show("Thêm không thành công");
            LoadChamcong();
        }
        private void btn_xem_Click(object sender, EventArgs e)
        {
            LoadChamcong();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DateTime ngay = dtp_ngay.Value;
            string giobd = dtp_giovao.Value.ToShortTimeString();
            string giokt = dtp_giora.Value.ToShortTimeString();
            string query = string.Format("exec chamcong_xoa {0},'{1}','{2}','{3}'", manv, giobd, giokt, ngay);
            if (DataProvider.Instance.ExecuteNonQuery(query) > 0) MessageBox.Show("Xóa thành công"); else MessageBox.Show("Xóa không thành công");

            LoadChamcong();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            DateTime from = dtp_from.Value;
            DateTime to = dtp_to.Value;
            string query = string.Format("Select nhanvien.manv,tennv,giobd,giokt,ngay from chamcong,nhanvien where nhanvien.manv=chamcong.manv and ngay>='{0}' and ngay<='{1}'", from, to);
            chamconglist.DataSource = DataProvider.Instance.ExecuteReader(query);
        }
        
    }
}