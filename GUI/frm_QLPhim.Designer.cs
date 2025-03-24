namespace GUI
{
    partial class frm_QLPhim
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QLPhim));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.dgv_Phim = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaoDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Xoa = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Sua = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Them = new Guna.UI2.WinForms.Guna2Button();
            this.txt_TimKiem = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Phim)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Phim
            // 
            this.dgv_Phim.AllowUserToAddRows = false;
            this.dgv_Phim.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Phim.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Phim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Phim.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Phim.ColumnHeadersHeight = 22;
            this.dgv_Phim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Phim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhim,
            this.TenPhim,
            this.DaoDien,
            this.QuocGia,
            this.NgayChieu,
            this.NgayKT,
            this.TenLoaiPhim});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Phim.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Phim.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgv_Phim.Location = new System.Drawing.Point(12, 147);
            this.dgv_Phim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Phim.Name = "dgv_Phim";
            this.dgv_Phim.ReadOnly = true;
            this.dgv_Phim.RowHeadersVisible = false;
            this.dgv_Phim.RowHeadersWidth = 62;
            this.dgv_Phim.RowTemplate.Height = 28;
            this.dgv_Phim.Size = new System.Drawing.Size(1129, 344);
            this.dgv_Phim.TabIndex = 23;
            this.dgv_Phim.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Phim.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Phim.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Phim.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Phim.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Phim.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Phim.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgv_Phim.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgv_Phim.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Phim.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Phim.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_Phim.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Phim.ThemeStyle.HeaderStyle.Height = 22;
            this.dgv_Phim.ThemeStyle.ReadOnly = true;
            this.dgv_Phim.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Phim.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Phim.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Phim.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Phim.ThemeStyle.RowsStyle.Height = 28;
            this.dgv_Phim.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Phim.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Phim.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Phim_CellDoubleClick);
            // 
            // MaPhim
            // 
            this.MaPhim.DataPropertyName = "MaPhim";
            this.MaPhim.HeaderText = "Mã phim";
            this.MaPhim.MinimumWidth = 6;
            this.MaPhim.Name = "MaPhim";
            this.MaPhim.ReadOnly = true;
            // 
            // TenPhim
            // 
            this.TenPhim.DataPropertyName = "TenPhim";
            this.TenPhim.HeaderText = "Tên phim";
            this.TenPhim.MinimumWidth = 6;
            this.TenPhim.Name = "TenPhim";
            this.TenPhim.ReadOnly = true;
            // 
            // DaoDien
            // 
            this.DaoDien.DataPropertyName = "DaoDien";
            this.DaoDien.HeaderText = "Đạo diễn";
            this.DaoDien.MinimumWidth = 6;
            this.DaoDien.Name = "DaoDien";
            this.DaoDien.ReadOnly = true;
            // 
            // QuocGia
            // 
            this.QuocGia.DataPropertyName = "QuocGia";
            this.QuocGia.HeaderText = "Quốc gia";
            this.QuocGia.MinimumWidth = 6;
            this.QuocGia.Name = "QuocGia";
            this.QuocGia.ReadOnly = true;
            // 
            // NgayChieu
            // 
            this.NgayChieu.DataPropertyName = "NgayChieu";
            this.NgayChieu.HeaderText = "Ngày khởi chiếu";
            this.NgayChieu.MinimumWidth = 6;
            this.NgayChieu.Name = "NgayChieu";
            this.NgayChieu.ReadOnly = true;
            // 
            // NgayKT
            // 
            this.NgayKT.DataPropertyName = "NgayKT";
            this.NgayKT.HeaderText = "Ngày kết thúc";
            this.NgayKT.MinimumWidth = 6;
            this.NgayKT.Name = "NgayKT";
            this.NgayKT.ReadOnly = true;
            // 
            // TenLoaiPhim
            // 
            this.TenLoaiPhim.DataPropertyName = "TenLoaiPhim";
            this.TenLoaiPhim.HeaderText = "Loại phim";
            this.TenLoaiPhim.MinimumWidth = 6;
            this.TenLoaiPhim.Name = "TenLoaiPhim";
            this.TenLoaiPhim.ReadOnly = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BorderRadius = 10;
            this.btn_Xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Xoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(789, 76);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(159, 40);
            this.btn_Xoa.TabIndex = 22;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BorderRadius = 10;
            this.btn_Sua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Sua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Sua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Sua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Sua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(597, 76);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(159, 40);
            this.btn_Sua.TabIndex = 21;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BorderRadius = 10;
            this.btn_Them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Them.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(398, 76);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(159, 40);
            this.btn_Them.TabIndex = 20;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.AcceptsReturn = false;
            this.txt_TimKiem.AcceptsTab = false;
            this.txt_TimKiem.AnimationSpeed = 200;
            this.txt_TimKiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_TimKiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_TimKiem.AutoSizeHeight = true;
            this.txt_TimKiem.BackColor = System.Drawing.Color.Transparent;
            this.txt_TimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_TimKiem.BackgroundImage")));
            this.txt_TimKiem.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_TimKiem.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_TimKiem.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_TimKiem.BorderColorIdle = System.Drawing.Color.IndianRed;
            this.txt_TimKiem.BorderRadius = 10;
            this.txt_TimKiem.BorderThickness = 1;
            this.txt_TimKiem.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txt_TimKiem.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_TimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiem.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_TimKiem.DefaultText = "";
            this.txt_TimKiem.FillColor = System.Drawing.Color.White;
            this.txt_TimKiem.HideSelection = true;
            this.txt_TimKiem.IconLeft = null;
            this.txt_TimKiem.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiem.IconPadding = 10;
            this.txt_TimKiem.IconRight = null;
            this.txt_TimKiem.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiem.Lines = new string[0];
            this.txt_TimKiem.Location = new System.Drawing.Point(12, 81);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TimKiem.MaxLength = 32767;
            this.txt_TimKiem.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_TimKiem.Modified = false;
            this.txt_TimKiem.Multiline = false;
            this.txt_TimKiem.Name = "txt_TimKiem";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_TimKiem.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_TimKiem.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_TimKiem.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.IndianRed;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_TimKiem.OnIdleState = stateProperties4;
            this.txt_TimKiem.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TimKiem.PasswordChar = '\0';
            this.txt_TimKiem.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_TimKiem.PlaceholderText = "Tìm Kiếm";
            this.txt_TimKiem.ReadOnly = false;
            this.txt_TimKiem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_TimKiem.SelectedText = "";
            this.txt_TimKiem.SelectionLength = 0;
            this.txt_TimKiem.SelectionStart = 0;
            this.txt_TimKiem.ShortcutsEnabled = true;
            this.txt_TimKiem.Size = new System.Drawing.Size(355, 38);
            this.txt_TimKiem.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_TimKiem.TabIndex = 19;
            this.txt_TimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_TimKiem.TextMarginBottom = 0;
            this.txt_TimKiem.TextMarginLeft = 3;
            this.txt_TimKiem.TextMarginTop = 1;
            this.txt_TimKiem.TextPlaceholder = "Tìm Kiếm";
            this.txt_TimKiem.UseSystemPasswordChar = false;
            this.txt_TimKiem.WordWrap = true;
            this.txt_TimKiem.TextChange += new System.EventHandler(this.txt_TimKiem_TextChange);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(488, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 34);
            this.label1.TabIndex = 194;
            this.label1.Text = "QUẢN LÝ PHIM";
            // 
            // frm_QLPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1153, 513);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Phim);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_TimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_QLPhim";
            this.Text = "frm_QLPhim";
            this.Load += new System.EventHandler(this.frm_QLPhim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Phim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgv_Phim;
        private Guna.UI2.WinForms.Guna2Button btn_Xoa;
        private Guna.UI2.WinForms.Guna2Button btn_Sua;
        private Guna.UI2.WinForms.Guna2Button btn_Them;
        private Bunifu.UI.WinForms.BunifuTextBox txt_TimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaoDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiPhim;
    }
}