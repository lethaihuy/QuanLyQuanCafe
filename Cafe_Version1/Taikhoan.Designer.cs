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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenHienThi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLoaiTaiKhoan = new System.Windows.Forms.ComboBox();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.btnXoaTaiKhoan = new System.Windows.Forms.Button();
            this.btnThemTaiKhoan = new System.Windows.Forms.Button();
            this.btnHuyTaiKhoan = new System.Windows.Forms.Button();
            this.btnSaveTaiKhoan = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHienThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiTaikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuyTaiKhoan);
            this.groupBox1.Controls.Add(this.btnSaveTaiKhoan);
            this.groupBox1.Controls.Add(this.cbLoaiTaiKhoan);
            this.groupBox1.Controls.Add(this.txtTenHienThi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(5, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(313, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(97, 46);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(205, 26);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(97, 87);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(205, 26);
            this.txtPassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // txtTenHienThi
            // 
            this.txtTenHienThi.Enabled = false;
            this.txtTenHienThi.Location = new System.Drawing.Point(97, 129);
            this.txtTenHienThi.Name = "txtTenHienThi";
            this.txtTenHienThi.Size = new System.Drawing.Size(205, 26);
            this.txtTenHienThi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên hiển thị:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Loại TK:";
            // 
            // cbLoaiTaiKhoan
            // 
            this.cbLoaiTaiKhoan.FormattingEnabled = true;
            this.cbLoaiTaiKhoan.Items.AddRange(new object[] {
            "Admin",
            "Nhân viên"});
            this.cbLoaiTaiKhoan.Location = new System.Drawing.Point(97, 166);
            this.cbLoaiTaiKhoan.Name = "cbLoaiTaiKhoan";
            this.cbLoaiTaiKhoan.Size = new System.Drawing.Size(205, 27);
            this.cbLoaiTaiKhoan.TabIndex = 0;
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
            this.dgvTaiKhoan.Size = new System.Drawing.Size(454, 354);
            this.dgvTaiKhoan.TabIndex = 1;
            // 
            // btnXoaTaiKhoan
            // 
            this.btnXoaTaiKhoan.BackColor = System.Drawing.Color.White;
            this.btnXoaTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTaiKhoan.ForeColor = System.Drawing.Color.Red;
            this.btnXoaTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaTaiKhoan.Image")));
            this.btnXoaTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaTaiKhoan.Location = new System.Drawing.Point(144, 7);
            this.btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
            this.btnXoaTaiKhoan.Size = new System.Drawing.Size(78, 36);
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
            this.btnThemTaiKhoan.Size = new System.Drawing.Size(104, 36);
            this.btnThemTaiKhoan.TabIndex = 6;
            this.btnThemTaiKhoan.Text = "Thêm mới";
            this.btnThemTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemTaiKhoan.UseVisualStyleBackColor = false;
            this.btnThemTaiKhoan.Click += new System.EventHandler(this.btnThemTaiKhoan_Click);
            // 
            // btnHuyTaiKhoan
            // 
            this.btnHuyTaiKhoan.AutoEllipsis = true;
            this.btnHuyTaiKhoan.BackColor = System.Drawing.Color.White;
            this.btnHuyTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyTaiKhoan.ForeColor = System.Drawing.Color.Blue;
            this.btnHuyTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyTaiKhoan.Image")));
            this.btnHuyTaiKhoan.Location = new System.Drawing.Point(199, 203);
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
            this.btnSaveTaiKhoan.Location = new System.Drawing.Point(255, 203);
            this.btnSaveTaiKhoan.Name = "btnSaveTaiKhoan";
            this.btnSaveTaiKhoan.Size = new System.Drawing.Size(47, 36);
            this.btnSaveTaiKhoan.TabIndex = 0;
            this.btnSaveTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveTaiKhoan.UseVisualStyleBackColor = false;
            this.btnSaveTaiKhoan.Click += new System.EventHandler(this.btnSaveTaiKhoan_Click);
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            // 
            // tenHienThi
            // 
            this.tenHienThi.DataPropertyName = "tenHienThi";
            this.tenHienThi.HeaderText = "Tên hiển thị";
            this.tenHienThi.Name = "tenHienThi";
            // 
            // loaiTaikhoan
            // 
            this.loaiTaikhoan.DataPropertyName = "loaiTaiKhoan";
            this.loaiTaikhoan.HeaderText = "Loại TK";
            this.loaiTaikhoan.Name = "loaiTaikhoan";
            this.loaiTaikhoan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // formQLTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 365);
            this.Controls.Add(this.btnXoaTaiKhoan);
            this.Controls.Add(this.btnThemTaiKhoan);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formQLTaiKhoan";
            this.Text = "Taikhoan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHienThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiTaikhoan;
    }
}