using Cafe_Version1.DAL;
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
    public partial class FormDoanhthu : Form
    {
        public FormDoanhthu()
        {
            InitializeComponent();
        }

        private void FormDoanhthu_Load(object sender, EventArgs e)
        {
            int slHDDaThanhToan = Convert.ToInt32(HoaDonDAL.Instance.SoLuongHoaDonDaThanhToan());
            this.lbSoLuong.Text = "Đã thanh toán: " + slHDDaThanhToan;

            int slChuaThanhToan = Convert.ToInt32(HoaDonDAL.Instance.SoLuongHoaDonChuaThanhToan());
            this.lbSoLuongChuaThanhToan.Text = "Chưa thanh toán: " + slChuaThanhToan;

            TongTienTatCaHoaDon();

            LoadDateTimePickerHienTai();
        }

        void TongTienTatCaHoaDon()
        {
            float tongTien = (float)Convert.ToDouble(HoaDonDAL.Instance.TongTienTatCaHoaDon());
            this.lbTongTien.Text = "Tổng thu nhập: " + String.Format("{0:0,0}", tongTien);
        }



        private void cbCheDoXem_SelectedIndexChanged(object sender, EventArgs e)
        {

            DateTime ngayHienTai = DateTime.Now;
            int sltt = 0;

            int slHDTheoNgay = HoaDonDAL.Instance.XemHoaDonTheoNgay((dtpkNgayHienTai.Value).ToString("yyyy/MM/dd")).Rows.Count;



            float tongTienTheoThang = 0;

            if (cbCheDoXem.SelectedIndex == 0)
            {
                if (HoaDonDAL.Instance.TongTienTheoThang(1) is DBNull)
                {
                    tongTienTheoThang = 0;
                }
                else
                {
                    tongTienTheoThang = (float)Convert.ToDouble(HoaDonDAL.Instance.TongTienTheoThang(1).ToString());
                }
                sltt = HoaDonDAL.Instance.XemHoaDonTheoThang(1).Rows.Count;
                this.lbTongTienTheoHD.Text = "Tổng tiền : " + String.Format("{0:0,0 VND}", tongTienTheoThang);
                DanhSachHoaDonTheoThang(1);
                this.lbSLHDTheoNgay.Text = sltt + " hóa đơn";
                this.lbDangXem.Text = "Đang xem : " + cbCheDoXem.SelectedItem.ToString();
            }
            if (cbCheDoXem.SelectedIndex == 1)
            {
                if (HoaDonDAL.Instance.TongTienTheoThang(2) is DBNull)
                {
                    tongTienTheoThang = 0;
                }
                else
                {
                    tongTienTheoThang = (float)Convert.ToDouble(HoaDonDAL.Instance.TongTienTheoThang(2).ToString());
                }
                this.lbTongTienTheoHD.Text = "Tổng tiền : " + String.Format("{0:0,0 VND}", tongTienTheoThang);
                sltt = HoaDonDAL.Instance.XemHoaDonTheoThang(2).Rows.Count;
                DanhSachHoaDonTheoThang(2);
                this.lbSLHDTheoNgay.Text = sltt + " hóa đơn";
            }
            if (cbCheDoXem.SelectedIndex == 2)
            {
                if (HoaDonDAL.Instance.TongTienTheoThang(3) is DBNull)
                {
                    tongTienTheoThang = 0;
                }
                else
                {
                    tongTienTheoThang = (float)Convert.ToDouble(HoaDonDAL.Instance.TongTienTheoThang(3).ToString());
                }
                this.lbTongTienTheoHD.Text = "Tổng tiền : " + String.Format("{0:0,0 VND}", tongTienTheoThang);
                sltt = HoaDonDAL.Instance.XemHoaDonTheoThang(3).Rows.Count;
                DanhSachHoaDonTheoThang(3);
                this.lbSLHDTheoNgay.Text = sltt + " hóa đơn";
                this.lbDangXem.Text = "Đang xem : " + cbCheDoXem.SelectedItem.ToString();
            }
            if (cbCheDoXem.SelectedIndex == 3)
            {
                if (HoaDonDAL.Instance.TongTienTheoThang(4) is DBNull)
                {
                    tongTienTheoThang = 0;
                }
                else
                {
                    tongTienTheoThang = (float)Convert.ToDouble(HoaDonDAL.Instance.TongTienTheoThang(4).ToString());
                }
                this.lbTongTienTheoHD.Text = "Tổng tiền : " + String.Format("{0:0,0 VND}", tongTienTheoThang);
                sltt = HoaDonDAL.Instance.XemHoaDonTheoThang(4).Rows.Count;
                DanhSachHoaDonTheoThang(4);
                this.lbSLHDTheoNgay.Text = sltt + " hóa đơn";
                this.lbDangXem.Text = "Đang xem : " + cbCheDoXem.SelectedItem.ToString();
            }
            if (cbCheDoXem.SelectedIndex == 4)
            {
                if (HoaDonDAL.Instance.TongTienTheoThang(5) is DBNull)
                {
                    tongTienTheoThang = 0;
                }
                else
                {
                    tongTienTheoThang = (float)Convert.ToDouble(HoaDonDAL.Instance.TongTienTheoThang(5).ToString());
                }
                this.lbTongTienTheoHD.Text = "Tổng tiền : " + String.Format("{0:0,0 VND}", tongTienTheoThang);
                sltt = HoaDonDAL.Instance.XemHoaDonTheoThang(5).Rows.Count;
                DanhSachHoaDonTheoThang(5);
                this.lbSLHDTheoNgay.Text = sltt + " hóa đơn";
                this.lbDangXem.Text = "Đang xem : " + cbCheDoXem.SelectedItem.ToString();
            }
            if (cbCheDoXem.SelectedIndex == 5)
            {
                if (HoaDonDAL.Instance.TongTienTheoThang(6) is DBNull)
                {
                    tongTienTheoThang = 0;
                }
                else
                {
                    tongTienTheoThang = (float)Convert.ToDouble(HoaDonDAL.Instance.TongTienTheoThang(6).ToString());
                }
                this.lbTongTienTheoHD.Text = "Tổng tiền : " + String.Format("{0:0,0 VND}", tongTienTheoThang);
                sltt = HoaDonDAL.Instance.XemHoaDonTheoThang(6).Rows.Count;
                DanhSachHoaDonTheoThang(6);
                this.lbSLHDTheoNgay.Text = sltt + " hóa đơn";
                this.lbDangXem.Text = "Đang xem : " + cbCheDoXem.SelectedItem.ToString();
            }
            if (cbCheDoXem.SelectedIndex == 6)
            {
                if (HoaDonDAL.Instance.TongTienTheoThang(7) is DBNull)
                {
                    tongTienTheoThang = 0;
                }
                else
                {
                    tongTienTheoThang = (float)Convert.ToDouble(HoaDonDAL.Instance.TongTienTheoThang(7));
                }
                this.lbTongTienTheoHD.Text = "Tổng tiền : " + String.Format("{0:0,0 VND}", tongTienTheoThang);
                sltt = HoaDonDAL.Instance.XemHoaDonTheoThang(7).Rows.Count;
                DanhSachHoaDonTheoThang(7);
                this.lbSLHDTheoNgay.Text = sltt + " hóa đơn";
                this.lbDangXem.Text = "Đang xem : " + cbCheDoXem.SelectedItem.ToString();
            }
            if (cbCheDoXem.SelectedIndex == 7)
            {
                if (HoaDonDAL.Instance.TongTienTheoThang(8) is DBNull)
                {
                    tongTienTheoThang = 0;
                }
                else
                {
                    tongTienTheoThang = (float)Convert.ToDouble(HoaDonDAL.Instance.TongTienTheoThang(8).ToString());
                }
                this.lbTongTienTheoHD.Text = "Tổng tiền : " + String.Format("{0:0,0 VND}", tongTienTheoThang);
                sltt = HoaDonDAL.Instance.XemHoaDonTheoThang(8).Rows.Count;
                DanhSachHoaDonTheoThang(8);
                this.lbSLHDTheoNgay.Text = sltt + " hóa đơn";
                this.lbDangXem.Text = "Đang xem : " + cbCheDoXem.SelectedItem.ToString();
            }
            if (cbCheDoXem.SelectedIndex == 8)
            {
                if (HoaDonDAL.Instance.TongTienTheoThang(9) is DBNull)
                {
                    tongTienTheoThang = 0;
                }
                else
                {
                    tongTienTheoThang = (float)Convert.ToDouble(HoaDonDAL.Instance.TongTienTheoThang(9).ToString());
                }
                this.lbTongTienTheoHD.Text = "Tổng tiền : " + String.Format("{0:0,0 VND}", tongTienTheoThang);
                sltt = HoaDonDAL.Instance.XemHoaDonTheoThang(9).Rows.Count;
                DanhSachHoaDonTheoThang(9);
                this.lbSLHDTheoNgay.Text = sltt + " hóa đơn";
                this.lbDangXem.Text = "Đang xem : " + cbCheDoXem.SelectedItem.ToString();
            }
            if (cbCheDoXem.SelectedIndex == 9)
            {
                if (HoaDonDAL.Instance.TongTienTheoThang(10) is DBNull)
                {
                    tongTienTheoThang = 0;
                }
                else
                {
                    tongTienTheoThang = (float)Convert.ToDouble(HoaDonDAL.Instance.TongTienTheoThang(10).ToString());
                }
                this.lbTongTienTheoHD.Text = "Tổng tiền : " + String.Format("{0:0,0 VND}", tongTienTheoThang);
                sltt = HoaDonDAL.Instance.XemHoaDonTheoThang(10).Rows.Count;
                DanhSachHoaDonTheoThang(10);
                this.lbSLHDTheoNgay.Text = sltt + " hóa đơn";
                this.lbDangXem.Text = "Đang xem : " + cbCheDoXem.SelectedItem.ToString();
            }
            if (cbCheDoXem.SelectedIndex == 10)
            {
                if (HoaDonDAL.Instance.TongTienTheoThang(11) is DBNull)
                {
                    tongTienTheoThang = 0;
                }
                else
                {
                    tongTienTheoThang = (float)Convert.ToDouble(HoaDonDAL.Instance.TongTienTheoThang(11).ToString());
                }
                this.lbTongTienTheoHD.Text = "Tổng tiền : " + String.Format("{0:0,0 VND}", tongTienTheoThang);
                sltt = HoaDonDAL.Instance.XemHoaDonTheoThang(11).Rows.Count;
                DanhSachHoaDonTheoThang(11);
                this.lbSLHDTheoNgay.Text = sltt + " hóa đơn";
                this.lbDangXem.Text = "Đang xem : " + cbCheDoXem.SelectedItem.ToString();
            }
            if (cbCheDoXem.SelectedIndex == 11)
            {
                if (HoaDonDAL.Instance.TongTienTheoThang(12) is DBNull)
                {
                    tongTienTheoThang = 0;
                }
                else
                {
                    tongTienTheoThang = (float)Convert.ToDouble(HoaDonDAL.Instance.TongTienTheoThang(12).ToString());
                }
                this.lbTongTienTheoHD.Text = "Tổng tiền : " + String.Format("{0:0,0 VND}", tongTienTheoThang);
                sltt = HoaDonDAL.Instance.XemHoaDonTheoThang(12).Rows.Count;
                DanhSachHoaDonTheoThang(12);
                this.lbSLHDTheoNgay.Text = sltt + " hóa đơn";
                this.lbDangXem.Text = "Đang xem : " + cbCheDoXem.SelectedItem.ToString();
            }

        }

        public void LoadDateTimePickerHienTai()
        {
            DateTime time = DateTime.Now;
            dtpkNgayHienTai.Value = time;
        }

        void DanhSachHoaDonTheoNgay(DateTime ngay)
        {
            dgvXemDoanhthu.DataSource = HoaDonDAL.Instance.XemHoaDonTheoNgay((dtpkNgayHienTai.Value).ToString("yyyy/MM/dd"));
        }

        void DanhSachHoaDonTheoThang(int thang)
        {
            dgvXemDoanhthu.DataSource = HoaDonDAL.Instance.XemHoaDonTheoThang(thang);
        }
        private void dtpkNgayHienTai_ValueChanged(object sender, EventArgs e)
        {
            float tongTienTheoNgay = 0;

            string ngayFormat = (dtpkNgayHienTai.Value).ToString("yyyy/MM/dd");

            this.lbDangXem.Text = "Đang xem : " + (dtpkNgayHienTai.Value).ToString("dd/MM/yyyy");

            dgvXemDoanhthu.DataSource = HoaDonDAL.Instance.XemHoaDonTheoNgay(ngayFormat);

            if (HoaDonDAL.Instance.TongTienTheoNgay(ngayFormat) is DBNull)
            {
                tongTienTheoNgay = 0;
            }
            else
            {
                tongTienTheoNgay = (float)Convert.ToDouble(HoaDonDAL.Instance.TongTienTheoNgay(ngayFormat).ToString());
            }

            this.lbTongTienTheoHD.Text = "Tổng tiền : " + String.Format("{0:0,0 VND}", tongTienTheoNgay);

            int sltn = HoaDonDAL.Instance.XemHoaDonTheoNgay(ngayFormat).Rows.Count;
            this.lbSLHDTheoNgay.Text = sltn + " hóa đơn";
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
