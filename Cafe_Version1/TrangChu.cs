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
        public formTrangChu()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            pnLeft.Top = btnThanhToan.Top;
            pnLeft.Height = btnThanhToan.Height;
            pnLeft.Visible = true;
            Color.FromArgb(128, 204, 255);
            formHome home = new formHome();
            this.Hide();
            home.ShowDialog();
            this.Show();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            pnLeft.Visible = true;
            btnThanhToan.BackColor = Color.FromArgb(128, 204, 255);
            pnLeft.Top = btnDanhMuc.Top;
            pnLeft.Height = btnDanhMuc.Height;
        }

        private void btnDoUong_Click(object sender, EventArgs e)
        {
            pnLeft.Top = btnDoUong.Top;
            pnLeft.Height = btnDoUong.Height;
        }

        private void BtnBan_Click(object sender, EventArgs e)
        {
            pnLeft.Visible = true;
            pnLeft.Top = BtnBan.Top;
            pnLeft.Height = BtnBan.Height;
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            pnLeft.Visible = true;
            pnLeft.Top = btnDoanhThu.Top;
            pnLeft.Height = btnDoanhThu.Height;
        }

        private void formTrangChu_Load(object sender, EventArgs e)
        {
            this.pnLeft.Visible = false;
            time = DateTime.Now;
            this.tileItem2.Text = time.ToString("dddd") + Environment.NewLine + time.ToString("dd");     
        }
        int chay = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now;
            lbThoiGian.Text = time.ToString("HH:mm:ss");
            lbNgay.Text = time.ToString("dddd, dd/MM/yyyy");
            lbXinChao.Location = new Point(lbXinChao.Location.X + chay, lbXinChao.Location.Y);
            if (lbXinChao.Location.X > 877)
            {
                lbXinChao.Location = new Point(lbXinChao.Location.X - 385, lbXinChao.Location.Y);
            }
        }

        private void pnHeader_MouseDown(object sender, MouseEventArgs e)
        {
            this.drag = true;
            this.startPoint = new Point(e.X, e.Y);
        }

        private void pnHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void pnHeader_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void itemUser_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            formUser f = new formUser();
            f.ShowDialog();
        }

    }
}
