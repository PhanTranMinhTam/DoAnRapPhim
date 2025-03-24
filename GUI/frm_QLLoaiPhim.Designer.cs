namespace GUI
{
    partial class frm_QLLoaiPhim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QLLoaiPhim));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.dgv_LoaiPhim = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaLoaiPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_TimKiem = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btn_Xoa = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Sua = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Them = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiPhim)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_LoaiPhim
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_LoaiPhim.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_LoaiPhim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_LoaiPhim.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_LoaiPhim.ColumnHeadersHeight = 25;
            this.dgv_LoaiPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_LoaiPhim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiPhim,
            this.TenLoaiPhim,
            this.MoTa});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_LoaiPhim.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_LoaiPhim.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgv_LoaiPhim.Location = new System.Drawing.Point(12, 157);
            this.dgv_LoaiPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_LoaiPhim.Name = "dgv_LoaiPhim";
            this.dgv_LoaiPhim.RowHeadersVisible = false;
            this.dgv_LoaiPhim.RowHeadersWidth = 62;
            this.dgv_LoaiPhim.RowTemplate.Height = 28;
            this.dgv_LoaiPhim.Size = new System.Drawing.Size(999, 324);
            this.dgv_LoaiPhim.TabIndex = 26;
            this.dgv_LoaiPhim.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_LoaiPhim.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_LoaiPhim.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_LoaiPhim.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_LoaiPhim.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_LoaiPhim.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_LoaiPhim.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgv_LoaiPhim.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_LoaiPhim.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_LoaiPhim.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_LoaiPhim.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_LoaiPhim.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_LoaiPhim.ThemeStyle.HeaderStyle.Height = 25;
            this.dgv_LoaiPhim.ThemeStyle.ReadOnly = false;
            this.dgv_LoaiPhim.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_LoaiPhim.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_LoaiPhim.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_LoaiPhim.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_LoaiPhim.ThemeStyle.RowsStyle.Height = 28;
            this.dgv_LoaiPhim.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_LoaiPhim.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaLoaiPhim
            // 
            this.MaLoaiPhim.DataPropertyName = "MaLoaiPhim";
            this.MaLoaiPhim.HeaderText = "Mã loại phim";
            this.MaLoaiPhim.MinimumWidth = 8;
            this.MaLoaiPhim.Name = "MaLoaiPhim";
            // 
            // TenLoaiPhim
            // 
            this.TenLoaiPhim.DataPropertyName = "TenLoaiPhim";
            this.TenLoaiPhim.HeaderText = "Tên loại phim";
            this.TenLoaiPhim.MinimumWidth = 8;
            this.TenLoaiPhim.Name = "TenLoaiPhim";
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.MinimumWidth = 8;
            this.MoTa.Name = "MoTa";
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
            this.txt_TimKiem.Location = new System.Drawing.Point(12, 90);
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
            this.txt_TimKiem.Size = new System.Drawing.Size(238, 38);
            this.txt_TimKiem.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_TimKiem.TabIndex = 30;
            this.txt_TimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_TimKiem.TextMarginBottom = 0;
            this.txt_TimKiem.TextMarginLeft = 3;
            this.txt_TimKiem.TextMarginTop = 1;
            this.txt_TimKiem.TextPlaceholder = "Tìm Kiếm";
            this.txt_TimKiem.UseSystemPasswordChar = false;
            this.txt_TimKiem.WordWrap = true;
            this.txt_TimKiem.TextChange += new System.EventHandler(this.txt_TimKiem_TextChange);
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
            this.btn_Xoa.Location = new System.Drawing.Point(564, 88);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(111, 40);
            this.btn_Xoa.TabIndex = 29;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_xoa_Click);
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
            this.btn_Sua.Location = new System.Drawing.Point(417, 88);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(111, 40);
            this.btn_Sua.TabIndex = 28;
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
            this.btn_Them.Location = new System.Drawing.Point(276, 88);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(111, 40);
            this.btn_Them.TabIndex = 27;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Crimson;
            this.bunifuLabel1.Location = new System.Drawing.Point(402, 12);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(266, 37);
            this.bunifuLabel1.TabIndex = 31;
            this.bunifuLabel1.Text = "QUẢN LÝ LOẠI PHIM";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frm_QLLoaiPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1023, 511);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.dgv_LoaiPhim);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_QLLoaiPhim";
            this.Text = "frm_QLLoaiPhim";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiPhim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgv_LoaiPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private Bunifu.UI.WinForms.BunifuTextBox txt_TimKiem;
        private Guna.UI2.WinForms.Guna2Button btn_Xoa;
        private Guna.UI2.WinForms.Guna2Button btn_Sua;
        private Guna.UI2.WinForms.Guna2Button btn_Them;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
    }
}