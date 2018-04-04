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
    public partial class formHome : Form
    {
        bool drag = false;
        Point startPoint = new Point(0, 0);
        public formHome()
        {
            InitializeComponent();
            LoadDanhSachBan();
            LoadDanhSachDanhMuc();
        }

        public void LoadDanhSachBan()
        {
            flpDanhSachBan.Controls.Clear();
            List<Ban> dsBan = BanDAL.Instance.LayDanhSachBan();
            foreach (Ban item in dsBan)
            {
                Button btnBan = new Button() { Width = BanDAL.dai, Height = BanDAL.rong };
                btnBan.FlatStyle = FlatStyle.Flat;
                btnBan.FlatAppearance.BorderSize = 0;
                btnBan.Cursor = Cursors.Hand;
                btnBan.Text = item.TenBan;
                btnBan.Tag = item;
                //Sự kiện click vào button trên danh sách bàn.
                btnBan.Click += BtnBan_Click;

                if (item.TrangThai == "Trống")
                {
                    btnBan.BackColor = Color.WhiteSmoke;
                }
                else
                {
                    btnBan.BackColor = Color.LightPink;
                }

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
            this.lbTongTien.Text = "Tổng tiền = " + String.Format("{0:0,0 VND}", tongTien);

        }

        #region  EVENT

        private void BtnBan_Click(object sender, EventArgs e)
        {
            //Color mau = (sender as Button).BackColor = Color.Gold;
            //(sender as Button).Text += Environment.NewLine + "Xử lý";
            int IDBan = ((sender as Button).Tag as Ban)._ID;
            listViewHoaDon.Tag = (sender as Button).Tag;
            lbDangChon.Text = "Đang chọn: " + ((sender as Button).Tag as Ban).TenBan;
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
           if(e.Button == MouseButtons.Right)
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
            DoUong doUong = (sender as Button).Tag as DoUong;
            int idDoUong = doUong.ID;
            if (idHoaDon == -1)
            {
                HoaDonDAL.Instance.ThemHoaDon(ban._ID, "huy");
                ChiTietHoaDonDAL.Instance.ThemChiTietHoaDon(HoaDonDAL.Instance.MAXIDHoaDon(), idDoUong, 1);
            }
            else
            {
                ChiTietHoaDonDAL.Instance.ThemChiTietHoaDon(idHoaDon, idDoUong, 1);
            }
            HienThiHoaDonTheoBan(ban._ID);
            LoadDanhSachBan();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Ban ban = listViewHoaDon.Tag as Ban;
            if (ban == null)
            {
                MessageBox.Show("Chưa chọn bàn cần thanh toán !", "Thông báo");
            }
            else
            {
                int idHoaDon = HoaDonDAL.Instance.LayIDHoaDonTuIDBan(ban._ID);
                if (idHoaDon != -1)
                {
                    if (MessageBox.Show("Bạn muốn thanh toán " + ban.TenBan + " ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        HoaDonDAL.Instance.ThanhToan(idHoaDon);
                        HienThiHoaDonTheoBan(ban._ID);
                        LoadDanhSachBan();
                    }
                }
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
            // TODO: This line of code loads data into the 'cAFE_VERSION_1DataSet.DanhMuc' table. You can move, or remove it, as needed.
            listViewHoaDon.CheckBoxes = true;
        }


    }
}