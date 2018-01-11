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
    public partial class fChucVu : Form
    {

        BindingSource chucvuList = new BindingSource();
        public fChucVu()
        {
            InitializeComponent();
            dataGridView1.DataSource = chucvuList;
            LoadChucvu();
            AddchucvuBinding();
        }
        void LoadChucvu()
        {
            chucvuList.DataSource = DataProvider.Instance.ExecuteReader("Select * from chucvu");
        }
        void AddchucvuBinding()
        {
            txt_macv.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Macv", true, DataSourceUpdateMode.Never));
            txt_tencv.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "tencv", true, DataSourceUpdateMode.Never));
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            string ten = txt_tencv.Text;
            string query = string.Format("INSERT INTO [dbo].[CHUCVU]([TenCV])VALUES(N'{0}')", ten);
            DataProvider.Instance.ExecuteReader(query);
            LoadChucvu();
        }
        private void btn_xem_Click(object sender, EventArgs e)
        {
            LoadChucvu();
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(txt_macv.Text);
            string ten = txt_tencv.Text;
            string query = string.Format("update chucvu set tencv= N'{1}' where macv= {0}", manv, ten);
            DataProvider.Instance.ExecuteReader(query);
            LoadChucvu();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int macv = int.Parse(txt_macv.Text);
            string query = string.Format("Delete from chucvu where macv= {0}", macv);
            DataProvider.Instance.ExecuteReader(query);
            LoadChucvu();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (txt_timkiem_ma.Text == "")
            {
                string name = txt_timkiem_ten.Text;
                string query = string.Format("SELECT * FROM chucvu WHERE dbo.fuConvertToUnsign1(tencv) LIKE '%'+dbo.fuConvertToUnsign1(N'{0}')+'%'", name);
                DataTable data = DataProvider.Instance.ExecuteReader(query);
                chucvuList.DataSource = data;
            }
            else
            {
                int manv = int.Parse(txt_timkiem_ma.Text);
                string query = string.Format("SELECT * FROM chucvu WHERE macv = {0}", manv);
                DataTable data = DataProvider.Instance.ExecuteReader(query);
                chucvuList.DataSource = data;
            }
        }
    }
}
