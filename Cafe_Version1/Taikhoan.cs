using Cafe_Version1.DAL;
using Cafe_Version1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Version1
{
    public partial class formQLTaiKhoan : Form
    {
        BindingSource dsAcc = new BindingSource();

        string filename = string.Empty;
        public formQLTaiKhoan()
        {
            InitializeComponent();
            dgvTaiKhoan.DataSource = dsAcc;
            LoadDanhSachTaikhoan();
            BindingTaiKhoan();

        }

        void LoadDanhSachTaikhoan()
        {
            dsAcc.DataSource = AccountDAL.Instance.LayDanhSachTaiKhoan();
        }

        void BindingTaiKhoan()
        {
            txtUsername.DataBindings.Add(new Binding("text", dgvTaiKhoan.DataSource, "username", true, DataSourceUpdateMode.Never));
            txtPassword.DataBindings.Add(new Binding("text", dgvTaiKhoan.DataSource, "password", true, DataSourceUpdateMode.Never));
            txtTenHienThi.DataBindings.Add(new Binding("text", dgvTaiKhoan.DataSource, "tenHienThi", true, DataSourceUpdateMode.Never));
            cbLoaiTaiKhoan.DataBindings.Add(new Binding("text", dgvTaiKhoan.DataSource, "loaiTaiKhoan", true, DataSourceUpdateMode.Never));
            txtFilename.DataBindings.Add(new Binding("text", dgvTaiKhoan.DataSource, "anhDaiDien", true, DataSourceUpdateMode.Never));
        }
        public bool flag = false;

        void ResetFormTaiKhoan()
        {
            this.txtUsername.Enabled = false;
            this.txtPassword.Enabled = false;
            this.txtTenHienThi.Enabled = false;
        }

        #region Event
        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            this.txtUsername.Enabled = true;
            this.txtPassword.Enabled = true;
            this.txtTenHienThi.Enabled = true;
            this.txtUsername.Focus();
            this.flag = true;
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            if (AccountDAL.Instance.XoaTaiKhoan(username))
            {
                MessageBox.Show("Xóa tài khoản thành công !", "Thông báo");
                this.LoadDanhSachTaikhoan();
            }
        }

        private void btnLoadAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.ShowDialog();
            this.filename = openFile.FileName;
            if (string.IsNullOrEmpty(this.filename))
                return;
            Image myImage = Image.FromFile(this.filename);
            picAnh.Image = myImage;
        }

        private void btnSaveTaiKhoan_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string tenHienThi = txtTenHienThi.Text;
            string loaiTaiKhoan = cbLoaiTaiKhoan.SelectedItem.ToString();
            

            //Username không dc trùng
            try
            {
                if (username == "")
                {
                    MessageBox.Show("username này đã tồn tại !", "thông báo");
                }
                else
                {
                    if (AccountDAL.Instance.ThemTaiKhoan(username, password, tenHienThi, loaiTaiKhoan, this.filename))
                    {
                        MessageBox.Show("Thêm tài khoản thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Bị lỗi", "Thông báo");
                    }
                    this.LoadDanhSachTaikhoan();
                    ResetFormTaiKhoan();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Username này đã tồn tại! Vui lòng kiểm tra lại !", "Thông báo lỗi");
                ResetFormTaiKhoan();
            }

        }

        private void btnHuyTaiKhoan_Click(object sender, EventArgs e)
        {
            ResetFormTaiKhoan();
        }

        #endregion

        private void txtFilename_TextChanged(object sender, EventArgs e)
        {
            try
            {
                picAnh.Image = Image.FromFile(txtFilename.Text);
            }
            catch (Exception)
            {
            }
        
        }
    }
}