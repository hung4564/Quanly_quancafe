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
    public partial class fNhapHang : Form
    {
        string manv;
        public fNhapHang(string manv)
        {
            this.manv = manv;
            InitializeComponent();
            cd_nguyenlieu.DataSource = DataProvider.Instance.ExecuteReader("Select * from nguyenlieu where manl>0");
            cd_nguyenlieu.DisplayMember = "tennl";
            cb_ncc.DataSource = DataProvider.Instance.ExecuteReader("Select * from nhacungcap where mancc>0");
            cb_ncc.DisplayMember = "tenncc";
            txtb_nhanvien.Text = DataProvider.Instance.ExecuteScalar("Select tennv from nhanvien where manv =" + manv).ToString();
        }

        private void bt_nhap_Click(object sender, EventArgs e)
        {
            string manl = (cd_nguyenlieu.SelectedItem as DataRowView)["Manl"].ToString();
            string tennl = (cd_nguyenlieu.SelectedItem as DataRowView)["tennl"].ToString();
            string mancc = (cb_ncc.SelectedItem as DataRowView)["Mancc"].ToString();
            int soluong = (int)nd_soluong.Value;
            string giatien = txtb_gia.Text;
            NhapItemTolist(manl, tennl, soluong, giatien);
        }
        void NhapItemTolist(string manl, string tennl, int soluong, string giatien)
        {
            ListViewItem lsvItem = new ListViewItem(tennl);
            int index = kietralist(manl);
            if (index >= 0)
            {
                int tong = (int.Parse(lv_nhap.Items[index].SubItems[1].Text) + soluong);
                if (tong <= 0)
                {
                    lv_nhap.Items.RemoveAt(index);
                }
                else
                {

                    lv_nhap.Items[index].SubItems[1].Text = tong.ToString();
                    lv_nhap.Items[index].SubItems[2].Text = giatien;
                }
            }
            else
            {
                if (soluong > 0)
                {

                    lsvItem.SubItems.Add(soluong.ToString());
                    lsvItem.SubItems.Add(giatien);
                    lsvItem.Tag = manl;
                    lv_nhap.Items.Add(lsvItem);
                }
            }
            tinhtien();
        }
        int kietralist(string tenma)
        {
            int index = -1;
            for (int i = 0; i < lv_nhap.Items.Count; i++)
            {
                if (lv_nhap.Items[i].Tag.ToString() == tenma) { index = i; break; }
            }
            return index;
        }
        void tinhtien()
        {
            double sum = 0;
            foreach (ListViewItem item in lv_nhap.Items)
            {
                sum += int.Parse(item.SubItems[1].Text) * float.Parse(item.SubItems[2].Text);
            }
            txtb_sum.Text = sum.ToString();
        }

        private void bt_xacnhan_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận đơn hàng", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string mancc = (cb_ncc.SelectedItem as DataRowView)["Mancc"].ToString();
                double sum = double.Parse(txtb_sum.Text);
                DateTime date = dtp_ngaynhap.Value;
                string query = string.Format("exec phieunhap_them {0},{1},'{2}',{3}", manv, mancc, date, sum);
                DataProvider.Instance.ExecuteNonQuery(query);
                string masp;
                string soluong;
                string dongia;

                query = "select Max(mapn) from phieunhap";
                string mabill = DataProvider.Instance.ExecuteScalar(query).ToString();
                foreach (ListViewItem item in lv_nhap.Items)
                {
                    masp = item.Tag.ToString();
                    soluong = item.SubItems[1].Text.ToString();
                    dongia = item.SubItems[2].Text.ToString();
                    query = string.Format("exec phieunhap_nhap {0},{1},{2},{3}", mabill, masp, dongia, soluong);
                    DataProvider.Instance.ExecuteNonQuery(query);
                }
            }
        }
    }
}
