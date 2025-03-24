namespace GUI
{
    partial class frm_QLKhuyenMai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QLKhuyenMai));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.dgv_khuyenmai = new Guna.UI2.WinForms.Guna2DataGridView();
            this.maKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhanTramKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_xoa = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Them = new Guna.UI2.WinForms.Guna2Button();
            this.txt_TimKiem = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khuyenmai)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_khuyenmai
            // 
            this.dgv_khuyenmai.AllowUserToAddRows = false;
            this.dgv_khuyenmai.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_khuyenmai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_khuyenmai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_khuyenmai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_khuyenmai.ColumnHeadersHeight = 22;
            this.dgv_khuyenmai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_khuyenmai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKM,
            this.Column1,
            this.Column2,
            this.Column3,
            this.PhanTramKM});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_khuyenmai.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_khuyenmai.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgv_khuyenmai.Location = new System.Drawing.Point(7, 156);
            this.dgv_khuyenmai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_khuyenmai.Name = "dgv_khuyenmai";
            this.dgv_khuyenmai.ReadOnly = true;
            this.dgv_khuyenmai.RowHeadersVisible = false;
            this.dgv_khuyenmai.RowHeadersWidth = 62;
            this.dgv_khuyenmai.RowTemplate.Height = 28;
            this.dgv_khuyenmai.Size = new System.Drawing.Size(1165, 326);
            this.dgv_khuyenmai.TabIndex = 23;
            this.dgv_khuyenmai.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_khuyenmai.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_khuyenmai.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_khuyenmai.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_khuyenmai.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_khuyenmai.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_khuyenmai.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgv_khuyenmai.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgv_khuyenmai.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_khuyenmai.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_khuyenmai.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_khuyenmai.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_khuyenmai.ThemeStyle.HeaderStyle.Height = 22;
            this.dgv_khuyenmai.ThemeStyle.ReadOnly = true;
            this.dgv_khuyenmai.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_khuyenmai.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_khuyenmai.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_khuyenmai.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_khuyenmai.ThemeStyle.RowsStyle.Height = 28;
            this.dgv_khuyenmai.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_khuyenmai.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // maKM
            // 
            this.maKM.DataPropertyName = "maKM";
            this.maKM.HeaderText = "Mã Khuyến Mãi";
            this.maKM.MinimumWidth = 8;
            this.maKM.Name = "maKM";
            this.maKM.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tenKM";
            this.Column1.HeaderText = "Tên Khuyến Mãi";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "thoiGianBD";
            this.Column2.HeaderText = "Thời Gian Bắt Đầu";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "thoiGianKT";
            this.Column3.HeaderText = "Thời Gian Kết Thúc";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // PhanTramKM
            // 
            this.PhanTramKM.DataPropertyName = "PhanTramKM";
            this.PhanTramKM.HeaderText = "Phần Trăm Khuyến Mãi";
            this.PhanTramKM.MinimumWidth = 8;
            this.PhanTramKM.Name = "PhanTramKM";
            this.PhanTramKM.ReadOnly = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BorderRadius = 10;
            this.btn_xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Location = new System.Drawing.Point(514, 88);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(95, 40);
            this.btn_xoa.TabIndex = 25;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BorderRadius = 10;
            this.btn_Them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Them.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(384, 88);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(107, 40);
            this.btn_Them.TabIndex = 24;
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
            this.txt_TimKiem.Location = new System.Drawing.Point(6, 90);
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
            this.txt_TimKiem.TabIndex = 22;
            this.txt_TimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_TimKiem.TextMarginBottom = 0;
            this.txt_TimKiem.TextMarginLeft = 3;
            this.txt_TimKiem.TextMarginTop = 1;
            this.txt_TimKiem.TextPlaceholder = "Tìm Kiếm";
            this.txt_TimKiem.UseSystemPasswordChar = false;
            this.txt_TimKiem.WordWrap = true;
            this.txt_TimKiem.TextChange += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(431, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 34);
            this.label1.TabIndex = 202;
            this.label1.Text = "QUẢN LÝ KHUYẾN MÃI";
            // 
            // frm_QLKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 526);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_khuyenmai);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_TimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_QLKhuyenMai";
            this.Text = "frm_KhuyenMai";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khuyenmai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgv_khuyenmai;
        private Guna.UI2.WinForms.Guna2Button btn_xoa;
        private Guna.UI2.WinForms.Guna2Button btn_Them;
        private Bunifu.UI.WinForms.BunifuTextBox txt_TimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhanTramKM;
    }
}