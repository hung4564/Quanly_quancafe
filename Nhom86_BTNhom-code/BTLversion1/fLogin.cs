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
    public partial class fLogin : Form
    {
        string manv;
        string type;
        public fLogin()
        {
            InitializeComponent();
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool IsLogin(string username, string password)
        {
            string query = string.Format("USP_Login '{0}' , '{1}'", username, password);
            DataTable result = DataProvider.Instance.ExecuteReader(query);
            //    this.manv = result.Rows[0]["manv"].ToString();
            //    this.type = result.Rows[0]["type"].ToString();
            //    return result.Rows.Count > 0;
            if (result.Rows.Count > 0)
            {
                this.manv = result.Rows[0]["manv"].ToString();
                this.type = result.Rows[0]["type"].ToString();
                return true;
            }
            else return false;
        }
        private void flogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit ? ", "Notifications", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
                this.Show();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            if (IsLogin(username, password))
            {
                fhome f = new fhome(manv, type);
                this.Hide();
                f.ShowDialog();
                if (f.login) this.Show();
                else Application.Exit();
            }
            else
            {
                DialogResult reslut = MessageBox.Show("Ban nhap sai mat khau\nBan muon nhap lai khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (reslut == DialogResult.No) this.Close();
            }
        }

    }
}
