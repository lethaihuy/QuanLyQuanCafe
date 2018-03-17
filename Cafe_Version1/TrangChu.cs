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
        public formTrangChu()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {  
            pnLeft.Top = btnHeThong.Top;
            pnLeft.Height = btnHeThong.Height;
            pnLeft.Visible = true;
            Color.FromArgb(128, 204, 255);
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            pnLeft.Visible = true;
            btnHeThong.BackColor = Color.FromArgb(128, 204, 255);
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
            btnHeThong.BackColor = Color.FromArgb(128, 204, 255);
            pnLeft.Top = BtnBan.Top;
            pnLeft.Height = BtnBan.Height;
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            pnLeft.Visible = true;
            btnHeThong.BackColor = Color.FromArgb(128, 204, 255);
            pnLeft.Top = btnDoanhThu.Top;
            pnLeft.Height = btnDoanhThu.Height;
        }

        private void formTrangChu_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            lbThoiGian.Text = time.ToString("HH:mm:ss");
            lbNgay.Text = time.ToString("dddd, dd/MM/yyyy");
        }
    }
}
