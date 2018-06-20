namespace Cafe_Version1
{
    partial class formDanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDanhMuc));
            this.tbcAdmin = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvDanhSachBan = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoaBan = new System.Windows.Forms.Button();
            this.btnSuaBan = new System.Windows.Forms.Button();
            this.btnThemDanhMuc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuyBan = new System.Windows.Forms.Button();
            this.btnSaveBan = new System.Windows.Forms.Button();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDBan = new System.Windows.Forms.TextBox();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnXoaDM = new System.Windows.Forms.Button();
            this.btnSuaDM = new System.Windows.Forms.Button();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHuyDanhMuc = new System.Windows.Forms.Button();
            this.btnSaveDanhMuc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDDanhMuc = new System.Windows.Forms.TextBox();
            this.txtTenDanhMuc = new System.Windows.Forms.TextBox();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this._ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnXoaDoUong = new System.Windows.Forms.Button();
            this.btnSuaDoUong = new System.Windows.Forms.Button();
            this.btnThemDoUong = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHuyDoUong = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.btnSaveDoUong = new System.Windows.Forms.Button();
            this.cbThuocDanhMuc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDDoUong = new System.Windows.Forms.TextBox();
            this.txtTenDoUong = new System.Windows.Forms.TextBox();
            this.dgvDoUong = new System.Windows.Forms.DataGridView();
            this._IDd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDoUong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnBackHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbcAdmin.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoUong)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcAdmin
            // 
            this.tbcAdmin.Controls.Add(this.tabPage1);
            this.tbcAdmin.Controls.Add(this.tabPage2);
            this.tbcAdmin.Controls.Add(this.tabPage3);
            this.tbcAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbcAdmin.Location = new System.Drawing.Point(0, 31);
            this.tbcAdmin.Margin = new System.Windows.Forms.Padding(5);
            this.tbcAdmin.Name = "tbcAdmin";
            this.tbcAdmin.SelectedIndex = 0;
            this.tbcAdmin.Size = new System.Drawing.Size(898, 469);
            this.tbcAdmin.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvDanhSachBan);
            this.tabPage1.Controls.Add(this.btnXoaBan);
            this.tabPage1.Controls.Add(this.btnSuaBan);
            this.tabPage1.Controls.Add(this.btnThemDanhMuc);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.Size = new System.Drawing.Size(890, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách bàn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvDanhSachBan
            // 
            this.dgvDanhSachBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachBan.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachBan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDanhSachBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.tenBan,
            this.trangThai});
            this.dgvDanhSachBan.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvDanhSachBan.Location = new System.Drawing.Point(438, 5);
            this.dgvDanhSachBan.Name = "dgvDanhSachBan";
            this.dgvDanhSachBan.Size = new System.Drawing.Size(447, 431);
            this.dgvDanhSachBan.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "_ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // tenBan
            // 
            this.tenBan.DataPropertyName = "tenBan";
            this.tenBan.HeaderText = "Tên bàn";
            this.tenBan.Name = "tenBan";
            // 
            // trangThai
            // 
            this.trangThai.DataPropertyName = "trangThai";
            this.trangThai.HeaderText = "Trạng thái";
            this.trangThai.Name = "trangThai";
            // 
            // btnXoaBan
            // 
            this.btnXoaBan.BackColor = System.Drawing.Color.White;
            this.btnXoaBan.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaBan.ForeColor = System.Drawing.Color.Red;
            this.btnXoaBan.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaBan.Image")));
            this.btnXoaBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaBan.Location = new System.Drawing.Point(279, 10);
            this.btnXoaBan.Name = "btnXoaBan";
            this.btnXoaBan.Size = new System.Drawing.Size(78, 36);
            this.btnXoaBan.TabIndex = 3;
            this.btnXoaBan.Text = "Xóa";
            this.btnXoaBan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaBan.UseVisualStyleBackColor = false;
            this.btnXoaBan.Click += new System.EventHandler(this.btnXoaBan_Click);
            // 
            // btnSuaBan
            // 
            this.btnSuaBan.BackColor = System.Drawing.Color.White;
            this.btnSuaBan.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaBan.ForeColor = System.Drawing.Color.Red;
            this.btnSuaBan.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaBan.Image")));
            this.btnSuaBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaBan.Location = new System.Drawing.Point(156, 10);
            this.btnSuaBan.Name = "btnSuaBan";
            this.btnSuaBan.Size = new System.Drawing.Size(78, 36);
            this.btnSuaBan.TabIndex = 3;
            this.btnSuaBan.Text = "Sửa";
            this.btnSuaBan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaBan.UseVisualStyleBackColor = false;
            this.btnSuaBan.Click += new System.EventHandler(this.btnSuaBan_Click);
            // 
            // btnThemDanhMuc
            // 
            this.btnThemDanhMuc.BackColor = System.Drawing.Color.White;
            this.btnThemDanhMuc.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDanhMuc.ForeColor = System.Drawing.Color.Red;
            this.btnThemDanhMuc.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDanhMuc.Image")));
            this.btnThemDanhMuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDanhMuc.Location = new System.Drawing.Point(19, 10);
            this.btnThemDanhMuc.Name = "btnThemDanhMuc";
            this.btnThemDanhMuc.Size = new System.Drawing.Size(104, 36);
            this.btnThemDanhMuc.TabIndex = 3;
            this.btnThemDanhMuc.Text = "Thêm mới";
            this.btnThemDanhMuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemDanhMuc.UseVisualStyleBackColor = false;
            this.btnThemDanhMuc.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuyBan);
            this.groupBox1.Controls.Add(this.btnSaveBan);
            this.groupBox1.Controls.Add(this.cbTrangThai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIDBan);
            this.groupBox1.Controls.Add(this.txtTenBan);
            this.groupBox1.Location = new System.Drawing.Point(19, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 208);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // btnHuyBan
            // 
            this.btnHuyBan.BackColor = System.Drawing.Color.White;
            this.btnHuyBan.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyBan.Image")));
            this.btnHuyBan.Location = new System.Drawing.Point(207, 149);
            this.btnHuyBan.Name = "btnHuyBan";
            this.btnHuyBan.Size = new System.Drawing.Size(47, 36);
            this.btnHuyBan.TabIndex = 3;
            this.btnHuyBan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyBan.UseVisualStyleBackColor = false;
            this.btnHuyBan.Click += new System.EventHandler(this.btnHuyBan_Click);
            // 
            // btnSaveBan
            // 
            this.btnSaveBan.BackColor = System.Drawing.Color.White;
            this.btnSaveBan.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveBan.Image")));
            this.btnSaveBan.Location = new System.Drawing.Point(260, 149);
            this.btnSaveBan.Name = "btnSaveBan";
            this.btnSaveBan.Size = new System.Drawing.Size(47, 36);
            this.btnSaveBan.TabIndex = 3;
            this.btnSaveBan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveBan.UseVisualStyleBackColor = false;
            this.btnSaveBan.Click += new System.EventHandler(this.btnSaveBan_Click);
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.Enabled = false;
            this.cbTrangThai.ForeColor = System.Drawing.Color.Red;
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Trống ",
            "Có người"});
            this.cbTrangThai.Location = new System.Drawing.Point(93, 111);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(214, 23);
            this.cbTrangThai.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trạng thái:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID bàn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên bàn:";
            // 
            // txtIDBan
            // 
            this.txtIDBan.Enabled = false;
            this.txtIDBan.ForeColor = System.Drawing.Color.Red;
            this.txtIDBan.Location = new System.Drawing.Point(93, 34);
            this.txtIDBan.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtIDBan.Name = "txtIDBan";
            this.txtIDBan.Size = new System.Drawing.Size(214, 23);
            this.txtIDBan.TabIndex = 0;
            // 
            // txtTenBan
            // 
            this.txtTenBan.Enabled = false;
            this.txtTenBan.ForeColor = System.Drawing.Color.Red;
            this.txtTenBan.Location = new System.Drawing.Point(93, 72);
            this.txtTenBan.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(214, 23);
            this.txtTenBan.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnXoaDM);
            this.tabPage2.Controls.Add(this.btnSuaDM);
            this.tabPage2.Controls.Add(this.btnDanhMuc);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.dgvDanhMuc);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage2.Size = new System.Drawing.Size(890, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh mục";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnXoaDM
            // 
            this.btnXoaDM.BackColor = System.Drawing.Color.White;
            this.btnXoaDM.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDM.ForeColor = System.Drawing.Color.Red;
            this.btnXoaDM.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDM.Image")));
            this.btnXoaDM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDM.Location = new System.Drawing.Point(268, 8);
            this.btnXoaDM.Name = "btnXoaDM";
            this.btnXoaDM.Size = new System.Drawing.Size(78, 36);
            this.btnXoaDM.TabIndex = 4;
            this.btnXoaDM.Text = "Xóa";
            this.btnXoaDM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaDM.UseVisualStyleBackColor = false;
            this.btnXoaDM.Click += new System.EventHandler(this.btnXoaDM_Click);
            // 
            // btnSuaDM
            // 
            this.btnSuaDM.BackColor = System.Drawing.Color.White;
            this.btnSuaDM.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDM.ForeColor = System.Drawing.Color.Red;
            this.btnSuaDM.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaDM.Image")));
            this.btnSuaDM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaDM.Location = new System.Drawing.Point(145, 8);
            this.btnSuaDM.Name = "btnSuaDM";
            this.btnSuaDM.Size = new System.Drawing.Size(78, 36);
            this.btnSuaDM.TabIndex = 5;
            this.btnSuaDM.Text = "Sửa";
            this.btnSuaDM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaDM.UseVisualStyleBackColor = false;
            this.btnSuaDM.Click += new System.EventHandler(this.btnSuaDM_Click);
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.BackColor = System.Drawing.Color.White;
            this.btnDanhMuc.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhMuc.ForeColor = System.Drawing.Color.Red;
            this.btnDanhMuc.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhMuc.Image")));
            this.btnDanhMuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhMuc.Location = new System.Drawing.Point(8, 8);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(104, 36);
            this.btnDanhMuc.TabIndex = 6;
            this.btnDanhMuc.Text = "Thêm mới";
            this.btnDanhMuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDanhMuc.UseVisualStyleBackColor = false;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnThemDanhMuc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHuyDanhMuc);
            this.groupBox2.Controls.Add(this.btnSaveDanhMuc);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtIDDanhMuc);
            this.groupBox2.Controls.Add(this.txtTenDanhMuc);
            this.groupBox2.Location = new System.Drawing.Point(8, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 169);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // btnHuyDanhMuc
            // 
            this.btnHuyDanhMuc.BackColor = System.Drawing.Color.White;
            this.btnHuyDanhMuc.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyDanhMuc.Image")));
            this.btnHuyDanhMuc.Location = new System.Drawing.Point(210, 117);
            this.btnHuyDanhMuc.Name = "btnHuyDanhMuc";
            this.btnHuyDanhMuc.Size = new System.Drawing.Size(47, 36);
            this.btnHuyDanhMuc.TabIndex = 4;
            this.btnHuyDanhMuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyDanhMuc.UseVisualStyleBackColor = false;
            this.btnHuyDanhMuc.Click += new System.EventHandler(this.btnHuyDanhMuc_Click);
            // 
            // btnSaveDanhMuc
            // 
            this.btnSaveDanhMuc.BackColor = System.Drawing.Color.White;
            this.btnSaveDanhMuc.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveDanhMuc.Image")));
            this.btnSaveDanhMuc.Location = new System.Drawing.Point(268, 117);
            this.btnSaveDanhMuc.Name = "btnSaveDanhMuc";
            this.btnSaveDanhMuc.Size = new System.Drawing.Size(47, 36);
            this.btnSaveDanhMuc.TabIndex = 3;
            this.btnSaveDanhMuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveDanhMuc.UseVisualStyleBackColor = false;
            this.btnSaveDanhMuc.Click += new System.EventHandler(this.btnSaveDanhMuc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "ID  danh mục:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên danh mục:";
            // 
            // txtIDDanhMuc
            // 
            this.txtIDDanhMuc.Enabled = false;
            this.txtIDDanhMuc.Location = new System.Drawing.Point(101, 34);
            this.txtIDDanhMuc.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtIDDanhMuc.Name = "txtIDDanhMuc";
            this.txtIDDanhMuc.Size = new System.Drawing.Size(214, 23);
            this.txtIDDanhMuc.TabIndex = 0;
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.Enabled = false;
            this.txtTenDanhMuc.ForeColor = System.Drawing.Color.Red;
            this.txtTenDanhMuc.Location = new System.Drawing.Point(101, 72);
            this.txtTenDanhMuc.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(214, 23);
            this.txtTenDanhMuc.TabIndex = 0;
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMuc.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._ID,
            this.tenDanhMuc});
            this.dgvDanhMuc.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvDanhMuc.Location = new System.Drawing.Point(508, 5);
            this.dgvDanhMuc.MultiSelect = false;
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.Size = new System.Drawing.Size(377, 431);
            this.dgvDanhMuc.TabIndex = 0;
            // 
            // _ID
            // 
            this._ID.DataPropertyName = "_ID";
            this._ID.HeaderText = "ID";
            this._ID.Name = "_ID";
            // 
            // tenDanhMuc
            // 
            this.tenDanhMuc.DataPropertyName = "tenDanhMuc";
            this.tenDanhMuc.HeaderText = "Tên danh mục";
            this.tenDanhMuc.Name = "tenDanhMuc";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnXoaDoUong);
            this.tabPage3.Controls.Add(this.btnSuaDoUong);
            this.tabPage3.Controls.Add(this.btnThemDoUong);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.dgvDoUong);
            this.tabPage3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.ForeColor = System.Drawing.Color.Black;
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(890, 441);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Đồ uống";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnXoaDoUong
            // 
            this.btnXoaDoUong.BackColor = System.Drawing.Color.White;
            this.btnXoaDoUong.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDoUong.ForeColor = System.Drawing.Color.Red;
            this.btnXoaDoUong.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDoUong.Image")));
            this.btnXoaDoUong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDoUong.Location = new System.Drawing.Point(268, 14);
            this.btnXoaDoUong.Name = "btnXoaDoUong";
            this.btnXoaDoUong.Size = new System.Drawing.Size(78, 36);
            this.btnXoaDoUong.TabIndex = 5;
            this.btnXoaDoUong.Text = "Xóa";
            this.btnXoaDoUong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaDoUong.UseVisualStyleBackColor = false;
            this.btnXoaDoUong.Click += new System.EventHandler(this.btnXoaDoUong_Click);
            // 
            // btnSuaDoUong
            // 
            this.btnSuaDoUong.BackColor = System.Drawing.Color.White;
            this.btnSuaDoUong.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDoUong.ForeColor = System.Drawing.Color.Red;
            this.btnSuaDoUong.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaDoUong.Image")));
            this.btnSuaDoUong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaDoUong.Location = new System.Drawing.Point(145, 14);
            this.btnSuaDoUong.Name = "btnSuaDoUong";
            this.btnSuaDoUong.Size = new System.Drawing.Size(78, 36);
            this.btnSuaDoUong.TabIndex = 6;
            this.btnSuaDoUong.Text = "Sửa";
            this.btnSuaDoUong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaDoUong.UseVisualStyleBackColor = false;
            this.btnSuaDoUong.Click += new System.EventHandler(this.btnSuaDoUong_Click);
            // 
            // btnThemDoUong
            // 
            this.btnThemDoUong.BackColor = System.Drawing.Color.White;
            this.btnThemDoUong.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDoUong.ForeColor = System.Drawing.Color.Red;
            this.btnThemDoUong.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDoUong.Image")));
            this.btnThemDoUong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDoUong.Location = new System.Drawing.Point(8, 14);
            this.btnThemDoUong.Name = "btnThemDoUong";
            this.btnThemDoUong.Size = new System.Drawing.Size(104, 36);
            this.btnThemDoUong.TabIndex = 7;
            this.btnThemDoUong.Text = "Thêm mới";
            this.btnThemDoUong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemDoUong.UseVisualStyleBackColor = false;
            this.btnThemDoUong.Click += new System.EventHandler(this.btnThemDoUong_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHuyDoUong);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtGiaTien);
            this.groupBox3.Controls.Add(this.btnSaveDoUong);
            this.groupBox3.Controls.Add(this.cbThuocDanhMuc);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtIDDoUong);
            this.groupBox3.Controls.Add(this.txtTenDoUong);
            this.groupBox3.Location = new System.Drawing.Point(8, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 242);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin";
            // 
            // btnHuyDoUong
            // 
            this.btnHuyDoUong.BackColor = System.Drawing.Color.White;
            this.btnHuyDoUong.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyDoUong.Image")));
            this.btnHuyDoUong.Location = new System.Drawing.Point(202, 191);
            this.btnHuyDoUong.Name = "btnHuyDoUong";
            this.btnHuyDoUong.Size = new System.Drawing.Size(47, 36);
            this.btnHuyDoUong.TabIndex = 6;
            this.btnHuyDoUong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyDoUong.UseVisualStyleBackColor = false;
            this.btnHuyDoUong.Click += new System.EventHandler(this.btnHuyDoUong_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Giá tiền:";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Enabled = false;
            this.txtGiaTien.ForeColor = System.Drawing.Color.Red;
            this.txtGiaTien.Location = new System.Drawing.Point(93, 150);
            this.txtGiaTien.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(214, 23);
            this.txtGiaTien.TabIndex = 4;
            // 
            // btnSaveDoUong
            // 
            this.btnSaveDoUong.BackColor = System.Drawing.Color.White;
            this.btnSaveDoUong.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveDoUong.Image")));
            this.btnSaveDoUong.Location = new System.Drawing.Point(260, 191);
            this.btnSaveDoUong.Name = "btnSaveDoUong";
            this.btnSaveDoUong.Size = new System.Drawing.Size(47, 36);
            this.btnSaveDoUong.TabIndex = 3;
            this.btnSaveDoUong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveDoUong.UseVisualStyleBackColor = false;
            this.btnSaveDoUong.Click += new System.EventHandler(this.btnSaveDoUong_Click);
            // 
            // cbThuocDanhMuc
            // 
            this.cbThuocDanhMuc.Enabled = false;
            this.cbThuocDanhMuc.ForeColor = System.Drawing.Color.Red;
            this.cbThuocDanhMuc.FormattingEnabled = true;
            this.cbThuocDanhMuc.Items.AddRange(new object[] {
            "Trống ",
            "Có người"});
            this.cbThuocDanhMuc.Location = new System.Drawing.Point(93, 111);
            this.cbThuocDanhMuc.Name = "cbThuocDanhMuc";
            this.cbThuocDanhMuc.Size = new System.Drawing.Size(214, 23);
            this.cbThuocDanhMuc.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thuộc DM:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "ID :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tên đồ uống:";
            // 
            // txtIDDoUong
            // 
            this.txtIDDoUong.AcceptsReturn = true;
            this.txtIDDoUong.Enabled = false;
            this.txtIDDoUong.ForeColor = System.Drawing.Color.Red;
            this.txtIDDoUong.Location = new System.Drawing.Point(93, 34);
            this.txtIDDoUong.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtIDDoUong.Name = "txtIDDoUong";
            this.txtIDDoUong.Size = new System.Drawing.Size(214, 23);
            this.txtIDDoUong.TabIndex = 0;
            this.txtIDDoUong.TextChanged += new System.EventHandler(this.txtIDDoUong_TextChanged);
            // 
            // txtTenDoUong
            // 
            this.txtTenDoUong.Enabled = false;
            this.txtTenDoUong.ForeColor = System.Drawing.Color.Red;
            this.txtTenDoUong.Location = new System.Drawing.Point(93, 72);
            this.txtTenDoUong.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtTenDoUong.Name = "txtTenDoUong";
            this.txtTenDoUong.Size = new System.Drawing.Size(214, 23);
            this.txtTenDoUong.TabIndex = 0;
            // 
            // dgvDoUong
            // 
            this.dgvDoUong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoUong.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoUong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoUong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._IDd,
            this.tenDoUong,
            this.IDDanhMuc,
            this.giaTien});
            this.dgvDoUong.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvDoUong.Location = new System.Drawing.Point(426, 0);
            this.dgvDoUong.MultiSelect = false;
            this.dgvDoUong.Name = "dgvDoUong";
            this.dgvDoUong.Size = new System.Drawing.Size(464, 441);
            this.dgvDoUong.TabIndex = 1;
            // 
            // _IDd
            // 
            this._IDd.DataPropertyName = "ID";
            this._IDd.HeaderText = "ID";
            this._IDd.Name = "_IDd";
            // 
            // tenDoUong
            // 
            this.tenDoUong.DataPropertyName = "tenDoUong";
            this.tenDoUong.HeaderText = "Tên đồ uống";
            this.tenDoUong.Name = "tenDoUong";
            // 
            // IDDanhMuc
            // 
            this.IDDanhMuc.DataPropertyName = "IDDanhMuc";
            this.IDDanhMuc.HeaderText = "Thuộc DM";
            this.IDDanhMuc.Name = "IDDanhMuc";
            // 
            // giaTien
            // 
            this.giaTien.DataPropertyName = "giaTien";
            this.giaTien.HeaderText = "Giá tiền";
            this.giaTien.Name = "giaTien";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 29);
            this.panel1.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Activecolor = System.Drawing.Color.White;
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.BorderRadius = 0;
            this.btnBack.ButtonText = "";
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DisabledColor = System.Drawing.Color.Gray;
            this.btnBack.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBack.Iconimage = null;
            this.btnBack.Iconimage_right = null;
            this.btnBack.Iconimage_right_Selected = null;
            this.btnBack.Iconimage_Selected = null;
            this.btnBack.IconMarginLeft = 0;
            this.btnBack.IconMarginRight = 0;
            this.btnBack.IconRightVisible = true;
            this.btnBack.IconRightZoom = 0D;
            this.btnBack.IconVisible = true;
            this.btnBack.IconZoom = 50D;
            this.btnBack.IsTab = false;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Normalcolor = System.Drawing.Color.White;
            this.btnBack.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBack.selected = false;
            this.btnBack.Size = new System.Drawing.Size(34, 29);
            this.btnBack.TabIndex = 1;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Textcolor = System.Drawing.Color.White;
            this.btnBack.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnBackHome
            // 
            this.btnBackHome.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBackHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBackHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackHome.BorderRadius = 0;
            this.btnBackHome.ButtonText = "     Bunifu Flat Button";
            this.btnBackHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnBackHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBackHome.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBackHome.Iconimage")));
            this.btnBackHome.Iconimage_right = null;
            this.btnBackHome.Iconimage_right_Selected = null;
            this.btnBackHome.Iconimage_Selected = null;
            this.btnBackHome.IconMarginLeft = 0;
            this.btnBackHome.IconMarginRight = 0;
            this.btnBackHome.IconRightVisible = true;
            this.btnBackHome.IconRightZoom = 0D;
            this.btnBackHome.IconVisible = true;
            this.btnBackHome.IconZoom = 90D;
            this.btnBackHome.IsTab = false;
            this.btnBackHome.Location = new System.Drawing.Point(0, 0);
            this.btnBackHome.Name = "btnBackHome";
            this.btnBackHome.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBackHome.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnBackHome.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBackHome.selected = false;
            this.btnBackHome.Size = new System.Drawing.Size(241, 48);
            this.btnBackHome.TabIndex = 0;
            this.btnBackHome.Text = "     Bunifu Flat Button";
            this.btnBackHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackHome.Textcolor = System.Drawing.Color.White;
            this.btnBackHome.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // formDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbcAdmin);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "formDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formDanhMuc";
            this.Load += new System.EventHandler(this.formDanhMuc_Load);
            this.tbcAdmin.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoUong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcAdmin;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.Windows.Forms.DataGridView dgvDoUong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.Button btnThemDanhMuc;
        private System.Windows.Forms.Button btnSaveBan;
        private System.Windows.Forms.DataGridView dgvDanhSachBan;
        private System.Windows.Forms.Button btnSuaBan;
        private System.Windows.Forms.Button btnXoaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDBan;
        private System.Windows.Forms.Button btnXoaDM;
        private System.Windows.Forms.Button btnSuaDM;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveDanhMuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIDDanhMuc;
        private System.Windows.Forms.TextBox txtTenDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn _ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDanhMuc;
        private System.Windows.Forms.Button btnXoaDoUong;
        private System.Windows.Forms.Button btnSuaDoUong;
        private System.Windows.Forms.Button btnThemDoUong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Button btnSaveDoUong;
        private System.Windows.Forms.ComboBox cbThuocDanhMuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIDDoUong;
        private System.Windows.Forms.TextBox txtTenDoUong;
        private Bunifu.Framework.UI.BunifuFlatButton btnBackHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn _IDd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDoUong;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTien;
        private Bunifu.Framework.UI.BunifuFlatButton btnBack;
        private System.Windows.Forms.Button btnHuyBan;
        private System.Windows.Forms.Button btnHuyDanhMuc;
        private System.Windows.Forms.Button btnHuyDoUong;
    }
}