using Cafe_Version1.DAL;
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

        private void btnSaveTaiKhoan_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string tenHienThi = txtTenHienThi.Text;
            string loaiTaiKhoan = cbLoaiTaiKhoan.SelectedItem.ToString();

            string file = openFileDialog1.FileName;

            //Username không dc trùng
            try
            {
                if (this.dsAcc.Equals(username) == true && username == "")
                {
                    MessageBox.Show("username này đã tồn tại !", "thông báo");
                }
                else
                {
                    if (AccountDAL.Instance.ThemTaiKhoan(username, password, tenHienThi, loaiTaiKhoan, file))
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

        private void btnLoadAnh_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string file = openFileDialog1.FileName;
            if (string.IsNullOrEmpty(file))
                return;
            Image myImage = Image.FromFile(file);
            picAnh.Image = myImage;
        }

        byte[] ConvertImageToBinary(Image img)
        {
            string file = openFileDialog1.FileName;
            Image myImage = Image.FromFile(file);
            FileStream fs;
            fs = new FileStream(file, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }

        Image ByteToImg(string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = picAnh.Image;
            return image;
        }
    }
}