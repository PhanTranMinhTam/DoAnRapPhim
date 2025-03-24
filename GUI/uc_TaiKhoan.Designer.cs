namespace GUI
{
    partial class uc_TaiKhoan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_TaiKhoan));
            this.btn_Logout = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.lb_ChucVu = new Bunifu.UI.WinForms.BunifuLabel();
            this.lb_HoTen = new Bunifu.UI.WinForms.BunifuLabel();
            this.lb_XinChao = new Bunifu.UI.WinForms.BunifuLabel();
            this.btn_DangXuat = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_DangXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Logout
            // 
            this.btn_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Logout.BorderRadius = 10;
            this.btn_Logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Logout.FillColor = System.Drawing.Color.White;
            this.btn_Logout.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Black;
            this.btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Image")));
            this.btn_Logout.Location = new System.Drawing.Point(678, 42);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(147, 44);
            this.btn_Logout.TabIndex = 35;
            this.btn_Logout.Text = "Đăng xuất";
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 109);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(828, 17);
            this.bunifuSeparator1.TabIndex = 34;
            // 
            // lb_ChucVu
            // 
            this.lb_ChucVu.AllowParentOverrides = false;
            this.lb_ChucVu.AutoEllipsis = false;
            this.lb_ChucVu.Cursor = System.Windows.Forms.Cursors.Default;
            this.lb_ChucVu.CursorType = System.Windows.Forms.Cursors.Default;
            this.lb_ChucVu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChucVu.ForeColor = System.Drawing.Color.Black;
            this.lb_ChucVu.Location = new System.Drawing.Point(104, 83);
            this.lb_ChucVu.Name = "lb_ChucVu";
            this.lb_ChucVu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_ChucVu.Size = new System.Drawing.Size(62, 23);
            this.lb_ChucVu.TabIndex = 33;
            this.lb_ChucVu.Text = "Chức vụ";
            this.lb_ChucVu.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lb_ChucVu.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lb_HoTen
            // 
            this.lb_HoTen.AllowParentOverrides = false;
            this.lb_HoTen.AutoEllipsis = false;
            this.lb_HoTen.Cursor = System.Windows.Forms.Cursors.Default;
            this.lb_HoTen.CursorType = System.Windows.Forms.Cursors.Default;
            this.lb_HoTen.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HoTen.ForeColor = System.Drawing.Color.Black;
            this.lb_HoTen.Location = new System.Drawing.Point(105, 51);
            this.lb_HoTen.Name = "lb_HoTen";
            this.lb_HoTen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_HoTen.Size = new System.Drawing.Size(58, 25);
            this.lb_HoTen.TabIndex = 32;
            this.lb_HoTen.Text = "Họ tên";
            this.lb_HoTen.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lb_HoTen.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lb_XinChao
            // 
            this.lb_XinChao.AllowParentOverrides = false;
            this.lb_XinChao.AutoEllipsis = false;
            this.lb_XinChao.CursorType = null;
            this.lb_XinChao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_XinChao.ForeColor = System.Drawing.Color.Black;
            this.lb_XinChao.Location = new System.Drawing.Point(102, 22);
            this.lb_XinChao.Name = "lb_XinChao";
            this.lb_XinChao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_XinChao.Size = new System.Drawing.Size(70, 23);
            this.lb_XinChao.TabIndex = 31;
            this.lb_XinChao.Text = "Xin chào,";
            this.lb_XinChao.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lb_XinChao.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.AllowFocused = false;
            this.btn_DangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DangXuat.AutoSizeHeight = true;
            this.btn_DangXuat.BorderRadius = 37;
            this.btn_DangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btn_DangXuat.Image")));
            this.btn_DangXuat.IsCircle = true;
            this.btn_DangXuat.Location = new System.Drawing.Point(3, 25);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(75, 75);
            this.btn_DangXuat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_DangXuat.TabIndex = 30;
            this.btn_DangXuat.TabStop = false;
            this.btn_DangXuat.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // uc_TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lb_ChucVu);
            this.Controls.Add(this.lb_HoTen);
            this.Controls.Add(this.lb_XinChao);
            this.Controls.Add(this.btn_DangXuat);
            this.Name = "uc_TaiKhoan";
            this.Size = new System.Drawing.Size(828, 126);
            ((System.ComponentModel.ISupportInitialize)(this.btn_DangXuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_Logout;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuLabel lb_ChucVu;
        private Bunifu.UI.WinForms.BunifuLabel lb_HoTen;
        private Bunifu.UI.WinForms.BunifuLabel lb_XinChao;
        private Bunifu.UI.WinForms.BunifuPictureBox btn_DangXuat;
    }
}
