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
    public partial class formTrangChu : Form
    {
        bool drag = false;
        Point startPoint = new Point(0, 0);
        public DateTime time;
        public formTrangChu(Account acc)
        {
            InitializeComponent();

            this.TaiKhoanDangNhap = acc;

        }

        private Account taiKhoanDangNhap;


        public Account TaiKhoanDangNhap
        {
            get
            {
                return taiKhoanDangNhap;
            }

            set
            {
                taiKhoanDangNhap = value;
                DoiTaiKhoan(taiKhoanDangNhap.LoaiTaiKhoan);
            }
        }

        void DoiTaiKhoan(string loaiTK)
        {
            //Phân quyền admin và nhân viên
            if (loaiTK == "Admin")
            {
                this.btnQLNhanVien.Enabled = true;
                this.btnThietLap.Enabled = true;
            }
       
           
            this.lbPhanQuyen.Text = TaiKhoanDangNhap.LoaiTaiKhoan;
            this.lbTenTaiKhoanDangNhap.Text = TaiKhoanDangNhap.TenHienThi;
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Color.FromArgb(128, 204, 255);
            formHome home = new formHome();
            this.Hide();
            home.ShowDialog();
            this.Show();
        }

        private void formTrangChu_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnThietLap_Click(object sender, EventArgs e)
        {
            formDanhMuc fDanhMuc = new formDanhMuc();
            fDanhMuc.ShowDialog();
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            formQLTaiKhoan fTaiKhoan = new formQLTaiKhoan();
            fTaiKhoan.ShowDialog();
        }


        int chay = 10;


        private void timer1_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now;
                   
            if (time.DayOfWeek == DayOfWeek.Monday)
            {
                lbThu.Text = "Thứ 2";
            }
            else if (time.DayOfWeek == DayOfWeek.Tuesday)
            {
                lbThu.Text = "Thứ 3";
            }
            else if (time.DayOfWeek == DayOfWeek.Wednesday)
            {
                lbThu.Text = "Thứ 4";
            }
            else if (time.DayOfWeek == DayOfWeek.Thursday)
            {
                lbThu.Text = "Thứ 5";
            }
            else if (time.DayOfWeek == DayOfWeek.Friday)
            {
                lbThu.Text = "Thứ 6";
            }
            else if (time.DayOfWeek == DayOfWeek.Saturday)
            {
                lbThu.Text = "Thứ 7";
            }
            else if (time.DayOfWeek == DayOfWeek.Sunday)
            {
                lbThu.Text = "Chủ nhật";
            }

            lbThoiGian.Text = time.ToString("HH:mm:ss");

            lbNgay.Text = time.ToString("dd");
            lbThangNam.Text = time.ToString("MM/yyyy");

            formHome.Ngaythang = lbThu.Text+", " + time.ToString("dd/MM/yyyy");

            //lbXinChao.Location = new Point(lbXinChao.Location.X + chay, lbXinChao.Location.Y);
            //if (lbXinChao.Location.X > 877)
            //{
            //    lbXinChao.Location = new Point(lbXinChao.Location.X - 385, lbXinChao.Location.Y);
            //}
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random ran = new Random();
            Color mau = Color.FromArgb(ran.Next(256), ran.Next(256), ran.Next(256));
            //pnThoiGian.BackColor = mau;
            lbTenQuan.ForeColor = mau;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void itemUser_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            formUser f = new formUser();
            f.ShowDialog();
        }

        private void formTrangChu_MouseDown(object sender, MouseEventArgs e)
        {
            this.drag = true;
            this.startPoint = new Point(e.X, e.Y);
        }

        private void formTrangChu_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void formTrangChu_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void picAvatar_MouseDown(object sender, MouseEventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            if (e.Button == MouseButtons.Right)
            {
                menu.Items.Add("Chỉnh sửa").Name = "Chỉnh sửa";
                menu.Items.Add("Đổi mật khẩu").Name = "Đổi mật khẩu";
                menu.Items.Add("Đăng xuất").Name = "Đăng xuất";
                menu.Items.Add("Hủy").Name = "Hủy";
                menu.Show(picAvatar, new Point(e.X, e.Y));
            }

            menu.ItemClicked += Menu_ItemClicked;
        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "Chỉnh sửa")
            {
                formUser fSua = new formUser();
                formUser.ThayDoi = false;
                fSua.ShowDialog();
            }
            else if (e.ClickedItem.Name == "Đổi mật khẩu")
            {
                formUser fSua = new formUser();
                formUser.ThayDoi = true;
                fSua.ShowDialog();
            }
            else if (e.ClickedItem.Name == "Đăng xuất")
            {
                formDangNhap fDangNhap = new formDangNhap();
                this.Close();
                fDangNhap.ShowDialog();
            }
        }

        #region  Event

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            FormDoanhthu fDoanhthu = new FormDoanhthu();
            this.Hide();
            fDoanhthu.ShowDialog();
            this.Show();
        }

        #endregion

    }
}
