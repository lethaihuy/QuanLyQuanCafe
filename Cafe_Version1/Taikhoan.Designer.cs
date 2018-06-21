namespace Cafe_Version1
{
    partial class formQLTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formQLTaiKhoan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadAnh = new System.Windows.Forms.Button();
            this.btnHuyTaiKhoan = new System.Windows.Forms.Button();
            this.btnSaveTaiKhoan = new System.Windows.Forms.Button();
            this.cbLoaiTaiKhoan = new System.Windows.Forms.ComboBox();
            this.txtTenHienThi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHienThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiTaikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoaTaiKhoan = new System.Windows.Forms.Button();
            this.btnThemTaiKhoan = new System.Windows.Forms.Button();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoadAnh);
            this.groupBox1.Controls.Add(this.btnHuyTaiKhoan);
            this.groupBox1.Controls.Add(this.btnSaveTaiKhoan);
            this.groupBox1.Controls.Add(this.cbLoaiTaiKhoan);
            this.groupBox1.Controls.Add(this.txtTenHienThi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(5, 117);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(313, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // btnLoadAnh
            // 
            this.btnLoadAnh.ForeColor = System.Drawing.Color.Black;
            this.btnLoadAnh.Location = new System.Drawing.Point(96, 172);
            this.btnLoadAnh.Name = "btnLoadAnh";
            this.btnLoadAnh.Size = new System.Drawing.Size(77, 28);
            this.btnLoadAnh.TabIndex = 8;
            this.btnLoadAnh.Text = "Chọn ảnh";
            this.btnLoadAnh.UseVisualStyleBackColor = true;
            this.btnLoadAnh.Click += new System.EventHandler(this.btnLoadAnh_Click);
            // 
            // btnHuyTaiKhoan
            // 
            this.btnHuyTaiKhoan.AutoEllipsis = true;
            this.btnHuyTaiKhoan.BackColor = System.Drawing.Color.White;
            this.btnHuyTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyTaiKhoan.ForeColor = System.Drawing.Color.Blue;
            this.btnHuyTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyTaiKhoan.Image")));
            this.btnHuyTaiKhoan.Location = new System.Drawing.Point(202, 205);
            this.btnHuyTaiKhoan.Name = "btnHuyTaiKhoan";
            this.btnHuyTaiKhoan.Size = new System.Drawing.Size(47, 36);
            this.btnHuyTaiKhoan.TabIndex = 7;
            this.btnHuyTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyTaiKhoan.UseVisualStyleBackColor = false;
            this.btnHuyTaiKhoan.Click += new System.EventHandler(this.btnHuyTaiKhoan_Click);
            // 
            // btnSaveTaiKhoan
            // 
            this.btnSaveTaiKhoan.BackColor = System.Drawing.Color.White;
            this.btnSaveTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveTaiKhoan.Image")));
            this.btnSaveTaiKhoan.Location = new System.Drawing.Point(258, 205);
            this.btnSaveTaiKhoan.Name = "btnSaveTaiKhoan";
            this.btnSaveTaiKhoan.Size = new System.Drawing.Size(47, 36);
            this.btnSaveTaiKhoan.TabIndex = 0;
            this.btnSaveTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveTaiKhoan.UseVisualStyleBackColor = false;
            this.btnSaveTaiKhoan.Click += new System.EventHandler(this.btnSaveTaiKhoan_Click);
            // 
            // cbLoaiTaiKhoan
            // 
            this.cbLoaiTaiKhoan.FormattingEnabled = true;
            this.cbLoaiTaiKhoan.Items.AddRange(new object[] {
            "Admin",
            "Nhân viên"});
            this.cbLoaiTaiKhoan.Location = new System.Drawing.Point(96, 136);
            this.cbLoaiTaiKhoan.Name = "cbLoaiTaiKhoan";
            this.cbLoaiTaiKhoan.Size = new System.Drawing.Size(205, 27);
            this.cbLoaiTaiKhoan.TabIndex = 0;
            // 
            // txtTenHienThi
            // 
            this.txtTenHienThi.Enabled = false;
            this.txtTenHienThi.Location = new System.Drawing.Point(96, 98);
            this.txtTenHienThi.Name = "txtTenHienThi";
            this.txtTenHienThi.Size = new System.Drawing.Size(205, 26);
            this.txtTenHienThi.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Loại TK:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên hiển thị:";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(96, 59);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(205, 26);
            this.txtPassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(96, 20);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(205, 26);
            this.txtUsername.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ảnh đại diện:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.password,
            this.tenHienThi,
            this.loaiTaikhoan});
            this.dgvTaiKhoan.GridColor = System.Drawing.Color.LightGray;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(325, 7);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.Size = new System.Drawing.Size(522, 354);
            this.dgvTaiKhoan.TabIndex = 1;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.FillWeight = 87.29955F;
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.FillWeight = 81.19404F;
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            // 
            // tenHienThi
            // 
            this.tenHienThi.DataPropertyName = "tenHienThi";
            this.tenHienThi.FillWeight = 152.2843F;
            this.tenHienThi.HeaderText = "Tên hiển thị";
            this.tenHienThi.Name = "tenHienThi";
            // 
            // loaiTaikhoan
            // 
            this.loaiTaikhoan.DataPropertyName = "loaiTaiKhoan";
            this.loaiTaikhoan.FillWeight = 73.07727F;
            this.loaiTaikhoan.HeaderText = "Loại TK";
            this.loaiTaikhoan.Name = "loaiTaikhoan";
            this.loaiTaikhoan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnXoaTaiKhoan
            // 
            this.btnXoaTaiKhoan.BackColor = System.Drawing.Color.White;
            this.btnXoaTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTaiKhoan.ForeColor = System.Drawing.Color.Red;
            this.btnXoaTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaTaiKhoan.Image")));
            this.btnXoaTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaTaiKhoan.Location = new System.Drawing.Point(7, 61);
            this.btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
            this.btnXoaTaiKhoan.Size = new System.Drawing.Size(69, 36);
            this.btnXoaTaiKhoan.TabIndex = 4;
            this.btnXoaTaiKhoan.Text = "Xóa";
            this.btnXoaTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaTaiKhoan.UseVisualStyleBackColor = false;
            this.btnXoaTaiKhoan.Click += new System.EventHandler(this.btnXoaTaiKhoan_Click);
            // 
            // btnThemTaiKhoan
            // 
            this.btnThemTaiKhoan.BackColor = System.Drawing.Color.White;
            this.btnThemTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTaiKhoan.ForeColor = System.Drawing.Color.Red;
            this.btnThemTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnThemTaiKhoan.Image")));
            this.btnThemTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemTaiKhoan.Location = new System.Drawing.Point(5, 7);
            this.btnThemTaiKhoan.Name = "btnThemTaiKhoan";
            this.btnThemTaiKhoan.Size = new System.Drawing.Size(71, 36);
            this.btnThemTaiKhoan.TabIndex = 6;
            this.btnThemTaiKhoan.Text = "Thêm";
            this.btnThemTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemTaiKhoan.UseVisualStyleBackColor = false;
            this.btnThemTaiKhoan.Click += new System.EventHandler(this.btnThemTaiKhoan_Click);
            // 
            // picAnh
            // 
            this.picAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.picAnh.Location = new System.Drawing.Point(154, 7);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(152, 114);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 7;
            this.picAnh.TabStop = false;
            // 
            // txtFilename
            // 
            this.txtFilename.AcceptsReturn = true;
            this.txtFilename.Location = new System.Drawing.Point(325, 335);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(522, 26);
            this.txtFilename.TabIndex = 1;
            this.txtFilename.TextChanged += new System.EventHandler(this.txtFilename_TextChanged);
            // 
            // formQLTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(849, 365);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.btnXoaTaiKhoan);
            this.Controls.Add(this.btnThemTaiKhoan);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFilename);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formQLTaiKhoan";
            this.Text = "Taikhoan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenHienThi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLoaiTaiKhoan;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.Button btnXoaTaiKhoan;
        private System.Windows.Forms.Button btnThemTaiKhoan;
        private System.Windows.Forms.Button btnHuyTaiKhoan;
        private System.Windows.Forms.Button btnSaveTaiKhoan;
        private System.Windows.Forms.Button btnLoadAnh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHienThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiTaikhoan;
        private System.Windows.Forms.TextBox txtFilename;
    }
}