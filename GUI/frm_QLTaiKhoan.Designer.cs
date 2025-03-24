namespace GUI
{
    partial class frm_QLTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QLTaiKhoan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_NhanVien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rd_HoatDong = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_DSTaiKhoan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoatDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Luu = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Xoa = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Sua = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Them = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Huy = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbo_NhanVien);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_TenTaiKhoan);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.rd_HoatDong);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(342, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 216);
            this.groupBox2.TabIndex = 176;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhân viên";
            // 
            // cbo_NhanVien
            // 
            this.cbo_NhanVien.BackColor = System.Drawing.Color.Transparent;
            this.cbo_NhanVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_NhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_NhanVien.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_NhanVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_NhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_NhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_NhanVien.ItemHeight = 30;
            this.cbo_NhanVien.Location = new System.Drawing.Point(184, 25);
            this.cbo_NhanVien.Name = "cbo_NhanVien";
            this.cbo_NhanVien.Size = new System.Drawing.Size(306, 36);
            this.cbo_NhanVien.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên tài khoản";
            // 
            // txt_TenTaiKhoan
            // 
            this.txt_TenTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenTaiKhoan.DefaultText = "";
            this.txt_TenTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TenTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TenTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenTaiKhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenTaiKhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TenTaiKhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenTaiKhoan.Location = new System.Drawing.Point(184, 98);
            this.txt_TenTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TenTaiKhoan.Name = "txt_TenTaiKhoan";
            this.txt_TenTaiKhoan.PasswordChar = '\0';
            this.txt_TenTaiKhoan.PlaceholderText = "";
            this.txt_TenTaiKhoan.SelectedText = "";
            this.txt_TenTaiKhoan.Size = new System.Drawing.Size(306, 36);
            this.txt_TenTaiKhoan.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hoạt động";
            // 
            // rd_HoatDong
            // 
            this.rd_HoatDong.AllowBindingControlAnimation = true;
            this.rd_HoatDong.AllowBindingControlColorChanges = false;
            this.rd_HoatDong.AllowBindingControlLocation = true;
            this.rd_HoatDong.AllowCheckBoxAnimation = false;
            this.rd_HoatDong.AllowCheckmarkAnimation = true;
            this.rd_HoatDong.AllowOnHoverStates = true;
            this.rd_HoatDong.AutoCheck = true;
            this.rd_HoatDong.BackColor = System.Drawing.Color.Transparent;
            this.rd_HoatDong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rd_HoatDong.BackgroundImage")));
            this.rd_HoatDong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rd_HoatDong.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.rd_HoatDong.BorderRadius = 12;
            this.rd_HoatDong.Checked = true;
            this.rd_HoatDong.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.rd_HoatDong.Cursor = System.Windows.Forms.Cursors.Default;
            this.rd_HoatDong.CustomCheckmarkImage = null;
            this.rd_HoatDong.Location = new System.Drawing.Point(184, 177);
            this.rd_HoatDong.MinimumSize = new System.Drawing.Size(17, 17);
            this.rd_HoatDong.Name = "rd_HoatDong";
            this.rd_HoatDong.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rd_HoatDong.OnCheck.BorderRadius = 12;
            this.rd_HoatDong.OnCheck.BorderThickness = 2;
            this.rd_HoatDong.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.rd_HoatDong.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.rd_HoatDong.OnCheck.CheckmarkThickness = 2;
            this.rd_HoatDong.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.rd_HoatDong.OnDisable.BorderRadius = 12;
            this.rd_HoatDong.OnDisable.BorderThickness = 2;
            this.rd_HoatDong.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.rd_HoatDong.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.rd_HoatDong.OnDisable.CheckmarkThickness = 2;
            this.rd_HoatDong.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.rd_HoatDong.OnHoverChecked.BorderRadius = 12;
            this.rd_HoatDong.OnHoverChecked.BorderThickness = 2;
            this.rd_HoatDong.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.rd_HoatDong.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.rd_HoatDong.OnHoverChecked.CheckmarkThickness = 2;
            this.rd_HoatDong.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.rd_HoatDong.OnHoverUnchecked.BorderRadius = 12;
            this.rd_HoatDong.OnHoverUnchecked.BorderThickness = 1;
            this.rd_HoatDong.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.rd_HoatDong.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.rd_HoatDong.OnUncheck.BorderRadius = 12;
            this.rd_HoatDong.OnUncheck.BorderThickness = 1;
            this.rd_HoatDong.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.rd_HoatDong.Size = new System.Drawing.Size(21, 21);
            this.rd_HoatDong.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.rd_HoatDong.TabIndex = 9;
            this.rd_HoatDong.ThreeState = false;
            this.rd_HoatDong.ToolTipText = null;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(228, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hoạt động";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgv_DSTaiKhoan);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1156, 193);
            this.groupBox1.TabIndex = 170;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách tài khoản";
            // 
            // dgv_DSTaiKhoan
            // 
            this.dgv_DSTaiKhoan.AllowUserToAddRows = false;
            this.dgv_DSTaiKhoan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_DSTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DSTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DSTaiKhoan.ColumnHeadersHeight = 20;
            this.dgv_DSTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.TenDN,
            this.MatKhau,
            this.HoatDong});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DSTaiKhoan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_DSTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DSTaiKhoan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_DSTaiKhoan.Location = new System.Drawing.Point(3, 23);
            this.dgv_DSTaiKhoan.Name = "dgv_DSTaiKhoan";
            this.dgv_DSTaiKhoan.ReadOnly = true;
            this.dgv_DSTaiKhoan.RowHeadersVisible = false;
            this.dgv_DSTaiKhoan.RowHeadersWidth = 51;
            this.dgv_DSTaiKhoan.RowTemplate.Height = 24;
            this.dgv_DSTaiKhoan.Size = new System.Drawing.Size(1150, 167);
            this.dgv_DSTaiKhoan.TabIndex = 0;
            this.dgv_DSTaiKhoan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DSTaiKhoan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_DSTaiKhoan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_DSTaiKhoan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_DSTaiKhoan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_DSTaiKhoan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DSTaiKhoan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_DSTaiKhoan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_DSTaiKhoan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_DSTaiKhoan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgv_DSTaiKhoan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_DSTaiKhoan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_DSTaiKhoan.ThemeStyle.HeaderStyle.Height = 20;
            this.dgv_DSTaiKhoan.ThemeStyle.ReadOnly = true;
            this.dgv_DSTaiKhoan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DSTaiKhoan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_DSTaiKhoan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgv_DSTaiKhoan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_DSTaiKhoan.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_DSTaiKhoan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_DSTaiKhoan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_DSTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSTaiKhoan_CellClick);
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "maNhanVien";
            this.MaNhanVien.HeaderText = "Mã nhân vien";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            // 
            // TenDN
            // 
            this.TenDN.DataPropertyName = "tenDangNhap";
            this.TenDN.HeaderText = "Tên đăng nhập";
            this.TenDN.MinimumWidth = 6;
            this.TenDN.Name = "TenDN";
            this.TenDN.ReadOnly = true;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "matKhau";
            this.MatKhau.HeaderText = "Mật khẩu";
            this.MatKhau.MinimumWidth = 6;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.ReadOnly = true;
            // 
            // HoatDong
            // 
            this.HoatDong.DataPropertyName = "hoatDong";
            this.HoatDong.HeaderText = "Hoạt động";
            this.HoatDong.MinimumWidth = 6;
            this.HoatDong.Name = "HoatDong";
            this.HoatDong.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(480, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 34);
            this.label1.TabIndex = 169;
            this.label1.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Luu.BorderRadius = 10;
            this.btn_Luu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Luu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Luu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Luu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Luu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Luu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.Color.White;
            this.btn_Luu.Location = new System.Drawing.Point(309, 308);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(159, 43);
            this.btn_Luu.TabIndex = 208;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Xoa.BorderRadius = 10;
            this.btn_Xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Xoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(682, 308);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(159, 43);
            this.btn_Xoa.TabIndex = 207;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Sua.BorderRadius = 10;
            this.btn_Sua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Sua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Sua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Sua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Sua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(490, 308);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(159, 43);
            this.btn_Sua.TabIndex = 206;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Them.BorderRadius = 10;
            this.btn_Them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Them.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(131, 308);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(159, 43);
            this.btn_Them.TabIndex = 205;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Huy.BorderRadius = 10;
            this.btn_Huy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Huy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Huy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Huy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Huy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Huy.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.ForeColor = System.Drawing.Color.White;
            this.btn_Huy.Location = new System.Drawing.Point(868, 308);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(159, 43);
            this.btn_Huy.TabIndex = 209;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // frm_QLTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1180, 604);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label1);
            this.Name = "frm_QLTaiKhoan";
            this.Text = "frm_QLTaiKhoan";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_NhanVien;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_TenTaiKhoan;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuCheckBox rd_HoatDong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_DSTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoatDong;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_Luu;
        private Guna.UI2.WinForms.Guna2Button btn_Xoa;
        private Guna.UI2.WinForms.Guna2Button btn_Sua;
        private Guna.UI2.WinForms.Guna2Button btn_Them;
        private Guna.UI2.WinForms.Guna2Button btn_Huy;
    }
}