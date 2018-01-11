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
    public partial class fPhaChe : Form
    {
        public fPhaChe()
        {
            InitializeComponent();
            cd_nguyenlieu.DataSource = DataProvider.Instance.ExecuteReader("Select * from nguyenlieu where manl>0");
            cd_nguyenlieu.DisplayMember = "tennl";
            cb_sp.DataSource = DataProvider.Instance.ExecuteReader("Select * from sanpham where masp>0");
            cb_sp.DisplayMember = "tensp";
        }
        void Loadcongthuc()
        {
            lv_nguyenlieu.Items.Clear();
            string masp = (cb_sp.SelectedItem as DataRowView)["Masp"].ToString();
            string query = "select nguyenlieu.manl,nguyenlieu.tennl,sll from phache,nguyenlieu where nguyenlieu.manl=phache.manl and masp=" + masp;

            DataTable data = DataProvider.Instance.ExecuteReader(query);
            foreach (DataRow row in data.Rows)
            {
                ListViewItem lsvItem = new ListViewItem(row["tennl"].ToString());
                lsvItem.SubItems.Add(row["Sll"].ToString());
                lsvItem.Tag = row["manl"].ToString();
                lv_nguyenlieu.Items.Add(lsvItem);
            }
        }
        private void bt_nhap_Click(object sender, EventArgs e)
        {
            if (lv_nguyenlieu.Tag != null)
            {
                string manl = (cd_nguyenlieu.SelectedItem as DataRowView)["Manl"].ToString();
                string tennl = (cd_nguyenlieu.SelectedItem as DataRowView)["tennl"].ToString();
                int soluong = (int)nd_soluong.Value;
                NhapItemTolist(manl, tennl, soluong);
            }
        }
        void NhapItemTolist(string manl, string tennl, int soluong)
        {
            ListViewItem lsvItem = new ListViewItem(tennl);
            int index = kietralist(manl);
            if (index >= 0)
            {
                int tong = (int.Parse(lv_nguyenlieu.Items[index].SubItems[1].Text) + soluong);
                if (tong <= 0)
                {
                    lv_nguyenlieu.Items.RemoveAt(index);
                }
                else
                {

                    lv_nguyenlieu.Items[index].SubItems[1].Text = tong.ToString();
                }
            }
            else
            {
                if (soluong > 0)
                {

                    lsvItem.SubItems.Add(soluong.ToString());
                    lsvItem.Tag = manl;
                    lv_nguyenlieu.Items.Add(lsvItem);
                }
            }
        }
        int kietralist(string tenma)
        {
            int index = -1;
            for (int i = 0; i < lv_nguyenlieu.Items.Count; i++)
            {
                if (lv_nguyenlieu.Items[i].Tag.ToString() == tenma) { index = i; break; }
            }
            return index;
        }

        private void bt_xacnhan_Click(object sender, EventArgs e)
        {
            if (lv_nguyenlieu.Tag != null)
            {
                string tenmon = DataProvider.Instance.ExecuteScalar("Select masp from sanpham where masp=" + lv_nguyenlieu.Tag.ToString()).ToString();
                DialogResult result = MessageBox.Show("Xác nhận công thức cho món" + tenmon, "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string query;
                    string masp = (cb_sp.SelectedItem as DataRowView)["Masp"].ToString();
                    string manl;
                    string soluong;
                    query = string.Format("delete from phache where masp = " + masp);
                    DataProvider.Instance.ExecuteNonQuery(query);
                    foreach (ListViewItem item in lv_nguyenlieu.Items)
                    {
                        manl = item.Tag.ToString();
                        soluong = item.SubItems[1].Text.ToString();
                        query = string.Format("exec phache_nhap {0},{1},{2}", masp, manl, soluong);
                        DataProvider.Instance.ExecuteNonQuery(query);
                    }
                }
            }
            else
                MessageBox.Show("CHọn sản phẩm để chỉnh trước");
        }

        private void bt_chinh_Click(object sender, EventArgs e)
        {
            string masp = (cb_sp.SelectedItem as DataRowView)["Masp"].ToString();
            lv_nguyenlieu.Tag = masp;
            Loadcongthuc();
        }
    }
}
