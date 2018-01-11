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
    public partial class fhome : Form
    {
        string maNv;
        string type;
        public bool login = false;
        public fhome(string manv, string type)
        {
            InitializeComponent();
            this.maNv = manv;
            this.type = type;
            string query = "select* from[SAN_PHAM_DAT_NHAT]";
            dgv_sanphamdat.DataSource = DataProvider.Instance.ExecuteReader(query);
            query = "select* from[SAN_PHAM_RE_NHAT]";
            dgv_sanphamre.DataSource = DataProvider.Instance.ExecuteReader(query);
            query = "select* from[SAN_PHAM_MAX]";
            dgv_sanphammax.DataSource = DataProvider.Instance.ExecuteReader(query);
            query = "select* from[SAN_PHAM_MIN]";
            dgv_sanphammin.DataSource = DataProvider.Instance.ExecuteReader(query);

            query = "select* from[THONG_KE_CHUC_VU]";
            dgv_cv.DataSource = DataProvider.Instance.ExecuteReader(query);
            query = "select* from[BANG_LUONG]";
            dgv_luong.DataSource = DataProvider.Instance.ExecuteReader(query);
            query = "select* from[NHAN_VIEN_CHAM_CHI_NHAT]";
            dgv_nhanvienchamchi.DataSource = DataProvider.Instance.ExecuteReader(query);
            query = "select* from[NHA_CUNG_CAP_TIN_CAY]";
            dgv_ncc.DataSource = DataProvider.Instance.ExecuteReader(query);

            query = " exec [DOANH_THU_MAX]";
            dgv_thang.DataSource = DataProvider.Instance.ExecuteReader(query);
            query = "select* from[HOA_DON_MAX]";
            dgv_hoadon.DataSource = DataProvider.Instance.ExecuteReader(query);
            query = "select* from[KHACH_HANG_TIEM_NANG ]";
            dgv_kh.DataSource = DataProvider.Instance.ExecuteReader(query);
            query = "select* from[NGUYENLIEUNHAPNHIEUTIENNHAT]";
            dgv_nguyenlieu.DataSource = DataProvider.Instance.ExecuteReader(query);

        }

        private void pictureboxstaff_Click(object sender, EventArgs e)
        {
            fstaff fsta = new fstaff();
            this.Hide();
            fsta.ShowDialog();
            this.Show();

        }

        private void pictureboxcustomer_Click(object sender, EventArgs e)
        {
            fcustomer fcus = new fcustomer();
            this.Hide();
            fcus.ShowDialog();
            this.Show();
        }

        private void pictureboxsanpham_Click(object sender, EventArgs e)
        {
            fdouong fdou = new fdouong();
            this.Hide();
            fdou.ShowDialog();
            this.Show();
        }

        private void pictureboxnguyenlieu_Click(object sender, EventArgs e)
        {
            fnguyenlieu fngu = new fnguyenlieu();
            this.Hide();
            fngu.ShowDialog();
            this.Show();
        }

        private void pictureboxluong_Click(object sender, EventArgs e)
        {
            fluong fluo = new fluong(maNv);
            this.Hide();
            fluo.ShowDialog();
            this.Show();
        }

        private void fhome_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void logout_click(object sender, EventArgs e)
        {
            login = true;
            this.Close();
        }

        private void exit_click(object sender, EventArgs e)
        {
            login = false;
            this.Close();
        }

        private void ban_click(object sender, EventArgs e)
        {
            fTable f = new fTable(maNv);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void nhacungcap_Click(object sender, EventArgs e)
        {
            fnhacungcap fnha = new fnhacungcap();
            this.Hide();
            fnha.ShowDialog();
            this.Show();
        }

        private void nhaphang_Click(object sender, EventArgs e)
        {
            fNhapHang fNhap = new fNhapHang(maNv);
            this.Hide();
            fNhap.ShowDialog();
            this.Show();
        }

        private void phache_Click(object sender, EventArgs e)
        {
            fPhaChe fpha = new fPhaChe();
            this.Hide();
            fpha.ShowDialog();
            this.Show();
        }

        private void chamcong_click(object sender, EventArgs e)
        {
            fChamcong fcha = new fChamcong(maNv);
            this.Hide();
            fcha.ShowDialog();
            this.Show();
        }


    }
}
