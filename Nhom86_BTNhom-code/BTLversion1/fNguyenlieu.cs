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
    public partial class fnguyenlieu : Form
    {

        BindingSource nhanvienList = new BindingSource();
        public fnguyenlieu()
        {
            InitializeComponent();
            dgv_nl.DataSource = nhanvienList;
            Loadnguyenlieu();
            Addnguyenlieubinding();
        }
        void Addnguyenlieubinding()
        {
            txtb_manl.DataBindings.Add(new Binding("Text", dgv_nl.DataSource, "Manl", true, DataSourceUpdateMode.Never));
            txtb_tennl.DataBindings.Add(new Binding("Text", dgv_nl.DataSource, "tennl", true, DataSourceUpdateMode.Never));
        }
        void Loadnguyenlieu()
        {
            nhanvienList.DataSource = DataProvider.Instance.ExecuteReader("Select * from nguyenlieu");
        }
        private void btn_them_click(object sender, EventArgs e)
        {
            string tennl = txtb_tennl.Text;
            string query = string.Format("exec nguyenlieu_them N'{0}'", tennl);
            DataProvider.Instance.ExecuteNonQuery(query);
            if (DataProvider.Instance.ExecuteNonQuery(query) > 0) MessageBox.Show("Thêm thành công"); else MessageBox.Show("Thêm không thành công");

            Loadnguyenlieu();

        }
        private void btn_xem_click(object sender, EventArgs e)
        {
            Loadnguyenlieu();
        }

        private void btn_sua_click(object sender, EventArgs e)
        {
            int manl = int.Parse(txtb_manl.Text);
            string tennl = txtb_tennl.Text;
            string query = string.Format("exec nguyenlieu_sua '{0}',N'{1}'", manl, tennl);
            DataProvider.Instance.ExecuteNonQuery(query);
            if (DataProvider.Instance.ExecuteNonQuery(query) > 0) MessageBox.Show("Sửa thành công"); else MessageBox.Show("Sửa không thành công");

            Loadnguyenlieu();
        }

        private void btn_xoa_click(object sender, EventArgs e)
        {
            int manl = int.Parse(txtb_manl.Text);
            string query = string.Format("exec nguyenlieu_xoa {0}", manl);
            DataProvider.Instance.ExecuteNonQuery(query);
            if (DataProvider.Instance.ExecuteNonQuery(query) > 0) MessageBox.Show("Xóa thành công"); else MessageBox.Show("Xóa không thành công");

            Loadnguyenlieu();
        }

        private void btn_timkiem_click(object sender, EventArgs e)
        {
            if (txtb_timkiem_manl.Text == "")
            {
                string name = txtb_timkiem_tennl.Text;
                string query = string.Format("SELECT * FROM nguyenlieu WHERE dbo.fuConvertToUnsign1(tennl) LIKE '%'+dbo.fuConvertToUnsign1(N'{0}')+'%'", name);
                DataTable data = DataProvider.Instance.ExecuteReader(query);
                nhanvienList.DataSource = data;
            }
            else
            {
                int manl = int.Parse(txtb_timkiem_manl.Text);
                string query = string.Format("SELECT * FROM nguyenlieu WHERE manl = {0}", manl);
                DataTable data = DataProvider.Instance.ExecuteReader(query);
                nhanvienList.DataSource = data;
            }
        }
    }
}
