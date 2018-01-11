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
    public partial class fBIll : Form
    {
        string manv;
        string maban;
        string trangthai;
        string mabill;
        public fBIll(string maban, string manv)
        {
            InitializeComponent();
            this.manv = manv;
            this.maban = maban;
            label1.Text = DataProvider.Instance.ExecuteScalar(string.Format("Select tenban from ban where maban = {0}", maban)).ToString();
            this.trangthai = DataProvider.Instance.ExecuteScalar(string.Format("Select trangthai from ban where maban = {0}", maban)).ToString();
            LoadSanpham();
            LoadKH();
            lv_bill.View = View.Details;
            if (trangthai != "Trống")
            {
                string query = string.Format("select Mapt from Phieuthu where maban = {0} and tinhtrang = 0", maban);
                this.mabill = DataProvider.Instance.ExecuteScalar(query).ToString();
                LoadBill(mabill);
                tinhtien();
                Loadthongtin("0", mabill, manv);
            }
            else mabill = null;
        }
        void LoadKH()
        {
            comboBox1.DataSource = DataProvider.Instance.ExecuteReader("select makh,tenkh from  khachhang");
            comboBox1.DisplayMember = "tenkh";
        }
        int foodWidtht = 100;
        int foodHeight = 100;
        void LoadSanpham()
        {
            DataTable foodList = DataProvider.Instance.ExecuteReader("select * from Sanpham where masp>0");
            foreach (DataRow food in foodList.Rows)
            {
                Button bt = new Button()
                {
                    Width = foodWidtht,
                    Height = foodHeight,
                    Text = food["TenSp"].ToString() + "\n" + food["DonGia"].ToString(),
                    Tag = food["MaSP"].ToString()
                };

                bt.Click += Bt_Click;
                flp_food.Controls.Add(bt);
            }
        }
        void LoadBill(string mabill)
        {

            string query = string.Format("select sanpham.masp,sanpham.tensp,Chitietphieuthu.SoLuong,Chitietphieuthu.dongia from Chitietphieuthu,sanpham where mapt={0} and chitietphieuthu.masp=sanpham.masp ", mabill);
            DataTable billList = DataProvider.Instance.ExecuteReader(query);
            foreach (DataRow bill in billList.Rows)
            {
                ListViewItem lsvItem = new ListViewItem(bill["tensp"].ToString());
                lsvItem.SubItems.Add(bill["Soluong"].ToString());
                lsvItem.SubItems.Add(bill["dongia"].ToString());
                lsvItem.Tag = bill["masp"].ToString();
                lv_bill.Items.Add(lsvItem);
            }
        }
        void Loadthongtin(string makh, string mabill, string manv)
        {
            txtb_NV.Text = DataProvider.Instance.ExecuteScalar("select tennv from nhanvien where manv= " + manv).ToString();
            txt_Giovao.Text = DataProvider.Instance.ExecuteScalar("Select Giovao from phieuthu where mapt= " + mabill).ToString();
            txtb_MaPT.Text = mabill;
        }
        int kietralist(string tenma)
        {
            int index = -1;
            for (int i = 0; i < lv_bill.Items.Count; i++)
            {
                if (lv_bill.Items[i].Text == tenma) { index = i; break; }
            }
            return index;
        }
        void tinhtien()
        {
            double sum = 0;
            foreach (ListViewItem item in lv_bill.Items)
            {
                sum += int.Parse(item.SubItems[1].Text) * float.Parse(item.SubItems[2].Text);
            }
            txtb_sum.Text = sum.ToString();
            txtb_thanhtien.Text = (double.Parse(txtb_sum.Text) * (100 - (int)nd_phantram.Value) / 100).ToString();
        }
        private void Bt_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            string[] sp = bt.Text.Split('\n');
            ListViewItem lsvItem = new ListViewItem(sp[0]);
            int index = kietralist(sp[0]);
            if (index >= 0)
            {
                string soluong = (int.Parse(lv_bill.Items[index].SubItems[1].Text) + 1).ToString();
                lv_bill.Items[index].SubItems[1].Text = soluong;
                lv_bill.Items[index].SubItems[2].Text = sp[1];
            }
            else
            {
                lsvItem.SubItems.Add("1");
                lsvItem.SubItems.Add(sp[1]);
                lsvItem.Tag = bt.Tag.ToString();
                lv_bill.Items.Add(lsvItem);
            }
            tinhtien();
        }
        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            fHoadon f = new fHoadon(label1.Text,txtb_thanhtien.Text);
            f.ShowDialog();
            DataRowView khach = comboBox1.SelectedItem as DataRowView;
            if(f.thanhtoan)
            {
                DateTime giora = DateTime.Now;
                DataProvider.Instance.ExecuteNonQuery("update phieuthu set makh = "+ khach[0].ToString()+" where mapt = "+mabill);
                string query = string.Format("exec hoadon_thanhtoan  {0},'{1}',{2},{3}", mabill, giora,nd_phantram.Value ,txtb_thanhtien.Text);
                DataProvider.Instance.ExecuteNonQuery(query);
                this.Close();
            }

        }

        private void bt_gọi_Click(object sender, EventArgs e)
        {
            DateTime giovao = DateTime.Now;
            if (this.trangthai == "Trống")
            {
                string query = string.Format("exec hoadon_tao {0},{1},'{2}'", manv, maban, giovao);
                DataProvider.Instance.ExecuteNonQuery(query);
                query = string.Format("select Mapt from Phieuthu where maban = {0} and tinhtrang = 0", maban);
                this.mabill = DataProvider.Instance.ExecuteScalar(query).ToString();
                string masp;
                string soluong;
                foreach (ListViewItem item in lv_bill.Items)
                {
                    masp = item.Tag.ToString();
                    soluong = item.SubItems[1].Text.ToString();
                    query= string.Format("exec hoadon_nhap {0},{1},{2}", mabill, masp, soluong);
                    DataProvider.Instance.ExecuteNonQuery(query);
                }
                this.Close();
            }
            else
            {
                string query;
                string masp;
                string soluong;
                foreach (ListViewItem item in lv_bill.Items)
                {
                    masp = item.Tag.ToString();
                    soluong = item.SubItems[1].Text.ToString();
                    query = string.Format("exec hoadon_nhap {0},{1},{2}", mabill, masp, soluong);
                    DataProvider.Instance.ExecuteNonQuery(query);
                }
                this.Close();
            }
        }

        private void lv_bill_Click(object sender, EventArgs e)
        {
            ListViewItem sp = lv_bill.SelectedItems[0];
            string tensp = sp.Text;
            string soluong = sp.SubItems[1].Text;
            fFood_bill f = new fFood_bill(tensp, soluong);
            f.ShowDialog();
            if (f.xoa)
            {
                lv_bill.Items.Remove(sp);
            }
            else
            {
                lv_bill.SelectedItems[0].SubItems[1].Text = f.soluong;
            }
            tinhtien();
        }

        private void nd_phantram_ValueChanged(object sender, EventArgs e)
        {
            txtb_thanhtien.Text = (double.Parse(txtb_sum.Text) * (100 - (int)nd_phantram.Value) / 100).ToString();
        }
    }
}
