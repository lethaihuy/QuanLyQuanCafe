using Cafe_Version1.DAL;
using Cafe_Version1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Version1
{
    public partial class formUser : Form
    {
        private static bool thayDoi;

        Bunifu.Framework.UI.Drag dr = new Bunifu.Framework.UI.Drag();
        public formUser()
        {
            InitializeComponent();
        }

        private static Account taiKhoanHienTai;
        public static Account TaiKhoanHienTai
        {
            get
            {
                return taiKhoanHienTai;
            }

            set
            {
                taiKhoanHienTai = value;
            }
        }

        public static bool ThayDoi
        {
            get
            {
                return thayDoi;
            }

            set
            {
                thayDoi = value;
            }
        }

        private void pnheader_MouseUp(object sender, MouseEventArgs e)
        {
            dr.Release();
        }

        private void pnheader_MouseMove(object sender, MouseEventArgs e)
        {
            dr.MoveObject();
        }

        private void pnheader_MouseDown(object sender, MouseEventArgs e)
        {
            dr.Grab(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void DoiMatKhau(string username, string tenHienThi, string passwordcu, string passwordMoi, string nhapLaiPass)
        {
            if (tenHienThi == "" || passwordcu == "" || passwordMoi == "" || nhapLaiPass == "")
            {
                MessageBox.Show("Không được để trống!", "Thông báo");
            }
            else
            {
                if (passwordMoi != nhapLaiPass)
                {
                    MessageBox.Show("Password mới nhập không trùng nhau .", "Thông báo");
                }
                else
                {
                    if (AccountDAL.Instance.ThayDoiMatKhau(username, passwordMoi, tenHienThi))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu không thành công!", "Thông báo");
                    }
                }
            }
        }
        private void btnSuaUser_Click(object sender, EventArgs e)
        {
            string username = this.txtUsername.Text;
            string tenHienThi = this.txtTenHienThi.Text;
            string passwordcu = this.txtPassword.Text;
            string passwordMoi = this.txtPasswordMoi.Text;
            string nhapLaiPass = this.txtNhapLaiPassword.Text;

            if (thayDoi)
            {
                if (!string.IsNullOrEmpty(passwordMoi) || !string.IsNullOrEmpty(nhapLaiPass))
                {
                    DoiMatKhau(username, tenHienThi, passwordcu, passwordMoi, nhapLaiPass);
                }
            }
            else
            {
                if (tenHienThi == "" || passwordcu == "")
                {
                    MessageBox.Show("Không dược để trống!", "Thông báo");
                }
                else
                {
                    if (AccountDAL.Instance.SuaTaiKhoan(username, passwordcu, tenHienThi))
                    {
                        MessageBox.Show("Cập nhật tài khoản thành công !", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật tài khoản không thành công! Xin kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
          
            //Đổi mật khẩu
            


        }

        private void formUser_Load(object sender, EventArgs e)
        {
            this.txtUsername.Text = TaiKhoanHienTai.Username;
            this.txtTenHienThi.Text = TaiKhoanHienTai.TenHienThi;

            if (thayDoi)
            {
                this.txtPasswordMoi.Visible = true;
                this.txtNhapLaiPassword.Visible = true;
                this.lbPasswordMoi.Visible = true;
                this.lbNhapLaiPassword.Visible = true;
            }
        }
    }
}