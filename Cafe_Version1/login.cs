using Cafe_Version1.DAL;
using Cafe_Version1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Version1
{
    public partial class formDangNhap : Form
    {
        public formDangNhap()
        {
            InitializeComponent();
        }
        bool DangNhapHienTai(string username, string password)
        {
            return AccountDAL.Instance.Login(username, password) == true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (DangNhapHienTai(username, password) == true)
            {
                Account accLogin = AccountDAL.Instance.LayTaiKhoanDangNhap(username);
                formHome.thuNgan = username;
                formUser.TaiKhoanHienTai = accLogin;
                formTrangChu fTrangChu = new formTrangChu(accLogin);
                this.Hide();
                fTrangChu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username hoặc password không đúng!");
            }
        }

        private void formDangNhap_Load(object sender, EventArgs e)
        {
            //this.ResetMouseEventArgs();
            txtPassword.isPassword = true;
        }


        private void formDangNhap_MouseHover(object sender, EventArgs e)
        {
            this.formDangNhap_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
