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
    public partial class fluong : Form
    {
        public string manv;
        public fluong(string manv )
        {
            InitializeComponent();
            this.manv = manv;//phan biet this.manv la cai truyen vao , con khong la cai ma nv trong bang do 
            Loadluong(manv);
        }
        void Loadluong(string manv )
        {
            txtb_manv.Text = DataProvider.Instance.ExecuteScalar("select tennv from nhanvien where manv=" + manv).ToString();
            if (DataProvider.Instance.ExecuteReader("Select * from luong where manv =" + manv).Rows.Count > 0)
            {
                txtb_lcb.Text = DataProvider.Instance.ExecuteScalar("select luongcoban from luong where manv=" + manv).ToString();
                txtb_hesoluong.Text = DataProvider.Instance.ExecuteScalar("select hesoluong from luong where manv=" + manv).ToString();
                txtb_phucap.Text = DataProvider.Instance.ExecuteScalar("select phucap from luong where manv=" + manv).ToString();


            }

        }
        private void btn_sua_click(object sender, EventArgs e)
        {
            
            string lcb = txtb_lcb.Text; 
            string hesoluong= txtb_hesoluong.Text;
            string phuccap=txtb_phucap.Text;

            string query = string.Format("exec luong_sua {0},{1},{2} ,{3}",  this.manv, lcb,hesoluong,phuccap);

            DataTable data = DataProvider.Instance.ExecuteReader(query);
        

        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
