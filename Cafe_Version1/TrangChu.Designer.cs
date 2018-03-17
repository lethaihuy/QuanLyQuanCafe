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
            this.pnHeader = new System.Windows.Forms.Panel();
            this.lbXinChao = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbNgay = new System.Windows.Forms.Label();
            this.lbThoiGian = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.BtnBan = new System.Windows.Forms.Button();
            this.btnDoUong = new System.Windows.Forms.Button();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnHeThong = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.lbAvatar = new System.Windows.Forms.Label();
            this.pnHeader.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.pnHeader.Controls.Add(this.lbXinChao);
            this.pnHeader.Controls.Add(this.btnBack);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(876, 29);
            this.pnHeader.TabIndex = 0;
            this.pnHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseDown);
            this.pnHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseMove);
            this.pnHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseUp);
            // 
            // lbXinChao
            // 
            this.lbXinChao.AutoSize = true;
            this.lbXinChao.Location = new System.Drawing.Point(491, 5);
            this.lbXinChao.Name = "lbXinChao";
            this.lbXinChao.Size = new System.Drawing.Size(169, 19);
            this.lbXinChao.TabIndex = 5;
            this.lbXinChao.Text = "Kính chào quý khách hàng";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(31, 28);
            this.btnBack.TabIndex = 5;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.ForeColor = System.Drawing.Color.Black;
            this.lbNgay.Location = new System.Drawing.Point(10, 28);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(45, 19);
            this.lbNgay.TabIndex = 2;
            this.lbNgay.Text = "label1";
            // 
            // lbThoiGian
            // 
            this.lbThoiGian.AutoSize = true;
            this.lbThoiGian.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiGian.ForeColor = System.Drawing.Color.Black;
            this.lbThoiGian.Location = new System.Drawing.Point(10, 6);
            this.lbThoiGian.Name = "lbThoiGian";
            this.lbThoiGian.Size = new System.Drawing.Size(49, 22);
            this.lbThoiGian.TabIndex = 1;
            this.lbThoiGian.Text = "lable";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.lbNgay);
            this.panel2.Controls.Add(this.pnLeft);
            this.panel2.Controls.Add(this.lbThoiGian);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnDoanhThu);
            this.panel2.Controls.Add(this.BtnBan);
            this.panel2.Controls.Add(this.btnDoUong);
            this.panel2.Controls.Add(this.btnDanhMuc);
            this.panel2.Controls.Add(this.btnHeThong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 480);
            this.panel2.TabIndex = 1;
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.Yellow;
            this.pnLeft.Location = new System.Drawing.Point(7, 60);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(10, 58);
            this.pnLeft.TabIndex = 0;
            this.pnLeft.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(12, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nhân viên";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(214)))));
            this.btnDoanhThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoanhThu.FlatAppearance.BorderSize = 0;
            this.btnDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoanhThu.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btnDoanhThu.Image = ((System.Drawing.Image)(resources.GetObject("btnDoanhThu.Image")));
            this.btnDoanhThu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDoanhThu.Location = new System.Drawing.Point(12, 316);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(157, 58);
            this.btnDoanhThu.TabIndex = 0;
            this.btnDoanhThu.Text = "Doanh thu";
            this.btnDoanhThu.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDoanhThu.UseVisualStyleBackColor = false;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // BtnBan
            // 
            this.BtnBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.BtnBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBan.FlatAppearance.BorderSize = 0;
            this.BtnBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBan.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBan.ForeColor = System.Drawing.Color.White;
            this.BtnBan.Image = ((System.Drawing.Image)(resources.GetObject("BtnBan.Image")));
            this.BtnBan.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnBan.Location = new System.Drawing.Point(12, 252);
            this.BtnBan.Name = "BtnBan";
            this.BtnBan.Size = new System.Drawing.Size(157, 58);
            this.BtnBan.TabIndex = 0;
            this.BtnBan.Text = "Bàn";
            this.BtnBan.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.BtnBan.UseVisualStyleBackColor = false;
            this.BtnBan.Click += new System.EventHandler(this.BtnBan_Click);
            // 
            // btnDoUong
            // 
            this.btnDoUong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(209)))), ((int)(((byte)(71)))));
            this.btnDoUong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoUong.FlatAppearance.BorderSize = 0;
            this.btnDoUong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoUong.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoUong.ForeColor = System.Drawing.Color.White;
            this.btnDoUong.Image = ((System.Drawing.Image)(resources.GetObject("btnDoUong.Image")));
            this.btnDoUong.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDoUong.Location = new System.Drawing.Point(12, 188);
            this.btnDoUong.Name = "btnDoUong";
            this.btnDoUong.Size = new System.Drawing.Size(157, 58);
            this.btnDoUong.TabIndex = 0;
            this.btnDoUong.Text = "Đồ uống";
            this.btnDoUong.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDoUong.UseVisualStyleBackColor = false;
            this.btnDoUong.Click += new System.EventHandler(this.btnDoUong_Click);
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(51)))));
            this.btnDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDanhMuc.FlatAppearance.BorderSize = 0;
            this.btnDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhMuc.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhMuc.ForeColor = System.Drawing.Color.White;
            this.btnDanhMuc.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhMuc.Image")));
            this.btnDanhMuc.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDanhMuc.Location = new System.Drawing.Point(12, 124);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(157, 58);
            this.btnDanhMuc.TabIndex = 0;
            this.btnDanhMuc.Text = "Danh mục";
            this.btnDanhMuc.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDanhMuc.UseVisualStyleBackColor = false;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // btnHeThong
            // 
            this.btnHeThong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnHeThong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHeThong.FlatAppearance.BorderSize = 0;
            this.btnHeThong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeThong.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeThong.ForeColor = System.Drawing.Color.White;
            this.btnHeThong.Image = ((System.Drawing.Image)(resources.GetObject("btnHeThong.Image")));
            this.btnHeThong.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnHeThong.Location = new System.Drawing.Point(12, 60);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Size = new System.Drawing.Size(157, 58);
            this.btnHeThong.TabIndex = 0;
            this.btnHeThong.Text = "Hệ thống";
            this.btnHeThong.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnHeThong.UseVisualStyleBackColor = false;
            this.btnHeThong.Click += new System.EventHandler(this.btnHeThong_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Location = new System.Drawing.Point(0, 499);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(876, 10);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(180, 128);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(696, 336);
            this.panel4.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picAvatar
            // 
            this.picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            this.picAvatar.Location = new System.Drawing.Point(797, 35);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(67, 49);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 3;
            this.picAvatar.TabStop = false;
            // 
            // lbAvatar
            // 
            this.lbAvatar.AutoSize = true;
            this.lbAvatar.Location = new System.Drawing.Point(811, 87);
            this.lbAvatar.Name = "lbAvatar";
            this.lbAvatar.Size = new System.Drawing.Size(38, 19);
            this.lbAvatar.TabIndex = 4;
            this.lbAvatar.Text = "User";
            // 
            // formTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 509);
            this.Controls.Add(this.lbAvatar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnHeader);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrangChu";
            this.Load += new System.EventHandler(this.formTrangChu_Load);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnBan;
        private System.Windows.Forms.Button btnDoUong;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnHeThong;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbThoiGian;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.Label lbAvatar;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbXinChao;
    }
}