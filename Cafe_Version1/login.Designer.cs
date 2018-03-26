namespace Cafe_Version1
{
    partial class formDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDangNhap));
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtPassword.HintText = "";
            this.txtPassword.isPassword = false;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(111)))), ((int)(((byte)(150)))));
            this.txtPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(111)))), ((int)(((byte)(150)))));
            this.txtPassword.LineThickness = 3;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.MouseHover += new System.EventHandler(this.txtPassword_MouseHover);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.HintForeColor = System.Drawing.Color.Empty;
            this.txtUsername.HintText = "";
            this.txtUsername.isPassword = false;
            this.txtUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(111)))), ((int)(((byte)(150)))));
            this.txtUsername.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.txtUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(111)))), ((int)(((byte)(150)))));
            this.txtUsername.LineThickness = 3;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            this.txtUsername.MouseHover += new System.EventHandler(this.txtUsername_MouseHover);
            // 
            // bunifuCustomLabel1
            // 
            resources.ApplyResources(this.bunifuCustomLabel1, "bunifuCustomLabel1");
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(111)))), ((int)(((byte)(150)))));
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.ImageActive = null;
            this.btnClose.Name = "btnClose";
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.AutoEllipsis = true;
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(111)))), ((int)(((byte)(150)))));
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnDangNhap, "btnDangNhap");
            this.btnDangNhap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lbUsername
            // 
            resources.ApplyResources(this.lbUsername, "lbUsername");
            this.lbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(111)))), ((int)(((byte)(150)))));
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Click += new System.EventHandler(this.lbUsername_Click);
            // 
            // lbPassword
            // 
            resources.ApplyResources(this.lbPassword, "lbPassword");
            this.lbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(111)))), ((int)(((byte)(150)))));
            this.lbPassword.Name = "lbPassword";
            // 
            // formDangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formDangNhap";
            this.Load += new System.EventHandler(this.formDangNhap_Load);
            this.MouseHover += new System.EventHandler(this.formDangNhap_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsername;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Button btnDangNhap;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
    }
}

