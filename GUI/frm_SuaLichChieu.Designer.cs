namespace GUI
{
    partial class frm_SuaLichChieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SuaLichChieu));
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dtp_NgayChieu = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtp_GioKetThuc = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtp_GioBatDau = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btn_Huy = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Luu = new Guna.UI2.WinForms.Guna2Button();
            this.cbo_PhongChieu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbo_Phim = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Red;
            this.bunifuLabel1.Location = new System.Drawing.Point(306, 22);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(241, 37);
            this.bunifuLabel1.TabIndex = 22;
            this.bunifuLabel1.Text = "Cập nhật lịch chiếu";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dtp_NgayChieu
            // 
            this.dtp_NgayChieu.Checked = true;
            this.dtp_NgayChieu.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayChieu.FillColor = System.Drawing.Color.White;
            this.dtp_NgayChieu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayChieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayChieu.Location = new System.Drawing.Point(358, 204);
            this.dtp_NgayChieu.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_NgayChieu.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_NgayChieu.Name = "dtp_NgayChieu";
            this.dtp_NgayChieu.Size = new System.Drawing.Size(329, 36);
            this.dtp_NgayChieu.TabIndex = 40;
            this.dtp_NgayChieu.Value = new System.DateTime(2024, 10, 7, 21, 4, 16, 952);
            // 
            // dtp_GioKetThuc
            // 
            this.dtp_GioKetThuc.Checked = true;
            this.dtp_GioKetThuc.CustomFormat = "HH:mm:ss";
            this.dtp_GioKetThuc.FillColor = System.Drawing.Color.White;
            this.dtp_GioKetThuc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_GioKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_GioKetThuc.Location = new System.Drawing.Point(358, 343);
            this.dtp_GioKetThuc.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_GioKetThuc.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_GioKetThuc.Name = "dtp_GioKetThuc";
            this.dtp_GioKetThuc.ShowUpDown = true;
            this.dtp_GioKetThuc.Size = new System.Drawing.Size(329, 36);
            this.dtp_GioKetThuc.TabIndex = 39;
            this.dtp_GioKetThuc.Value = new System.DateTime(2024, 10, 7, 21, 4, 16, 952);
            // 
            // dtp_GioBatDau
            // 
            this.dtp_GioBatDau.Checked = true;
            this.dtp_GioBatDau.CustomFormat = "HH:mm:ss";
            this.dtp_GioBatDau.FillColor = System.Drawing.Color.White;
            this.dtp_GioBatDau.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_GioBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_GioBatDau.Location = new System.Drawing.Point(358, 270);
            this.dtp_GioBatDau.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_GioBatDau.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_GioBatDau.Name = "dtp_GioBatDau";
            this.dtp_GioBatDau.ShowUpDown = true;
            this.dtp_GioBatDau.Size = new System.Drawing.Size(329, 36);
            this.dtp_GioBatDau.TabIndex = 38;
            this.dtp_GioBatDau.Value = new System.DateTime(2024, 10, 7, 21, 7, 55, 186);
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel6.Location = new System.Drawing.Point(118, 212);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(107, 28);
            this.bunifuLabel6.TabIndex = 37;
            this.bunifuLabel6.Text = "Ngày chiếu";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Huy.BorderRadius = 10;
            this.btn_Huy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Huy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Huy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Huy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Huy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Huy.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.ForeColor = System.Drawing.Color.White;
            this.btn_Huy.Location = new System.Drawing.Point(444, 421);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(159, 45);
            this.btn_Huy.TabIndex = 36;
            this.btn_Huy.Text = "Hủy";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Luu.BorderRadius = 10;
            this.btn_Luu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Luu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Luu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Luu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Luu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Luu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.Color.White;
            this.btn_Luu.Location = new System.Drawing.Point(257, 421);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(159, 45);
            this.btn_Luu.TabIndex = 35;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // cbo_PhongChieu
            // 
            this.cbo_PhongChieu.BackColor = System.Drawing.Color.Transparent;
            this.cbo_PhongChieu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_PhongChieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_PhongChieu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_PhongChieu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_PhongChieu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_PhongChieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_PhongChieu.ItemHeight = 30;
            this.cbo_PhongChieu.Location = new System.Drawing.Point(358, 141);
            this.cbo_PhongChieu.Name = "cbo_PhongChieu";
            this.cbo_PhongChieu.Size = new System.Drawing.Size(329, 36);
            this.cbo_PhongChieu.TabIndex = 34;
            // 
            // cbo_Phim
            // 
            this.cbo_Phim.BackColor = System.Drawing.Color.Transparent;
            this.cbo_Phim.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_Phim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Phim.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_Phim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_Phim.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_Phim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_Phim.ItemHeight = 30;
            this.cbo_Phim.Location = new System.Drawing.Point(358, 81);
            this.cbo_Phim.Name = "cbo_Phim";
            this.cbo_Phim.Size = new System.Drawing.Size(329, 36);
            this.cbo_Phim.TabIndex = 33;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel5.Location = new System.Drawing.Point(118, 351);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(179, 28);
            this.bunifuLabel5.TabIndex = 32;
            this.bunifuLabel5.Text = "Thời gian kết thúc:";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.Location = new System.Drawing.Point(118, 278);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(174, 28);
            this.bunifuLabel4.TabIndex = 31;
            this.bunifuLabel4.Text = "Thời gian bắt đầu:";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.Location = new System.Drawing.Point(118, 156);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(117, 28);
            this.bunifuLabel3.TabIndex = 30;
            this.bunifuLabel3.Text = "Phòng chiếu";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(118, 89);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(89, 28);
            this.bunifuLabel2.TabIndex = 29;
            this.bunifuLabel2.Text = "Tên phim";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frm_SuaLichChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(806, 526);
            this.Controls.Add(this.dtp_NgayChieu);
            this.Controls.Add(this.dtp_GioKetThuc);
            this.Controls.Add(this.dtp_GioBatDau);
            this.Controls.Add(this.bunifuLabel6);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.cbo_PhongChieu);
            this.Controls.Add(this.cbo_Phim);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.Name = "frm_SuaLichChieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_SuaLichChieu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_NgayChieu;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_GioKetThuc;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_GioBatDau;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Guna.UI2.WinForms.Guna2Button btn_Huy;
        private Guna.UI2.WinForms.Guna2Button btn_Luu;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_PhongChieu;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_Phim;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
    }
}