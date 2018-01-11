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
    public partial class fChuyenban : Form
    {
        public string mabangoc;
        public string mabanchuyen;
        public fChuyenban()
        {
            InitializeComponent();
            cb_goc.DataSource = LoadListTable();
            cb_goc.DisplayMember = "tenban";
            cb_chuyen.DataSource = LoadListTable();
            cb_chuyen.DisplayMember = "tenban";
        }
        DataTable LoadListTable()
        {
            string query = "select * from Ban where maban>0";
            DataTable tableList = DataProvider.Instance.ExecuteReader(query);
            return tableList;
        }

        private void bt_chuyen_Click(object sender, EventArgs e)
        {
            DataRowView goc = cb_goc.SelectedItem as DataRowView;
            DataRowView chuyen = cb_chuyen.SelectedItem as DataRowView;
            if (goc[0].ToString() == chuyen[0].ToString())
                MessageBox.Show("Bạn không thể chuyển lại chính bàn cũ");
            else if (goc[2].ToString() == "Trống")
                MessageBox.Show("Bàn trống chuyển làm gì");
            else if (chuyen[2].ToString() != "Trống")
                MessageBox.Show("Bàn đã có người không thể chuyển");
            else
            {
                DialogResult result= MessageBox.Show(string.Format("Bạn muốn chuyển từ bàn {0} sang {1}?", goc[1].ToString(), chuyen[1].ToString()),"Chú ý",MessageBoxButtons.YesNo);
                if(result==DialogResult.Yes)
                {
                    mabangoc = goc[0].ToString();
                    mabanchuyen = chuyen[0].ToString();
                    MessageBox.Show("Đã chuyển bàn");
                    this.Close();
                }
            }
        }

        private void bt_quaylai_Click(object sender, EventArgs e)
        {
            this.mabanchuyen = null;
            this.mabangoc = null;
            this.Close();
        }
    }
}
