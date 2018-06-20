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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Version1
{
    public partial class formHome : Form
    {
        public static string thuNgan = string.Empty;
        private static string ngaythang = string.Empty;
        public DateTime time;

        bool drag = false;
        Point startPoint = new Point(0, 0);

        public static string Ngaythang
        {
            get
            {
                return ngaythang;
            }

            set
            {
                ngaythang = value;
            }
        }

        public formHome()
        {
            InitializeComponent();

            LoadDanhSachBan();
            LoadDanhSachDanhMuc();
            LoadDanhSachBanLenCombobox(cbChuyenBan);
        }


        public void LoadDanhSachBan()
        {
            flpDanhSachBan.Controls.Clear();
            List<Ban> dsBan = BanDAL.Instance.LayDanhSachBan();

            int demBanTrong = 0;
            int demBanCoKhach = 0;
            foreach (Ban item in dsBan)
            {
                Button btnBan = new Button() { Width = BanDAL.dai, Height = BanDAL.rong };
                btnBan.FlatStyle = FlatStyle.Flat;
                btnBan.FlatAppearance.BorderSize = 0;
                btnBan.Cursor = Cursors.Hand;
                btnBan.Text = item.TenBan;
                btnBan.TextAlign = ContentAlignment.BottomCenter;
                btnBan.ForeColor = Color.Red;
                btnBan.Tag = item;
                btnBan.BackgroundImageLayout = ImageLayout.Center;
                //Sự kiện click vào button trên danh sách bàn.
                btnBan.Click += BtnBan_Click;

                if (item.TrangThai == "Trống")
                {
                    //btnBan.BackColor = Color.Pink;
                    btnBan.BackgroundImage= Image.FromFile(@"D:\Do An C#\He Quan Tri CSDL\QuanLyQuanCafe\Cafe_Version1\icon\coffee-cup-64.png");
                    demBanTrong++;
                }
                else
                {
                    //btnBan.BackColor = Color.Yellow;
                    btnBan.BackgroundImage = Image.FromFile(@"D:\Do An C#\He Quan Tri CSDL\QuanLyQuanCafe\Cafe_Version1\icon\hot-coffee.png");
                    demBanCoKhach++;
                }

                this.lbBanCoKhach.Text = "Bàn có khách: " + demBanCoKhach + " bàn";
                this.lbBanTrong.Text = "Bàn trống: " + demBanTrong + " bàn";

                flpDanhSachBan.Controls.Add(btnBan);
            }
        }

        public void LoadDanhSachDanhMuc()
        {
            List<DanhMuc> dsDanhMuc = DanhMucDAL.Instance.LayDanhSachDanhMuc();
            cbDanhMuc.DataSource = dsDanhMuc;
        }

        void HienThiHoaDonTheoBan(int id)
        {
            listViewHoaDon.Items.Clear();
            float tongTien = 0;
            List<ThanhToan> dsChiTietHoaDon = ThanhToanDAL.Instance.LayDanhSachDoUongTheoIDBan(id);
            foreach (ThanhToan item in dsChiTietHoaDon)
            {
                ListViewItem cacThanhPhanHoaDon = new ListViewItem(item.TenDoUong.ToString());
                cacThanhPhanHoaDon.SubItems.Add(item.SoLuong.ToString());
                cacThanhPhanHoaDon.SubItems.Add(String.Format("{0:0,0}", item.GiaTien));
                cacThanhPhanHoaDon.SubItems.Add(String.Format("{0:0,0}", item.TongTien));
                listViewHoaDon.Items.Add(cacThanhPhanHoaDon);
                tongTien += item.TongTien;
            }
            this.txtTongTien.Text = String.Format("{0:0,0}", tongTien);
        }

        #region  EVENT

        private void BtnBan_Click(object sender, EventArgs e)
        {
            int IDBan = ((sender as Button).Tag as Ban)._ID;
            listViewHoaDon.Tag = (sender as Button).Tag;
            lbDangChon.Text = "Đang chọn: " + (listViewHoaDon.Tag as Ban).TenBan;

            HienThiHoaDonTheoBan(IDBan);
        }
        private void cbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cbDanhMuc = sender as ComboBox;
            if (cbDanhMuc.SelectedItem == null) { return; }
            DanhMuc doUongTheoID = cbDanhMuc.SelectedItem as DanhMuc;
            id = doUongTheoID._ID;
            LoadDanhSachDoUongCuaDanhMuc(id);
        }
        void LoadDanhSachDoUongCuaDanhMuc(int id)
        {
            flpDoUongTheoDanhMuc.Controls.Clear();
            List<DoUong> dsDoUong = DoUongDAL.Instance.LayDanhSachDoUongTheoID(id);
            foreach (DoUong item in dsDoUong)
            {
                Button btnDoUong = new Button() { Width = 185, Height = 60 };
                btnDoUong.FlatStyle = FlatStyle.Flat;
                btnDoUong.Cursor = Cursors.Hand;
                btnDoUong.Text = item.TenDoUong + Environment.NewLine + String.Format("{0:0,0}", item.GiaTien);
                btnDoUong.Tag = item;
                btnDoUong.MouseClick += BtnDoUong_MouseClick;
                btnDoUong.MouseDown += BtnDoUong_MouseDown;
                flpDoUongTheoDanhMuc.Controls.Add(btnDoUong);
            }

        }


        private void BtnDoUong_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new ContextMenuStrip();
                menu.Items.Add("Thêm nhiều");
                menu.Items.Add("Hủy");
                menu.Show(flpDoUongTheoDanhMuc, new Point(e.X, e.Y));
            }
        }

        private void BtnDoUong_MouseClick(object sender, MouseEventArgs e)
        {
            Ban ban = listViewHoaDon.Tag as Ban;

            int idHoaDon = HoaDonDAL.Instance.LayIDHoaDonTuIDBan(ban._ID);

            //int idBan = (flpDanhSachBan.Tag as Ban)._ID;

            DoUong doUong = (sender as Button).Tag as DoUong;
            int idDoUong = doUong.ID;
            if (idHoaDon == -1)
            {
                HoaDonDAL.Instance.ThemHoaDon(ban._ID, thuNgan);
                ChiTietHoaDonDAL.Instance.ThemChiTietHoaDon(HoaDonDAL.Instance.MAXIDHoaDon(), idDoUong, 1);
            }
            else
            {
                ChiTietHoaDonDAL.Instance.ThemChiTietHoaDon(idHoaDon, idDoUong, 1);
            }

            HienThiHoaDonTheoBan(ban._ID);

            //Load bàn khi thêm đồ uống
            LoadDanhSachBan();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            //Nhớ lấy username tài khoản thanh toán
            try
            {
                double tongTien = (float)Convert.ToDouble(txtTongTien.Text);
                Ban ban = listViewHoaDon.Tag as Ban;

                int idHoaDon = HoaDonDAL.Instance.LayIDHoaDonTuIDBan(ban._ID);

                if (ban.TrangThai == "Trống" && idHoaDon == -1)
                {
                    MessageBox.Show("Bàn không có gì mà cũng thanh toán ! vl", "Thông báo");
                }
                else if (idHoaDon != -1)
                {
                    if (MessageBox.Show("Bạn muốn thanh toán va in hóa đơn " + ban.TenBan + " ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        int idBan = (listViewHoaDon.Tag as Ban)._ID;
                        string tenBan = (listViewHoaDon.Tag as Ban).TenBan;
                        formInHoaDon.tenBanInHD = tenBan;
                        formInHoaDon.idBanInHD = idBan;
                        formInHoaDon.tenThuNganInHD = thuNgan;
                        formInHoaDon fI = new formInHoaDon();
                        fI.Show();

                        HoaDonDAL.Instance.ThanhToan(idHoaDon, (float)tongTien);
                        HienThiHoaDonTheoBan(ban._ID);
                        LoadDanhSachBan();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa chọn bàn cần thanh toán !", "Thông báo");
            }
        }

        #endregion

        private void pnHeaderHome_MouseDown(object sender, MouseEventArgs e)
        {
            this.drag = true;
            this.startPoint = new Point(e.X, e.Y);
        }

        private void pnHeaderHome_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void pnHeaderHome_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.formHome_Load(sender, e);
        }

        private void formHome_Load(object sender, EventArgs e)
        {
            timer1.Start();

            if (!string.IsNullOrEmpty(thuNgan))
            {
                this.lbThuNgan.Text = thuNgan;
            }

            this.lbNgayThang.Text = Ngaythang;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now;
            this.lbGio.Text = time.ToString("HH:mm:ss");
        }


        void LoadDanhSachBanLenCombobox(ComboBox cb)
        {
            cb.DataSource = BanDAL.Instance.LayDanhSachBan();
            cb.DisplayMember = "tenBan";
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            int idBan1 = (listViewHoaDon.Tag as Ban)._ID;
            int idBan2 = (cbChuyenBan.SelectedItem as Ban)._ID;

            if (MessageBox.Show(string.Format("Bạn muốn chuyển {0} qua {1} ?", (listViewHoaDon.Tag as Ban).TenBan, (cbChuyenBan.SelectedItem as Ban).TenBan), "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                BanDAL.Instance.ChuyenBan(idBan1, idBan2, thuNgan);
            }
            LoadDanhSachBan();
            HienThiHoaDonTheoBan(idBan2);
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                int idBan = (listViewHoaDon.Tag as Ban)._ID;
                string tenBan = (listViewHoaDon.Tag as Ban).TenBan;
                formInHoaDon.tenBanInHD = tenBan;
                formInHoaDon.idBanInHD = idBan;
                formInHoaDon.tenThuNganInHD = thuNgan;
                formInHoaDon fI = new formInHoaDon();
                fI.Show();
            }
            catch (Exception)
            {

            }
        }

        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            Ban ban = listViewHoaDon.Tag as Ban;      
            int idHoaDon = HoaDonDAL.Instance.LayIDHoaDonTuIDBan(ban._ID);

            try
            {
                if (MessageBox.Show("Bạn muốn hủy hóa đơn cho " + ban.TenBan, "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    HoaDonDAL.Instance.HuyHoaDon(idHoaDon, ban._ID);
                    this.LoadDanhSachBan();
                    HienThiHoaDonTheoBan(ban._ID);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi");
            }
        }
    }
}