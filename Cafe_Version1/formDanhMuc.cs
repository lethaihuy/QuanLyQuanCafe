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
    public partial class formDanhMuc : Form
    {
        BindingSource dsBan = new BindingSource();
        BindingSource dsDanhMuc = new BindingSource();
        BindingSource dsDoUong = new BindingSource();

        public formDanhMuc()
        {
            InitializeComponent();
            LoadData();
        }

        public bool flag = false;
        public bool sua = false;

        public void LoadData()
        {
            LoadDanhMuc();
            LoadDanhSachBan();
            LoadDanhSachDoUong();

            dgvDanhSachBan.DataSource = dsBan;
            dgvDanhMuc.DataSource = dsDanhMuc;
            dgvDoUong.DataSource = dsDoUong;

            BindingBan();
            BindingDanhMuc();
            BindingDoUong();
            BindingcbDanhMucTheoTen(cbThuocDanhMuc);
        }

        public void LoadDanhMuc()
        {
            dsDanhMuc.DataSource = DanhMucDAL.Instance.LayDanhSachDanhMuc();
        }
        public void LoadDanhSachBan()
        {
            dsBan.DataSource = BanDAL.Instance.LayDanhSachBan();
        }
        public void LoadDanhSachDoUong()
        {
            dsDoUong.DataSource = DoUongDAL.Instance.LayDanhSachDoUong();
        }

        #region Binding

        void BindingBan()
        {
            this.txtIDBan.DataBindings.Add(new Binding("Text", dgvDanhSachBan.DataSource, "_ID", true, DataSourceUpdateMode.Never));
            this.txtTenBan.DataBindings.Add(new Binding("Text", dgvDanhSachBan.DataSource, "tenBan", true, DataSourceUpdateMode.Never));
            this.cbTrangThai.DataBindings.Add(new Binding("text", dgvDanhSachBan.DataSource, "trangThai", true, DataSourceUpdateMode.Never));
        }

        void BindingDanhMuc()
        {
            this.txtIDDanhMuc.DataBindings.Add(new Binding("Text", dgvDanhMuc.DataSource, "_ID", true, DataSourceUpdateMode.Never));
            this.txtTenDanhMuc.DataBindings.Add(new Binding("Text", dgvDanhMuc.DataSource, "tenDanhMuc", true, DataSourceUpdateMode.Never));
        }

        void BindingDoUong()
        {
            this.txtIDDoUong.DataBindings.Add(new Binding("Text", dgvDoUong.DataSource, "ID", true, DataSourceUpdateMode.Never));
            this.txtTenDoUong.DataBindings.Add(new Binding("Text", dgvDoUong.DataSource, "tenDoUong", true, DataSourceUpdateMode.Never));
            this.txtGiaTien.DataBindings.Add(new Binding("Text", dgvDoUong.DataSource, "giaTien", true, DataSourceUpdateMode.Never));
        }

        void BindingcbDanhMucTheoTen(ComboBox cb)
        {
            cb.DataSource = DanhMucDAL.Instance.LayDanhSachDanhMuc();
            cb.DisplayMember = "tenDanhMuc";
        }

        #endregion

        private void formDanhMuc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cAFE_VERSION_1DataSet8.Ban' table. You can move, or remove it, as needed.

        }

        #region event

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            this.txtTenBan.Enabled = true;
            this.txtTenBan.Focus();
            this.flag = true;

        }

        private void btnSuaBan_Click(object sender, EventArgs e)
        {
            this.txtTenBan.Enabled = true;
            this.txtTenBan.Focus();
            this.sua = true;
        }

        private void btnSaveBan_Click(object sender, EventArgs e)
        {
            string tenBan = txtTenBan.Text;
            int IDBan = int.Parse(txtIDBan.Text);


            if (BanDAL.Instance.LayDanhSachBan().Equals(tenBan))
            {
                MessageBox.Show("Tên bàn bị trùng xin kiểm tra lại!", "Thông báo");
                return;
            }
            else
            {
                if (this.flag == true)
                {
                    if (BanDAL.Instance.ThemBan(tenBan))
                    {
                        MessageBox.Show("Thêm Thành công!", "Thông báo");
                        this.LoadDanhSachBan();
                    }
                }
                else
                {
                    if (BanDAL.Instance.SuaBan(IDBan, tenBan))
                    {
                        MessageBox.Show("Sửa Thành công!", "Thông báo");
                        this.LoadDanhSachBan();
                    }
                }
                this.txtTenBan.Enabled = false;
            }

        }

        private void btnXoaBan_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIDBan.Text);
            if (id != 0)
            {
                BanDAL.Instance.XoaBan(id);
                this.LoadDanhSachBan();
                MessageBox.Show("Xóa thành công !", "Thông báo");
            }

        }

        private void btnThemDanhMuc_Click(object sender, EventArgs e)
        {
            this.txtTenDanhMuc.Enabled = true;
            this.txtTenDanhMuc.Focus();
            this.flag = true;
        }

        private void btnSuaDM_Click(object sender, EventArgs e)
        {
            this.txtTenDanhMuc.Enabled = true;
            this.txtTenDanhMuc.Focus();
        }

        private void btnXoaDM_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIDDanhMuc.Text);
            if (DanhMucDAL.Instance.XoaDanhMuc(id))
            {
                LoadDanhMuc();
                MessageBox.Show("Đã xóa danh mục!", "Thông báo");
            }
        }

        private void btnSaveDanhMuc_Click(object sender, EventArgs e)
        {
            string tenDM = txtTenDanhMuc.Text;
            int id = int.Parse(txtIDDanhMuc.Text);

            //tào lao
            if (tenDanhMuc.Equals(tenDM))
            {
                MessageBox.Show("Tên danh mục trùng !", "Thông báo");
            }
            else
            {
                if (this.flag == true)
                {
                    if (DanhMucDAL.Instance.ThemDanhMuc(tenDM))
                    {
                        MessageBox.Show("Thêm Thành công!", "Thông báo");

                    }
                }
                else
                {
                    if (DanhMucDAL.Instance.SuaDanhMuc(id, tenDM))
                    {
                        MessageBox.Show("Sửa Thành công!", "Thông báo");
                    }
                }
                this.txtTenDanhMuc.Enabled = false;
                this.LoadDanhMuc();
            }
        }

        #region
        public void ResetFormDoUong()
        {
            this.txtTenDoUong.Enabled = false;
            this.cbThuocDanhMuc.Enabled = false;
            this.txtGiaTien.Enabled = false;
        }
        #endregion

        private void btnThemDoUong_Click(object sender, EventArgs e)
        {
            LoadDanhMuc();
            BindingcbDanhMucTheoTen(cbThuocDanhMuc);
            this.txtTenDoUong.Enabled = true;
            this.cbThuocDanhMuc.Enabled = true;
            this.txtGiaTien.Enabled = true;
            this.txtTenDoUong.Focus();
            this.flag = true;
        }

        private void btnSuaDoUong_Click(object sender, EventArgs e)
        {
            LoadDanhMuc();
            BindingcbDanhMucTheoTen(cbThuocDanhMuc);
            this.txtTenDoUong.Enabled = true;
            this.cbThuocDanhMuc.Enabled = true;
            this.txtGiaTien.Enabled = true;
            this.txtTenDoUong.Focus();
            this.flag = false;
        }

        private void btnXoaDoUong_Click(object sender, EventArgs e)
        {
            int idDoUong = int.Parse(txtIDDoUong.Text);
            if (DoUongDAL.Instance.XoaDoUong(idDoUong))
            {
                MessageBox.Show("Xóa thành công ", "Thông báo");
                LoadDanhSachDoUong();
            }
        }

        private void btnSaveDoUong_Click(object sender, EventArgs e)
        {
            int idDoUong = int.Parse(txtIDDoUong.Text);

            string tenNuoc = this.txtTenDoUong.Text;
            int thuocDM = (cbThuocDanhMuc.SelectedItem as DanhMuc)._ID;
            float giaTien = float.Parse(this.txtGiaTien.Text);

            if (tenNuoc == "")
            {
                MessageBox.Show("Tên bị trùng rồi !");
            }
            else
            {
                if (flag == true)
                {
                    if (DoUongDAL.Instance.ThemDoUong(tenNuoc, thuocDM, giaTien))
                    {
                        MessageBox.Show("Thêm thành công !", "Thông báo");
                    }
                }
                else
                {
                    if (DoUongDAL.Instance.SuaDoUong(idDoUong, tenNuoc, thuocDM, giaTien))
                    {
                        MessageBox.Show("Sữa thành công !", "Thông báo");
                    }
                }
                LoadDanhSachDoUong();
                this.ResetFormDoUong();
            }

        }


        #endregion

        private void txtIDDoUong_TextChanged(object sender, EventArgs e)
        {
            if (dgvDoUong.SelectedCells.Count > 0)
            {
                int id = (int)(dgvDoUong.SelectedCells[0].OwningRow.Cells["IDDanhMuc"].Value);

                DanhMuc category = DanhMucDAL.Instance.LayDanhSachDanhMucTheoID(id);
                int index = -1;
                int i = 0;
                foreach (DanhMuc item in cbThuocDanhMuc.Items)
                {
                    if (item._ID == category._ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cbThuocDanhMuc.SelectedIndex = index;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuyDanhMuc_Click(object sender, EventArgs e)
        {
            this.txtTenDanhMuc.Enabled = false;
        }

        private void btnHuyDoUong_Click(object sender, EventArgs e)
        {
            this.ResetFormDoUong();
        }

        private void btnHuyBan_Click(object sender, EventArgs e)
        {
            this.txtTenBan.Enabled = false;
        }
    }
}
