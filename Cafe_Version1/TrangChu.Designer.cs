namespace Cafe_Version1
{
    partial class formTrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTrangChu));
            this.lbXinChao = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbThangNam = new System.Windows.Forms.Label();
            this.lbThoiGian = new System.Windows.Forms.Label();
            this.btnQLNhanVien = new System.Windows.Forms.Button();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.btnQuanLyKhoHang = new System.Windows.Forms.Button();
            this.btnThietLap = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnThoiGian = new System.Windows.Forms.Panel();
            this.lbNgay = new System.Windows.Forms.Label();
            this.lbThu = new System.Windows.Forms.Label();
            this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.lbPhanQuyen = new System.Windows.Forms.Label();
            this.lbTenTaiKhoanDangNhap = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pnThoiGian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbXinChao
            // 
            this.lbXinChao.AutoSize = true;
            this.lbXinChao.Location = new System.Drawing.Point(548, 18);
            this.lbXinChao.Name = "lbXinChao";
            this.lbXinChao.Size = new System.Drawing.Size(169, 19);
            this.lbXinChao.TabIndex = 5;
            this.lbXinChao.Text = "Kính chào quý khách hàng";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(31, 28);
            this.btnBack.TabIndex = 5;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbThangNam
            // 
            this.lbThangNam.AutoSize = true;
            this.lbThangNam.ForeColor = System.Drawing.Color.White;
            this.lbThangNam.Location = new System.Drawing.Point(141, 77);
            this.lbThangNam.Name = "lbThangNam";
            this.lbThangNam.Size = new System.Drawing.Size(61, 19);
            this.lbThangNam.TabIndex = 2;
            this.lbThangNam.Text = "10/2018";
            // 
            // lbThoiGian
            // 
            this.lbThoiGian.AutoSize = true;
            this.lbThoiGian.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiGian.ForeColor = System.Drawing.Color.White;
            this.lbThoiGian.Location = new System.Drawing.Point(3, 2);
            this.lbThoiGian.Name = "lbThoiGian";
            this.lbThoiGian.Size = new System.Drawing.Size(133, 36);
            this.lbThoiGian.TabIndex = 2;
            this.lbThoiGian.Text = "12:00:00";
            // 
            // btnQLNhanVien
            // 
            this.btnQLNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(112)))), ((int)(((byte)(184)))));
            this.btnQLNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLNhanVien.Enabled = false;
            this.btnQLNhanVien.FlatAppearance.BorderSize = 0;
            this.btnQLNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNhanVien.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnQLNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnQLNhanVien.Image")));
            this.btnQLNhanVien.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnQLNhanVien.Location = new System.Drawing.Point(41, 215);
            this.btnQLNhanVien.Name = "btnQLNhanVien";
            this.btnQLNhanVien.Size = new System.Drawing.Size(176, 100);
            this.btnQLNhanVien.TabIndex = 0;
            this.btnQLNhanVien.Text = "QUẢN LÝ NHÂN VIÊN";
            this.btnQLNhanVien.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnQLNhanVien.UseVisualStyleBackColor = false;
            this.btnQLNhanVien.Click += new System.EventHandler(this.btnQLNhanVien_Click);
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(214)))));
            this.btnDoanhThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoanhThu.FlatAppearance.BorderSize = 0;
            this.btnDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoanhThu.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btnDoanhThu.Image = ((System.Drawing.Image)(resources.GetObject("btnDoanhThu.Image")));
            this.btnDoanhThu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDoanhThu.Location = new System.Drawing.Point(451, 92);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(134, 98);
            this.btnDoanhThu.TabIndex = 0;
            this.btnDoanhThu.Text = "DOANH THU";
            this.btnDoanhThu.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDoanhThu.UseVisualStyleBackColor = false;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // btnQuanLyKhoHang
            // 
            this.btnQuanLyKhoHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btnQuanLyKhoHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyKhoHang.FlatAppearance.BorderSize = 0;
            this.btnQuanLyKhoHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyKhoHang.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyKhoHang.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyKhoHang.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLyKhoHang.Image")));
            this.btnQuanLyKhoHang.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnQuanLyKhoHang.Location = new System.Drawing.Point(308, 200);
            this.btnQuanLyKhoHang.Name = "btnQuanLyKhoHang";
            this.btnQuanLyKhoHang.Size = new System.Drawing.Size(277, 100);
            this.btnQuanLyKhoHang.TabIndex = 0;
            this.btnQuanLyKhoHang.Text = "QUẢN LÝ KHO HÀNG";
            this.btnQuanLyKhoHang.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnQuanLyKhoHang.UseVisualStyleBackColor = false;
            // 
            // btnThietLap
            // 
            this.btnThietLap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnThietLap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThietLap.Enabled = false;
            this.btnThietLap.FlatAppearance.BorderSize = 0;
            this.btnThietLap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThietLap.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThietLap.ForeColor = System.Drawing.Color.White;
            this.btnThietLap.Image = ((System.Drawing.Image)(resources.GetObject("btnThietLap.Image")));
            this.btnThietLap.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnThietLap.Location = new System.Drawing.Point(41, 334);
            this.btnThietLap.Name = "btnThietLap";
            this.btnThietLap.Size = new System.Drawing.Size(176, 100);
            this.btnThietLap.TabIndex = 0;
            this.btnThietLap.Text = "THIẾT LẬP QUÁN";
            this.btnThietLap.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnThietLap.UseVisualStyleBackColor = false;
            this.btnThietLap.Click += new System.EventHandler(this.btnThietLap_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(0)))));
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(308, 91);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(134, 98);
            this.btnThanhToan.TabIndex = 0;
            this.btnThanhToan.Text = "BÁN HÀNG";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Location = new System.Drawing.Point(0, 499);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(876, 10);
            this.panel3.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnThoiGian
            // 
            this.pnThoiGian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.pnThoiGian.Controls.Add(this.lbNgay);
            this.pnThoiGian.Controls.Add(this.lbThu);
            this.pnThoiGian.Controls.Add(this.lbThoiGian);
            this.pnThoiGian.Controls.Add(this.lbThangNam);
            this.pnThoiGian.Location = new System.Drawing.Point(635, 91);
            this.pnThoiGian.Name = "pnThoiGian";
            this.pnThoiGian.Size = new System.Drawing.Size(206, 98);
            this.pnThoiGian.TabIndex = 4;
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgay.ForeColor = System.Drawing.Color.White;
            this.lbNgay.Location = new System.Drawing.Point(150, 42);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(45, 35);
            this.lbNgay.TabIndex = 3;
            this.lbNgay.Text = "10";
            // 
            // lbThu
            // 
            this.lbThu.AutoSize = true;
            this.lbThu.BackColor = System.Drawing.Color.Transparent;
            this.lbThu.ForeColor = System.Drawing.Color.White;
            this.lbThu.Location = new System.Drawing.Point(148, 23);
            this.lbThu.Name = "lbThu";
            this.lbThu.Size = new System.Drawing.Size(63, 19);
            this.lbThu.TabIndex = 3;
            this.lbThu.Text = "Chủ nhật";
            // 
            // tileGroup1
            // 
            this.tileGroup1.Name = "tileGroup1";
            // 
            // picAvatar
            // 
            this.picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            this.picAvatar.Location = new System.Drawing.Point(41, 91);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(144, 109);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 5;
            this.picAvatar.TabStop = false;
            this.picAvatar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picAvatar_MouseDown);
            // 
            // lbPhanQuyen
            // 
            this.lbPhanQuyen.AutoSize = true;
            this.lbPhanQuyen.BackColor = System.Drawing.Color.Transparent;
            this.lbPhanQuyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhanQuyen.ForeColor = System.Drawing.Color.White;
            this.lbPhanQuyen.Location = new System.Drawing.Point(191, 158);
            this.lbPhanQuyen.Name = "lbPhanQuyen";
            this.lbPhanQuyen.Size = new System.Drawing.Size(68, 19);
            this.lbPhanQuyen.TabIndex = 6;
            this.lbPhanQuyen.Text = "nhanvien";
            // 
            // lbTenTaiKhoanDangNhap
            // 
            this.lbTenTaiKhoanDangNhap.AutoSize = true;
            this.lbTenTaiKhoanDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.lbTenTaiKhoanDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTaiKhoanDangNhap.ForeColor = System.Drawing.Color.Gray;
            this.lbTenTaiKhoanDangNhap.Location = new System.Drawing.Point(191, 181);
            this.lbTenTaiKhoanDangNhap.Name = "lbTenTaiKhoanDangNhap";
            this.lbTenTaiKhoanDangNhap.Size = new System.Drawing.Size(71, 19);
            this.lbTenTaiKhoanDangNhap.TabIndex = 7;
            this.lbTenTaiKhoanDangNhap.Text = "username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(790, 431);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(676, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quản lý quán cafe\r\nversion 1.0\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // formTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 509);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbXinChao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.lbTenTaiKhoanDangNhap);
            this.Controls.Add(this.pnThoiGian);
            this.Controls.Add(this.lbPhanQuyen);
            this.Controls.Add(this.btnQLNhanVien);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnDoanhThu);
            this.Controls.Add(this.btnQuanLyKhoHang);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnThietLap);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.formTrangChu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formTrangChu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formTrangChu_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formTrangChu_MouseUp);
            this.pnThoiGian.ResumeLayout(false);
            this.pnThoiGian.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnQuanLyKhoHang;
        private System.Windows.Forms.Button btnThietLap;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Button btnQLNhanVien;
        private System.Windows.Forms.Label lbThoiGian;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbThangNam;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbXinChao;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnThoiGian;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.Label lbThu;
        private System.Windows.Forms.PictureBox picAvatar;
        private DevExpress.XtraEditors.TileGroup tileGroup1;
        private System.Windows.Forms.Label lbTenTaiKhoanDangNhap;
        private System.Windows.Forms.Label lbPhanQuyen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
    }
}